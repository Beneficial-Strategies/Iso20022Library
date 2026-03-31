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
[IsoId("_ZWUNI9p-Ed-ak6NoX_4Aeg_1984550487")]
[Description(@"Specifies the type of product or financial instrument.")]
[Derivations(typeof(ProductType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ProductTypeCode>))]
#endif
public enum ProductTypeCode
{
    /// <summary>
    /// Identifies categories of instruments issued by federal agencies.
    /// Encoded/decoded by serializers as &quot;AGEN&quot;.
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("_ZWUNJNp-Ed-ak6NoX_4Aeg_-2015814182")]
    [Description(@"Identifies categories of instruments issued by federal agencies.")]
    Agency,

    /// <summary>
    /// Identifies categories of instruments that are commodities.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_ZWUNJdp-Ed-ak6NoX_4Aeg_-2001964235")]
    [Description(@"Identifies categories of instruments that are commodities.")]
    Commodity,

    /// <summary>
    /// Identifies categories of instruments issued by corporates.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_ZWUNJtp-Ed-ak6NoX_4Aeg_-1988111298")]
    [Description(@"Identifies categories of instruments issued by corporates.")]
    Corporate,

    /// <summary>
    /// Identifies categories of currency instruments.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_ZWUNJ9p-Ed-ak6NoX_4Aeg_-1983490715")]
    [Description(@"Identifies categories of currency instruments.")]
    Currency,

    /// <summary>
    /// Identifies the nature or type of an equity.
    /// Encoded/decoded by serializers as &quot;EQUI&quot;.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_ZWUNKNp-Ed-ak6NoX_4Aeg_-1969639916")]
    [Description(@"Identifies the nature or type of an equity.")]
    Equity,

    /// <summary>
    /// Identifies categories of obligations issued by a government.
    /// Encoded/decoded by serializers as &quot;GOVE&quot;.
    /// </summary>
    [EnumMember(Value = "GOVE")]
    [IsoId("_ZWUNKdp-Ed-ak6NoX_4Aeg_-1958557726")]
    [Description(@"Identifies categories of obligations issued by a government.")]
    Government,

    /// <summary>
    /// Identifies categories of loans.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_ZWd-INp-Ed-ak6NoX_4Aeg_-1941008876")]
    [Description(@"Identifies categories of loans.")]
    Loan,

    /// <summary>
    /// Identifies categories of short-term debt securities maturing in less than one year.
    /// Encoded/decoded by serializers as &quot;MOMA&quot;.
    /// </summary>
    [EnumMember(Value = "MOMA")]
    [IsoId("_ZWd-Idp-Ed-ak6NoX_4Aeg_-1929929598")]
    [Description(
        @"Identifies categories of short-term debt securities maturing in less than one year."
    )]
    MoneyMarket,

    /// <summary>
    /// Identifies categories of mortgage securities.
    /// Encoded/decoded by serializers as &quot;MORT&quot;.
    /// </summary>
    [EnumMember(Value = "MORT")]
    [IsoId("_ZWd-Itp-Ed-ak6NoX_4Aeg_-1916075308")]
    [Description(@"Identifies categories of mortgage securities.")]
    Mortgage,

    /// <summary>
    /// Identifies categories of securities issued by states and local governments.
    /// Encoded/decoded by serializers as &quot;MUNI&quot;.
    /// </summary>
    [EnumMember(Value = "MUNI")]
    [IsoId("_ZWd-I9p-Ed-ak6NoX_4Aeg_-1910534166")]
    [Description(@"Identifies categories of securities issued by states and local governments.")]
    Municipal,

    /// <summary>
    /// Identifies categories of financing instruments.
    /// Encoded/decoded by serializers as &quot;FINA&quot;.
    /// </summary>
    [EnumMember(Value = "FINA")]
    [IsoId("_ZWd-JNp-Ed-ak6NoX_4Aeg_-1883751161")]
    [Description(@"Identifies categories of financing instruments.")]
    Financing,

    /// <summary>
    /// The asset type is property.
    /// Encoded/decoded by serializers as &quot;PROP&quot;.
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_bfQPltp-Ed-ak6NoX_4Aeg_-1282805152")]
    [Description(@"The asset type is property.")]
    Property,

    /// <summary>
    /// The asset type is a swap.
    /// Encoded/decoded by serializers as &quot;SWAP&quot;.
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_bfQPmNp-Ed-ak6NoX_4Aeg_-1280032626")]
    [Description(@"The asset type is a swap.")]
    Swap,

    /// <summary>
    /// The asset type is other.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_bfaAkNp-Ed-ak6NoX_4Aeg_-1279108826")]
    [Description(@"The asset type is other.")]
    Other,
}
