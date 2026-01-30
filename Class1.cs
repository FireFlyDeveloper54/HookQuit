using HarmonyLib;
using MelonLoader;

namespace FIREFLYBEST
{
	public class Main : MelonMod { }

	public class Patcher 
	{
		[HarmonyPatch(typeof(UnityEngine.Application), "Quit", new System.Type[]
	{

	})]
		public class Quit_Hook
		{
			[HarmonyPrefix]
			internal static bool Prefix()
			{
				return false;
			}
		}
	}
}
