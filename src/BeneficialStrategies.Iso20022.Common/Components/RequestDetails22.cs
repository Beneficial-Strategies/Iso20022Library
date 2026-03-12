// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the request providing the changes and references of the instruction.
/// </summary>
[IsoId("_ZCu2lzneEem7JZMuWtwtsg")]
[DisplayName("Request Details")]
public partial record RequestDetails22
{
    #nullable enable
    
    /// <summary>
    /// References of the transaction for which the intra-balance modification is requested.
    /// </summary>
    [IsoId("_ZMt4lTneEem7JZMuWtwtsg")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References14 Reference { get; init; } 
    
    /// <summary>
    /// Specifies the type of linkage requested.
    /// </summary>
    [IsoId("_ZMt4nTneEem7JZMuWtwtsg")]
    [DisplayName("Linkage")]
    [IsoXmlTag("Lkg")]
    public LinkageType3Choice_? Linkage { get; init; } 
    
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_ZMt4pTneEem7JZMuWtwtsg")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric4Choice_? Priority { get; init; } 
    
    /// <summary>
    /// Specifies another type of processing change request.
    /// </summary>
    [IsoId("_ZMt4rTneEem7JZMuWtwtsg")]
    [DisplayName("Other Processing")]
    [IsoXmlTag("OthrPrcg")]
    public GenericIdentification30? OtherProcessing { get; init; } 
    
    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("_ZMt4tTneEem7JZMuWtwtsg")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PartialSettlementIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the clearing channel to be used to process the payment instruction.
    /// </summary>
    [IsoId("_ZMt4vTneEem7JZMuWtwtsg")]
    [DisplayName("Clearing Channel")]
    [IsoXmlTag("ClrChanl")]
    public ClearingChannel2Code? ClearingChannel { get; init; } 
    
    /// <summary>
    /// Information regarding the linkage requested.
    /// </summary>
    [IsoId("_ZMt4xTneEem7JZMuWtwtsg")]
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public Linkages57? Linkages { get; init; } 
    
    
    #nullable disable
    
}
