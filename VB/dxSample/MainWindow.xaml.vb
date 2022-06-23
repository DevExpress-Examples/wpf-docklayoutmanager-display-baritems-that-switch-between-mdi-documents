Imports System.Windows
Imports System.Windows.Controls

Namespace dxSample

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub item_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            Me.dxDockLayoutManager.MDIController.TileHorizontal(Me.dxDocumentGroup)
        End Sub

        Private Sub item_ItemClick_1(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            Me.dxDockLayoutManager.MDIController.TileVertical(Me.dxDocumentGroup)
        End Sub
    End Class
End Namespace
