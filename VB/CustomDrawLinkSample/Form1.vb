Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraNavBar

Namespace CustomDrawLinkSample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub navBarControl1_CustomDrawLink(ByVal sender As Object, ByVal e As CustomDrawNavBarElementEventArgs) Handles navBarControl1.CustomDrawLink
			Dim textSize As SizeF = e.Cache.CalcTextSize(e.Caption, e.Appearance.Font, StringFormat.GenericDefault, e.RealBounds.Width)
			Dim args As NavLinkInfoArgs = CType(e.ObjectInfo, NavLinkInfoArgs)
			Dim newCaptionRectangle As Rectangle = args.RealCaptionRectangle
			newCaptionRectangle.Width = Convert.ToInt32(textSize.Width)
			args.CaptionRectangle = newCaptionRectangle
		End Sub
	End Class
End Namespace