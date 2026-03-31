// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the type of price to which the discretion offset is related to.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YwduFtp-Ed-ak6NoX_4Aeg_337179698")]
[Description(@"Contains the type of price to which the discretion offset is related to.")]
[Derivations(typeof(TypeOfDiscretionPrice1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TypeOfDiscretionPriceCode>))]
#endif
public enum TypeOfDiscretionPriceCode
{
    /// <summary>
    /// Indicates that the offset value is related to displayed price.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_YwduF9p-Ed-ak6NoX_4Aeg_337179699")]
    [Description(@"Indicates that the offset value is related to displayed price.")]
    DisplayedPrice,

    /// <summary>
    /// Indicates that the offset value is related to market price.
    /// Encoded/decoded by serializers as &quot;MRKT&quot;.
    /// </summary>
    [EnumMember(Value = "MRKT")]
    [IsoId("_YwduGNp-Ed-ak6NoX_4Aeg_337179700")]
    [Description(@"Indicates that the offset value is related to market price.")]
    MarketPrice,

    /// <summary>
    /// Indicates that the offset value is related to primary price.
    /// Encoded/decoded by serializers as &quot;PRIM&quot;.
    /// </summary>
    [EnumMember(Value = "PRIM")]
    [IsoId("_YwnfENp-Ed-ak6NoX_4Aeg_337179701")]
    [Description(@"Indicates that the offset value is related to primary price.")]
    PrimaryPrice,

    /// <summary>
    /// Indicates that the offset value is related to local primary price.
    /// Encoded/decoded by serializers as &quot;LPRI&quot;.
    /// </summary>
    [EnumMember(Value = "LPRI")]
    [IsoId("_YwnfEdp-Ed-ak6NoX_4Aeg_337179702")]
    [Description(@"Indicates that the offset value is related to local primary price.")]
    LocalPrimaryPrice,

    /// <summary>
    /// Indicates that the offset value is related to midpoint price.
    /// Encoded/decoded by serializers as &quot;MIDP&quot;.
    /// </summary>
    [EnumMember(Value = "MIDP")]
    [IsoId("_YwnfEtp-Ed-ak6NoX_4Aeg_337179703")]
    [Description(@"Indicates that the offset value is related to midpoint price.")]
    MidpointPrice,

    /// <summary>
    /// Indicates that the offset value is related to VWAP price.
    /// Encoded/decoded by serializers as &quot;VWAP&quot;.
    /// </summary>
    [EnumMember(Value = "VWAP")]
    [IsoId("_YwnfE9p-Ed-ak6NoX_4Aeg_-1352175476")]
    [Description(@"Indicates that the offset value is related to VWAP price.")]
    VolumeWeightedAveragePrice,

    /// <summary>
    /// Indicates that the offset value is related to average price guarantee.
    /// Encoded/decoded by serializers as &quot;AVPG&quot;.
    /// </summary>
    [EnumMember(Value = "AVPG")]
    [IsoId("_YwnfFNp-Ed-ak6NoX_4Aeg_-1352175416")]
    [Description(@"Indicates that the offset value is related to average price guarantee.")]
    AveragePriceGuarantee,
}
