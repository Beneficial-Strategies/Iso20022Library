// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate action option information for the custodian record.
/// </summary>
[IsoId("_1TqvATL3EeKU9IrkkToqcw_1383220652")]
[DisplayName("Custodian Option Date Details SD")]
public record CustodianOptionDateDetailsSD1
{
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1TqvAjL3EeKU9IrkkToqcw_-1902659123")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; }

    /// <summary>
    /// Custodian deadline date for the option instructions. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1TqvAzL3EeKU9IrkkToqcw_-26617381")]
    [DisplayName("Agent Deadline Date")]
    [IsoXmlTag("AgtDdlnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? AgentDeadlineDate { get; init; }

    /// <summary>
    /// Custodian deadline time for the option instructions. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1TqvBDL3EeKU9IrkkToqcw_-744742048")]
    [DisplayName("Agent Deadline Time")]
    [IsoXmlTag("AgtDdlnTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? AgentDeadlineTime { get; init; }
}
