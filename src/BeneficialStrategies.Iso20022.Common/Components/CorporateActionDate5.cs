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
[IsoId("_TfjOFNp-Ed-ak6NoX_4Aeg_1806455399")]
[DisplayName("Corporate Action Date")]
public partial record CorporateActionDate5
{
    #nullable enable
    
    /// <summary>
    /// Date/time at which a foreign exchange rate will be determined.
    /// </summary>
    [IsoId("_TfjOFdp-Ed-ak6NoX_4Aeg_1920050127")]
    [DisplayName("Foreign Exchange Rate Fixing Date")]
    [IsoXmlTag("FXRateFxgDt")]
    public DateFormat4Choice_? ForeignExchangeRateFixingDate { get; init; } 
    
    /// <summary>
    /// Date/time at which assets become available to the account owner (in a credit entry), or cease to be available to the account owner (in a debit entry).
    /// </summary>
    [IsoId("_TfjOFtp-Ed-ak6NoX_4Aeg_-1783188999")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateFormat4Choice_? ValueDate { get; init; } 
    
    /// <summary>
    /// Date/time at which the distribution is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_TfjOF9p-Ed-ak6NoX_4Aeg_104425986")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public DateFormat4Choice_? PaymentDate { get; init; } 
    
    /// <summary>
    /// Date/time at which a payment can be made, eg, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_TfjOGNp-Ed-ak6NoX_4Aeg_-19325862")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateFormat4Choice_? EarliestPaymentDate { get; init; } 
    
    
    #nullable disable
    
}
