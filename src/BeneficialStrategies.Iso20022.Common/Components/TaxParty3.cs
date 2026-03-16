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
[IsoId("_SknWoAEcEeCQm6a_G2yO_w_-837981111")]
[DisplayName("Tax Party")]
public record TaxParty3
{
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    [IsoId("_SknWoQEcEeCQm6a_G2yO_w_1225150116")]
    [DisplayName("Tax Identification")]
    [IsoXmlTag("TaxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TaxIdentification { get; init; }

    /// <summary>
    /// Type of tax payer.
    /// </summary>
    [IsoId("_SknWogEcEeCQm6a_G2yO_w_1724761612")]
    [DisplayName("Tax Type")]
    [IsoXmlTag("TaxTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TaxType { get; init; }

    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_SknWowEcEeCQm6a_G2yO_w_1665746426")]
    [DisplayName("Registration Identification")]
    [IsoXmlTag("RegnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RegistrationIdentification { get; init; }

    /// <summary>
    /// Specification of the tax exemption reason.
    /// </summary>
    [IsoId("_SknWpAEcEeCQm6a_G2yO_w_377116311")]
    [DisplayName("Tax Exemption Reason")]
    [IsoXmlTag("TaxXmptnRsn")]
    public TaxExemptionReasonFormatChoice_? TaxExemptionReason { get; init; }
}
