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
/// Information about code and number of event of fund transfer.
/// </summary>
[IsoId("_9JE20Cc7Eea7avjfd7yDAA")]
[DisplayName("Transfer Event")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransferEvent1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransferEvent1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransferEvent1( System.String reqEventCode )
    {
        EventCode = reqEventCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Code of fund transfer event.
    /// </summary>
    [IsoId("_Mmm70Cc8Eea7avjfd7yDAA")]
    [DisplayName("Event Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtCd")]
    #endif
    [IsoXmlTag("EvtCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax4Text EventCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String EventCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String EventCode { get; init; } 
    #else
    public System.String EventCode { get; set; } 
    #endif
    
    /// <summary>
    /// Event number related to the event code.
    /// </summary>
    [IsoId("_ReAIkCc8Eea7avjfd7yDAA")]
    [DisplayName("Event Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtNb")]
    #endif
    [IsoXmlTag("EvtNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? EventNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EventNumber { get; init; } 
    #else
    public System.String? EventNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
