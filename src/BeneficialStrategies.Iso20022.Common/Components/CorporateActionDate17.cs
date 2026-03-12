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
[IsoId("_jMBm0_ZFEd-2Jsl2KtUQCw")]
[DisplayName("Corporate Action Date")]
public partial record CorporateActionDate17
{
    #nullable enable
    
    /// <summary>
    /// Date on which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_jMBm1fZFEd-2Jsl2KtUQCw")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public required DateFormat19Choice_ PaymentDate { get; init; } 
    
    /// <summary>
    /// Date at which assets become available to the account owner (in a credit entry), or cease to be available to the account owner (in a debit entry).
    /// </summary>
    [IsoId("_jMBm1_ZFEd-2Jsl2KtUQCw")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateFormat11Choice_? ValueDate { get; init; } 
    
    /// <summary>
    /// Date/time at which a foreign exchange rate will be determined.
    /// </summary>
    [IsoId("_jMBm2fZFEd-2Jsl2KtUQCw")]
    [DisplayName("Foreign Exchange Rate Fixing Date")]
    [IsoXmlTag("FXRateFxgDt")]
    public DateFormat19Choice_? ForeignExchangeRateFixingDate { get; init; } 
    
    /// <summary>
    /// Date on which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_jMBm2_ZFEd-2Jsl2KtUQCw")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateFormat19Choice_? EarliestPaymentDate { get; init; } 
    
    
    #nullable disable
    
}
