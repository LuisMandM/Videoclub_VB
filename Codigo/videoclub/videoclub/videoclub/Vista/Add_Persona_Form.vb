Public Class Add_Persona_Form
    Private _tipo_Persona As Role.role
    Private writer As New WriteSQL

    Property tipo_Persona As Role.role
        Get
            Return _tipo_Persona
        End Get
        Set
            _tipo_Persona = Value
        End Set
    End Property

    Public Structure Role
        Enum role
            ACTOR
            DIRECTOR
        End Enum
    End Structure

    Private Sub btton_Save_Click(sender As Object, e As EventArgs) Handles btton_Save.Click
        Try
            If Me.tipo_Persona = Role.role.ACTOR Then
                writer.AddActor(tbox_Name.Text)
                MsgBox(String.Format("Actor: {0}, Guardado Exitosamente", tbox_Name.Text))
                Me.Close()

            Else Me.tipo_Persona = Role.role.DIRECTOR
                writer.AddDirector(tbox_Name.Text)
                MsgBox(String.Format("Director: {0}, Guardado Exitosamente", tbox_Name.Text))
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, Title:="Error Insertando")
        End Try

    End Sub
End Class