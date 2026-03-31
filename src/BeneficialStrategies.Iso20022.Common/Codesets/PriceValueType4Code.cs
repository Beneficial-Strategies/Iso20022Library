// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of price value.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aJbFGNp-Ed-ak6NoX_4Aeg_-1761185747")]
[Description(@"Specifies a type of price value.")]
[DerivedFrom(typeof(PriceValueTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PriceValueType4Code>))]
#endif
public enum PriceValueType4Code
{
    /// <summary>
    /// Price has not been established.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_aJbFGdp-Ed-ak6NoX_4Aeg_-1213536998")]
    [Description(@"Price has not been established.")]
    OpenDated = PriceValueTypeCode.OpenDated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price to be specified by account owner.
    /// Encoded/decoded by serializers as &quot;TBSP&quot;.
    /// </summary>
    [EnumMember(Value = "TBSP")]
    [IsoId("_aJk2ENp-Ed-ak6NoX_4Aeg_-1196914941")]
    [Description(@"Price to be specified by account owner.")]
    ToBeSpecified = PriceValueTypeCode.ToBeSpecified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is not required to be specified by account owner.
    /// Encoded/decoded by serializers as &quot;UNSP&quot;.
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_aJk2Edp-Ed-ak6NoX_4Aeg_-942945763")]
    [Description(@"Price is not required to be specified by account owner.")]
    Unspecified = PriceValueTypeCode.Unspecified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_aJk2Etp-Ed-ak6NoX_4Aeg_-927245276")]
    [Description(@"Price is unknown by the sender or has not been established.")]
    Unknown = PriceValueTypeCode.Unknown, // same ordinal as derivation source for type conversions
}
