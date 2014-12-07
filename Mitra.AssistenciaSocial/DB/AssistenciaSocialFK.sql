
ALTER TABLE AssistenciaSocial.Beneficiario ADD CONSTRAINT [FK_id_entidade_social] 
FOREIGN KEY([id_entidade_social]) REFERENCES [AssistenciaSocial].[EntidadeSocial] ([Id])


ALTER TABLE AssistenciaSocial.Beneficiario ADD CONSTRAINT [FK_id_tipo_assistencia] 
FOREIGN KEY([id_tipo_assistencia]) REFERENCES [AssistenciaSocial].[TipoDeAssistencia] ([Id])


ALTER TABLE AssistenciaSocial.Dependente ADD CONSTRAINT [FK_id_beneficiario] 
FOREIGN KEY([id_beneficiario]) REFERENCES [AssistenciaSocial].[Beneficiario] ([Id])


ALTER TABLE AssistenciaSocial.Filiacao ADD CONSTRAINT [FK_id_beneficiario] 
FOREIGN KEY([id_beneficiario]) REFERENCES [AssistenciaSocial].[Beneficiario] ([Id])