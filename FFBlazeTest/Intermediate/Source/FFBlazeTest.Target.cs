using UnrealBuildTool;

public class FFBlazeTestTarget : TargetRules
{
	public FFBlazeTestTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("FFBlazeTest");
	}
}
