Esse projeto console foi criado com o objetivo de testar a comunicação com o nosso servidor python implementado utilizando o Pyro5 com um projeto em .net utilizando também a biblioteca Pyro. 

Como esse projeto foi criado: 

Lembrando que PyroCliente é o nome que definimos para o nosso projeto. 

`dotnet new console -n PyroCliente`

codigo adicionado apenas em Program.cs. Esse codigo está muito similar ao nosso desenvolvimento em python, com a unica diferença que não solicita as informações ao usuário, está preenchendo automaticamente para agilizar os nossos testes. 

------------------------------

⚠️ **Importante:** Adicione via nuget a biblioteca Pyrolite
`dotnet add package Razorvine.Pyrolite`.

-----------------------------
Para executar: 
`dotnet run`. 

---------------------------

Considerações
Nossa cliente so vai funcionar com o servidor também executado. Lembrando o que vimos em aula: 

Executar o servidor de nomes (obrigatoriamente antes de subir o servidor)
python -m Pyro5.nameserver

Executar o servidor
python PyroServidorPython.py.

-------------------------------

Obs.: Na função listar diretorio crie uma pasta chamada "teste" no mesmo diretorio onde está o codigo fonte do servidor, e adicione alguns arquivos para testar. 

------------------------------

Daqui pra frente divirta-se! 







