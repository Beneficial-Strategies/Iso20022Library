// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Taxable service charge amount conversions to host currency.
/// </summary>
[IsoId("_6QP-p5qlEeGSON8vddiWzQ_460369359")]
[DisplayName("Billing Services Amount")]
public record BillingServicesAmount2
{
    /// <summary>
    /// Sum of the original charge host amount and the service tax host amount values. It represents the total charge for a service (including taxes) expressed in the host currency.
    /// </summary>
    [IsoId("_6QP-qJqlEeGSON8vddiWzQ_-1570575712")]
    [DisplayName("Host Amount")]
    [IsoXmlTag("HstAmt")]
    public required AmountAndDirection34 HostAmount { get; init; }

    /// <summary>
    /// Sum of the original charge host amount and the service tax host amount values but expressed in the settlement currency.
    /// </summary>
    [IsoId("_6QZvoJqlEeGSON8vddiWzQ_-536702994")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public AmountAndDirection34? SettlementAmount { get; init; }

    /// <summary>
    /// Sum of the original charge host amount and the service tax host amount values but expressed in the pricing currency.
    /// </summary>
    [IsoId("_6QZvoZqlEeGSON8vddiWzQ_1108564441")]
    [DisplayName("Pricing Amount")]
    [IsoXmlTag("PricgAmt")]
    public AmountAndDirection34? PricingAmount { get; init; }
}
