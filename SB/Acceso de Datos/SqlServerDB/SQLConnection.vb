﻿Imports System.Data.SqlClient
Public MustInherit Class ConnectionToSql

        Private connectionString As String
        Protected Sub New()
        connectionString = "Server=GUERREROPC\GUERREROPCSQL; DataBase=BoletasDigitales; integrated security = true"
    End Sub
    Protected Function GetConnection() As SQLConnection
        Return New SQLConnection(connectionString)
    End Function
    'Programador: Andrey Guerrero
End Class
