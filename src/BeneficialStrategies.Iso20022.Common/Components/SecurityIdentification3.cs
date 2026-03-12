// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security by its symbol.
/// </summary>
[IsoId("_QdiOk9p-Ed-ak6NoX_4Aeg_2006961788")]
[DisplayName("Security Identification")]
public partial record SecurityIdentification3
{
    #nullable enable
    
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    [IsoId("_QdiOlNp-Ed-ak6NoX_4Aeg_2006961823")]
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    [IsoSimpleType(IsoSimpleType.ISINIdentifier)]
    public required IsoISINIdentifier ISIN { get; init; } 
    
    /// <summary>
    /// Letters that identify a stock traded on a stock exchange. The Ticker Symbol is a short and convenient way of identifying a stock, eg, RTR.L for Reuters quoted in London.
    /// </summary>
    [IsoId("_QdiOldp-Ed-ak6NoX_4Aeg_2007881872")]
    [DisplayName("Ticker Symbol")]
    [IsoXmlTag("TckrSymb")]
    [IsoSimpleType(IsoSimpleType.TickerIdentifier)]
    public IsoTickerIdentifier? TickerSymbol { get; init; } 
    
    /// <summary>
    /// Committee on Uniform Securities and Identification Procedures (CUSIP). The standards body that created and maintains the securities classification system in the US. The CUSIP is composed of a 9-character number that uniquely identifies a particular security. Non-US securities have a similar number called the CINS number.
    /// </summary>
    [IsoId("_QdiOltp-Ed-ak6NoX_4Aeg_2007881992")]
    [DisplayName("CUSIP")]
    [IsoXmlTag("CUSIP")]
    [IsoSimpleType(IsoSimpleType.CUSIPIdentifier)]
    public IsoCUSIPIdentifier? CUSIP { get; init; } 
    
    /// <summary>
    /// Stock Exchange Daily Official List (SEDOL) number. A code used by the London Stock Exchange to identify foreign stocks, especially those that aren&apos;t actively traded in the US and don&apos;t have a CUSIP number.
    /// </summary>
    [IsoId("_QdiOl9p-Ed-ak6NoX_4Aeg_2007882027")]
    [DisplayName("SEDOL")]
    [IsoXmlTag("SEDOL")]
    [IsoSimpleType(IsoSimpleType.SEDOLIdentifier)]
    public IsoSEDOLIdentifier? SEDOL { get; init; } 
    
    /// <summary>
    /// Identifier of a security assigned by the Japanese QUICK identification scheme for financial instruments.
    /// </summary>
    [IsoId("_QdiOmNp-Ed-ak6NoX_4Aeg_2007882069")]
    [DisplayName("QUICK")]
    [IsoXmlTag("QUICK")]
    [IsoSimpleType(IsoSimpleType.QUICKIdentifier)]
    public IsoQUICKIdentifier? QUICK { get; init; } 
    
    /// <summary>
    /// Proprietary identification of a security assigned by an institution or organisation.
    /// </summary>
    [IsoId("_QdiOmdp-Ed-ak6NoX_4Aeg_2007882827")]
    [DisplayName("Other Identification")]
    [IsoXmlTag("OthrId")]
    public AlternateFinancialInstrumentIdentification1? OtherIdentification { get; init; } 
    
    
    #nullable disable
    
}
