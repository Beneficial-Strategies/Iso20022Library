// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide information on the status reason of the record.
/// </summary>
[IsoId("_9gw7W248EeiU9cctagi5ow")]
[DisplayName("Validation Status Reason")]
public record ValidationStatusReason2
{
    /// <summary>
    /// Party that issues the status.
    /// </summary>
    [IsoId("_9rC4tW48EeiU9cctagi5ow")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification135? Originator { get; init; }

    /// <summary>
    /// Specifies the reason for the status.
    /// </summary>
    [IsoId("_9rC4t248EeiU9cctagi5ow")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public StatusReason6Choice_? Reason { get; init; }

    /// <summary>
    /// Provides details about the rule which could not be validated.
    /// </summary>
    [IsoId("_9rC4uW48EeiU9cctagi5ow")]
    [DisplayName("Validation Rule")]
    [IsoXmlTag("VldtnRule")]
    public ValueList<GenericValidationRuleIdentification1> ValidationRule { get; init; } = [];

    /// <summary>
    /// Further details on the status reason.||Usage: Additional information can be used for several purposes such as the reporting of repaired information.
    /// </summary>
    [IsoId("_9rC4u248EeiU9cctagi5ow")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
