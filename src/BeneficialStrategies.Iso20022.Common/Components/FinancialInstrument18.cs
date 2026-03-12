// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
/// </summary>
[IsoId("_SdiXeNp-Ed-ak6NoX_4Aeg_-1800133123")]
[DisplayName("Financial Instrument")]
public partial record FinancialInstrument18
{
    #nullable enable
    
    /// <summary>
    /// Identification of a security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_SdiXedp-Ed-ak6NoX_4Aeg_-1800133121")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification9 Identification { get; init; } 
    
    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_SdiXetp-Ed-ak6NoX_4Aeg_-1800133062")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; } 
    
    /// <summary>
    /// Date that identifies the issue of a fund series. It is typically applicable to a redemption order, subscription order confirmation or redemption order confirmation, but may be specified in the subscription order, if known.
    /// </summary>
    [IsoId("_SdsIcNp-Ed-ak6NoX_4Aeg_-798661529")]
    [DisplayName("Series Issue Identification Date")]
    [IsoXmlTag("SrsIsseIdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SeriesIssueIdentificationDate { get; init; } 
    
    /// <summary>
    /// Identifies the name of a fund series. It is typically applicable to a redemption order, subscription order confirmation or redemption order confirmation, but may be specified in the subscription, if known.
    /// </summary>
    [IsoId("_SdsIcdp-Ed-ak6NoX_4Aeg_971691708")]
    [DisplayName("Series Name")]
    [IsoXmlTag("SrsNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SeriesName { get; init; } 
    
    /// <summary>
    /// Indicates that the financial instrument and/or series included in the message is a new issue.
    /// </summary>
    [IsoId("_SdsIctp-Ed-ak6NoX_4Aeg_-2097762260")]
    [DisplayName("New Issue Indicator")]
    [IsoXmlTag("NewIsseInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NewIssueIndicator { get; init; } 
    
    /// <summary>
    /// Additional information about a financial instrument to help identify the instrument.
    /// </summary>
    [IsoId("_SdsIc9p-Ed-ak6NoX_4Aeg_-1800133031")]
    [DisplayName("Supplementary Identification")]
    [IsoXmlTag("SplmtryId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SupplementaryIdentification { get; init; } 
    
    
    #nullable disable
    
}
