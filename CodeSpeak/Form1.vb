Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class Form1
    Private Function ConvertToFarfallino(input As String) As String

        Dim output As String = ""
        Dim capitalizeNext As Boolean = True
        For Each c As Char In input
            If c = "." Then
                capitalizeNext = True
            End If

            If Char.IsPunctuation(c) Then
                output += c
            Else
                Select Case Char.ToLower(c)
                    Case "a"
                        output += If(capitalizeNext, "AFA", If(Char.IsUpper(c), "AFA", "afa"))
                    Case "e"
                        output += If(capitalizeNext, "EFE", If(Char.IsUpper(c), "EFE", "efe"))
                    Case "i"
                        output += If(capitalizeNext, "IFI", If(Char.IsUpper(c), "IFI", "ifi"))
                    Case "o"
                        output += If(capitalizeNext, "OFO", If(Char.IsUpper(c), "OFO", "ofo"))
                    Case "u"
                        output += If(capitalizeNext, "UFU", If(Char.IsUpper(c), "UFU", "ufu"))
                    Case "à"
                        output += If(capitalizeNext, "AFÀ", If(Char.IsUpper(c), "AFÀ", "afà"))
                    Case "è"
                        output += If(capitalizeNext, "EFÈ", If(Char.IsUpper(c), "EFÈ", "efè"))
                    Case "é"
                        output += If(capitalizeNext, "EFÉ", If(Char.IsUpper(c), "EFÉ", "efé"))
                    Case "ì"
                        output += If(capitalizeNext, "IFÌ", If(Char.IsUpper(c), "IFÌ", "ifì"))
                    Case "ò"
                        output += If(capitalizeNext, "OFÒ", If(Char.IsUpper(c), "OFÒ", "ofò"))
                    Case "ù"
                        output += If(capitalizeNext, "UFÙ", If(Char.IsUpper(c), "UFÙ", "ufù"))
                    Case Else
                        output += c
                End Select

                capitalizeNext = False ' Reset the flag after processing a letter.
            End If
        Next

        Return output ' No need to use ToTitleCase here.
    End Function



    Private Shared Function Cipher(input As String, oldAlphabet As String, newAlphabet As String, ByRef output As String) As Boolean
        output = String.Empty

        If oldAlphabet.Length <> newAlphabet.Length Then
            Return False
        End If

        For i As Integer = 0 To input.Length - 1
            Dim oldCharIndex As Integer = oldAlphabet.IndexOf(Char.ToLower(input(i)))

            If oldCharIndex >= 0 Then
                output += If(Char.IsUpper(input(i)), Char.ToUpper(newAlphabet(oldCharIndex)), newAlphabet(oldCharIndex))
            Else
                output += input(i)
            End If
        Next

        Return True
    End Function

    Public Shared Function Encipher(input As String, cipherAlphabet As String, ByRef output As String) As Boolean
        Dim plainAlphabet As String = "aàbdeèégiìmnoòprs"
        Return Cipher(input, plainAlphabet, cipherAlphabet, output)
    End Function

    Public Shared Function CustomEncipher(input As String, customPlain As String, cipherAlphabet As String, ByRef output As String) As Boolean

        Return Cipher(input, customPlain, cipherAlphabet, output)
    End Function




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EncryptedOutput.Clear()
        NormalInput.Clear()
        CustomCipherInput.Clear()
        CustomPlainInput.Clear()
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim text As String = NormalInput.Text 'gets the input from the text box aàbdeèégiìmnoòprs
        Dim cipherAlphabet As String = "oòpgiìídeènmaàbsr" 'sets the cipherAlphabet according to the plain alphabet combinations
        Dim cipherText As String = "" 'creates a variable that will contain the encrypted text
        Encipher(text, cipherAlphabet, cipherText) 'encrypts the text
        EncryptedOutput.Text = cipherText 'gives you the encrypted text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EncryptedOutput.Text = NormalInput.Text.Replace("a", "afa").Replace("e", "efe").Replace("i", "ifi").Replace("o", "ofo").Replace("u", "ufu").Replace("à", "afà").Replace("è", "efè").Replace("é", "efé").Replace("ì", "ifì").Replace("ò", "ofò").Replace("ù", "ufù").Replace("A", "AFA").Replace("E", "EFE").Replace("I", "IFI").Replace("O", "OFO").Replace("U", "UFU").Replace("À", "AFÀ").Replace("È", "EFÈ").Replace("É", "EFÉ").Replace("Ì", "IFÌ").Replace("Ò", "OFÒ").Replace("Ù", "UFÙ")
        If EncryptedOutput.TextLength > 1 Then
            EncryptedOutput.Text = EncryptedOutput.Text.Substring(0, 1).ToUpper() + EncryptedOutput.Text.Substring(1).ToLower()
        ElseIf EncryptedOutput.TextLength = 1 Then
            EncryptedOutput.Text = EncryptedOutput.Text.ToUpper()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim text As String = NormalInput.Text 'gets the input from the text box
        Dim CustomPlainAlphabet As String = CustomPlainInput.Text
        Dim cipherAlphabet As String = CustomCipherInput.Text 'sets the cipherAlphabet according to the plain alphabet combinations
        Dim cipherText As String = "" 'creates a variable that will contain the encrypted text
        Dim unused = CustomEncipher(text, CustomPlainAlphabet, cipherAlphabet, cipherText) 'encrypts the text
        EncryptedOutput.Text = cipherText 'gives you the encrypted text
    End Sub

    Private Sub ITALIAN_Click(sender As Object, e As EventArgs) Handles ITALIAN.Click
        Button1.Text = "Converti con cifrario standard"
        Button4.Text = "Converti con cifrario personalizzato"
        Button2.Text = "Converti in alfabeto farfallino"
        Button3.Text = "Svuota"
        Button5.Text = "Esci"
        GroupBox1.Text = "Testo normale da crittografare"
        Label1.Text = "Puoi scegliere se criptare/decriptare un messaggio usando il cifrario standard o creandone uno personalizzato. Nella prima casella di testo inserisci senza spazi le lettere o simboli che desideri siano sostituiti. Nella casella sottostante scrivi i corrispettivi simboli che cambieranno, senza spazi"
        CustomPlainInput.PlaceholderText = "Alfabeto custom di partenza"
        CustomCipherInput.PlaceholderText = "Conversione custom"
    End Sub

    Private Sub English_Click(sender As Object, e As EventArgs) Handles English.Click
        Button1.Text = "Convert with Default Substitution Cipher"
        Button4.Text = "Convert with Custom Substitution Cipher"
        Button2.Text = "Convert to Farfallino"
        Button3.Text = "Clear"
        Button5.Text = "Exit"
        GroupBox1.Text = "Normal text to be encrypted"
        Label1.Text = "Choose between the standard cipher method or a custom one. In the first textbox you'll have to list the letters that will be replaced. In the textbox below, you'll write the corresponding letter or symbol you want to use to replace the single letter."
        CustomPlainInput.PlaceholderText = "Custom plain letters"
        CustomCipherInput.PlaceholderText = "Custom key correspondance"
    End Sub
End Class
