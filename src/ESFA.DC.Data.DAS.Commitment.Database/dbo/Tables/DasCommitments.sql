﻿CREATE TABLE [dbo].[DasCommitments] (
    [CommitmentId]                     BIGINT          NOT NULL,
    [VersionId]                        VARCHAR (25)    NOT NULL,
    [Uln]                              BIGINT          NOT NULL,
    [Ukprn]                            BIGINT          NOT NULL,
    [AccountId]                        BIGINT          NOT NULL,
    [StartDate]                        DATE            NOT NULL,
    [EndDate]                          DATE            NOT NULL,
    [AgreedCost]                       DECIMAL (15, 2) NOT NULL,
    [StandardCode]                     BIGINT          NULL,
    [ProgrammeType]                    INT             NULL,
    [FrameworkCode]                    INT             NULL,
    [PathwayCode]                      INT             NULL,
    [PaymentStatus]                    INT             NOT NULL,
    [PaymentStatusDescription]         VARCHAR (50)    NOT NULL,
    [Priority]                         INT             NOT NULL,
    [EffectiveFromDate]                DATE            NOT NULL,
    [EffectiveToDate]                  DATE            NULL,
    [LegalEntityName]                  NVARCHAR (100)  NULL,
    [TransferSendingEmployerAccountId] BIGINT          NULL,
    [TransferApprovalDate]             DATETIME        NULL,
    [PausedOnDate]                     DATETIME2 (7)   NULL,
    [WithdrawnOnDate]                  DATETIME2 (7)   NULL,
    [AccountLegalEntityPublicHashedId] CHAR (6)        NULL,
    CONSTRAINT [PK_Commitments_CommitmentId_VersionId] PRIMARY KEY CLUSTERED ([CommitmentId] ASC, [VersionId] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_DasCommitments_Uln]
    ON [dbo].[DasCommitments]([Uln] ASC);

