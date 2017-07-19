
Namespace ProgressBarSample

    Public Enum ProgressBarDisplayText
        Percentage
        CustomText
    End Enum

    Class CustomProgress
        Inherits ProgressBar
        'Property to set to decide whether to print a % or Text
        Public Property DisplayStyle() As ProgressBarDisplayText

        'Property to hold the custom text
        Public Property CustomText() As [String]

        Public Sub New()
            ' Modify the ControlStyles flags
            'http://msdn.microsoft.com/en-us/library/system.windows.forms.controlstyles.aspx
            SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint, True)
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            Dim rect As Rectangle = ClientRectangle
            Dim g As Graphics = e.Graphics

            ProgressBarRenderer.DrawHorizontalBar(g, rect)
            rect.Inflate(-3, -3)
            If Value > 0 Then
                ' As we doing this ourselves we need to draw the chunks on the progress bar
                Dim clip As New Rectangle(rect.X, rect.Y, CType(Math.Round((CType(Value, Single) / Maximum) * rect.Width), Integer), rect.Height)
                ProgressBarRenderer.DrawHorizontalChunks(g, clip)
            End If

            ' Set the Display text (Either a % amount or our custom text
            Dim text As String = If(DisplayStyle = ProgressBarDisplayText.Percentage, Value.ToString() + "%"c, CustomText)


            Using f As New Font(FontFamily.GenericSerif, 10)

                Dim len As SizeF = g.MeasureString(text, f)
                ' Calculate the location of the text (the middle of progress bar)
                ' Point location = new Point(Convert.ToInt32((rect.Width / 2) - (len.Width / 2)), Convert.ToInt32((rect.Height / 2) - (len.Height / 2)));
                Dim location As New Point(Convert.ToInt32((Width / 2) - len.Width / 2), Convert.ToInt32((Height / 2) - len.Height / 2))
                ' The commented-out code will centre the text into the highlighted area only. This will centre the text regardless of the highlighted area.
                ' Draw the custom text
                g.DrawString(text, f, Brushes.White, location)
            End Using
        End Sub
    End Class
End Namespace