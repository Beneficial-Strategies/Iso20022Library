// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
[IsoId("_vdmqUZEKEem-9Y6mq5ZH3Q")]
[DisplayName("Fees")]
public record Fees2
{
    /// <summary>
    /// Reference to the agreement established between the fund and another party. This element, amongst others, defines the conditions of the commissions.
    /// </summary>
    [IsoId("_vyvM05EKEem-9Y6mq5ZH3Q")]
    [DisplayName("Commercial Agreement Reference")]
    [IsoXmlTag("ComrclAgrmtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CommercialAgreementReference { get; init; }

    /// <summary>
    /// Individual fee (charge/commission).
    /// </summary>
    [IsoId("_vyvM1ZEKEem-9Y6mq5ZH3Q")]
    [DisplayName("Individual Fee")]
    [IsoXmlTag("IndvFee")]
    public ValueList<Fee7> IndividualFee { get; init; } = [];
}
