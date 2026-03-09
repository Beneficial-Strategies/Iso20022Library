// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aw6i4dp-Ed-ak6NoX_4Aeg_-1335531039")]
[Description(@"Specifies whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date.")]
[DerivedFrom(typeof(DistributionTypeCode))]
public enum DistributionType1Code
{
    /// <summary>
    /// Event will have a number of acceptance and payment dates until further announcement by the Issuer or its agent.
    /// Encoded/decoded by serializers as &quot;ROLL&quot;.
    /// </summary>
    [EnumMember(Value = "ROLL")]
    [IsoId("_aw6i4tp-Ed-ak6NoX_4Aeg_-1335531037")]
    [Description(@"Event will have a number of acceptance and payment dates until further announcement by the Issuer or its agent.")]
    RollingBasis = DistributionTypeCode.RollingBasis, // same ordinal as derivation source for type conversions
    
}
