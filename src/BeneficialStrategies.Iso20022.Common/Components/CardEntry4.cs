// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card transaction entry.
/// </summary>
[IsoId("_UU_vYXh1EeidzqjNEfehPg")]
[DisplayName("Card Entry")]
public partial record CardEntry4
{
    #nullable enable
    
    /// <summary>
    /// Electronic money product that provides the cardholder with a portable and specialised computer device, which typically contains a microprocessor.
    /// </summary>
    [IsoId("_UkPsUXh1EeidzqjNEfehPg")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard4? Card { get; init; } 
    
    /// <summary>
    /// Physical or logical card payment terminal containing software and hardware components.
    /// </summary>
    [IsoId("_UkPsU3h1EeidzqjNEfehPg")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public PointOfInteraction1? POI { get; init; } 
    
    /// <summary>
    /// Card entry details, based on card transaction aggregated data performed by the account servicer.
    /// </summary>
    [IsoId("_UkPsVXh1EeidzqjNEfehPg")]
    [DisplayName("Aggregated Entry")]
    [IsoXmlTag("AggtdNtry")]
    public CardAggregated2? AggregatedEntry { get; init; } 
    
    /// <summary>
    /// Prepaid account for the transfer or loading of an amount of money.
    /// </summary>
    [IsoId("_UkPsV3h1EeidzqjNEfehPg")]
    [DisplayName("Pre Paid Account")]
    [IsoXmlTag("PrePdAcct")]
    public CashAccount38? PrePaidAccount { get; init; } 
    
    
    #nullable disable
    
}
