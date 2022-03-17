using BepInEx;
using UnityEngine;
using EFT.Interactive;
using System.Linq;

namespace ValensHasThePower
{
    [BepInPlugin("com.Valens.HasThePower", "ValensHasThePower", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            Logger.LogInfo($"Valens...now has the POWER!!!");
            new PatchThePower().Enable();
        }
    }

    public class PowerOn
    {
        public static void Start()
        {
            var power = GameObject.FindObjectsOfType<Switch>().ToList();

            foreach (var Switch in power) // Turn the Power Station switch to On.
            {
                //Interchange - Power to Mall
                if (Switch.Id == "Shopping_Mall_DesignStuff_00055"&&Switch.name == "reserve_electric_switcher_lever")
                {
                    Switch.DoorState = EDoorState.Open;
                    Debug.LogError(Switch.name);
                }
                //Activation of Toilet Key Card Reader in Burger Stop
                if (Switch.name == "Node_Keycard_Saferoom")
                {
                    Switch.DoorState = EDoorState.Open;
                }
                //Activation of OBJ21 Container
                if (Switch.Id == "Shopping_Mall_DesignStuff_00061"&&Switch.Id == "reserve_electric_switcher_lever")
                {
                    Switch.DoorState = EDoorState.Open;
                }

                //Customs - Power to ZB-013 Extract.
                if (Switch.Id == "custom_DesignStuff_00034"&&Switch.name == "reserve_electric_switcher_lever")
                {
                    Switch.DoorState = EDoorState.Open;
                }

                if (Switch.ExfiltrationPoint == "EXFIL_ZONE_ZB013")
                {
                    Switch.ExfiltrationPoint.Status = ??
                }    

                //Reserve
            }
        }
    }
}