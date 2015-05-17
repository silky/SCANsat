﻿#region license
/* 
 * [Scientific Committee on Advanced Navigation]
 * 			S.C.A.N. Satellite
 *
 * SCAN FixedColorPalettes - static class for generating fixed size color palettes; see each palette for licensing information
 * 
 * Copyright (c)2014 David Grandy <david.grandy@gmail.com>;
 * Copyright (c)2014 technogeeky <technogeeky@gmail.com>;
 * Copyright (c)2014 (Your Name Here) <your email here>; see LICENSE.txt for licensing details.
 */
#endregion

using System;
using UnityEngine;

namespace SCANsat.SCAN_Platform.Palettes.FixedColors
{
	public static class FixedColorPalettes
	{
		static Func<byte, byte, byte, Color32> RGB = (r, g, b) => new Color32(r, g, b, 255);

		/* Wikipedia color scheme licensed under Creative Commons Attribution-Share Alike 3.0 Unported license
		 * Black Forest Scheme - Schwarzwald-topographie - http://commons.wikimedia.org/wiki/File:Schwarzwald-topographie.png
		 * */
		public static Palette blackForest()
		{
			Color32[] c;
			c = new[] { RGB(176, 243, 190), RGB(224, 251, 178), RGB(184, 222, 118), RGB(39, 165, 42), RGB(52, 136, 60), RGB(156,164,41), RGB(248,176,4), RGB(192,74,2), RGB(135,8,0), RGB(116,24,5), RGB(108,42,10), RGB(125,74,43), RGB(156,129,112), RGB(181,181,181), RGB(218,216,218)};
			return new Palette(c, "blackForest", Palette.Kind.Fixed, (Palette.Is)3, (Palette.Is)3, (Palette.Is)3, (Palette.Is)3);
		}

		/* A freely available color scheme by Mark J. Fenbers
		 * http://soliton.vm.bytemark.co.uk/pub/cpt-city/mjf/copying.html
		 * */
		public static Palette departure()
		{
			Color32[] c;
			c = new[] { RGB(68, 34, 0), RGB(102, 51, 0), RGB(160, 108, 60), RGB(218, 166, 120), RGB(238, 212, 188), RGB(255, 255, 255), RGB(200, 255, 200), RGB(100, 255, 100), RGB(0, 255, 0), RGB(0, 192, 0), RGB(0, 128, 0) };
			return new Palette(c, "departure", Palette.Kind.Fixed, (Palette.Is)3, (Palette.Is)3, (Palette.Is)3, (Palette.Is)3);
		}

		/* Wikipedia color scheme licensed under Creative Commons Attribution-Share Alike 3.0 Unported license
		 * http://commons.wikimedia.org/wiki/File:North_Rhine-Westphalia_Topography_01.svg
		 * */
		public static Palette northRhine()
		{
			Color32[] c;
			c = new[] { RGB(5, 6, 3), RGB(55, 55, 36), RGB(24, 62, 41), RGB(52, 105, 69), RGB(62, 138, 89), RGB(108, 163, 99), RGB(165, 186, 111), RGB(231, 213, 122), RGB(199, 167, 92), RGB(176, 120, 58) };
			return new Palette(c, "northRhine", Palette.Kind.Fixed, (Palette.Is)3, (Palette.Is)3, (Palette.Is)3, (Palette.Is)3);
		}

		/* Wikipedia color scheme licensed under Creative Commons Attribution-Share Alike 3.0 Unported license
		 * Mars color scheme by PZmaps - http://commons.wikimedia.org/wiki/User:PZmaps
		 * */
		public static Palette mars()
		{
			Color32[] c;
			c = new[] { RGB(120, 65, 20), RGB(141, 84, 43), RGB(164, 114, 66), RGB(188, 144, 89), RGB(211, 174, 112), RGB(235, 205, 136), RGB(219, 185, 120), RGB(204, 165, 105), RGB(189, 145, 90), RGB(174, 125, 75), RGB(159, 110, 70), RGB(160, 120, 80), RGB(174, 134, 100), RGB(189, 163, 140), RGB(204, 191, 180), RGB(220, 212, 205), RGB(240, 232, 225), RGB(255, 255, 255) };
			return new Palette(c, "mars", Palette.Kind.Fixed, (Palette.Is)3, (Palette.Is)3, (Palette.Is)3, (Palette.Is)3);
		}

		//A public domain Wikipedia color scheme - http://soliton.vm.bytemark.co.uk/pub/cpt-city/wkp/template/index.html
		public static Palette wiki2()
		{
			Color32[] c;
			c = new[] { RGB(113, 171, 216), RGB(216, 242, 254), RGB(148, 191, 139), RGB(239, 235, 192), RGB(170, 135, 83), RGB(245, 244, 242) };
			return new Palette(c, "wiki2", Palette.Kind.Fixed, (Palette.Is)3, (Palette.Is)3, (Palette.Is)3, (Palette.Is)3);
		}

		/* Wikipedia color scheme licensed under Creative Commons Attribution-Share Alike 3.0 Unported license
		 * Plumbago Scheme- http://en.wikipedia.org/wiki/File:AYool_topography_15min.png
		 * */
		public static Palette plumbago()
		{
			Color32[] c;
			c = new[] { RGB(151, 0, 176), RGB(23, 0, 151), RGB(203, 254, 254), RGB(0, 168, 0), RGB(254, 254, 126), RGB(87, 36, 36), RGB(203, 101, 203), RGB(228, 190, 228) };
			return new Palette(c, "plumbago", Palette.Kind.Fixed, (Palette.Is)3, (Palette.Is)3, (Palette.Is)3, (Palette.Is)3);
		}

		/* A freely available color scheme by Meghan Miller
		 * http://soliton.vm.bytemark.co.uk/pub/cpt-city/cw/index.html
		 * */
		public static Palette cw1_013()
		{
			Color32[] c;
			c = new[] { RGB(97, 65, 78), RGB(226, 87, 68), RGB(252, 255, 67), RGB(86, 118, 157), RGB(167, 214, 255) };
			return new Palette(c, "cw1_013", Palette.Kind.Fixed, (Palette.Is)3, (Palette.Is)3, (Palette.Is)3, (Palette.Is)3);
		}

		/* A freely available color scheme from Arendal
		 * http://soliton.vm.bytemark.co.uk/pub/cpt-city/arendal/copying.html
		 * */
		public static Palette arctic()
		{
			Color32[] c;
			c = new[] { RGB(44, 53, 99), RGB(197, 197, 206), RGB(150, 210, 131), RGB(174, 223, 135), RGB(195, 230, 138), RGB(218, 237, 142), RGB(226, 233, 137), RGB(232, 217, 119), RGB(238, 200, 102), RGB(231, 183, 89), RGB(196, 167, 89), RGB(174, 158, 89) };
			return new Palette(c, "arctic", Palette.Kind.Fixed, (Palette.Is)3, (Palette.Is)3, (Palette.Is)3, (Palette.Is)3);
		}

	}
}
