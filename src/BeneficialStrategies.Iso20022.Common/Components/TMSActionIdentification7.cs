// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of an individual terminal management action by the point of interaction.
/// </summary>
[IsoId("_ELZQYSi0Eeurkfo6MpvKDA")]
[DisplayName("TMS Action Identification")]
public partial record TMSActionIdentification7
{
    #nullable enable
    
    /// <summary>
    /// Types of terminal management action performed by a point of interaction.
    /// </summary>
    [IsoId("_EZbFUSi0Eeurkfo6MpvKDA")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction5Code ActionType { get; init; } 
    
    /// <summary>
    /// Data set on which the action has been performed.
    /// </summary>
    [IsoId("_EZbFUyi0Eeurkfo6MpvKDA")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public DataSetIdentification8? DataSetIdentification { get; init; } 
    
    
    #nullable disable
    
}
