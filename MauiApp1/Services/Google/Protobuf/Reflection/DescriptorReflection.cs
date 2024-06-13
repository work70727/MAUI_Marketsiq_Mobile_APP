﻿namespace MarketsIQ.Services.Google.Protobuf.Reflection
{
    internal static class DescriptorReflection
    {
        private static FileDescriptor descriptor;

        public static FileDescriptor Descriptor => descriptor;

        static DescriptorReflection()
        {
            descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBnb29nbGUvcHJvdG9idWYvZGVzY3JpcHRvci5wcm90bxIPZ29vZ2xlLnBy" + "b3RvYnVmIkcKEUZpbGVEZXNjcmlwdG9yU2V0EjIKBGZpbGUYASADKAsyJC5n" + "b29nbGUucHJvdG9idWYuRmlsZURlc2NyaXB0b3JQcm90byLbAwoTRmlsZURl" + "c2NyaXB0b3JQcm90bxIMCgRuYW1lGAEgASgJEg8KB3BhY2thZ2UYAiABKAkS" + "EgoKZGVwZW5kZW5jeRgDIAMoCRIZChFwdWJsaWNfZGVwZW5kZW5jeRgKIAMo" + "BRIXCg93ZWFrX2RlcGVuZGVuY3kYCyADKAUSNgoMbWVzc2FnZV90eXBlGAQg" + "AygLMiAuZ29vZ2xlLnByb3RvYnVmLkRlc2NyaXB0b3JQcm90bxI3CgllbnVt" + "X3R5cGUYBSADKAsyJC5nb29nbGUucHJvdG9idWYuRW51bURlc2NyaXB0b3JQ" + "cm90bxI4CgdzZXJ2aWNlGAYgAygLMicuZ29vZ2xlLnByb3RvYnVmLlNlcnZp" + "Y2VEZXNjcmlwdG9yUHJvdG8SOAoJZXh0ZW5zaW9uGAcgAygLMiUuZ29vZ2xl" + "LnByb3RvYnVmLkZpZWxkRGVzY3JpcHRvclByb3RvEi0KB29wdGlvbnMYCCAB" + "KAsyHC5nb29nbGUucHJvdG9idWYuRmlsZU9wdGlvbnMSOQoQc291cmNlX2Nv" + "ZGVfaW5mbxgJIAEoCzIfLmdvb2dsZS5wcm90b2J1Zi5Tb3VyY2VDb2RlSW5m" + "bxIOCgZzeW50YXgYDCABKAkiqQUKD0Rlc2NyaXB0b3JQcm90bxIMCgRuYW1l" + "GAEgASgJEjQKBWZpZWxkGAIgAygLMiUuZ29vZ2xlLnByb3RvYnVmLkZpZWxk" + "RGVzY3JpcHRvclByb3RvEjgKCWV4dGVuc2lvbhgGIAMoCzIlLmdvb2dsZS5w" + "cm90b2J1Zi5GaWVsZERlc2NyaXB0b3JQcm90bxI1CgtuZXN0ZWRfdHlwZRgD" + "IAMoCzIgLmdvb2dsZS5wcm90b2J1Zi5EZXNjcmlwdG9yUHJvdG8SNwoJZW51" + "bV90eXBlGAQgAygLMiQuZ29vZ2xlLnByb3RvYnVmLkVudW1EZXNjcmlwdG9y" + "UHJvdG8SSAoPZXh0ZW5zaW9uX3JhbmdlGAUgAygLMi8uZ29vZ2xlLnByb3Rv" + "YnVmLkRlc2NyaXB0b3JQcm90by5FeHRlbnNpb25SYW5nZRI5CgpvbmVvZl9k" + "ZWNsGAggAygLMiUuZ29vZ2xlLnByb3RvYnVmLk9uZW9mRGVzY3JpcHRvclBy" + "b3RvEjAKB29wdGlvbnMYByABKAsyHy5nb29nbGUucHJvdG9idWYuTWVzc2Fn" + "ZU9wdGlvbnMSRgoOcmVzZXJ2ZWRfcmFuZ2UYCSADKAsyLi5nb29nbGUucHJv" + "dG9idWYuRGVzY3JpcHRvclByb3RvLlJlc2VydmVkUmFuZ2USFQoNcmVzZXJ2" + "ZWRfbmFtZRgKIAMoCRplCg5FeHRlbnNpb25SYW5nZRINCgVzdGFydBgBIAEo" + "BRILCgNlbmQYAiABKAUSNwoHb3B0aW9ucxgDIAEoCzImLmdvb2dsZS5wcm90" + "b2J1Zi5FeHRlbnNpb25SYW5nZU9wdGlvbnMaKwoNUmVzZXJ2ZWRSYW5nZRIN" + "CgVzdGFydBgBIAEoBRILCgNlbmQYAiABKAUiZwoVRXh0ZW5zaW9uUmFuZ2VP" + "cHRpb25zEkMKFHVuaW50ZXJwcmV0ZWRfb3B0aW9uGOcHIAMoCzIkLmdvb2ds" + "ZS5wcm90b2J1Zi5VbmludGVycHJldGVkT3B0aW9uKgkI6AcQgICAgAIivAUK" + "FEZpZWxkRGVzY3JpcHRvclByb3RvEgwKBG5hbWUYASABKAkSDgoGbnVtYmVy" + "GAMgASgFEjoKBWxhYmVsGAQgASgOMisuZ29vZ2xlLnByb3RvYnVmLkZpZWxk" + "RGVzY3JpcHRvclByb3RvLkxhYmVsEjgKBHR5cGUYBSABKA4yKi5nb29nbGUu" + "cHJvdG9idWYuRmllbGREZXNjcmlwdG9yUHJvdG8uVHlwZRIRCgl0eXBlX25h" + "bWUYBiABKAkSEAoIZXh0ZW5kZWUYAiABKAkSFQoNZGVmYXVsdF92YWx1ZRgH" + "IAEoCRITCgtvbmVvZl9pbmRleBgJIAEoBRIRCglqc29uX25hbWUYCiABKAkS" + "LgoHb3B0aW9ucxgIIAEoCzIdLmdvb2dsZS5wcm90b2J1Zi5GaWVsZE9wdGlv" + "bnMitgIKBFR5cGUSDwoLVFlQRV9ET1VCTEUQARIOCgpUWVBFX0ZMT0FUEAIS" + "DgoKVFlQRV9JTlQ2NBADEg8KC1RZUEVfVUlOVDY0EAQSDgoKVFlQRV9JTlQz" + "MhAFEhAKDFRZUEVfRklYRUQ2NBAGEhAKDFRZUEVfRklYRUQzMhAHEg0KCVRZ" + "UEVfQk9PTBAIEg8KC1RZUEVfU1RSSU5HEAkSDgoKVFlQRV9HUk9VUBAKEhAK" + "DFRZUEVfTUVTU0FHRRALEg4KClRZUEVfQllURVMQDBIPCgtUWVBFX1VJTlQz" + "MhANEg0KCVRZUEVfRU5VTRAOEhEKDVRZUEVfU0ZJWEVEMzIQDxIRCg1UWVBF" + "X1NGSVhFRDY0EBASDwoLVFlQRV9TSU5UMzIQERIPCgtUWVBFX1NJTlQ2NBAS" + "IkMKBUxhYmVsEhIKDkxBQkVMX09QVElPTkFMEAESEgoOTEFCRUxfUkVRVUlS" + "RUQQAhISCg5MQUJFTF9SRVBFQVRFRBADIlQKFE9uZW9mRGVzY3JpcHRvclBy" + "b3RvEgwKBG5hbWUYASABKAkSLgoHb3B0aW9ucxgCIAEoCzIdLmdvb2dsZS5w" + "cm90b2J1Zi5PbmVvZk9wdGlvbnMipAIKE0VudW1EZXNjcmlwdG9yUHJvdG8S" + "DAoEbmFtZRgBIAEoCRI4CgV2YWx1ZRgCIAMoCzIpLmdvb2dsZS5wcm90b2J1" + "Zi5FbnVtVmFsdWVEZXNjcmlwdG9yUHJvdG8SLQoHb3B0aW9ucxgDIAEoCzIc" + "Lmdvb2dsZS5wcm90b2J1Zi5FbnVtT3B0aW9ucxJOCg5yZXNlcnZlZF9yYW5n" + "ZRgEIAMoCzI2Lmdvb2dsZS5wcm90b2J1Zi5FbnVtRGVzY3JpcHRvclByb3Rv" + "LkVudW1SZXNlcnZlZFJhbmdlEhUKDXJlc2VydmVkX25hbWUYBSADKAkaLwoR" + "RW51bVJlc2VydmVkUmFuZ2USDQoFc3RhcnQYASABKAUSCwoDZW5kGAIgASgF" + "ImwKGEVudW1WYWx1ZURlc2NyaXB0b3JQcm90bxIMCgRuYW1lGAEgASgJEg4K" + "Bm51bWJlchgCIAEoBRIyCgdvcHRpb25zGAMgASgLMiEuZ29vZ2xlLnByb3Rv" + "YnVmLkVudW1WYWx1ZU9wdGlvbnMikAEKFlNlcnZpY2VEZXNjcmlwdG9yUHJv" + "dG8SDAoEbmFtZRgBIAEoCRI2CgZtZXRob2QYAiADKAsyJi5nb29nbGUucHJv" + "dG9idWYuTWV0aG9kRGVzY3JpcHRvclByb3RvEjAKB29wdGlvbnMYAyABKAsy" + "Hy5nb29nbGUucHJvdG9idWYuU2VydmljZU9wdGlvbnMiwQEKFU1ldGhvZERl" + "c2NyaXB0b3JQcm90bxIMCgRuYW1lGAEgASgJEhIKCmlucHV0X3R5cGUYAiAB" + "KAkSEwoLb3V0cHV0X3R5cGUYAyABKAkSLwoHb3B0aW9ucxgEIAEoCzIeLmdv" + "b2dsZS5wcm90b2J1Zi5NZXRob2RPcHRpb25zEh8KEGNsaWVudF9zdHJlYW1p" + "bmcYBSABKAg6BWZhbHNlEh8KEHNlcnZlcl9zdHJlYW1pbmcYBiABKAg6BWZh" + "bHNlIqYGCgtGaWxlT3B0aW9ucxIUCgxqYXZhX3BhY2thZ2UYASABKAkSHAoU" + "amF2YV9vdXRlcl9jbGFzc25hbWUYCCABKAkSIgoTamF2YV9tdWx0aXBsZV9m" + "aWxlcxgKIAEoCDoFZmFsc2USKQodamF2YV9nZW5lcmF0ZV9lcXVhbHNfYW5k" + "X2hhc2gYFCABKAhCAhgBEiUKFmphdmFfc3RyaW5nX2NoZWNrX3V0ZjgYGyAB" + "KAg6BWZhbHNlEkYKDG9wdGltaXplX2ZvchgJIAEoDjIpLmdvb2dsZS5wcm90" + "b2J1Zi5GaWxlT3B0aW9ucy5PcHRpbWl6ZU1vZGU6BVNQRUVEEhIKCmdvX3Bh" + "Y2thZ2UYCyABKAkSIgoTY2NfZ2VuZXJpY19zZXJ2aWNlcxgQIAEoCDoFZmFs" + "c2USJAoVamF2YV9nZW5lcmljX3NlcnZpY2VzGBEgASgIOgVmYWxzZRIiChNw" + "eV9nZW5lcmljX3NlcnZpY2VzGBIgASgIOgVmYWxzZRIjChRwaHBfZ2VuZXJp" + "Y19zZXJ2aWNlcxgqIAEoCDoFZmFsc2USGQoKZGVwcmVjYXRlZBgXIAEoCDoF" + "ZmFsc2USHwoQY2NfZW5hYmxlX2FyZW5hcxgfIAEoCDoFZmFsc2USGQoRb2Jq" + "Y19jbGFzc19wcmVmaXgYJCABKAkSGAoQY3NoYXJwX25hbWVzcGFjZRglIAEo" + "CRIUCgxzd2lmdF9wcmVmaXgYJyABKAkSGAoQcGhwX2NsYXNzX3ByZWZpeBgo" + "IAEoCRIVCg1waHBfbmFtZXNwYWNlGCkgASgJEh4KFnBocF9tZXRhZGF0YV9u" + "YW1lc3BhY2UYLCABKAkSFAoMcnVieV9wYWNrYWdlGC0gASgJEkMKFHVuaW50" + "ZXJwcmV0ZWRfb3B0aW9uGOcHIAMoCzIkLmdvb2dsZS5wcm90b2J1Zi5Vbmlu" + "dGVycHJldGVkT3B0aW9uIjoKDE9wdGltaXplTW9kZRIJCgVTUEVFRBABEg0K" + "CUNPREVfU0laRRACEhAKDExJVEVfUlVOVElNRRADKgkI6AcQgICAgAJKBAgm" + "ECci8gEKDk1lc3NhZ2VPcHRpb25zEiYKF21lc3NhZ2Vfc2V0X3dpcmVfZm9y" + "bWF0GAEgASgIOgVmYWxzZRIuCh9ub19zdGFuZGFyZF9kZXNjcmlwdG9yX2Fj" + "Y2Vzc29yGAIgASgIOgVmYWxzZRIZCgpkZXByZWNhdGVkGAMgASgIOgVmYWxz" + "ZRIRCgltYXBfZW50cnkYByABKAgSQwoUdW5pbnRlcnByZXRlZF9vcHRpb24Y" + "5wcgAygLMiQuZ29vZ2xlLnByb3RvYnVmLlVuaW50ZXJwcmV0ZWRPcHRpb24q" + "CQjoBxCAgICAAkoECAgQCUoECAkQCiKeAwoMRmllbGRPcHRpb25zEjoKBWN0" + "eXBlGAEgASgOMiMuZ29vZ2xlLnByb3RvYnVmLkZpZWxkT3B0aW9ucy5DVHlw" + "ZToGU1RSSU5HEg4KBnBhY2tlZBgCIAEoCBI/CgZqc3R5cGUYBiABKA4yJC5n" + "b29nbGUucHJvdG9idWYuRmllbGRPcHRpb25zLkpTVHlwZToJSlNfTk9STUFM" + "EhMKBGxhenkYBSABKAg6BWZhbHNlEhkKCmRlcHJlY2F0ZWQYAyABKAg6BWZh" + "bHNlEhMKBHdlYWsYCiABKAg6BWZhbHNlEkMKFHVuaW50ZXJwcmV0ZWRfb3B0" + "aW9uGOcHIAMoCzIkLmdvb2dsZS5wcm90b2J1Zi5VbmludGVycHJldGVkT3B0" + "aW9uIi8KBUNUeXBlEgoKBlNUUklORxAAEggKBENPUkQQARIQCgxTVFJJTkdf" + "UElFQ0UQAiI1CgZKU1R5cGUSDQoJSlNfTk9STUFMEAASDQoJSlNfU1RSSU5H" + "EAESDQoJSlNfTlVNQkVSEAIqCQjoBxCAgICAAkoECAQQBSJeCgxPbmVvZk9w" + "dGlvbnMSQwoUdW5pbnRlcnByZXRlZF9vcHRpb24Y5wcgAygLMiQuZ29vZ2xl" + "LnByb3RvYnVmLlVuaW50ZXJwcmV0ZWRPcHRpb24qCQjoBxCAgICAAiKTAQoL" + "RW51bU9wdGlvbnMSEwoLYWxsb3dfYWxpYXMYAiABKAgSGQoKZGVwcmVjYXRl" + "ZBgDIAEoCDoFZmFsc2USQwoUdW5pbnRlcnByZXRlZF9vcHRpb24Y5wcgAygL" + "MiQuZ29vZ2xlLnByb3RvYnVmLlVuaW50ZXJwcmV0ZWRPcHRpb24qCQjoBxCA" + "gICAAkoECAUQBiJ9ChBFbnVtVmFsdWVPcHRpb25zEhkKCmRlcHJlY2F0ZWQY" + "ASABKAg6BWZhbHNlEkMKFHVuaW50ZXJwcmV0ZWRfb3B0aW9uGOcHIAMoCzIk" + "Lmdvb2dsZS5wcm90b2J1Zi5VbmludGVycHJldGVkT3B0aW9uKgkI6AcQgICA" + "gAIiewoOU2VydmljZU9wdGlvbnMSGQoKZGVwcmVjYXRlZBghIAEoCDoFZmFs" + "c2USQwoUdW5pbnRlcnByZXRlZF9vcHRpb24Y5wcgAygLMiQuZ29vZ2xlLnBy" + "b3RvYnVmLlVuaW50ZXJwcmV0ZWRPcHRpb24qCQjoBxCAgICAAiKtAgoNTWV0" + "aG9kT3B0aW9ucxIZCgpkZXByZWNhdGVkGCEgASgIOgVmYWxzZRJfChFpZGVt" + "cG90ZW5jeV9sZXZlbBgiIAEoDjIvLmdvb2dsZS5wcm90b2J1Zi5NZXRob2RP" + "cHRpb25zLklkZW1wb3RlbmN5TGV2ZWw6E0lERU1QT1RFTkNZX1VOS05PV04S" + "QwoUdW5pbnRlcnByZXRlZF9vcHRpb24Y5wcgAygLMiQuZ29vZ2xlLnByb3Rv" + "YnVmLlVuaW50ZXJwcmV0ZWRPcHRpb24iUAoQSWRlbXBvdGVuY3lMZXZlbBIX" + "ChNJREVNUE9URU5DWV9VTktOT1dOEAASEwoPTk9fU0lERV9FRkZFQ1RTEAES" + "DgoKSURFTVBPVEVOVBACKgkI6AcQgICAgAIingIKE1VuaW50ZXJwcmV0ZWRP" + "cHRpb24SOwoEbmFtZRgCIAMoCzItLmdvb2dsZS5wcm90b2J1Zi5VbmludGVy" + "cHJldGVkT3B0aW9uLk5hbWVQYXJ0EhgKEGlkZW50aWZpZXJfdmFsdWUYAyAB" + "KAkSGgoScG9zaXRpdmVfaW50X3ZhbHVlGAQgASgEEhoKEm5lZ2F0aXZlX2lu" + "dF92YWx1ZRgFIAEoAxIUCgxkb3VibGVfdmFsdWUYBiABKAESFAoMc3RyaW5n" + "X3ZhbHVlGAcgASgMEhcKD2FnZ3JlZ2F0ZV92YWx1ZRgIIAEoCRozCghOYW1l" + "UGFydBIRCgluYW1lX3BhcnQYASACKAkSFAoMaXNfZXh0ZW5zaW9uGAIgAigI" + "ItUBCg5Tb3VyY2VDb2RlSW5mbxI6Cghsb2NhdGlvbhgBIAMoCzIoLmdvb2ds" + "ZS5wcm90b2J1Zi5Tb3VyY2VDb2RlSW5mby5Mb2NhdGlvbhqGAQoITG9jYXRp" + "b24SEAoEcGF0aBgBIAMoBUICEAESEAoEc3BhbhgCIAMoBUICEAESGAoQbGVh" + "ZGluZ19jb21tZW50cxgDIAEoCRIZChF0cmFpbGluZ19jb21tZW50cxgEIAEo" + "CRIhChlsZWFkaW5nX2RldGFjaGVkX2NvbW1lbnRzGAYgAygJIqcBChFHZW5l" + "cmF0ZWRDb2RlSW5mbxJBCgphbm5vdGF0aW9uGAEgAygLMi0uZ29vZ2xlLnBy" + "b3RvYnVmLkdlbmVyYXRlZENvZGVJbmZvLkFubm90YXRpb24aTwoKQW5ub3Rh" + "dGlvbhIQCgRwYXRoGAEgAygFQgIQARITCgtzb3VyY2VfZmlsZRgCIAEoCRIN" + "CgViZWdpbhgDIAEoBRILCgNlbmQYBCABKAVCjwEKE2NvbS5nb29nbGUucHJv" + "dG9idWZCEERlc2NyaXB0b3JQcm90b3NIAVo+Z2l0aHViLmNvbS9nb2xhbmcv" + "cHJvdG9idWYvcHJvdG9jLWdlbi1nby9kZXNjcmlwdG9yO2Rlc2NyaXB0b3L4" + "AQGiAgNHUEKqAhpHb29nbGUuUHJvdG9idWYuUmVmbGVjdGlvbg=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[21]
            {
            new GeneratedClrTypeInfo(typeof(FileDescriptorSet), FileDescriptorSet.Parser, new string[1] { "File" }, null, null, null),
            new GeneratedClrTypeInfo(typeof(FileDescriptorProto), FileDescriptorProto.Parser, new string[12]
            {
                "Name", "Package", "Dependency", "PublicDependency", "WeakDependency", "MessageType", "EnumType", "Service", "Extension", "Options",
                "SourceCodeInfo", "Syntax"
            }, null, null, null),
            new GeneratedClrTypeInfo(typeof(DescriptorProto), DescriptorProto.Parser, new string[10] { "Name", "Field", "Extension", "NestedType", "EnumType", "ExtensionRange", "OneofDecl", "Options", "ReservedRange", "ReservedName" }, null, null, new GeneratedClrTypeInfo[2]
            {
                new GeneratedClrTypeInfo(typeof(DescriptorProto.Types.ExtensionRange), DescriptorProto.Types.ExtensionRange.Parser, new string[3] { "Start", "End", "Options" }, null, null, null),
                new GeneratedClrTypeInfo(typeof(DescriptorProto.Types.ReservedRange), DescriptorProto.Types.ReservedRange.Parser, new string[2] { "Start", "End" }, null, null, null)
            }),
            new GeneratedClrTypeInfo(typeof(ExtensionRangeOptions), ExtensionRangeOptions.Parser, new string[1] { "UninterpretedOption" }, null, null, null),
            new GeneratedClrTypeInfo(typeof(FieldDescriptorProto), FieldDescriptorProto.Parser, new string[10] { "Name", "Number", "Label", "Type", "TypeName", "Extendee", "DefaultValue", "OneofIndex", "JsonName", "Options" }, null, new Type[2]
            {
                typeof(FieldDescriptorProto.Types.Type),
                typeof(FieldDescriptorProto.Types.Label)
            }, null),
            new GeneratedClrTypeInfo(typeof(OneofDescriptorProto), OneofDescriptorProto.Parser, new string[2] { "Name", "Options" }, null, null, null),
            new GeneratedClrTypeInfo(typeof(EnumDescriptorProto), EnumDescriptorProto.Parser, new string[5] { "Name", "Value", "Options", "ReservedRange", "ReservedName" }, null, null, new GeneratedClrTypeInfo[1]
            {
                new GeneratedClrTypeInfo(typeof(EnumDescriptorProto.Types.EnumReservedRange), EnumDescriptorProto.Types.EnumReservedRange.Parser, new string[2] { "Start", "End" }, null, null, null)
            }),
            new GeneratedClrTypeInfo(typeof(EnumValueDescriptorProto), EnumValueDescriptorProto.Parser, new string[3] { "Name", "Number", "Options" }, null, null, null),
            new GeneratedClrTypeInfo(typeof(ServiceDescriptorProto), ServiceDescriptorProto.Parser, new string[3] { "Name", "Method", "Options" }, null, null, null),
            new GeneratedClrTypeInfo(typeof(MethodDescriptorProto), MethodDescriptorProto.Parser, new string[6] { "Name", "InputType", "OutputType", "Options", "ClientStreaming", "ServerStreaming" }, null, null, null),
            new GeneratedClrTypeInfo(typeof(FileOptions), FileOptions.Parser, new string[21]
            {
                "JavaPackage", "JavaOuterClassname", "JavaMultipleFiles", "JavaGenerateEqualsAndHash", "JavaStringCheckUtf8", "OptimizeFor", "GoPackage", "CcGenericServices", "JavaGenericServices", "PyGenericServices",
                "PhpGenericServices", "Deprecated", "CcEnableArenas", "ObjcClassPrefix", "CsharpNamespace", "SwiftPrefix", "PhpClassPrefix", "PhpNamespace", "PhpMetadataNamespace", "RubyPackage",
                "UninterpretedOption"
            }, null, new Type[1] { typeof(FileOptions.Types.OptimizeMode) }, null),
            new GeneratedClrTypeInfo(typeof(MessageOptions), MessageOptions.Parser, new string[5] { "MessageSetWireFormat", "NoStandardDescriptorAccessor", "Deprecated", "MapEntry", "UninterpretedOption" }, null, null, null),
                new GeneratedClrTypeInfo(typeof(FieldOptions), FieldOptions.Parser, new string[7] { "Ctype", "Packed", "Jstype", "Lazy", "Deprecated", "Weak", "UninterpretedOption" }, null, new Type[2]
                {
                    typeof(FieldOptions.Types.CType),
                    typeof(FieldOptions.Types.JSType)
                }, null),
            new GeneratedClrTypeInfo(typeof(OneofOptions), OneofOptions.Parser, new string[1] { "UninterpretedOption" }, null, null, null),
            new GeneratedClrTypeInfo(typeof(EnumOptions), EnumOptions.Parser, new string[3] { "AllowAlias", "Deprecated", "UninterpretedOption" }, null, null, null),
            new GeneratedClrTypeInfo(typeof(EnumValueOptions), EnumValueOptions.Parser, new string[2] { "Deprecated", "UninterpretedOption" }, null, null, null),
            new GeneratedClrTypeInfo(typeof(ServiceOptions), ServiceOptions.Parser, new string[2] { "Deprecated", "UninterpretedOption" }, null, null, null),
            new GeneratedClrTypeInfo(typeof(MethodOptions), MethodOptions.Parser, new string[3] { "Deprecated", "IdempotencyLevel", "UninterpretedOption" }, null, new Type[1] { typeof(MethodOptions.Types.IdempotencyLevel) }, null),
            new GeneratedClrTypeInfo(typeof(UninterpretedOption), UninterpretedOption.Parser, new string[7] { "Name", "IdentifierValue", "PositiveIntValue", "NegativeIntValue", "DoubleValue", "StringValue", "AggregateValue" }, null, null, new GeneratedClrTypeInfo[1]
            {
                new GeneratedClrTypeInfo(typeof(UninterpretedOption.Types.NamePart), UninterpretedOption.Types.NamePart.Parser, new string[2] { "NamePart_", "IsExtension" }, null, null, null)
            }),
            new GeneratedClrTypeInfo(typeof(SourceCodeInfo), SourceCodeInfo.Parser, new string[1] { "Location" }, null, null, new GeneratedClrTypeInfo[1]
            {
                new GeneratedClrTypeInfo(typeof(SourceCodeInfo.Types.Location), SourceCodeInfo.Types.Location.Parser, new string[5] { "Path", "Span", "LeadingComments", "TrailingComments", "LeadingDetachedComments" }, null, null, null)
            }),
            new GeneratedClrTypeInfo(typeof(GeneratedCodeInfo), GeneratedCodeInfo.Parser, new string[1] { "Annotation" }, null, null, new GeneratedClrTypeInfo[1]
            {
                new GeneratedClrTypeInfo(typeof(GeneratedCodeInfo.Types.Annotation), GeneratedCodeInfo.Types.Annotation.Parser, new string[4] { "Path", "SourceFile", "Begin", "End" }, null, null, null)
            })
            }));
        }
    }
}
