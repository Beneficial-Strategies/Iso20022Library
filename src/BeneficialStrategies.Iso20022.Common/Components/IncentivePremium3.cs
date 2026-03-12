// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash premium made available if the securities holder consents or participates to an event.
/// </summary>
[IsoId("_TjIGidp-Ed-ak6NoX_4Aeg_590255137")]
[DisplayName("Incentive Premium")]
public partial record IncentivePremium3
{
    #nullable enable
    
    /// <summary>
    /// Description of the premium.
    /// </summary>
    [IsoId("_TjIGitp-Ed-ak6NoX_4Aeg_590255168")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? Description { get; init; } 
    
    /// <summary>
    /// Cash premium paid per security, per vote or per attendee.
    /// </summary>
    [IsoId("_TjIGi9p-Ed-ak6NoX_4Aeg_590255198")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required PriceRateOrAmountChoice_ Amount { get; init; } 
    
    /// <summary>
    /// Type of incentive premium.
    /// </summary>
    [IsoId("_TjIGjNp-Ed-ak6NoX_4Aeg_590255477")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required IncentivePremiumType1Choice_ Type { get; init; } 
    
    /// <summary>
    /// Date/time for the payment of the premium.
    /// </summary>
    [IsoId("_TjIGjdp-Ed-ak6NoX_4Aeg_591175570")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public DateFormat3Choice_? PaymentDate { get; init; } 
    
    
    #nullable disable
    
}
