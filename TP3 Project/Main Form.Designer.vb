<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdEpreuveLabel As System.Windows.Forms.Label
        Dim NomEpreuveLabel As System.Windows.Forms.Label
        Dim DateHeureDebutEpreuveLabel As System.Windows.Forms.Label
        Dim DateHeureFinEpreuveLabel As System.Windows.Forms.Label
        Dim LieuEpreuveLabel As System.Windows.Forms.Label
        Dim NoteObtenueEpreuveLabel As System.Windows.Forms.Label
        Dim NoCoursEpreuveLabel As System.Windows.Forms.Label
        Dim TitreCoursEpreuveLabel As System.Windows.Forms.Label
        Dim RemarquesEpreuveLabel As System.Windows.Forms.Label
        Dim NomTypeLabel As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFichier = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFichierExtraire = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFichierQuitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEpreuves = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEpreuvesPremier = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEpreuvesPrecedent = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEpreuvesSuivant = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEpreuvesDernier = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEpreuvesAjouter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEpreuvesSupprimer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEpreuvesSauvegarder = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEpreuvesStatistiques = New System.Windows.Forms.ToolStripMenuItem()
        Me.TP3_20201HVB_DataSet = New TP3_Project.TP3_20201HVB_DataSet()
        Me.EpreuveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EpreuveTableAdapter = New TP3_Project.TP3_20201HVB_DataSetTableAdapters.epreuveTableAdapter()
        Me.TableAdapterManager = New TP3_Project.TP3_20201HVB_DataSetTableAdapters.TableAdapterManager()
        Me.TypeEpreuveTableAdapter = New TP3_Project.TP3_20201HVB_DataSetTableAdapters.typeEpreuveTableAdapter()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.dtpDebut = New System.Windows.Forms.DateTimePicker()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.txtLieu = New System.Windows.Forms.TextBox()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.txtNoCours = New System.Windows.Forms.TextBox()
        Me.txtTitreCours = New System.Windows.Forms.TextBox()
        Me.txtRemarques = New System.Windows.Forms.TextBox()
        Me.cboTypeEpreuve = New System.Windows.Forms.ComboBox()
        Me.TypeEpreuveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnPremier = New System.Windows.Forms.Button()
        Me.btnPrecedent = New System.Windows.Forms.Button()
        Me.btnSuivant = New System.Windows.Forms.Button()
        Me.btnDernier = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnSauvegarder = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        IdEpreuveLabel = New System.Windows.Forms.Label()
        NomEpreuveLabel = New System.Windows.Forms.Label()
        DateHeureDebutEpreuveLabel = New System.Windows.Forms.Label()
        DateHeureFinEpreuveLabel = New System.Windows.Forms.Label()
        LieuEpreuveLabel = New System.Windows.Forms.Label()
        NoteObtenueEpreuveLabel = New System.Windows.Forms.Label()
        NoCoursEpreuveLabel = New System.Windows.Forms.Label()
        TitreCoursEpreuveLabel = New System.Windows.Forms.Label()
        RemarquesEpreuveLabel = New System.Windows.Forms.Label()
        NomTypeLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TP3_20201HVB_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EpreuveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeEpreuveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdEpreuveLabel
        '
        IdEpreuveLabel.AutoSize = True
        IdEpreuveLabel.Location = New System.Drawing.Point(74, 76)
        IdEpreuveLabel.Name = "IdEpreuveLabel"
        IdEpreuveLabel.Size = New System.Drawing.Size(20, 15)
        IdEpreuveLabel.TabIndex = 4
        IdEpreuveLabel.Text = "Id:"
        '
        'NomEpreuveLabel
        '
        NomEpreuveLabel.AutoSize = True
        NomEpreuveLabel.Location = New System.Drawing.Point(57, 133)
        NomEpreuveLabel.Name = "NomEpreuveLabel"
        NomEpreuveLabel.Size = New System.Drawing.Size(37, 15)
        NomEpreuveLabel.TabIndex = 8
        NomEpreuveLabel.Text = "Nom:"
        '
        'DateHeureDebutEpreuveLabel
        '
        DateHeureDebutEpreuveLabel.AutoSize = True
        DateHeureDebutEpreuveLabel.Location = New System.Drawing.Point(375, 103)
        DateHeureDebutEpreuveLabel.Name = "DateHeureDebutEpreuveLabel"
        DateHeureDebutEpreuveLabel.Size = New System.Drawing.Size(104, 15)
        DateHeureDebutEpreuveLabel.TabIndex = 18
        DateHeureDebutEpreuveLabel.Text = "Date Heure Debut:"
        '
        'DateHeureFinEpreuveLabel
        '
        DateHeureFinEpreuveLabel.AutoSize = True
        DateHeureFinEpreuveLabel.Location = New System.Drawing.Point(391, 133)
        DateHeureFinEpreuveLabel.Name = "DateHeureFinEpreuveLabel"
        DateHeureFinEpreuveLabel.Size = New System.Drawing.Size(88, 15)
        DateHeureFinEpreuveLabel.TabIndex = 20
        DateHeureFinEpreuveLabel.Text = "Date Heure Fin:"
        '
        'LieuEpreuveLabel
        '
        LieuEpreuveLabel.AutoSize = True
        LieuEpreuveLabel.Location = New System.Drawing.Point(62, 223)
        LieuEpreuveLabel.Name = "LieuEpreuveLabel"
        LieuEpreuveLabel.Size = New System.Drawing.Size(32, 15)
        LieuEpreuveLabel.TabIndex = 14
        LieuEpreuveLabel.Text = "Lieu:"
        '
        'NoteObtenueEpreuveLabel
        '
        NoteObtenueEpreuveLabel.AutoSize = True
        NoteObtenueEpreuveLabel.Location = New System.Drawing.Point(396, 162)
        NoteObtenueEpreuveLabel.Name = "NoteObtenueEpreuveLabel"
        NoteObtenueEpreuveLabel.Size = New System.Drawing.Size(83, 15)
        NoteObtenueEpreuveLabel.TabIndex = 22
        NoteObtenueEpreuveLabel.Text = "Note obtenue:"
        '
        'NoCoursEpreuveLabel
        '
        NoCoursEpreuveLabel.AutoSize = True
        NoCoursEpreuveLabel.Location = New System.Drawing.Point(36, 163)
        NoCoursEpreuveLabel.Name = "NoCoursEpreuveLabel"
        NoCoursEpreuveLabel.Size = New System.Drawing.Size(58, 15)
        NoCoursEpreuveLabel.TabIndex = 10
        NoCoursEpreuveLabel.Text = "No cours:"
        '
        'TitreCoursEpreuveLabel
        '
        TitreCoursEpreuveLabel.AutoSize = True
        TitreCoursEpreuveLabel.Location = New System.Drawing.Point(29, 193)
        TitreCoursEpreuveLabel.Name = "TitreCoursEpreuveLabel"
        TitreCoursEpreuveLabel.Size = New System.Drawing.Size(65, 15)
        TitreCoursEpreuveLabel.TabIndex = 12
        TitreCoursEpreuveLabel.Text = "Titre cours:"
        '
        'RemarquesEpreuveLabel
        '
        RemarquesEpreuveLabel.AutoSize = True
        RemarquesEpreuveLabel.Location = New System.Drawing.Point(25, 252)
        RemarquesEpreuveLabel.Name = "RemarquesEpreuveLabel"
        RemarquesEpreuveLabel.Size = New System.Drawing.Size(69, 15)
        RemarquesEpreuveLabel.TabIndex = 16
        RemarquesEpreuveLabel.Text = "Remarques:"
        '
        'NomTypeLabel
        '
        NomTypeLabel.AutoSize = True
        NomTypeLabel.Location = New System.Drawing.Point(60, 103)
        NomTypeLabel.Name = "NomTypeLabel"
        NomTypeLabel.Size = New System.Drawing.Size(34, 15)
        NomTypeLabel.TabIndex = 6
        NomTypeLabel.Text = "Type:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFichier, Me.mnuEpreuves})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(629, 24)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFichier
        '
        Me.mnuFichier.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFichierExtraire, Me.ToolStripMenuItem1, Me.mnuFichierQuitter})
        Me.mnuFichier.Name = "mnuFichier"
        Me.mnuFichier.Size = New System.Drawing.Size(54, 20)
        Me.mnuFichier.Text = "&Fichier"
        '
        'mnuFichierExtraire
        '
        Me.mnuFichierExtraire.Name = "mnuFichierExtraire"
        Me.mnuFichierExtraire.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuFichierExtraire.Size = New System.Drawing.Size(185, 22)
        Me.mnuFichierExtraire.Text = "&Extraire"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(182, 6)
        '
        'mnuFichierQuitter
        '
        Me.mnuFichierQuitter.Name = "mnuFichierQuitter"
        Me.mnuFichierQuitter.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.mnuFichierQuitter.Size = New System.Drawing.Size(185, 22)
        Me.mnuFichierQuitter.Text = "&Quitter"
        '
        'mnuEpreuves
        '
        Me.mnuEpreuves.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEpreuvesPremier, Me.mnuEpreuvesPrecedent, Me.mnuEpreuvesSuivant, Me.mnuEpreuvesDernier, Me.mnuEpreuvesAjouter, Me.mnuEpreuvesSupprimer, Me.mnuEpreuvesSauvegarder, Me.ToolStripMenuItem2, Me.mnuEpreuvesStatistiques})
        Me.mnuEpreuves.Name = "mnuEpreuves"
        Me.mnuEpreuves.Size = New System.Drawing.Size(66, 20)
        Me.mnuEpreuves.Text = "&Épreuves"
        '
        'mnuEpreuvesPremier
        '
        Me.mnuEpreuvesPremier.Name = "mnuEpreuvesPremier"
        Me.mnuEpreuvesPremier.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuEpreuvesPremier.Size = New System.Drawing.Size(180, 22)
        Me.mnuEpreuvesPremier.Text = "&Premier"
        '
        'mnuEpreuvesPrecedent
        '
        Me.mnuEpreuvesPrecedent.Name = "mnuEpreuvesPrecedent"
        Me.mnuEpreuvesPrecedent.ShortcutKeyDisplayString = "Ctrl++"
        Me.mnuEpreuvesPrecedent.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.OemMinus), System.Windows.Forms.Keys)
        Me.mnuEpreuvesPrecedent.Size = New System.Drawing.Size(180, 22)
        Me.mnuEpreuvesPrecedent.Text = "P&récédent"
        '
        'mnuEpreuvesSuivant
        '
        Me.mnuEpreuvesSuivant.Name = "mnuEpreuvesSuivant"
        Me.mnuEpreuvesSuivant.ShortcutKeyDisplayString = "Ctrl+-"
        Me.mnuEpreuvesSuivant.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Oemplus), System.Windows.Forms.Keys)
        Me.mnuEpreuvesSuivant.Size = New System.Drawing.Size(180, 22)
        Me.mnuEpreuvesSuivant.Text = "Sui&vant"
        '
        'mnuEpreuvesDernier
        '
        Me.mnuEpreuvesDernier.Name = "mnuEpreuvesDernier"
        Me.mnuEpreuvesDernier.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.mnuEpreuvesDernier.Size = New System.Drawing.Size(180, 22)
        Me.mnuEpreuvesDernier.Text = "&Dernier"
        '
        'mnuEpreuvesAjouter
        '
        Me.mnuEpreuvesAjouter.Name = "mnuEpreuvesAjouter"
        Me.mnuEpreuvesAjouter.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuEpreuvesAjouter.Size = New System.Drawing.Size(180, 22)
        Me.mnuEpreuvesAjouter.Text = "A&jouter"
        '
        'mnuEpreuvesSupprimer
        '
        Me.mnuEpreuvesSupprimer.Name = "mnuEpreuvesSupprimer"
        Me.mnuEpreuvesSupprimer.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.mnuEpreuvesSupprimer.Size = New System.Drawing.Size(180, 22)
        Me.mnuEpreuvesSupprimer.Text = "S&upprimer"
        '
        'mnuEpreuvesSauvegarder
        '
        Me.mnuEpreuvesSauvegarder.Name = "mnuEpreuvesSauvegarder"
        Me.mnuEpreuvesSauvegarder.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuEpreuvesSauvegarder.Size = New System.Drawing.Size(180, 22)
        Me.mnuEpreuvesSauvegarder.Text = "&Sauvegarder"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(177, 6)
        '
        'mnuEpreuvesStatistiques
        '
        Me.mnuEpreuvesStatistiques.Name = "mnuEpreuvesStatistiques"
        Me.mnuEpreuvesStatistiques.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuEpreuvesStatistiques.Size = New System.Drawing.Size(180, 22)
        Me.mnuEpreuvesStatistiques.Text = "S&tatistiques"
        '
        'TP3_20201HVB_DataSet
        '
        Me.TP3_20201HVB_DataSet.DataSetName = "TP3_20201HVB_DataSet"
        Me.TP3_20201HVB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EpreuveBindingSource
        '
        Me.EpreuveBindingSource.DataMember = "epreuve"
        Me.EpreuveBindingSource.DataSource = Me.TP3_20201HVB_DataSet
        '
        'EpreuveTableAdapter
        '
        Me.EpreuveTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.epreuveTableAdapter = Nothing
        Me.TableAdapterManager.typeEpreuveTableAdapter = Me.TypeEpreuveTableAdapter
        Me.TableAdapterManager.UpdateOrder = TP3_Project.TP3_20201HVB_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TypeEpreuveTableAdapter
        '
        Me.TypeEpreuveTableAdapter.ClearBeforeFill = True
        '
        'lblId
        '
        Me.lblId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EpreuveBindingSource, "IdEpreuve", True))
        Me.lblId.Location = New System.Drawing.Point(100, 76)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(47, 18)
        Me.lblId.TabIndex = 5
        '
        'txtNom
        '
        Me.txtNom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EpreuveBindingSource, "NomEpreuve", True))
        Me.txtNom.Location = New System.Drawing.Point(100, 129)
        Me.txtNom.MaxLength = 15
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(258, 23)
        Me.txtNom.TabIndex = 9
        '
        'dtpDebut
        '
        Me.dtpDebut.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpDebut.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EpreuveBindingSource, "DateHeureDebutEpreuve", True))
        Me.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDebut.Location = New System.Drawing.Point(485, 99)
        Me.dtpDebut.Name = "dtpDebut"
        Me.dtpDebut.ShowUpDown = True
        Me.dtpDebut.Size = New System.Drawing.Size(124, 23)
        Me.dtpDebut.TabIndex = 19
        '
        'dtpFin
        '
        Me.dtpFin.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpFin.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EpreuveBindingSource, "DateHeureFinEpreuve", True))
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFin.Location = New System.Drawing.Point(485, 129)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.ShowUpDown = True
        Me.dtpFin.Size = New System.Drawing.Size(124, 23)
        Me.dtpFin.TabIndex = 21
        '
        'txtLieu
        '
        Me.txtLieu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EpreuveBindingSource, "lieuEpreuve", True))
        Me.txtLieu.Location = New System.Drawing.Point(100, 219)
        Me.txtLieu.MaxLength = 40
        Me.txtLieu.Name = "txtLieu"
        Me.txtLieu.Size = New System.Drawing.Size(258, 23)
        Me.txtLieu.TabIndex = 15
        '
        'txtNote
        '
        Me.txtNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EpreuveBindingSource, "noteObtenueEpreuve", True))
        Me.txtNote.Location = New System.Drawing.Point(485, 158)
        Me.txtNote.MaxLength = 4
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(124, 23)
        Me.txtNote.TabIndex = 23
        '
        'txtNoCours
        '
        Me.txtNoCours.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EpreuveBindingSource, "noCoursEpreuve", True))
        Me.txtNoCours.Location = New System.Drawing.Point(100, 159)
        Me.txtNoCours.MaxLength = 10
        Me.txtNoCours.Name = "txtNoCours"
        Me.txtNoCours.Size = New System.Drawing.Size(258, 23)
        Me.txtNoCours.TabIndex = 11
        '
        'txtTitreCours
        '
        Me.txtTitreCours.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EpreuveBindingSource, "titreCoursEpreuve", True))
        Me.txtTitreCours.Location = New System.Drawing.Point(100, 189)
        Me.txtTitreCours.MaxLength = 80
        Me.txtTitreCours.Name = "txtTitreCours"
        Me.txtTitreCours.Size = New System.Drawing.Size(258, 23)
        Me.txtTitreCours.TabIndex = 13
        '
        'txtRemarques
        '
        Me.txtRemarques.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EpreuveBindingSource, "remarquesEpreuve", True))
        Me.txtRemarques.Location = New System.Drawing.Point(100, 248)
        Me.txtRemarques.MaxLength = 200
        Me.txtRemarques.Multiline = True
        Me.txtRemarques.Name = "txtRemarques"
        Me.txtRemarques.Size = New System.Drawing.Size(258, 55)
        Me.txtRemarques.TabIndex = 17
        '
        'cboTypeEpreuve
        '
        Me.cboTypeEpreuve.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EpreuveBindingSource, "IdTypeEpreuve", True))
        Me.cboTypeEpreuve.DataSource = Me.TypeEpreuveBindingSource
        Me.cboTypeEpreuve.DisplayMember = "nomType"
        Me.cboTypeEpreuve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTypeEpreuve.FormattingEnabled = True
        Me.cboTypeEpreuve.Location = New System.Drawing.Point(100, 99)
        Me.cboTypeEpreuve.Name = "cboTypeEpreuve"
        Me.cboTypeEpreuve.Size = New System.Drawing.Size(258, 23)
        Me.cboTypeEpreuve.TabIndex = 7
        Me.cboTypeEpreuve.ValueMember = "IdTypeEpreuve"
        '
        'TypeEpreuveBindingSource
        '
        Me.TypeEpreuveBindingSource.DataMember = "typeEpreuve"
        Me.TypeEpreuveBindingSource.DataSource = Me.TP3_20201HVB_DataSet
        '
        'btnPremier
        '
        Me.btnPremier.Location = New System.Drawing.Point(12, 38)
        Me.btnPremier.Name = "btnPremier"
        Me.btnPremier.Size = New System.Drawing.Size(82, 23)
        Me.btnPremier.TabIndex = 0
        Me.btnPremier.Text = "&Premier"
        Me.btnPremier.UseVisualStyleBackColor = True
        '
        'btnPrecedent
        '
        Me.btnPrecedent.Location = New System.Drawing.Point(100, 38)
        Me.btnPrecedent.Name = "btnPrecedent"
        Me.btnPrecedent.Size = New System.Drawing.Size(82, 23)
        Me.btnPrecedent.TabIndex = 1
        Me.btnPrecedent.Text = "P&récédent"
        Me.btnPrecedent.UseVisualStyleBackColor = True
        '
        'btnSuivant
        '
        Me.btnSuivant.Location = New System.Drawing.Point(188, 38)
        Me.btnSuivant.Name = "btnSuivant"
        Me.btnSuivant.Size = New System.Drawing.Size(82, 23)
        Me.btnSuivant.TabIndex = 2
        Me.btnSuivant.Text = "Sui&vant"
        Me.btnSuivant.UseVisualStyleBackColor = True
        '
        'btnDernier
        '
        Me.btnDernier.Location = New System.Drawing.Point(276, 38)
        Me.btnDernier.Name = "btnDernier"
        Me.btnDernier.Size = New System.Drawing.Size(82, 23)
        Me.btnDernier.TabIndex = 3
        Me.btnDernier.Text = "&Dernier"
        Me.btnDernier.UseVisualStyleBackColor = True
        '
        'btnAjouter
        '
        Me.btnAjouter.Location = New System.Drawing.Point(12, 326)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(82, 28)
        Me.btnAjouter.TabIndex = 24
        Me.btnAjouter.Text = "A&jouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'btnSauvegarder
        '
        Me.btnSauvegarder.Location = New System.Drawing.Point(100, 326)
        Me.btnSauvegarder.Name = "btnSauvegarder"
        Me.btnSauvegarder.Size = New System.Drawing.Size(82, 28)
        Me.btnSauvegarder.TabIndex = 25
        Me.btnSauvegarder.Text = "&Sauvegarder"
        Me.btnSauvegarder.UseVisualStyleBackColor = True
        '
        'btnSupprimer
        '
        Me.btnSupprimer.Location = New System.Drawing.Point(276, 326)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(82, 28)
        Me.btnSupprimer.TabIndex = 26
        Me.btnSupprimer.Text = "S&upprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = True
        '
        'frmForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 374)
        Me.Controls.Add(Me.btnSupprimer)
        Me.Controls.Add(Me.btnSauvegarder)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.btnDernier)
        Me.Controls.Add(Me.btnSuivant)
        Me.Controls.Add(Me.btnPrecedent)
        Me.Controls.Add(Me.btnPremier)
        Me.Controls.Add(IdEpreuveLabel)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(NomEpreuveLabel)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(DateHeureDebutEpreuveLabel)
        Me.Controls.Add(Me.dtpDebut)
        Me.Controls.Add(DateHeureFinEpreuveLabel)
        Me.Controls.Add(Me.dtpFin)
        Me.Controls.Add(LieuEpreuveLabel)
        Me.Controls.Add(Me.txtLieu)
        Me.Controls.Add(NoteObtenueEpreuveLabel)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(NoCoursEpreuveLabel)
        Me.Controls.Add(Me.txtNoCours)
        Me.Controls.Add(TitreCoursEpreuveLabel)
        Me.Controls.Add(Me.txtTitreCours)
        Me.Controls.Add(RemarquesEpreuveLabel)
        Me.Controls.Add(Me.txtRemarques)
        Me.Controls.Add(NomTypeLabel)
        Me.Controls.Add(Me.cboTypeEpreuve)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda Scolaire"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TP3_20201HVB_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EpreuveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeEpreuveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFichier As ToolStripMenuItem
    Friend WithEvents mnuFichierExtraire As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuFichierQuitter As ToolStripMenuItem
    Friend WithEvents mnuEpreuves As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents mnuEpreuvesStatistiques As ToolStripMenuItem
    Friend WithEvents TP3_20201HVB_DataSet As TP3_20201HVB_DataSet
    Friend WithEvents EpreuveBindingSource As BindingSource
    Friend WithEvents EpreuveTableAdapter As TP3_20201HVB_DataSetTableAdapters.epreuveTableAdapter
    Friend WithEvents TableAdapterManager As TP3_20201HVB_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblId As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents dtpDebut As DateTimePicker
    Friend WithEvents dtpFin As DateTimePicker
    Friend WithEvents txtLieu As TextBox
    Friend WithEvents txtNote As TextBox
    Friend WithEvents txtNoCours As TextBox
    Friend WithEvents txtTitreCours As TextBox
    Friend WithEvents txtRemarques As TextBox
    Friend WithEvents cboTypeEpreuve As ComboBox
    Friend WithEvents TypeEpreuveTableAdapter As TP3_20201HVB_DataSetTableAdapters.typeEpreuveTableAdapter
    Friend WithEvents TypeEpreuveBindingSource As BindingSource
    Friend WithEvents btnPremier As Button
    Friend WithEvents btnPrecedent As Button
    Friend WithEvents btnSuivant As Button
    Friend WithEvents btnDernier As Button
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnSauvegarder As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents mnuEpreuvesPremier As ToolStripMenuItem
    Friend WithEvents mnuEpreuvesPrecedent As ToolStripMenuItem
    Friend WithEvents mnuEpreuvesSuivant As ToolStripMenuItem
    Friend WithEvents mnuEpreuvesDernier As ToolStripMenuItem
    Friend WithEvents mnuEpreuvesAjouter As ToolStripMenuItem
    Friend WithEvents mnuEpreuvesSupprimer As ToolStripMenuItem
    Friend WithEvents mnuEpreuvesSauvegarder As ToolStripMenuItem
End Class
