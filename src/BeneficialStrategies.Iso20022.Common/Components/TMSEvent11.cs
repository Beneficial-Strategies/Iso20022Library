// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// TMS Event11.
/// </summary>
[IsoId("_eeuUEZLXEe6-zvj9Dw-ctg")]
[DisplayName("TMS Event11")]
public record TMSEvent11
{
    /// <summary>
    /// Time Stamp.
    /// </summary>
    [DisplayName("Time Stamp")]
    [IsoXmlTag("TmStmp")]
    public required ISODateTime TimeStamp { get; init; }

    /// <summary>
    /// Result.
    /// </summary>
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required TerminalManagementActionResult5Code Result { get; init; }

    /// <summary>
    /// Action Identification.
    /// </summary>
    [DisplayName("Action Identification")]
    [IsoXmlTag("ActnId")]
    public required TMSActionIdentification9 ActionIdentification { get; init; }

    /// <summary>
    /// Additional Error Information.
    /// </summary>
    [DisplayName("Additional Error Information")]
    [IsoXmlTag("AddtlErrInf")]
    public Max70Text? AdditionalErrorInformation { get; init; }

    /// <summary>
    /// Terminal Manager Identification.
    /// </summary>
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public Max35Text? TerminalManagerIdentification { get; init; }

    /// <summary>
    /// Device Response.
    /// </summary>
    [DisplayName("Device Response")]
    [IsoXmlTag("DvcRspn")]
    public DeviceResponse7? DeviceResponse { get; init; }
}
