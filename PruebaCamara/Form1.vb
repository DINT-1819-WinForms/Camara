Imports WebEye.Controls.WinForms.WebCameraControl

Public Class Form1

    Private Sub IniciarButton_Click(sender As Object, e As EventArgs) Handles IniciarButton.Click

        'Obtenemos el listado de cámaras disponibles en el sistema
        Dim cameras As New List(Of WebCameraId)
        cameras = WebCameraControl1.GetVideoCaptureDevices()
        Try
            'Como solo tenemos una, la iniciamos directamente
            WebCameraControl1.StartCapture(cameras(0))
        Catch ex As Exception
            MessageBox.Show("Error al iniciar la cámara:" & ex.Message)
        End Try

    End Sub

    Private Sub CapturarButton_Click(sender As Object, e As EventArgs) Handles CapturarButton.Click
        Try
            'Indicamos la ruta y el formato del fichero
            WebCameraControl1.GetCurrentImage.Save(".\tmp.jpg", Imaging.ImageFormat.Jpeg)
        Catch ex As Exception
            MessageBox.Show("Error al guardar la imagen:" & ex.Message)
        End Try
    End Sub

    Private Sub PararButton_Click(sender As Object, e As EventArgs) Handles PararButton.Click
        Try
            'Paramos la cámara
            WebCameraControl1.StopCapture()

        Catch ex As Exception
            MessageBox.Show("Error al parar la cámara:" & ex.Message)
        End Try

    End Sub
End Class
