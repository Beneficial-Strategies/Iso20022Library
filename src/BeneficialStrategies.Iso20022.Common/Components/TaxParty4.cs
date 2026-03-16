// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details about the entity involved in the tax paid or to be paid.
/// </summary>
[IsoId("_4GUQge5oEemXBpiFxCCWFQ")]
[DisplayName("Tax Party")]
public record TaxParty4
{
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    [IsoId("_4V-dIe5oEemXBpiFxCCWFQ")]
    [DisplayName("Tax Identification")]
    [IsoXmlTag("TaxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TaxIdentification { get; init; }

    /// <summary>
    /// Type of tax payer.
    /// </summary>
    [IsoId("_4V-dI-5oEemXBpiFxCCWFQ")]
    [DisplayName("Tax Type")]
    [IsoXmlTag("TaxTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TaxType { get; init; }

    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_4V-dJe5oEemXBpiFxCCWFQ")]
    [DisplayName("Registration Identification")]
    [IsoXmlTag("RegnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RegistrationIdentification { get; init; }

    /// <summary>
    /// Specification of the tax exemption reason.
    /// </summary>
    [IsoId("_4V-dJ-5oEemXBpiFxCCWFQ")]
    [DisplayName("Tax Exemption Reason")]
    [IsoXmlTag("TaxXmptnRsn")]
    public TaxExemptionReasonFormat1Choice_? TaxExemptionReason { get; init; }
}
