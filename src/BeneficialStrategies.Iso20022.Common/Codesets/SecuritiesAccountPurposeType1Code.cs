// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the purpose of the securities account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y-7A1Np-Ed-ak6NoX_4Aeg_-1554401814")]
[Description(@"Specifies the purpose of the securities account.")]
[DerivedFrom(typeof(SecuritiesAccountPurposeTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SecuritiesAccountPurposeType1Code>))]
#endif
public enum SecuritiesAccountPurposeType1Code
{
    /// <summary>
    /// Account is used when financing is done by the broker.
    /// Encoded/decoded by serializers as &quot;MARG&quot;.
    /// </summary>
    [EnumMember(Value = "MARG")]
    [IsoId("_Y-7A1dp-Ed-ak6NoX_4Aeg_-1554401442")]
    [Description(@"Account is used when financing is done by the broker.")]
    Margin = SecuritiesAccountPurposeTypeCode.Margin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is used for short sale orders.
    /// Encoded/decoded by serializers as &quot;SHOR&quot;.
    /// </summary>
    [EnumMember(Value = "SHOR")]
    [IsoId("_Y-7A1tp-Ed-ak6NoX_4Aeg_-1554401407")]
    [Description(@"Account is used for short sale orders.")]
    ShortSale = SecuritiesAccountPurposeTypeCode.ShortSale, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is located in a financial institution outside the country where the transaction is taking place.
    /// Encoded/decoded by serializers as &quot;ABRD&quot;.
    /// </summary>
    [EnumMember(Value = "ABRD")]
    [IsoId("_Y-7A19p-Ed-ak6NoX_4Aeg_-1554401365")]
    [Description(
        @"Account is located in a financial institution outside the country where the transaction is taking place."
    )]
    Abroad = SecuritiesAccountPurposeTypeCode.Abroad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account and all its related positions are held in one location.
    /// Encoded/decoded by serializers as &quot;CEND&quot;.
    /// </summary>
    [EnumMember(Value = "CEND")]
    [IsoId("_Y-7A2Np-Ed-ak6NoX_4Aeg_-1554401347")]
    [Description(@"Account and all its related positions are held in one location.")]
    Centralised = SecuritiesAccountPurposeTypeCode.Centralised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is used for settlement upon delivery, or a collection on a delivery basis.
    /// Encoded/decoded by serializers as &quot;DVPA&quot;.
    /// </summary>
    [EnumMember(Value = "DVPA")]
    [IsoId("_Y-7A2dp-Ed-ak6NoX_4Aeg_-1554401304")]
    [Description(
        @"Account is used for settlement upon delivery, or a collection on a delivery basis."
    )]
    CashDVP = SecuritiesAccountPurposeTypeCode.CashDVP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is used for physical domestic safekeeping.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_Y_Ex0Np-Ed-ak6NoX_4Aeg_-1554401286")]
    [Description(@"Account is used for physical domestic safekeeping.")]
    Physical = SecuritiesAccountPurposeTypeCode.Physical, // same ordinal as derivation source for type conversions
}
