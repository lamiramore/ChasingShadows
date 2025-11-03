using UnrealBuildTool;

public class Burden_ProjectTarget : TargetRules
{
	public Burden_ProjectTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Burden_Project");
	}
}
