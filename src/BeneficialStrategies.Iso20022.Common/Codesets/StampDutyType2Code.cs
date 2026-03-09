// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the stamp duty is applicable.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_suw7QPpiEeCG_oUHBFcYXA")]
[Description(@"Specifies if the stamp duty is applicable.")]
[DerivedFrom(typeof(StampDutyTypeCode))]
public enum StampDutyType2Code
{
    /// <summary>
    /// Stamps duty is applicable.
    /// Encoded/decoded by serializers as &quot;ASTD&quot;.
    /// </summary>
    [EnumMember(Value = "ASTD")]
    [IsoId("_Cd9Nnv8vEeC87tbx-VXRVA")]
    [Description(@"Stamps duty is applicable.")]
    Applicable = StampDutyTypeCode.Applicable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Stamp duty not applicable.
    /// Encoded/decoded by serializers as &quot;SDRN&quot;.
    /// </summary>
    [EnumMember(Value = "SDRN")]
    [IsoId("_CmdCSv8vEeC87tbx-VXRVA")]
    [Description(@"Stamp duty not applicable.")]
    NotApplicable = StampDutyTypeCode.NotApplicable, // same ordinal as derivation source for type conversions
    
}
