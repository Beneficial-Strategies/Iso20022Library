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
[IsoId("_wZOj8bQZEeeKRKrD60ELBQ")]
[DisplayName("Corporate Action Date")]
public partial record CorporateActionDate65
{
    #nullable enable
    
    /// <summary>
    /// Date/time of the posting (credit or debit) to the account.
    /// </summary>
    [IsoId("_wp1LwbQZEeeKRKrD60ELBQ")]
    [DisplayName("Posting Date")]
    [IsoXmlTag("PstngDt")]
    public required DateAndDateTime2Choice_ PostingDate { get; init; } 
    
    /// <summary>
    /// Date/time when calculating economic benefit for a cash amount.
    /// </summary>
    [IsoId("_wp1LybQZEeeKRKrD60ELBQ")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTime2Choice_? ValueDate { get; init; } 
    
    /// <summary>
    /// Date/time at which a foreign exchange rate will be determined.
    /// </summary>
    [IsoId("_wp1L0bQZEeeKRKrD60ELBQ")]
    [DisplayName("Foreign Exchange Rate Fixing Date")]
    [IsoXmlTag("FXRateFxgDt")]
    public DateAndDateTime2Choice_? ForeignExchangeRateFixingDate { get; init; } 
    
    /// <summary>
    /// Date/time on which a payment can be made, for example, if the payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_wp1L2bQZEeeKRKrD60ELBQ")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateAndDateTime2Choice_? EarliestPaymentDate { get; init; } 
    
    /// <summary>
    /// Date on which the distribution is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_wp1L4bQZEeeKRKrD60ELBQ")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public DateAndDateTime2Choice_? PaymentDate { get; init; } 
    
    
    #nullable disable
    
}
