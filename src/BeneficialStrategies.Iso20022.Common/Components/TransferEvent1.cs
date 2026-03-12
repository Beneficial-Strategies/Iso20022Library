// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about code and number of event of fund transfer.
/// </summary>
[IsoId("_9JE20Cc7Eea7avjfd7yDAA")]
[DisplayName("Transfer Event")]
public partial record TransferEvent1
{
    #nullable enable
    
    /// <summary>
    /// Code of fund transfer event.
    /// </summary>
    [IsoId("_Mmm70Cc8Eea7avjfd7yDAA")]
    [DisplayName("Event Code")]
    [IsoXmlTag("EvtCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public required IsoMax4Text EventCode { get; init; } 
    
    /// <summary>
    /// Event number related to the event code.
    /// </summary>
    [IsoId("_ReAIkCc8Eea7avjfd7yDAA")]
    [DisplayName("Event Number")]
    [IsoXmlTag("EvtNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? EventNumber { get; init; } 
    
    
    #nullable disable
    
}
