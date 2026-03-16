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
[IsoId("_5gyqATVYEeKdge4xeUaMrg")]
[DisplayName("TMS Event")]
public record TMSEvent2
{
    /// <summary>
    /// Date time of the terminal management action performed by the point of interaction.
    /// </summary>
    [IsoId("_5qmtUTVYEeKdge4xeUaMrg")]
    [DisplayName("Time Stamp")]
    [IsoXmlTag("TmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TimeStamp { get; init; }

    /// <summary>
    /// Final result of the processed terminal management action.
    /// </summary>
    [IsoId("_5qmtVTVYEeKdge4xeUaMrg")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required TerminalManagementActionResult1Code Result { get; init; }

    /// <summary>
    /// Identification of the terminal management action performed by the point of interaction.
    /// </summary>
    [IsoId("_5qmtWTVYEeKdge4xeUaMrg")]
    [DisplayName("Action Identification")]
    [IsoXmlTag("ActnId")]
    public required TMSActionIdentification2 ActionIdentification { get; init; }

    /// <summary>
    /// Additional information related to a failure.
    /// </summary>
    [IsoId("_5qmtXTVYEeKdge4xeUaMrg")]
    [DisplayName("Additional Error Information")]
    [IsoXmlTag("AddtlErrInf")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AdditionalErrorInformation { get; init; }
}
