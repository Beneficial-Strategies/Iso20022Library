// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains information related to benefit (healthcare, employee benefit, etc.)
/// </summary>
[IsoId("_LarakCq-EfCD0_iZ8tw-zA")]
[DisplayName("Benefit Supporting Data1")]
public record BenefitSupportingData1
{
    /// <summary>
    /// Identification of the benefit administrator.
    /// </summary>
    [IsoId("_8TjN8Cq-EfCD0_iZ8tw-zA")]
    [DisplayName("Administrator Identification")]
    [IsoXmlTag("AdmstrId")]
    public IsoMax35Text? AdministratorIdentification { get; init; }

    /// <summary>
    /// The defined standard code for healthcare treatment or service type related to the benefit.
    /// </summary>
    [IsoId("_RjUXUCq_EfCD0_iZ8tw-zA")]
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public IsoMax35Text? ServiceType { get; init; }

    /// <summary>
    /// Identification of the health insurance provider.
    /// </summary>
    [IsoId("_t-nTQCq_EfCD0_iZ8tw-zA")]
    [DisplayName("Provider Identification")]
    [IsoXmlTag("PrvdrId")]
    public IsoMax35Text? ProviderIdentification { get; init; }

    /// <summary>
    /// Contains the reason of approval or declines of benefit eligibility inquiry.
    /// </summary>
    [IsoId("_9g-08Cq_EfCD0_iZ8tw-zA")]
    [DisplayName("Decision Reason")]
    [IsoXmlTag("DcsnRsn")]
    public IsoMax35Text? DecisionReason { get; init; }
}
