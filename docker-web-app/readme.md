##docker pull mcr.microsoft.com/mssql/server:2022-latest

##docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=badfather2024@@" -p 1433:1433 --name mysqlserver -h mysqlserver -d mcr.microsoft.com/mssql/server:2022-latest

##az aks create --resource-group RG-Global-SantanuPanchadhyay-Appteam --name mydemoAKSCluster --node-count 2 --generate-ssh-keys

##az aks get-credentials --resource-group RG-Global-SantanuPanchadhyay-Appteam --name mydemoAKSCluster

##kubectl create secret docker-registry acr-secret --docker-server=aksdemoreg.azurecr.io --docker-username=my-token --docker-password=e0o80c50P7j/ksj8bfG7yjRoj05QWHSmQK0sh5U+Zw+ACRBVqQAK --docker-email=unused --namespace=my-aks-namespace

##kubectl apply -f deployment-manifest-pvc.yaml -n my-aks-namespace

##kubectl exec -it docker-web-app-7556bb9f6f-tqxkb -- nslookup localhost

##kubectl exec -it docker-web-app-7556bb9f6f-tqxkb -- /opt/mssql-tools/bin/sqlcmd -S sqlcontainerdb -U SA -P badfather2024@@