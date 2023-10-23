using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/ntt/skyway/core/channel",
						"com/ntt/skyway/core/channel/member",
					},
					new Converter<string, Type?>[]{
						lookup_com_ntt_skyway_core_channel_package,
						lookup_com_ntt_skyway_core_channel_member_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

#if NET5_0_OR_GREATER
		[System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage ("Trimming", "IL2057")]
#endif
		static Type? Lookup (string[] mappings, string javaType)
		{
			var managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[]? package_com_ntt_skyway_core_channel_mappings;
		static Type? lookup_com_ntt_skyway_core_channel_package (string klass)
		{
			if (package_com_ntt_skyway_core_channel_mappings == null) {
				package_com_ntt_skyway_core_channel_mappings = new string[]{
					"com/ntt/skyway/core/channel/Channel$Companion:Com.Ntt.Skyway.Core.Channel.IChannel/Companion",
					"com/ntt/skyway/core/channel/Channel$State:Com.Ntt.Skyway.Core.Channel.IChannel/State",
					"com/ntt/skyway/core/channel/Channel$State$Companion:Com.Ntt.Skyway.Core.Channel.IChannel/State/Companion",
					"com/ntt/skyway/core/channel/Publication$Options:Com.Ntt.Skyway.Core.Channel.IPublication/Options",
					"com/ntt/skyway/core/channel/Publication$State:Com.Ntt.Skyway.Core.Channel.IPublication/State",
					"com/ntt/skyway/core/channel/Publication$State$Companion:Com.Ntt.Skyway.Core.Channel.IPublication/State/Companion",
					"com/ntt/skyway/core/channel/Subscription$Options:Com.Ntt.Skyway.Core.Channel.ISubscription/Options",
					"com/ntt/skyway/core/channel/Subscription$State:Com.Ntt.Skyway.Core.Channel.ISubscription/State",
					"com/ntt/skyway/core/channel/Subscription$State$Companion:Com.Ntt.Skyway.Core.Channel.ISubscription/State/Companion",
				};
			}

			return Lookup (package_com_ntt_skyway_core_channel_mappings, klass);
		}

		static string[]? package_com_ntt_skyway_core_channel_member_mappings;
		static Type? lookup_com_ntt_skyway_core_channel_member_package (string klass)
		{
			if (package_com_ntt_skyway_core_channel_member_mappings == null) {
				package_com_ntt_skyway_core_channel_member_mappings = new string[]{
					"com/ntt/skyway/core/channel/member/Member$Dto:Com.Ntt.Skyway.Core.Channel.Member.IMember/Dto",
					"com/ntt/skyway/core/channel/member/Member$Init:Com.Ntt.Skyway.Core.Channel.Member.IMember/Init",
					"com/ntt/skyway/core/channel/member/Member$Side:Com.Ntt.Skyway.Core.Channel.Member.IMember/Side",
					"com/ntt/skyway/core/channel/member/Member$State:Com.Ntt.Skyway.Core.Channel.Member.IMember/State",
					"com/ntt/skyway/core/channel/member/Member$State$Companion:Com.Ntt.Skyway.Core.Channel.Member.IMember/State/Companion",
					"com/ntt/skyway/core/channel/member/Member$Type:Com.Ntt.Skyway.Core.Channel.Member.IMember/Type",
				};
			}

			return Lookup (package_com_ntt_skyway_core_channel_member_mappings, klass);
		}
	}
}
