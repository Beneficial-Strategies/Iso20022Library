// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed description of the differences.
/// </summary>
[IsoId("_Ra7q8dp-Ed-ak6NoX_4Aeg_-1034400483")]
[DisplayName("Validation Result")]
public record ValidationResult5
{
    /// <summary>
    /// Sequential number assigned to the mismatch.
    /// </summary>
    [IsoId("_Ra7q8tp-Ed-ak6NoX_4Aeg_-1034400369")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber SequenceNumber { get; init; }

    /// <summary>
    /// Coded identification of the matching rule that is violated.
    /// </summary>
    [IsoId("_Ra7q89p-Ed-ak6NoX_4Aeg_-1034400461")]
    [DisplayName("Rule Identification")]
    [IsoXmlTag("RuleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text RuleIdentification { get; init; }

    /// <summary>
    /// Detailed description of the rule.
    /// </summary>
    [IsoId("_Ra7q9Np-Ed-ak6NoX_4Aeg_-1034400430")]
    [DisplayName("Rule Description")]
    [IsoXmlTag("RuleDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text RuleDescription { get; init; }

    /// <summary>
    /// Description of the element that creates the mismatch.
    /// </summary>
    [IsoId("_Ra7q9dp-Ed-ak6NoX_4Aeg_-1034400306")]
    [DisplayName("Mis Matched Element")]
    [IsoXmlTag("MisMtchdElmt")]
    public ElementIdentification1? MisMatchedElement { get; init; }
}
