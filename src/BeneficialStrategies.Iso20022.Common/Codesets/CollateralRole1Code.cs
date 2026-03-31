// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies whether the reporting counterparty is a collateral provider or a collateral taker.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pFIlUCDCEeaned5xL18mUQ")]
[Description(
    @"Identifies whether the reporting counterparty is a collateral provider or a collateral taker."
)]
[DerivedFrom(typeof(CollateralRoleCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CollateralRole1Code>))]
#endif
public enum CollateralRole1Code
{
    /// <summary>
    /// Collateral giver.
    /// Encoded/decoded by serializers as &quot;GIVE&quot;.
    /// </summary>
    [EnumMember(Value = "GIVE")]
    [IsoId("_qHyVISDCEeaned5xL18mUQ")]
    [Description(@"Collateral giver.")]
    CollateralGiver = CollateralRoleCode.CollateralGiver, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral taker.
    /// Encoded/decoded by serializers as &quot;TAKE&quot;.
    /// </summary>
    [EnumMember(Value = "TAKE")]
    [IsoId("_qPOZ4SDCEeaned5xL18mUQ")]
    [Description(@"Collateral taker. ")]
    CollateralTaker = CollateralRoleCode.CollateralTaker, // same ordinal as derivation source for type conversions
}
