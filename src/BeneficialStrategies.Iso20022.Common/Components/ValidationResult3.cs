// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the error that is the cause of the rejection.
/// </summary>
[IsoId("_RFLdYdp-Ed-ak6NoX_4Aeg_-1930823301")]
[DisplayName("Validation Result")]
public record ValidationResult3
{
    /// <summary>
    /// Sequential number assigned to the error.
    /// </summary>
    [IsoId("_RFLdYtp-Ed-ak6NoX_4Aeg_-1930823223")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber SequenceNumber { get; init; }

    /// <summary>
    /// Coded identification of the rule that is violated by the rejected message.
    /// </summary>
    [IsoId("_RFLdY9p-Ed-ak6NoX_4Aeg_-1930823282")]
    [DisplayName("Rule Identification")]
    [IsoXmlTag("RuleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text RuleIdentification { get; init; }

    /// <summary>
    /// Detailed description of the rule.
    /// </summary>
    [IsoId("_RFLdZNp-Ed-ak6NoX_4Aeg_-1930823266")]
    [DisplayName("Rule Description")]
    [IsoXmlTag("RuleDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text RuleDescription { get; init; }

    /// <summary>
    /// Description of the elements that violated the rule.
    /// </summary>
    [IsoId("_RFLdZdp-Ed-ak6NoX_4Aeg_-1930823205")]
    [DisplayName("Element")]
    [IsoXmlTag("Elmt")]
    public ElementIdentification3? Element { get; init; }
}
