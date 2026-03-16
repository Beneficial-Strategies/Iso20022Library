// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Order attached to a pension.
/// </summary>
[IsoId("_HAPJcLTpEeiENt6AoDfPXg")]
[DisplayName("Pension Order")]
public record PensionOrder1
{
    /// <summary>
    /// Order attached to the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_PU2D8LTpEeiENt6AoDfPXg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required PensionOrderType1Choice_ Type { get; init; }

    /// <summary>
    /// Additional information about the pension order.
    /// </summary>
    [IsoId("_4z8_ALTqEeiENt6AoDfPXg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
