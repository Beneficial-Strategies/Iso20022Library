// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code qualifying types of cash rounding.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1sZ_JDL3EeKU9IrkkToqcw_-1201472359")]
[Description(@"Code qualifying types of cash rounding.")]
[DerivedFrom(typeof(DTCCashRoundingTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DTCCashRoundingType1Code>))]
#endif
public enum DTCCashRoundingType1Code
{
    /// <summary>
    /// Round down to the nearest cent.
    /// Encoded/decoded by serializers as &quot;RDNC&quot;.
    /// </summary>
    [EnumMember(Value = "RDNC")]
    [IsoId("_1sZ_JTL3EeKU9IrkkToqcw_-437406661")]
    [Description(@"Round down to the nearest cent.")]
    RoundDownToTheNearestCent = DTCCashRoundingTypeCode.RoundDownToTheNearestCent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Round down to the nearest dollar.
    /// Encoded/decoded by serializers as &quot;RDND&quot;.
    /// </summary>
    [EnumMember(Value = "RDND")]
    [IsoId("_1sjJEDL3EeKU9IrkkToqcw_-1816089604")]
    [Description(@"Round down to the nearest dollar.")]
    RoundDownToTheNearestDollar = DTCCashRoundingTypeCode.RoundDownToTheNearestDollar, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Round up to the nearest cent.
    /// Encoded/decoded by serializers as &quot;RUNC&quot;.
    /// </summary>
    [EnumMember(Value = "RUNC")]
    [IsoId("_1sjJETL3EeKU9IrkkToqcw_-1929928670")]
    [Description(@"Round up to the nearest cent.")]
    RoundUpToTheNearestCent = DTCCashRoundingTypeCode.RoundUpToTheNearestCent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Round up to the nearest dollar.
    /// Encoded/decoded by serializers as &quot;RUND&quot;.
    /// </summary>
    [EnumMember(Value = "RUND")]
    [IsoId("_1sjJEjL3EeKU9IrkkToqcw_-1827188381")]
    [Description(@"Round up to the nearest dollar.")]
    RoundUpToTheNearestDollar = DTCCashRoundingTypeCode.RoundUpToTheNearestDollar, // same ordinal as derivation source for type conversions
}
