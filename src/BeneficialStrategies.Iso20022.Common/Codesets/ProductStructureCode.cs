// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the structure of a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_axfhYKDqEequlaOyi6MUhw")]
[Description(@"Specifies the structure of a financial instrument.")]
[Derivations(typeof(ProductStructure1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ProductStructureCode>))]
#endif
public enum ProductStructureCode
{
    /// <summary>
    /// Product is an exchange traded commodity.
    /// Encoded/decoded by serializers as &quot;EXTC&quot;.
    /// </summary>
    [EnumMember(Value = "EXTC")]
    [IsoId("_tSn6R6DqEequlaOyi6MUhw")]
    [Description(@"Product is an exchange traded commodity.")]
    ExchangeTradedCommodity,

    /// <summary>
    /// Product is a not an Undertaking for Collective Investment in Transferable Securities (UCITS).
    /// Encoded/decoded by serializers as &quot;NUCI&quot;.
    /// </summary>
    [EnumMember(Value = "NUCI")]
    [IsoId("_tSn6SKDqEequlaOyi6MUhw")]
    [Description(
        @"Product is a not an Undertaking for Collective Investment in Transferable Securities (UCITS)."
    )]
    NonUCITS,

    /// <summary>
    /// Product is a money market fund that is not an Undertaking for Collective Investment in Transferable Securities (UCITS).
    /// Encoded/decoded by serializers as &quot;NUMM&quot;.
    /// </summary>
    [EnumMember(Value = "NUMM")]
    [IsoId("_tSn6SaDqEequlaOyi6MUhw")]
    [Description(
        @"Product is a money market fund that is not an Undertaking for Collective Investment in Transferable Securities (UCITS)."
    )]
    NonUCITSMoneyMarketFund,

    /// <summary>
    /// Product is a structured fund.
    /// Encoded/decoded by serializers as &quot;SFUN&quot;.
    /// </summary>
    [EnumMember(Value = "SFUN")]
    [IsoId("_tSn6SqDqEequlaOyi6MUhw")]
    [Description(@"Product is a structured fund.")]
    StructuredFund,

    /// <summary>
    /// Product is a structured security.
    /// Encoded/decoded by serializers as &quot;SSEC&quot;.
    /// </summary>
    [EnumMember(Value = "SSEC")]
    [IsoId("_tSn6S6DqEequlaOyi6MUhw")]
    [Description(@"Product is a structured security.")]
    StructuredSecurity,

    /// <summary>
    /// Product is an Undertaking for Collective Investment in Transferable Securities (UCITS).
    /// Encoded/decoded by serializers as &quot;UCIT&quot;.
    /// </summary>
    [EnumMember(Value = "UCIT")]
    [IsoId("_tSn6TKDqEequlaOyi6MUhw")]
    [Description(
        @"Product is an Undertaking for Collective Investment in Transferable Securities (UCITS)."
    )]
    UCITS,

    /// <summary>
    /// Product is an Undertaking for Collective Investment in Transferable Securities (UCITS) money market fund.
    /// Encoded/decoded by serializers as &quot;UCMM&quot;.
    /// </summary>
    [EnumMember(Value = "UCMM")]
    [IsoId("_tSn6TaDqEequlaOyi6MUhw")]
    [Description(
        @"Product is an Undertaking for Collective Investment in Transferable Securities (UCITS) money market fund."
    )]
    UCITSMoneyMarketFund,

    /// <summary>
    /// Product is a bond.
    /// Encoded/decoded by serializers as &quot;BOND&quot;.
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_vOGvgKDqEequlaOyi6MUhw")]
    [Description(@"Product is a bond.")]
    Bond,
}
