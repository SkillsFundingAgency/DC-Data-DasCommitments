
CREATE USER [DASCommitmentROUser]
    WITH PASSWORD = N'$(ROUserPassword)';
GO
  GRANT CONNECT TO [DASCommitmentROUser]
GO
