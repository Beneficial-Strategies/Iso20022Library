// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a source of the cash asset.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_w1c-gEyLEeiepssxrmRw1A")]
[Description(@"Specifies a source of the cash asset.")]
[DerivedFrom(typeof(CashAssetTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CashAssetType1Code>))]
#endif
public enum CashAssetType1Code
{
    /// <summary>
    /// Cash is cash in the holding not yet invested.
    /// Encoded/decoded by serializers as &quot;CSH2&quot;.
    /// </summary>
    [EnumMember(Value = "CSH2")]
    [IsoId("_z92S0UyLEeiepssxrmRw1A")]
    [Description(@"Cash is cash in the holding not yet invested.")]
    CashInHolding = CashAssetTypeCode.CashInHolding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash is attributed to a cash investment.
    /// Encoded/decoded by serializers as &quot;CSH1&quot;.
    /// </summary>
    [EnumMember(Value = "CSH1")]
    [IsoId("_0EGEwUyLEeiepssxrmRw1A")]
    [Description(@"Cash is attributed to a cash investment.")]
    CashInvestment = CashAssetTypeCode.CashInvestment, // same ordinal as derivation source for type conversions
}
