<%
    
    Function GetClientsXml()
        Set oXmlHTTP = CreateObject("Microsoft.XMLHTTP")
        oXmlHTTP.Open "POST", "https://aspnetwebservices.azurewebsites.net/Services/ClientServices.asmx", False
        
        oXmlHTTP.setRequestHeader "Content-Type", "text/xml; charset=utf-8" 
        oXmlHTTP.setRequestHeader "SOAPAction", "https://aspnetwebservices.azurewebsites.net/Get"
        
        SOAPRequest = _		
                "<?xml version=""1.0"" encoding=""utf-8""?>" &_
                "<soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">" &_
                    "<soap:Body>" &_
                    "<Get xmlns=""https://aspnetwebservices.azurewebsites.net"" />" &_
                    "</soap:Body>" &_
                "</soap:Envelope>"
                    
        oXmlHTTP.send SOAPRequest    
        'Response.Write oXmlHTTP.responseXml.Xml
        'Response.End
        GetClientsXml = oXmlHTTP.responseXml.Xml
    End Function      
      
%>