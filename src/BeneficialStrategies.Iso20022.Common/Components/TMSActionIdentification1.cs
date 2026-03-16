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
[IsoId("_KsN72X1DEeCF8NjrBemJWQ_-230191666")]
[DisplayName("TMS Action Identification")]
public record TMSActionIdentification1
{
    /// <summary>
    /// Types of terminal management action performed by a point of interaction.
    /// </summary>
    [IsoId("_KsXs0H1DEeCF8NjrBemJWQ_-626855899")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction1Code ActionType { get; init; }

    /// <summary>
    /// Data set on which the action has been performed.
    /// </summary>
    [IsoId("_KsXs0X1DEeCF8NjrBemJWQ_-1959099550")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public DataSetIdentification2? DataSetIdentification { get; init; }
}
