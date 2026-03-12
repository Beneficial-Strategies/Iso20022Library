// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Taxable service charge amount conversions to host currency.
/// </summary>
[IsoId("_6QP-pJqlEeGSON8vddiWzQ_1984361507")]
[DisplayName("Billing Services Amount")]
public partial record BillingServicesAmount1
{
    #nullable enable
    
    /// <summary>
    /// Sum of all the individual taxes on the service expressed in the host currency.
    /// </summary>
    [IsoId("_6QP-pZqlEeGSON8vddiWzQ_-123622265")]
    [DisplayName("Host Amount")]
    [IsoXmlTag("HstAmt")]
    public required AmountAndDirection34 HostAmount { get; init; } 
    
    /// <summary>
    /// Amount of the tax obligation expressed in the tax region&apos;s pricing currency.|Usage: This is the same amount as carried in the host amount but allows the sender to optionally express the value in the pricing currency.
    /// </summary>
    [IsoId("_6QP-ppqlEeGSON8vddiWzQ_-1662410707")]
    [DisplayName("Pricing Amount")]
    [IsoXmlTag("PricgAmt")]
    public AmountAndDirection34? PricingAmount { get; init; } 
    
    
    #nullable disable
    
}
