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
/// Environment of the transaction.
/// </summary>
[IsoId("_Gj-mcXu6EeSLmfFG0DG7zQ")]
[DisplayName("Card Transaction Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardTransactionEnvironment5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardTransactionEnvironment5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardTransactionEnvironment5( GenericIdentification73 reqSendingInstitution,GenericIdentification73 reqReceivingInstitution,GenericIdentification73 reqSettlementInstitution )
    {
        SendingInstitution = reqSendingInstitution;
        ReceivingInstitution = reqReceivingInstitution;
        SettlementInstitution = reqSettlementInstitution;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Institution initiator of the reconciliation.
    /// It corresponds to the ISO 8583 field number 94.
    /// </summary>
    [IsoId("_UJ0xEHu6EeSLmfFG0DG7zQ")]
    [DisplayName("Sending Institution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndgInstn")]
    #endif
    [IsoXmlTag("SndgInstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification73 SendingInstitution { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification73 SendingInstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification73 SendingInstitution { get; init; } 
    #else
    public GenericIdentification73 SendingInstitution { get; set; } 
    #endif
    
    /// <summary>
    /// Institution destination of the reconciliation.
    /// It corresponds to the ISO 8583 field number 93.
    /// </summary>
    [IsoId("_eIpKoHu6EeSLmfFG0DG7zQ")]
    [DisplayName("Receiving Institution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgInstn")]
    #endif
    [IsoXmlTag("RcvgInstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification73 ReceivingInstitution { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification73 ReceivingInstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification73 ReceivingInstitution { get; init; } 
    #else
    public GenericIdentification73 ReceivingInstitution { get; set; } 
    #endif
    
    /// <summary>
    /// Institution in charge of the settlement of the transaction.
    /// </summary>
    [IsoId("_kcNacHu6EeSLmfFG0DG7zQ")]
    [DisplayName("Settlement Institution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmInstn")]
    #endif
    [IsoXmlTag("SttlmInstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification73 SettlementInstitution { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification73 SettlementInstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification73 SettlementInstitution { get; init; } 
    #else
    public GenericIdentification73 SettlementInstitution { get; set; } 
    #endif
    
    
    #nullable disable
    
}
