// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// TMS Action Identification10.
/// </summary>
[IsoId("_T_rQYZ9nEe-nbM0aSPcoiQ")]
[DisplayName("TMS Action Identification10")]
public record TMSActionIdentification10
{
    /// <summary>
    /// Action Type.
    /// </summary>
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction5Code ActionType { get; init; }

    /// <summary>
    /// Data Set Identification.
    /// </summary>
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public DataSetIdentification11? DataSetIdentification { get; init; }
}
