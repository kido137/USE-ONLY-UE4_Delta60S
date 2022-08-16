using UnrealBuildTool;

public class Delta60SecondShotTarget : TargetRules
{
	public Delta60SecondShotTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Delta60SecondShot");
	}
}
