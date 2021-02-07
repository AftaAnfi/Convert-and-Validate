Option Strict On
Option Explicit On

'Aftanom Anfilofieff
'RCET0265
'Spring 2021
'Convert and Validate
'https://github.com/AftaAnfi/SimpleCalculator.git

Module ConvertAndValidate

    Sub Main()
        Dim tempInteger As Integer

        Console.WriteLine(ValidateAndConvert("1244221", tempInteger))
        Console.WriteLine(tempInteger)

        Console.ReadLine()
    End Sub



    'Function to convert a string to an integer and return a message about the conversion
    Private Function ValidateAndConvert(ByVal convertThisString As String, ByRef toThisInteger As Integer) As String

        Dim message As String
        message = ""

        Try
            toThisInteger = CInt(convertThisString)

        Catch ex As Exception

            If convertThisString = "" Then
                message = "is empty"
            Else

                message = "must contain a number"
            End If
        End Try


        Return message

    End Function

End Module
