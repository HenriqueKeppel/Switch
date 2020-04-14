use switchdb;

CREATE TABLE Usuarios
(Id int NOT NULL AUTO_INCREMENT,
Nome longtext null,
SobreNome longtext null,
Email longtext null,
Senha longtext null,
DataNascimento datetime(6) not null,
Sexo int not null,
UrlFoto longtext null,
Constraint pk_usuarios primary key (Id));