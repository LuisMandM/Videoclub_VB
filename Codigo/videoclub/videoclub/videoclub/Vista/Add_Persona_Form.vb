Public Class Add_Persona_Form
    Private _tipo_Persona As Role.role
    Private writer As New WriteSQL
    Private _source As Add_Role_Form

    Property source As Add_Role_Form
        Get
            Return _source
        End Get
        Set
            _source = Value
        End Set
    End Property

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
            If tbox_Name.Text IsNot "" Then
                If Me.tipo_Persona = Role.role.ACTOR Then
                    writer.AddActor(tbox_Name.Text)
                    MsgBox(String.Format("Actor: {0}, Guardado Exitosamente", tbox_Name.Text))
                    If Me.source IsNot Nothing Then
                        source.Cargar_Datos()
                    End If
                    Me.Close()

                Else Me.tipo_Persona = Role.role.DIRECTOR
                    writer.AddDirector(tbox_Name.Text)
                    MsgBox(String.Format("Director: {0}, Guardado Exitosamente", tbox_Name.Text))
                    Me.Close()
                End If
            Else
                Throw New Exception("El campo de nombre no puede ser una cadena vacia")
            End If


        Catch ex As Exception
            MsgBox(ex.Message, Title:="Error Insertando")
        End Try

    End Sub
End Class