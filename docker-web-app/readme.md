##docker pull mcr.microsoft.com/mssql/server:2022-latest

##docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=badfather2024@@" -p 1433:1433 --name mysqlserver -h mysqlserver -d mcr.microsoft.com/mssql/server:2022-latest