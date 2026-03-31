// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of an individual terminal management action performed by the point of interaction.
/// </summary>
[IsoId("_gSsvsY3gEeW32YMP0mBeyw")]
[DisplayName("TMS Event")]
public record TMSEvent4
{
    /// <summary>
    /// Date time of the terminal management action performed by the point of interaction.
    /// </summary>
    [IsoId("_gexc0Y3gEeW32YMP0mBeyw")]
    [DisplayName("Time Stamp")]
    [IsoXmlTag("TmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TimeStamp { get; init; }

    /// <summary>
    /// Final result of the processed terminal management action.
    /// </summary>
    [IsoId("_gexc043gEeW32YMP0mBeyw")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required TerminalManagementActionResult1Code Result { get; init; }

    /// <summary>
    /// Identification of the terminal management action performed by the point of interaction.
    /// </summary>
    [IsoId("_gexc1Y3gEeW32YMP0mBeyw")]
    [DisplayName("Action Identification")]
    [IsoXmlTag("ActnId")]
    public required TMSActionIdentification4 ActionIdentification { get; init; }

    /// <summary>
    /// Additional information related to a failure.
    /// </summary>
    [IsoId("_gexc143gEeW32YMP0mBeyw")]
    [DisplayName("Additional Error Information")]
    [IsoXmlTag("AddtlErrInf")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AdditionalErrorInformation { get; init; }
}
