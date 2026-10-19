// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Funding Service3.
/// </summary>
[IsoId("_LlFl0XHAEe60F8I8TAMKmg")]
[DisplayName("Funding Service3")]
public partial record FundingService3
{
    /// <summary>
    /// Provider.
    /// </summary>
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    public Max35Text? Provider { get; init; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public Max35Text? Name { get; init; }

    /// <summary>
    /// Reference.
    /// </summary>
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public Max35Text? Reference { get; init; }

    /// <summary>
    /// Business Purpose.
    /// </summary>
    [DisplayName("Business Purpose")]
    [IsoXmlTag("BizPurp")]
    public Max500Text? BusinessPurpose { get; init; }

    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public Max256Text? Description { get; init; }

    /// <summary>
    /// Funding Source.
    /// </summary>
    [DisplayName("Funding Source")]
    [IsoXmlTag("FndgSrc")]
    public ValueList<FundingSource4> FundingSource { get; init; } = [];

    /// <summary>
    /// Claim Credentials.
    /// </summary>
    [DisplayName("Claim Credentials")]
    [IsoXmlTag("ClmCrdntls")]
    public Max500Text? ClaimCredentials { get; init; }

    /// <summary>
    /// Claim Assigner.
    /// </summary>
    [DisplayName("Claim Assigner")]
    [IsoXmlTag("ClmAssgnr")]
    public Max35Text? ClaimAssigner { get; init; }
}
