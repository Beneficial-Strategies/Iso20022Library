// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Billing Tax Identification3.
/// </summary>
[IsoId("_YgExIzE_Ee62xuUQ2zyZww")]
[DisplayName("Billing Tax Identification3")]
public record BillingTaxIdentification3
{
    /// <summary>
    /// Tax Contact.
    /// </summary>
    [DisplayName("Tax Contact")]
    [IsoXmlTag("TaxCtct")]
    public Contact13? TaxContact { get; init; }

    /// <summary>
    /// Tax Registration Number.
    /// </summary>
    [DisplayName("Tax Registration Number")]
    [IsoXmlTag("TaxRegnNb")]
    public IsoMax35Text? TaxRegistrationNumber { get; init; }

    /// <summary>
    /// VAT Registration Number.
    /// </summary>
    [DisplayName("VAT Registration Number")]
    [IsoXmlTag("VATRegnNb")]
    public IsoMax35Text? VATRegistrationNumber { get; init; }
}
