// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTC (The Depository Trust Company) defined asset class.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1rqYQjL3EeKU9IrkkToqcw_-716829742")]
[Description(@"Specifies DTC (The Depository Trust Company) defined asset class.")]
[DerivedFrom(typeof(AssetClassCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClass1Code>))]
#endif
public enum AssetClass1Code
{
    /// <summary>
    /// Debt instrument issued by a corporation.
    /// Encoded/decoded by serializers as &quot;CRPB&quot;.
    /// </summary>
    [EnumMember(Value = "CRPB")]
    [IsoId("_1rqYQzL3EeKU9IrkkToqcw_-1331446987")]
    [Description(@"Debt instrument issued by a corporation.")]
    CorporateDebt = AssetClassCode.CorporateDebt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Equity issued by a corporation.
    /// Encoded/decoded by serializers as &quot;CRPE&quot;.
    /// </summary>
    [EnumMember(Value = "CRPE")]
    [IsoId("_1rqYRDL3EeKU9IrkkToqcw_-1445286053")]
    [Description(@"Equity issued by a corporation.")]
    CorporateEquity = AssetClassCode.CorporateEquity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Debt instrument issued by municipality.
    /// Encoded/decoded by serializers as &quot;MUNB&quot;.
    /// </summary>
    [EnumMember(Value = "MUNB")]
    [IsoId("_1rqYRTL3EeKU9IrkkToqcw_-1006329480")]
    [Description(@"Debt instrument issued by municipality.")]
    MunicipalDebt = AssetClassCode.MunicipalDebt, // same ordinal as derivation source for type conversions
}
