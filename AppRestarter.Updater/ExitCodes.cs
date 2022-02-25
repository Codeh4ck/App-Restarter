namespace AppRestarter.Updater
{
    public enum ExitCodes
    {
        CouldNotValidateUpdateFiles = 1000,
        CouldNotKillAppRestarter = 1001,
        CouldNotBackupAppRestarterFiles = 1002,
        CouldNotInstallNewAppRestarterFiles = 1003,
        CouldNotCleanupUpdateFiles = 1004,
        CouldNotRollbackUpdate = 1005
    }
}
