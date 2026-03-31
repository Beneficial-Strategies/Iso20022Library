// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of product or financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZWKcIdp-Ed-ak6NoX_4Aeg_-1402597074")]
[Description(@"Specifies the type of product or financial instrument.")]
[DerivedFrom(typeof(ProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ProductType1Code>))]
#endif
public enum ProductType1Code
{
    /// <summary>
    /// Identifies categories of instruments issued by federal agencies.
    /// Encoded/decoded by serializers as &quot;AGEN&quot;.
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("_ZWKcItp-Ed-ak6NoX_4Aeg_-1124617360")]
    [Description(@"Identifies categories of instruments issued by federal agencies.")]
    Agency = ProductTypeCode.Agency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies categories of instruments that are commodities.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_ZWKcI9p-Ed-ak6NoX_4Aeg_-1124617335")]
    [Description(@"Identifies categories of instruments that are commodities.")]
    Commodity = ProductTypeCode.Commodity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies categories of instruments issued by corporates.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_ZWKcJNp-Ed-ak6NoX_4Aeg_-1124617334")]
    [Description(@"Identifies categories of instruments issued by corporates.")]
    Corporate = ProductTypeCode.Corporate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies categories of currency instruments.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_ZWKcJdp-Ed-ak6NoX_4Aeg_-1124617318")]
    [Description(@"Identifies categories of currency instruments.")]
    Currency = ProductTypeCode.Currency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies the nature or type of an equity.
    /// Encoded/decoded by serializers as &quot;EQUI&quot;.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_ZWKcJtp-Ed-ak6NoX_4Aeg_-1124617317")]
    [Description(@"Identifies the nature or type of an equity.")]
    Equity = ProductTypeCode.Equity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies categories of obligations issued by a government.
    /// Encoded/decoded by serializers as &quot;GOVE&quot;.
    /// </summary>
    [EnumMember(Value = "GOVE")]
    [IsoId("_ZWKcJ9p-Ed-ak6NoX_4Aeg_-1124617300")]
    [Description(@"Identifies categories of obligations issued by a government.")]
    Government = ProductTypeCode.Government, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies categories of loans.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_ZWKcKNp-Ed-ak6NoX_4Aeg_-1124617282")]
    [Description(@"Identifies categories of loans.")]
    Loan = ProductTypeCode.Loan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies categories of short-term debt securities maturing in less than one year.
    /// Encoded/decoded by serializers as &quot;MOMA&quot;.
    /// </summary>
    [EnumMember(Value = "MOMA")]
    [IsoId("_ZWKcKdp-Ed-ak6NoX_4Aeg_-1124617265")]
    [Description(
        @"Identifies categories of short-term debt securities maturing in less than one year."
    )]
    MoneyMarket = ProductTypeCode.MoneyMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies categories of mortgage securities.
    /// Encoded/decoded by serializers as &quot;MORT&quot;.
    /// </summary>
    [EnumMember(Value = "MORT")]
    [IsoId("_ZWUNINp-Ed-ak6NoX_4Aeg_-1124617264")]
    [Description(@"Identifies categories of mortgage securities.")]
    Mortgage = ProductTypeCode.Mortgage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies categories of securities issued by states and local governments.
    /// Encoded/decoded by serializers as &quot;MUNI&quot;.
    /// </summary>
    [EnumMember(Value = "MUNI")]
    [IsoId("_ZWUNIdp-Ed-ak6NoX_4Aeg_-1124617240")]
    [Description(@"Identifies categories of securities issued by states and local governments.")]
    Municipal = ProductTypeCode.Municipal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies categories of financing instruments.
    /// Encoded/decoded by serializers as &quot;FINA&quot;.
    /// </summary>
    [EnumMember(Value = "FINA")]
    [IsoId("_ZWUNItp-Ed-ak6NoX_4Aeg_-1124617223")]
    [Description(@"Identifies categories of financing instruments.")]
    Financing = ProductTypeCode.Financing, // same ordinal as derivation source for type conversions
}
