// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action dates.
/// </summary>
[IsoId("_YXgdp199Ee262vCSVgjImg")]
[DisplayName("Corporate Action Date")]
public partial record CorporateActionDate97
{
    #nullable enable
    
    /// <summary>
    /// Date/time on which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_YXgdq199Ee262vCSVgjImg")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public required DateFormat41Choice_ PaymentDate { get; init; } 
    
    /// <summary>
    /// Date/time when calculating economic benefit for a cash amount.
    /// </summary>
    [IsoId("_YXgds199Ee262vCSVgjImg")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateFormat64Choice_? ValueDate { get; init; } 
    
    /// <summary>
    /// Date/time at which a foreign exchange rate will be determined.
    /// </summary>
    [IsoId("_YXgdu199Ee262vCSVgjImg")]
    [DisplayName("Foreign Exchange Rate Fixing Date")]
    [IsoXmlTag("FXRateFxgDt")]
    public DateFormat49Choice_? ForeignExchangeRateFixingDate { get; init; } 
    
    /// <summary>
    /// Date/time on which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_YXgdw199Ee262vCSVgjImg")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateFormat41Choice_? EarliestPaymentDate { get; init; } 
    
    
    #nullable disable
    
}
