'Main Form.vb
'TP3 - Agenda d'examen, de laboratoires et de travaux.
'2020-04-03
'111245796

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmForm
    Private blnSauvegardeFlag As Boolean

    ' Procédure Sub et Function indépendantes.

    Private Sub AjouterEnregistrement()
        ' Vide les champs courant et prépare le prochain enregistrement.
        blnSauvegardeFlag = True
        EpreuveBindingSource.AddNew()
        dtpDebut.Value = DateTime.Now
        dtpFin.Value = DateTime.Now

    End Sub

    Private Sub SauvegardeEnregistrement()
        ' Enregistre l'enregistrement dans la base de données.

        Try
            Validate()
            EpreuveBindingSource.EndEdit()
            EpreuveTableAdapter.Update(TP3_20201HVB_DataSet.epreuve)
            blnSauvegardeFlag = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub SupprimerEnregistrement()
        ' Supprime l'enregistrement en cours.

        EpreuveBindingSource.RemoveCurrent()

        ' Sauvegarde
        SauvegardeEnregistrement()

    End Sub

    Private Sub AfficherStatistique()
        ' Affiche un messagebox avec la liste des épreuves. Il affiche aussi la moyenne pour chaque
        ' type d'épreuve.

        Dim dblMoyenneExamen As Double
        Dim dblMoyenneTravail As Double
        Dim dblMoyenneLaboratoire As Double
        Dim dblMoyenneAutre As Double
        Dim strStatistique As String

        dblMoyenneExamen = moyenneHeureEpreuve("Examen", InitialiserTableau())
        dblMoyenneTravail = moyenneHeureEpreuve("Travail", InitialiserTableau())
        dblMoyenneLaboratoire = moyenneHeureEpreuve("Laboratoire", InitialiserTableau())
        dblMoyenneAutre = moyenneHeureEpreuve("Autre", InitialiserTableau())

        ' Place la table en ordre décroissant selon date heure début.
        EpreuveTableAdapter.FillByDescendant(TP3_20201HVB_DataSet.epreuve)

        ' Ajoute entête.
        strStatistique = String.Format("{0, -28}{1, -31}{2, -034}{3, 4:1}{4}{5}", "Nom", "Début", "Fin", "Durée(h)",
                                       ControlChars.NewLine, ControlChars.NewLine)

        ' Ajoute les rangées et les colonnes nomEpreuve, DateHeureDebut, DateHeureFin et le temps entre les deux en heure.
        For Each row As TP3_20201HVB_DataSet.epreuveRow In TP3_20201HVB_DataSet.epreuve.Rows
            strStatistique += String.Format("{0, -15}{5}{1, 20}   {2, -20}  {3, -6:N1} {4}", row.NomEpreuve, row.DateHeureDebutEpreuve,
                                            row.DateHeureFinEpreuve, row.DateHeureDiff, ControlChars.NewLine, ControlChars.Tab)
        Next row

        ' Affiche les moyennes par types.
        strStatistique += ControlChars.NewLine & ControlChars.NewLine
        strStatistique += String.Format("{0,-20}{1}{2,-6}{3}heures en moyenne.{4}", "Examen:",
                                        ControlChars.Tab, dblMoyenneExamen, ControlChars.Tab, ControlChars.NewLine)
        strStatistique += String.Format("{0,-20}{1}{2,-6}{3}heures en moyenne.{4}", "Travail:",
                                        ControlChars.Tab, dblMoyenneTravail, ControlChars.Tab, ControlChars.NewLine)
        strStatistique += String.Format("{0,-20}{1}{2,-6}{3}heures en moyenne.{4}", "Laboratoire:",
                                        ControlChars.Tab, dblMoyenneLaboratoire, ControlChars.Tab, ControlChars.NewLine)
        strStatistique += String.Format("{0,-20}{1}{2,-6}{3}heures en moyenne.{4}", "Autre:",
                                        ControlChars.Tab, dblMoyenneAutre, ControlChars.Tab, ControlChars.NewLine)

        ' Affiche statistique.
        MessageBox.Show(strStatistique, "Statistiques", MessageBoxButtons.OK)

        ' Place la table en ordre croissant selon l'index.
        EpreuveTableAdapter.Fill(TP3_20201HVB_DataSet.epreuve)

    End Sub

    Private Sub ExtraireFichier()
        ' Extrait la liste de toutes les épreuves dans un fichier .txt.

        Dim outFile As IO.StreamWriter
        Dim strRemarquesEpreuve As String
        Dim strLieuEpreuve As String
        Dim strNoteObtenue As String

        ' Création du fichier txt.
        outFile = IO.File.CreateText("agenda.txt")

        For Each row As TP3_20201HVB_DataSet.epreuveRow In TP3_20201HVB_DataSet.epreuve.Rows

            ' Vérifie que lieuEpreuve est non-null.
            If row.IsNull("lieuEpreuve") Then
                strLieuEpreuve = ""
            Else
                strLieuEpreuve = row.lieuEpreuve
            End If
            ' Vérifie que remarquesEpreuve est non-null.
            If row.IsNull("remarquesEpreuve") Then
                strRemarquesEpreuve = ""
            Else
                strRemarquesEpreuve = row.remarquesEpreuve
            End If
            ' Vérifie que noteObtenueEpreuve est non-null.
            If row.IsNull("noteObtenueEpreuve") OrElse row.noteObtenueEpreuve = 0 Then
                strNoteObtenue = ""
            Else
                strNoteObtenue = row.noteObtenueEpreuve.ToString
            End If

            outFile.WriteLine("___________________________________________________________")

            ' Mise en forme et écriture des données.
            outFile.WriteLine(row.IdTypeEpreuve & "-" & NomEpreuve(row.IdTypeEpreuve) & Strings.Space(5) & row.NomEpreuve.PadRight(15) &
                          Strings.Space(5) & "Lieu: " & strLieuEpreuve)
            outFile.WriteLine("Cours: " & row.noCoursEpreuve & Strings.Space(5) & row.titreCoursEpreuve)
            outFile.WriteLine("Début: " & row.DateHeureDebutEpreuve & Strings.Space(10) & "Fin: " & row.DateHeureFinEpreuve)
            outFile.WriteLine("Note obtenue: " & strNoteObtenue)
            outFile.WriteLine("Remarques: ")
            outFile.WriteLine(strRemarquesEpreuve)
        Next

        ' Fermeture du fichier txt.
        outFile.Close()

        ' Message de confirmation.
        MessageBox.Show("Fichier extrait avec succès.", "Extraction",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Function InitialiserTableau() As String(,)
        ' Initialise un tableau à 2 dimensions avec le contenue de la table epreuve.
        ' Retour: Un tableau String à 2 dimensions contenant le nom de l'épreuve, la dateheure du début,
        '         la dateheure de fin et le total des heures.

        Dim nbRangee As Integer = TP3_20201HVB_DataSet.epreuve.Rows.Count
        Dim intCompteur As Integer = 0
        Dim strTableauEpreuves(nbRangee, 3) As String

        ' Ajoute le contenu de la table epreuve 
        For Each row As TP3_20201HVB_DataSet.epreuveRow In TP3_20201HVB_DataSet.epreuve.Rows
            strTableauEpreuves(intCompteur, 0) = NomEpreuve(row.IdTypeEpreuve)
            strTableauEpreuves(intCompteur, 1) = row.DateHeureDebutEpreuve.ToString
            strTableauEpreuves(intCompteur, 2) = row.DateHeureFinEpreuve.ToString
            strTableauEpreuves(intCompteur, 3) = row.DateHeureDiff.ToString
            intCompteur += 1
        Next row

        Return strTableauEpreuves

    End Function

    Function moyenneHeureEpreuve(ByVal typeEpreuve As String, ByRef tableau(,) As String) As Double
        ' Moyenne des nombres d'heures des épreuves contenus dans le tableau.
        ' Param (typeEpreuve): String qui contient le nom de l'épreuve.
        ' Param (tableau): Tableau de String à 2 dimensions représentant les épreuves.
        ' Retour: Double de la moyenne des heures pour l'épreuve demandé.

        Dim dblAcumulateur As Double = 0
        Dim dblStringConversion As Double
        Dim intCompteur As Integer = 0

        ' Boucle dans le tableau.
        For intI As Integer = 0 To tableau.GetUpperBound(0)
            If tableau(intI, 0) = typeEpreuve Then
                Double.TryParse(tableau(intI, 3), dblStringConversion)
                dblAcumulateur += dblStringConversion
                intCompteur += 1
            End If
        Next intI

        ' Vérifie si il y a division par zéro.
        If intCompteur = 0 Then
            Return 0
        Else
            Return Math.Round((dblAcumulateur / intCompteur), 1)
        End If

    End Function

    Function NomEpreuve(ByVal intIdTypeEpreuve As Integer) As String
        ' Fait la liaison entre la correspondance index et nom de l'épreuve.
        ' Param (intIdTypeEpreuve): Integer contenant le numéro de l'index.
        ' Retour: String contenant le nom de l'épreuve demandé.

        ' Parcours la table typeEpreuve.
        For Each row As TP3_20201HVB_DataSet.typeEpreuveRow In TP3_20201HVB_DataSet.typeEpreuve.Rows
            If row.IdTypeEpreuve = intIdTypeEpreuve Then
                Return row.nomType
            End If
        Next row

        ' Si erreur.
        Return String.Empty

    End Function

    Private Sub frmForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TP3_20201HVB_DataSet.typeEpreuve' table. You can move, or remove it, as needed.
        Me.TypeEpreuveTableAdapter.Fill(Me.TP3_20201HVB_DataSet.typeEpreuve)
        'TODO: This line of code loads data into the 'TP3_20201HVB_DataSet.epreuve' table. You can move, or remove it, as needed.
        Me.EpreuveTableAdapter.Fill(Me.TP3_20201HVB_DataSet.epreuve)

        ' Remise à zéro du drapeau de sauvegarde.
        blnSauvegardeFlag = False

    End Sub

    Private Sub mnuFichierQuitter_Click(sender As Object, e As EventArgs) Handles mnuFichierQuitter.Click
        Me.Close()

    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click, mnuEpreuvesAjouter.Click

        AjouterEnregistrement()

    End Sub

    Private Sub btnSauvegarder_Click(sender As Object, e As EventArgs) Handles btnSauvegarder.Click, mnuEpreuvesSauvegarder.Click
        ' Sauvegarde les enregistrements.

        SauvegardeEnregistrement()

    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click, mnuEpreuvesSupprimer.Click
        ' Supprime l'enregistrement en cours.

        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Effacer l'enregistrement en cours ?", "Confirmer Effacer",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        ' Confimer la suppression.
        If dlgButton = DialogResult.Yes Then
            SupprimerEnregistrement()
        End If

        ' Remise à zéro du drapeau de sauvegarde.
        blnSauvegardeFlag = False

    End Sub

    Private Sub btnPremier_Click(sender As Object, e As EventArgs) Handles btnPremier.Click, mnuEpreuvesPremier.Click
        ' Revient au premier enregistrement en ordre croissant.

        EpreuveBindingSource.MoveFirst()

        ' Remise à zéro du drapeau de sauvegarde.
        blnSauvegardeFlag = False

    End Sub

    Private Sub btnSuivant_Click(sender As Object, e As EventArgs) Handles btnSuivant.Click, mnuEpreuvesSuivant.Click
        ' Enregistrement suivant en ordre croissant.

        EpreuveBindingSource.MoveNext()

        ' Remise à zéro du drapeau de sauvegarde.
        blnSauvegardeFlag = False

    End Sub

    Private Sub btnPrecedent_Click(sender As Object, e As EventArgs) Handles btnPrecedent.Click, mnuEpreuvesPrecedent.Click
        ' Enregistrement précèdant en ordre croissant.

        EpreuveBindingSource.MovePrevious()

        ' Remise à zéro du drapeau de sauvegarde.
        blnSauvegardeFlag = False

    End Sub

    Private Sub btnDernier_Click(sender As Object, e As EventArgs) Handles btnDernier.Click, mnuEpreuvesDernier.Click
        ' Revient au dernier enregistrement en ordre croissant.

        EpreuveBindingSource.MoveLast()

        ' Remise à zéro du drapeau de sauvegarde.
        blnSauvegardeFlag = False

    End Sub

    Private Sub frmForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        ' Si l'enregistrement n'est pas sauvegardé.
        If blnSauvegardeFlag Then
            Dim dlgButton As DialogResult
            dlgButton = MessageBox.Show("Voulez-vous sauvegarder l'enregistrement en cours ?", "Sauvegarder",
                                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
            If dlgButton = DialogResult.Yes Then
                SauvegardeEnregistrement()
            ElseIf dlgButton = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub mnuEpreuvesStatistiques_Click(sender As Object, e As EventArgs) Handles mnuEpreuvesStatistiques.Click
        ' Affiche un messagebox des statistiques de l'agenda scolaire.

        AfficherStatistique()

    End Sub

    Private Sub mnuFichierExtraire_Click(sender As Object, e As EventArgs) Handles mnuFichierExtraire.Click
        ' Extrait dans un fichier agenda.txt les informations de l'agenda scolaire.

        ExtraireFichier()

    End Sub

    Private Sub txtNote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNote.KeyPress
        ' Accepte seulement les chiffres, le "Backspace" et la virgule(,).

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back AndAlso
            e.KeyChar <> "," Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtLieu_TextChanged(sender As Object, e As EventArgs) Handles _
        txtLieu.TextChanged, txtNoCours.TextChanged, txtNom.TextChanged, txtRemarques.TextChanged, txtTitreCours.TextChanged,
        dtpDebut.TextChanged, dtpFin.TextChanged, txtNote.TextChanged, cboTypeEpreuve.SelectedValueChanged

        ' Drapeau de sauvegarde placé à sauvegarder.
        blnSauvegardeFlag = True

    End Sub
End Class
