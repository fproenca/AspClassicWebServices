<%
    Function ErrorHandler()
        ' Error Handler
        If Err.Number <> 0 Then
           ' Error Occurred / Trap it
           On Error Goto 0 ' But don't let other errors hide!
           ErrorHandler = "A Error has occurred: " & Err.Message
        End If
        On Error Goto 0 ' Reset error handling.
    End Function
%>