<!--#INCLUDE file="Data/connection.asp" -->
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
						<h1>List Clients DB</h1>
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
							'rs.Open "SELECT " & _
							'			"Client.Id AS Id, " & _
							'			"Client.[Name], " & _ 
							'			"[DataBase].[Name] AS DataBaseName, " & _ 
							'			"WebServer.[Name] AS WebServerName " & _ 
							'		"FROM " & _
							'			"Client " & _ 
							'		"INNER JOIN [DataBase] ON [DataBase].Id = Client.IdDataBase " & _ 
							'		"INNER JOIN WebServer ON WebServer.Id = Client.IdWebServer", conn
							'While Not rs.EOF
							'	Response.Write "<tr>"
							'	Response.Write "<td>"
							'	Response.Write rs.Fields("Id")
							'	Response.Write "</td>"
							'	Response.Write "<td>"
							'	Response.Write rs.Fields("Name")
							'	Response.Write "</td>"
							'	Response.Write "<td>"
							'	Response.Write rs.Fields("DataBaseName")
							'	Response.Write "</td>"
							'	Response.Write "<td>"
							'	Response.Write rs.Fields("WebServerName")
							'	Response.Write "</td>"
							'	
							'	Response.Write "</tr>"
							'	rs.MoveNext()
							'Wend
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
<!--#INCLUDE file="Data/rsclose.asp" -->
<!--#INCLUDE file="Data/connectionclose.asp" -->