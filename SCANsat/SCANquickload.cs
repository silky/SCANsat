#region license
/*  * [Scientific Committee on Advanced Navigation]
 * 			S.C.A.N. Satellite
 * 
 * SCANquickload -
 * 		loads a specified savegame and vessel
 * 		useful for performance testing, debugging, screenshot, or example making
 *
 *
 * Copyright (c)2013 unknown KSP forum member;
 * Copyright (c)2014 technogeeky <technogeeky@gmail.com>;
 * Copyright (c)2014 (Your Name Here) <your email here>; see LICENSE.txt for licensing details.
*/
#endregion
#if DEBUG
using KSP;
using UnityEngine;
using SCANsat;
using System.Collections.Generic;


[KSPAddon(KSPAddon.Startup.MainMenu, false)]

public class Debug_AutoLoadPersistentSaveOnStartup : MonoBehaviour {

	public static bool first = true;
	public static int  vId = 0;

	public void Start () {
            
		if (first) {
			first = false;
			HighLogic.SaveFolder = "SCANsat Testing";
			var game = GamePersistence.LoadGame ("persistent" , HighLogic.SaveFolder , true , false);
			if (game != null && game.flightState != null && game.compatible) {
                     
				List<ProtoVessel> allVessels = game.flightState.protoVessels;
				int suitableVessel = 0;

				for (vId = 0; vId < allVessels.Count; vId++) {
					switch (allVessels [vId].vesselType) {
						case VesselType.SpaceObject: 	continue;  // asteroids
						case VesselType.Unknown: 	continue;  // asteroids in facepaint
						case VesselType.EVA: continue;  //Don't spawn rescue Kerbals
						default:					suitableVessel = vId;
												break; // this one will do
                         }
					/* If you want a more stringent filter than
                      *   "vessel is not inert ball of space dirt", then you
                      *   will want to do it here.
                      */
                    }

				FlightDriver.StartAndFocusVessel(game, suitableVessel);
				CheatOptions.InfiniteFuel = true;
               }
          }
     }
}

#endif