<!--#INCLUDE file="wsclient.asp" -->

<%
	Set xmlDoc = CreateObject("MSXML2.DOMDocument")
	xmlDoc.async = False
	xmlDoc.LoadXml GetClientsXml
	Set nodeList = xmlDoc.SelectNodes("//Client")
%>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>List Clients</title>
		<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
		<link rel="stylesheet" href="https://bootswatch.com/3/cosmo/bootstrap.min.css">
		<link rel="stylesheet" href="https://cdn.datatables.net/1.10.16/css/jquery.dataTables.min.css">
	</head>
	<body>
		
		<nav class="navbar navbar-inverse">
		  <div class="container">
			<div class="navbar-header">
			  <a class="navbar-brand" href="#">Asp Classic WS</a>
			</div>
			<ul class="nav navbar-nav">
			  <li><a href="default.asp">Home</a></li>
			</ul>
			<ul class="nav navbar-nav">
			  <li><a href="listclientsdb.asp">Clients DB</a></li>
			</ul>
			<ul class="nav navbar-nav">
			  <li><a href="listclientsws.asp">Clients WS</a></li>
			</ul>
		  </div>
		</nav>
		
		<div class="container">
			<section>
				<article>
					<header>
						<h1>List Clients WS</h1>
					</header>
					<div class="table-responsive">
					  <table id="clientsTable" class="table">
						<thead>
						  <tr>
								<th>#</th>
								<th>Name</th>
								<th>Data Base</th>
								<th>Web Server Name</th>
						  </tr>
						</thead>
						<tbody>
						<% 
                            For i = 0 To nodeList.length - 1
                                Response.Write "<tr>"
	                            For i2 = 0 To nodeList(i).childNodes.length - 1
                               
                                    Response.Write "<td>"
								    Response.Write nodeList(i).childNodes(i2).text
								    Response.Write "</td>"
	                            Next
                                Response.Write "</tr>"
                            Next
						%>
						</tbody>
					  </table>
					</div>
				</article>
			</section>
		</div>

		<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
		<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
		<script src="https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js"></script>
		<script>
			$('#clientsTable').DataTable();
		</script>
		
	</body>
</html>