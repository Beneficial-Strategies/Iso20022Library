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
[IsoId("_YkHdASi0Eeurkfo6MpvKDA")]
[DisplayName("TMS Event")]
public record TMSEvent8
{
    /// <summary>
    /// Date time of the terminal management action performed by the point of interaction.
    /// </summary>
    [IsoId("_YykvwSi0Eeurkfo6MpvKDA")]
    [DisplayName("Time Stamp")]
    [IsoXmlTag("TmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TimeStamp { get; init; }

    /// <summary>
    /// Final result of the processed terminal management action.
    /// </summary>
    [IsoId("_YylW0Si0Eeurkfo6MpvKDA")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required TerminalManagementActionResult4Code Result { get; init; }

    /// <summary>
    /// Identification of the terminal management action performed by the point of interaction.
    /// </summary>
    [IsoId("_YylW0yi0Eeurkfo6MpvKDA")]
    [DisplayName("Action Identification")]
    [IsoXmlTag("ActnId")]
    public required TMSActionIdentification7 ActionIdentification { get; init; }

    /// <summary>
    /// Additional information related to a failure.
    /// </summary>
    [IsoId("_YylW1Si0Eeurkfo6MpvKDA")]
    [DisplayName("Additional Error Information")]
    [IsoXmlTag("AddtlErrInf")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AdditionalErrorInformation { get; init; }

    /// <summary>
    /// Identification of the terminal management system (TMS) used with the action.
    /// </summary>
    [IsoId("_YylW1yi0Eeurkfo6MpvKDA")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TerminalManagerIdentification { get; init; }

    /// <summary>
    /// Response  of a device request done previously.
    /// </summary>
    [IsoId("_Bk7uACjAEeurkfo6MpvKDA")]
    [DisplayName("Device Response")]
    [IsoXmlTag("DvcRspn")]
    public DeviceResponse4? DeviceResponse { get; init; }
}
