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
[IsoId("_afK4O-FhEeWIA4E9cYSxxQ")]
[DisplayName("Request Details")]
public partial record RequestDetails17
{
    #nullable enable
    
    /// <summary>
    /// References of the transaction for which the intra-balance modification is requested.
    /// </summary>
    [IsoId("_aoP7peFhEeWIA4E9cYSxxQ")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References14 Reference { get; init; } 
    
    /// <summary>
    /// Specifies the type of linkage requested.
    /// </summary>
    [IsoId("_aoP7reFhEeWIA4E9cYSxxQ")]
    [DisplayName("Linkage")]
    [IsoXmlTag("Lkg")]
    public LinkageType3Choice_? Linkage { get; init; } 
    
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_aoP7teFhEeWIA4E9cYSxxQ")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric4Choice_? Priority { get; init; } 
    
    /// <summary>
    /// Specifies another type of processing change request.
    /// </summary>
    [IsoId("_aoP7veFhEeWIA4E9cYSxxQ")]
    [DisplayName("Other Processing")]
    [IsoXmlTag("OthrPrcg")]
    public GenericIdentification30? OtherProcessing { get; init; } 
    
    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("_aoP7xeFhEeWIA4E9cYSxxQ")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PartialSettlementIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the clearing channel to be used to process the payment instruction.
    /// </summary>
    [IsoId("_aoP7zeFhEeWIA4E9cYSxxQ")]
    [DisplayName("Clearing Channel")]
    [IsoXmlTag("ClrChanl")]
    public ClearingChannel2Code? ClearingChannel { get; init; } 
    
    /// <summary>
    /// Information regarding the linkage requested.
    /// </summary>
    [IsoId("_aoP71eFhEeWIA4E9cYSxxQ")]
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public Linkages51? Linkages { get; init; } 
    
    
    #nullable disable
    
}
