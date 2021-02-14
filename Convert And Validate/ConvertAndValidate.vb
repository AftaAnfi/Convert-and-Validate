Option Strict On
Option Explicit On

'Aftanom Anfilofieff
'RCET0265
'Spring 2021
'Convert and Validate
'https://github.com/AftaAnfi/Convert-and-Validate.git

Module ConvertAndValidate

    Sub Main()

        'create a temp variable to pass into the function
        Dim tempInteger As Integer


        Console.WriteLine("Input a number.")

        'validate the input number
        Console.WriteLine(ValidateAndConvert(Console.ReadLine(), tempInteger))
        If tempInteger <> 0 Then
            'if the integer is not 0, return to console
            Console.WriteLine($"{tempInteger} is your number")
        End If

        Console.ReadLine()

    End Sub



    'Function to convert a string to an integer and return a message about the conversion
    Private Function ValidateAndConvert(ByVal convertThisString As String, ByRef toThisInteger As Integer) As String

        Dim message As String
        message = ""

        'Try to convert the sent string integer
        Try
            toThisInteger = CInt(convertThisString)

            'if converting doesn't work return a string based on why it didn't convert
        Catch ex As Exception

            If convertThisString = "" Then
                message = "is empty"
            Else
                message = "must contain a number"
            End If
        End Try

        'return message
        Return message

    End Function

End Module
