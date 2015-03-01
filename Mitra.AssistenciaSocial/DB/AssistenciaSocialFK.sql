USE Mitra
GO

ALTER TABLE AssistenciaSocial.Beneficiario ADD CONSTRAINT [FK_EntidadeSocial_Beneficiario] 
FOREIGN KEY([id_entidade_social]) REFERENCES [AssistenciaSocial].[EntidadeSocial] ([Id])


ALTER TABLE AssistenciaSocial.Beneficiario ADD CONSTRAINT [FK_TipoDeAssistencia_Beneficiario] 
FOREIGN KEY([id_tipo_assistencia]) REFERENCES [AssistenciaSocial].[TipoDeAssistencia] ([Id])


ALTER TABLE AssistenciaSocial.Dependente ADD CONSTRAINT [FK_Beneficiario_Dependente] 
FOREIGN KEY([id_beneficiario]) REFERENCES [AssistenciaSocial].[Beneficiario] ([Id])


ALTER TABLE AssistenciaSocial.Filiacao ADD CONSTRAINT [FK_Beneficiario_Filiacao] 
FOREIGN KEY([id_beneficiario]) REFERENCES [AssistenciaSocial].[Beneficiario] ([Id])