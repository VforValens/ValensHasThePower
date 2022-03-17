using System.Reflection;
using Aki.Reflection.Patching;
using Aki.Reflection.Utils;
using EFT;

namespace ValensHasThePower
{
    public class PatchThePower : ModulePatch
    {
        protected override MethodBase GetTargetMethod()
        {
            var result = typeof(MainApplication).GetMethod("method_41", PatchConstants.PrivateFlags);

            return result;
        }

        [PatchPostfix]
        private static void PatchPostFix()
        {
            PowerOn.Start();

        }
    }
}