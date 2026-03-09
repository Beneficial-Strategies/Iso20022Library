// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security by its symbol.
/// </summary>
[IsoId("_QdiOk9p-Ed-ak6NoX_4Aeg_2006961788")]
[DisplayName("Security Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityIdentification3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecurityIdentification3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecurityIdentification3( System.String reqISIN )
    {
        ISIN = reqISIN;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    [IsoId("_QdiOlNp-Ed-ak6NoX_4Aeg_2006961823")]
    [DisplayName("ISIN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ISIN")]
    #endif
    [IsoXmlTag("ISIN")]
    [IsoSimpleType(IsoSimpleType.ISINIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISINIdentifier ISIN { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ISIN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ISIN { get; init; } 
    #else
    public System.String ISIN { get; set; } 
    #endif
    
    /// <summary>
    /// Letters that identify a stock traded on a stock exchange. The Ticker Symbol is a short and convenient way of identifying a stock, eg, RTR.L for Reuters quoted in London.
    /// </summary>
    [IsoId("_QdiOldp-Ed-ak6NoX_4Aeg_2007881872")]
    [DisplayName("Ticker Symbol")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TckrSymb")]
    #endif
    [IsoXmlTag("TckrSymb")]
    [IsoSimpleType(IsoSimpleType.TickerIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTickerIdentifier? TickerSymbol { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TickerSymbol { get; init; } 
    #else
    public System.String? TickerSymbol { get; set; } 
    #endif
    
    /// <summary>
    /// Committee on Uniform Securities and Identification Procedures (CUSIP). The standards body that created and maintains the securities classification system in the US. The CUSIP is composed of a 9-character number that uniquely identifies a particular security. Non-US securities have a similar number called the CINS number.
    /// </summary>
    [IsoId("_QdiOltp-Ed-ak6NoX_4Aeg_2007881992")]
    [DisplayName("CUSIP")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CUSIP")]
    #endif
    [IsoXmlTag("CUSIP")]
    [IsoSimpleType(IsoSimpleType.CUSIPIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoCUSIPIdentifier? CUSIP { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CUSIP { get; init; } 
    #else
    public System.String? CUSIP { get; set; } 
    #endif
    
    /// <summary>
    /// Stock Exchange Daily Official List (SEDOL) number. A code used by the London Stock Exchange to identify foreign stocks, especially those that aren&apos;t actively traded in the US and don&apos;t have a CUSIP number.
    /// </summary>
    [IsoId("_QdiOl9p-Ed-ak6NoX_4Aeg_2007882027")]
    [DisplayName("SEDOL")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SEDOL")]
    #endif
    [IsoXmlTag("SEDOL")]
    [IsoSimpleType(IsoSimpleType.SEDOLIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoSEDOLIdentifier? SEDOL { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SEDOL { get; init; } 
    #else
    public System.String? SEDOL { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier of a security assigned by the Japanese QUICK identification scheme for financial instruments.
    /// </summary>
    [IsoId("_QdiOmNp-Ed-ak6NoX_4Aeg_2007882069")]
    [DisplayName("QUICK")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QUICK")]
    #endif
    [IsoXmlTag("QUICK")]
    [IsoSimpleType(IsoSimpleType.QUICKIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoQUICKIdentifier? QUICK { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? QUICK { get; init; } 
    #else
    public System.String? QUICK { get; set; } 
    #endif
    
    /// <summary>
    /// Proprietary identification of a security assigned by an institution or organisation.
    /// </summary>
    [IsoId("_QdiOmdp-Ed-ak6NoX_4Aeg_2007882827")]
    [DisplayName("Other Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrId")]
    #endif
    [IsoXmlTag("OthrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AlternateFinancialInstrumentIdentification1? OtherIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AlternateFinancialInstrumentIdentification1? OtherIdentification { get; init; } 
    #else
    public AlternateFinancialInstrumentIdentification1? OtherIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
