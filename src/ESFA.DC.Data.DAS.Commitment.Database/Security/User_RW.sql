
CREATE USER [DASCommitmentRWUser]
    WITH PASSWORD = N'$(RWUserPassword)';
GO
  GRANT CONNECT TO [DASCommitmentRWUser]
GO
