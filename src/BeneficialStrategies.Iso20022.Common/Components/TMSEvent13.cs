// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Event on a terminal management system.
/// </summary>
[IsoId("_PMKpAbYEEfCUZfsQO4rYeA")]
[DisplayName("TMS Event13")]
public record TMSEvent13
{
    /// <summary>
    /// Date time of the terminal management action performed by the point of interaction.
    /// </summary>
    [IsoId("_PMKpAbYEEfCUZfsQO4rYeA-tms")]
    [DisplayName("Time Stamp")]
    [IsoXmlTag("TmStmp")]
    public required IsoISODateTime TimeStamp { get; init; }

    /// <summary>
    /// Final result of the processed terminal management action.
    /// </summary>
    [IsoId("_PMKpAbYEEfCUZfsQO4rYeA-res")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required TerminalManagementActionResult5Code Result { get; init; }

    /// <summary>
    /// Identification of the terminal management action performed by the point of interaction.
    /// </summary>
    [IsoId("_PMKpAbYEEfCUZfsQO4rYeA-aid")]
    [DisplayName("Action Identification")]
    [IsoXmlTag("ActnId")]
    public required TMSActionIdentification10 ActionIdentification { get; init; }

    /// <summary>
    /// Additional information related to a failure.
    /// </summary>
    [IsoId("_PMKpAbYEEfCUZfsQO4rYeA-aer")]
    [DisplayName("Additional Error Information")]
    [IsoXmlTag("AddtlErrInf")]
    public IsoMax70Text? AdditionalErrorInformation { get; init; }

    /// <summary>
    /// Identification of the terminal management system (TMS) used with the action.
    /// </summary>
    [IsoId("_PMKpAbYEEfCUZfsQO4rYeA-tmid")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TrmnlMgrId")]
    public IsoMax35Text? TerminalManagerIdentification { get; init; }

    /// <summary>
    /// Response of a device request done previously.
    /// </summary>
    [IsoId("_PMKpAbYEEfCUZfsQO4rYeA-dvrp")]
    [DisplayName("Device Response")]
    [IsoXmlTag("DvcRspn")]
    public DeviceResponse9? DeviceResponse { get; init; }
}
