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
/// Choice of the intra-balance movement status type.
/// </summary>
[IsoId("_WygsIeFUEeWIA4E9cYSxxQ")]
[DisplayName("Intra Balance Status And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraBalanceStatusAndReason2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [IsoId("_W7IckeFUEeWIA4E9cYSxxQ")]
    [DisplayName("Processing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgSts")]
    #endif
    [IsoXmlTag("PrcgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingStatus67Choice_? ProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingStatus67Choice_? ProcessingStatus { get; init; } 
    #else
    public ProcessingStatus67Choice_? ProcessingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the settlement status of a transaction.
    /// </summary>
    [IsoId("_W7Ick-FUEeWIA4E9cYSxxQ")]
    [DisplayName("Settlement Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSts")]
    #endif
    [IsoXmlTag("SttlmSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementStatus16Choice_? SettlementStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementStatus16Choice_? SettlementStatus { get; init; } 
    #else
    public SettlementStatus16Choice_? SettlementStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the state or the condition.
    /// </summary>
    [IsoId("_W7IcleFUEeWIA4E9cYSxxQ")]
    [DisplayName("Settled")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sttld")]
    #endif
    [IsoXmlTag("Sttld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProprietaryReason4? Settled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProprietaryReason4? Settled { get; init; } 
    #else
    public ProprietaryReason4? Settled { get; set; } 
    #endif
    
    
    #nullable disable
    
}
