// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of an individual terminal management action by the point of interaction.
/// </summary>
[IsoId("_npFHYY3gEeW32YMP0mBeyw")]
[DisplayName("TMS Action Identification")]
public record TMSActionIdentification4
{
    /// <summary>
    /// Types of terminal management action performed by a point of interaction.
    /// </summary>
    [IsoId("_nzzwsY3gEeW32YMP0mBeyw")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction2Code ActionType { get; init; }

    /// <summary>
    /// Data set on which the action has been performed.
    /// </summary>
    [IsoId("_nzzws43gEeW32YMP0mBeyw")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public DataSetIdentification6? DataSetIdentification { get; init; }
}
