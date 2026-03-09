// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of product or financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_g9bYnwOEEeWs3sTa9Sj6Lg")]
[Description(@"Specifies the type of product or financial instrument.")]
[Derivations(typeof(ProductType4Code),typeof(ProductType5Code),typeof(ProductType6Code),typeof(ProductType7Code))]
public enum ProductTypeV2Code
{
    /// <summary>
    /// Identifies categories of instruments issued by federal agencies.
    /// Encoded/decoded by serializers as &quot;AGEN&quot;.
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("_g9bYoAOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of instruments issued by federal agencies.")]
    Agency,
    
    /// <summary>
    /// Identifies categories of instruments that are commodities.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_g9bYqAOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of instruments that are commodities.")]
    Commodity,
    
    /// <summary>
    /// Identifies categories of instruments issued by corporates.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_g9bYrQOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of instruments issued by corporates.")]
    Corporate,
    
    /// <summary>
    /// Identifies categories of currency instruments.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_g9bYpgOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of currency instruments.")]
    Currency,
    
    /// <summary>
    /// Identifies the nature or type of an equity.
    /// Encoded/decoded by serializers as &quot;EQUI&quot;.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_g9bYoQOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies the nature or type of an equity.")]
    Equity,
    
    /// <summary>
    /// Identifies categories of obligations issued by a government.
    /// Encoded/decoded by serializers as &quot;GOVE&quot;.
    /// </summary>
    [EnumMember(Value = "GOVE")]
    [IsoId("_g9bYpAOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of obligations issued by a government.")]
    Government,
    
    /// <summary>
    /// Identifies categories of loans.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_g9bYqgOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of loans.")]
    Loan,
    
    /// <summary>
    /// Identifies categories of short-term debt securities maturing in less than one year.
    /// Encoded/decoded by serializers as &quot;MOMA&quot;.
    /// </summary>
    [EnumMember(Value = "MOMA")]
    [IsoId("_g9bYqwOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of short-term debt securities maturing in less than one year.")]
    MoneyMarket,
    
    /// <summary>
    /// Identifies categories of mortgage securities.
    /// Encoded/decoded by serializers as &quot;MORT&quot;.
    /// </summary>
    [EnumMember(Value = "MORT")]
    [IsoId("_g9bYqQOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of mortgage securities.")]
    Mortgage,
    
    /// <summary>
    /// Identifies categories of securities issued by states and local governments.
    /// Encoded/decoded by serializers as &quot;MUNI&quot;.
    /// </summary>
    [EnumMember(Value = "MUNI")]
    [IsoId("_g9bYrAOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of securities issued by states and local governments.")]
    Municipal,
    
    /// <summary>
    /// Identifies categories of financing instruments.
    /// Encoded/decoded by serializers as &quot;FINA&quot;.
    /// </summary>
    [EnumMember(Value = "FINA")]
    [IsoId("_g9bYpwOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of financing instruments.")]
    Financing,
    
    /// <summary>
    /// The asset type is property.
    /// Encoded/decoded by serializers as &quot;PROP&quot;.
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_g9bYogOEEeWs3sTa9Sj6Lg")]
    [Description(@"The asset type is property.")]
    Property,
    
    /// <summary>
    /// The asset type is a swap.
    /// Encoded/decoded by serializers as &quot;SWAP&quot;.
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_g9bYpQOEEeWs3sTa9Sj6Lg")]
    [Description(@"The asset type is a swap.")]
    Swap,
    
    /// <summary>
    /// Other asset type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_g9bYowOEEeWs3sTa9Sj6Lg")]
    [Description(@"Other asset type.")]
    Other,
    
    /// <summary>
    /// Identifies categories of instruments that are interest rates based.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_m3wpAAOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of instruments that are interest rates based.")]
    InterestRate,
    
    /// <summary>
    /// Identifies categories of instruments that are credits.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_uuxBgAOEEeWs3sTa9Sj6Lg")]
    [Description(@"Identifies categories of instruments that are credits.")]
    Credit,
    
    /// <summary>
    /// Identifies categories of instruments related to Emission Allowance.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_FUiLoGlDEeaLAKoEUNsD9g")]
    [Description(@"Identifies categories of instruments related to Emission Allowance.")]
    EmissionAllowance,
    
    /// <summary>
    /// The asset type is bond.
    /// Encoded/decoded by serializers as &quot;BOND&quot;.
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_S7x6kDXvEemdWfjs3tykFQ")]
    [Description(@"The asset type is bond.")]
    Bond,
    
    /// <summary>
    /// The asset type is cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_fNm4kDXvEemdWfjs3tykFQ")]
    [Description(@"The asset type is cash.")]
    Cash,
    
    /// <summary>
    /// Asset type is sovereign.
    /// Encoded/decoded by serializers as &quot;SVGN&quot;.
    /// </summary>
    [EnumMember(Value = "SVGN")]
    [IsoId("_qxLCYDXvEemdWfjs3tykFQ")]
    [Description(@"Asset type is sovereign.")]
    Sovereign,
    
}
