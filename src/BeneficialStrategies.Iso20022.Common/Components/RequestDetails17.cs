// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the request providing the changes and references of the instruction.
/// </summary>
[IsoId("_afK4O-FhEeWIA4E9cYSxxQ")]
[DisplayName("Request Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequestDetails17
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RequestDetails17 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequestDetails17( References14 reqReference )
    {
        Reference = reqReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// References of the transaction for which the intra-balance modification is requested.
    /// </summary>
    [IsoId("_aoP7peFhEeWIA4E9cYSxxQ")]
    [DisplayName("Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ref")]
    #endif
    [IsoXmlTag("Ref")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required References14 Reference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required References14 Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public References14 Reference { get; init; } 
    #else
    public References14 Reference { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of linkage requested.
    /// </summary>
    [IsoId("_aoP7reFhEeWIA4E9cYSxxQ")]
    [DisplayName("Linkage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lkg")]
    #endif
    [IsoXmlTag("Lkg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LinkageType3Choice_? Linkage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LinkageType3Choice_? Linkage { get; init; } 
    #else
    public LinkageType3Choice_? Linkage { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_aoP7teFhEeWIA4E9cYSxxQ")]
    [DisplayName("Priority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prty")]
    #endif
    [IsoXmlTag("Prty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriorityNumeric4Choice_? Priority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriorityNumeric4Choice_? Priority { get; init; } 
    #else
    public PriorityNumeric4Choice_? Priority { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies another type of processing change request.
    /// </summary>
    [IsoId("_aoP7veFhEeWIA4E9cYSxxQ")]
    [DisplayName("Other Processing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPrcg")]
    #endif
    [IsoXmlTag("OthrPrcg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification30? OtherProcessing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification30? OtherProcessing { get; init; } 
    #else
    public GenericIdentification30? OtherProcessing { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("_aoP7xeFhEeWIA4E9cYSxxQ")]
    [DisplayName("Partial Settlement Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlSttlmInd")]
    #endif
    [IsoXmlTag("PrtlSttlmInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PartialSettlementIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PartialSettlementIndicator { get; init; } 
    #else
    public System.String? PartialSettlementIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the clearing channel to be used to process the payment instruction.
    /// </summary>
    [IsoId("_aoP7zeFhEeWIA4E9cYSxxQ")]
    [DisplayName("Clearing Channel")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrChanl")]
    #endif
    [IsoXmlTag("ClrChanl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingChannel2Code? ClearingChannel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingChannel2Code? ClearingChannel { get; init; } 
    #else
    public ClearingChannel2Code? ClearingChannel { get; set; } 
    #endif
    
    /// <summary>
    /// Information regarding the linkage requested.
    /// </summary>
    [IsoId("_aoP71eFhEeWIA4E9cYSxxQ")]
    [DisplayName("Linkages")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lnkgs")]
    #endif
    [IsoXmlTag("Lnkgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Linkages51? Linkages { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Linkages51? Linkages { get; init; } 
    #else
    public Linkages51? Linkages { get; set; } 
    #endif
    
    
    #nullable disable
    
}
