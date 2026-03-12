// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies coprorate action dates.
/// </summary>
[IsoId("_TfQTJNp-Ed-ak6NoX_4Aeg_901406419")]
[DisplayName("Corporate Action Date")]
public partial record CorporateActionDate3
{
    #nullable enable
    
    /// <summary>
    /// Date/time at which the distribution is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_TfQTJdp-Ed-ak6NoX_4Aeg_93344284")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public DateFormat4Choice_? PaymentDate { get; init; } 
    
    /// <summary>
    /// Date/time at which securities become available for sale.
    /// </summary>
    [IsoId("_TfQTJtp-Ed-ak6NoX_4Aeg_-1737531965")]
    [DisplayName("Available Date")]
    [IsoXmlTag("AvlblDt")]
    public DateFormat4Choice_? AvailableDate { get; init; } 
    
    /// <summary>
    /// Date/time at which a security will be entitled to a dividend.
    /// </summary>
    [IsoId("_TfQTJ9p-Ed-ak6NoX_4Aeg_1745390082")]
    [DisplayName("Dividend Ranking Date")]
    [IsoXmlTag("DvddRnkgDt")]
    public DateFormat4Choice_? DividendRankingDate { get; init; } 
    
    /// <summary>
    /// Date on which security will assimilate, become fungible, or have the same rights to dividends as the parent issue.
    /// </summary>
    [IsoId("_TfQTKNp-Ed-ak6NoX_4Aeg_538944912")]
    [DisplayName("Pari Passu Date")]
    [IsoXmlTag("PrpssDt")]
    public DateFormat4Choice_? PariPassuDate { get; init; } 
    
    /// <summary>
    /// Date/time at which new securities begin trading.
    /// </summary>
    [IsoId("_TfQTKdp-Ed-ak6NoX_4Aeg_-1737531873")]
    [DisplayName("First Dealing Date")]
    [IsoXmlTag("FrstDealgDt")]
    public DateFormat4Choice_? FirstDealingDate { get; init; } 
    
    /// <summary>
    /// Date/time at which a payment can be made, eg, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_TfaEINp-Ed-ak6NoX_4Aeg_21312129")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateFormat4Choice_? EarliestPaymentDate { get; init; } 
    
    
    #nullable disable
    
}
