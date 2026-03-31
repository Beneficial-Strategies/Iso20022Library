// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if income is to be paid out (distributed) or retained (accumulated).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_awwx4tp-Ed-ak6NoX_4Aeg_-433302197")]
[Description(@"Specifies if income is to be paid out (distributed) or retained (accumulated).")]
[DerivedFrom(typeof(DistributionPolicyCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DistributionPolicy1Code>))]
#endif
public enum DistributionPolicy1Code
{
    /// <summary>
    /// Income is distributed to the investors in the fund.
    /// Encoded/decoded by serializers as &quot;DIST&quot;.
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_awwx49p-Ed-ak6NoX_4Aeg_-433302196")]
    [Description(@"Income is distributed to the investors in the fund.")]
    Distribution = DistributionPolicyCode.Distribution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Income is added to the capital of the fund.
    /// Encoded/decoded by serializers as &quot;ACCU&quot;.
    /// </summary>
    [EnumMember(Value = "ACCU")]
    [IsoId("_awwx5Np-Ed-ak6NoX_4Aeg_-433302187")]
    [Description(@"Income is added to the capital of the fund.")]
    Accumulation = DistributionPolicyCode.Accumulation, // same ordinal as derivation source for type conversions
}
