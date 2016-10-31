namespace TimeSavers.VS
{
    public static class PackageConstants
    {
        public const string Actions = "Actions";
        public const string Advanced = "Advanced";
        public const string Build = "Build";
        public const string Debug = "Debug";
        public const string Developer = "Developer";
        public const string General = "General";
        public const string Output = "Output";
        public const string Package = "Package";
        public const string VisualStudio = "Visual Studio";
        public const string VS = "VS";
        public const string Separators = "Separators";
        public const string InsertGuid = "Insert Guid";

        public const string Space = " ";
        public const string H1 = "1." + Space;
        public const string H2 = "2." + Space;

        public const string Enabled = "Enabled";
        public const string EnablesDisables = "Enables/disables";
        public const string EnablesDisablesAll = EnablesDisables + Space + "ALL";

        public const string Command = "Command";
        public const string Commands = "Commands";
        //public const string CommandsEnabled = Commands + Space + Enabled;

        public const string Feature = "Feature";
        public const string Features = "Features";
        //public const string FeaturesEnabled = Features + Space + Enabled;

        public const string TimeSavers = "Time Savers";
        public const string TimeSaversFeatures = TimeSavers + Space + Features;

        public const string BuildFeatures = Build + Space + Features;
        public const string BuildCommands = Build + Space + Commands;
        public const string RebuildSolution = "Rebuild Solution";
        public const string RebuildProject = "Rebuild Project";
        public const string CancelBuild = "Cancel Build";

        public const string DeveloperFeatures = Developer + Space + Features;
        public const string DeveloperCommands = Developer + Space + Commands;
        public const string ActivityLog = "Activity Log";
        public const string DiagnosticsLog = "Diagnostics Log";
        public const string PathVariables = "Path Variables";

        public const string VisualStudioFeatures = VisualStudio + Space + Features;
        public const string VisualStudioCommands = VisualStudio + Space + Commands;
        public const string ReopenStartPage = "Reopen Start Page";

        public const string SeparatorsFeature = Separators + Space + Feature;

        public const bool SupportsAutomation = true;
    }
}