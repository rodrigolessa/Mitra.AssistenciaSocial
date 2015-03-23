USE Mitra
GO

--  Drop Foreign Key Constraints 
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_EntidadeSocial_AssistenciaPorMes') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AssistenciaSocial.AssistenciaPorMes DROP CONSTRAINT FK_EntidadeSocial_AssistenciaPorMes
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_TipoDeAssistencia_AssistenciaPorMes') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AssistenciaSocial.AssistenciaPorMes DROP CONSTRAINT FK_TipoDeAssistencia_AssistenciaPorMes
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Beneficiario_AssistenciaPorMes') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AssistenciaSocial.AssistenciaPorMes DROP CONSTRAINT FK_Beneficiario_AssistenciaPorMes
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Beneficiario_Dependente') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AssistenciaSocial.Dependente DROP CONSTRAINT FK_Beneficiario_Dependente
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Beneficiario_Filiacao') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AssistenciaSocial.Filiacao DROP CONSTRAINT FK_Beneficiario_Filiacao
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_EntidadeSocial_TipoDeAssistencia') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AssistenciaSocial.TipoDeAssistencia DROP CONSTRAINT FK_EntidadeSocial_TipoDeAssistencia
GO

--  Drop Tables, Stored Procedures and Views 

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AssistenciaSocial.Beneficiario') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AssistenciaSocial.Beneficiario
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AssistenciaSocial.Dependente') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AssistenciaSocial.Dependente
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AssistenciaSocial.EntidadeSocial') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AssistenciaSocial.EntidadeSocial
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AssistenciaSocial.Filiacao') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AssistenciaSocial.Filiacao
;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AssistenciaSocial.TipoDeAssistencia') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AssistenciaSocial.TipoDeAssistencia
;


--  Create Tables 
CREATE TABLE AssistenciaSocial.Beneficiario ( 
	Id int identity(1,1)  NOT NULL,
	Nome varchar(100),
	CPF varchar(15),
	RG varchar(20),
	DataDeNascimento date,
	Sexo char(1),
	EstadoCivil char(1),
	Naturalidade varchar(50),
	Cor char(1),
	GrauDeInstrucao char(1),
	Endereco varchar(255),
	Bairro varchar(50),
	Cidade varchar(100),
	Estado char(2),
	Telefone varchar(15),
	PontoDeFerencia varchar(max),
	NomeDoResponsavel varchar(100),
	TelefoneDoResponsavel varchar(15),
	RendaFamiliar char(1),
	BeneficioDeEntidade bit,
	TipoDeBeneficioDaEntidade varchar(max),
	NomeDaEntidade varchar(255),
	TipoDeResidencia char(1),
	EspecificarTipoDeResidencia varchar(max),
	TipoDeConstrucao char(1),
	PisoDaConstrucao char(1),
	CoberturaDaConstrucao char(1),
	NumeroDeComodosDaConstrucao smallint,
	ComodosDaConstrucao varchar(max),
	EsgotoDaConstrucao char(1),
	AguaDaConstrucao char(1),
	BanheiroDaConstrucao char(1),
	EnergiaEletricaDaConstrucao char(1),
	LixoDaConstrucao char(1),
	PossuiOutrosImoveis bit,
	TipoDeConstrucaoOutrosImoveis char(1),
	PossuiVeiculo bit,
	UtilizacaoDoVeiculo char(1),
	AnoDoVeiculo int,
	ModeloDoVeiculo varchar(50),
	PossuiConvenioMedico bit,
	NomeDoConvenioMedico varchar(50),
	TratamentoMedico varchar(max),
	QualTipoDeDoenca varchar(100),
	MedicamentoDeUsoContinuo varchar(255),
	ComoAdquireMedicamentos char(1),
	EspecificarComoAdquireMedicamentos varchar(max),
	InformacoesAdicionais varchar(max),
	DataDeCadastro datetime DEFAULT (GetDate())
)
;

CREATE TABLE AssistenciaSocial.Dependente ( 
	Id int identity(1,1)  NOT NULL,
	id_beneficiario int,
	Nome varchar(100),
	DataDeNascimento date,
	Parentesco char(1),
	EstadoCivil char(1),
	GrauDeInstrucao char(1),
	Profissao varchar(100)
)
;

