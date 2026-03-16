// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies which party(ies) will pay charges due for processing of the instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a8PpJdp-Ed-ak6NoX_4Aeg_-867377904")]
[Description(@"Specifies which party(ies) will pay charges due for processing of the instruction.")]
[DerivedFrom(typeof(ChargeBearerTypeCode))]
public enum ChargeBearerType2Code
{
    /// <summary>
    /// Charges are to be applied following the rules agreed in the service level and/or scheme.
    /// Encoded/decoded by serializers as &quot;SLEV&quot;.
    /// </summary>
    [EnumMember(Value = "SLEV")]
    [IsoId("_a8PpJtp-Ed-ak6NoX_4Aeg_-867377749")]
    [Description(
        @"Charges are to be applied following the rules agreed in the service level and/or scheme."
    )]
    FollowingServiceLevel = ChargeBearerTypeCode.FollowingServiceLevel, // same ordinal as derivation source for type conversions
}