CREATE TABLE AssistenciaSocial.Filiacao ( 
	Parentesco char(1) NOT NULL,
	id_beneficiario int NOT NULL,
	Nome varchar(100),
	EstadoCivil char(1),
	DataDeNascimento date,
	GrauDeInstrucao char(1),
	LocalDeTrabalho varchar(100),
	EnderecoDeTrabalho varchar(255),
	Telefone varchar(15),
	Profissao varchar(100),
	FaixaSalarial varchar(50),
	HorarioDeTrabalho char(1)
)
;

CREATE TABLE AssistenciaSocial.EntidadeSocial ( 
	Id int identity(1,1)  NOT NULL,
	Nome varchar(255),
	Endereco varchar(255),
	Telefone varchar(15),
	CNPJ varchar(50),
	EntidadePrincipal varchar(255),
	Coordenador varchar(100),
	TelefoneCoordenador varchar(15),
	QuantidadeDeMembros int
)
;

CREATE TABLE AssistenciaSocial.TipoDeAssistencia ( 
	Id int identity(1,1)  NOT NULL,
	id_entidade_social int NOT NULL,
	Descricao varchar(255),
	Unidade varchar(3)
)
GO

CREATE TABLE AssistenciaSocial.AssistenciaPorMes ( 
	id_beneficiario int NOT NULL,
	id_entidade_social int NOT NULL,
	id_tipo_assistencia int NOT NULL,
	Data date NOT NULL,
	Descricao varchar(200),
	Quantidade numeric(10,2)
)
GO

--  Create Primary Key Constraints 
ALTER TABLE AssistenciaSocial.Beneficiario ADD CONSTRAINT PK_Beneficiario 
	PRIMARY KEY CLUSTERED (Id)
;

ALTER TABLE AssistenciaSocial.Dependente ADD CONSTRAINT PK_Dependente 
	PRIMARY KEY CLUSTERED (Id)
;

ALTER TABLE AssistenciaSocial.EntidadeSocial ADD CONSTRAINT PK_EntidadeSocial 
	PRIMARY KEY CLUSTERED (Id)
;

ALTER TABLE AssistenciaSocial.Filiacao ADD CONSTRAINT PK_Filiacao 
	PRIMARY KEY CLUSTERED (Parentesco, id_beneficiario)
;

ALTER TABLE AssistenciaSocial.TipoDeAssistencia ADD CONSTRAINT PK_TipoDeAssistencia 
	PRIMARY KEY CLUSTERED (Id)
;

ALTER TABLE AssistenciaSocial.AssistenciaPorMes ADD CONSTRAINT PK_AssistenciaPorMes 
	PRIMARY KEY CLUSTERED (id_beneficiario, id_entidade_social, id_tipo_assistencia, Data)
;

USE Mitra
GO

ALTER TABLE AssistenciaSocial.AssistenciaPorMes ADD CONSTRAINT [FK_EntidadeSocial_AssistenciaPorMes] 
FOREIGN KEY([id_entidade_social]) REFERENCES [AssistenciaSocial].[EntidadeSocial] ([Id])
;

ALTER TABLE AssistenciaSocial.AssistenciaPorMes ADD CONSTRAINT [FK_TipoDeAssistencia_AssistenciaPorMes] 
FOREIGN KEY([id_tipo_assistencia]) REFERENCES [AssistenciaSocial].[TipoDeAssistencia] ([Id])
;

ALTER TABLE AssistenciaSocial.AssistenciaPorMes ADD CONSTRAINT [FK_Beneficiario_AssistenciaPorMes] 
FOREIGN KEY([id_beneficiario]) REFERENCES [AssistenciaSocial].[Beneficiario] ([Id])
;

ALTER TABLE AssistenciaSocial.Dependente ADD CONSTRAINT [FK_Beneficiario_Dependente] 
FOREIGN KEY([id_beneficiario]) REFERENCES [AssistenciaSocial].[Beneficiario] ([Id])
;

ALTER TABLE AssistenciaSocial.Filiacao ADD CONSTRAINT [FK_Beneficiario_Filiacao] 
FOREIGN KEY([id_beneficiario]) REFERENCES [AssistenciaSocial].[Beneficiario] ([Id])
;

ALTER TABLE AssistenciaSocial.TipoDeAssistencia ADD CONSTRAINT [FK_EntidadeSocial_TipoDeAssistencia] 
FOREIGN KEY([id_entidade_social]) REFERENCES [AssistenciaSocial].[EntidadeSocial] ([Id])
;

