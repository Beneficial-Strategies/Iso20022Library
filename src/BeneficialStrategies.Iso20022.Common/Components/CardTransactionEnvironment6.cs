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
[IsoId("_hI8j0XvDEeSKFIcWw3l4Yw")]
[DisplayName("Card Transaction Environment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardTransactionEnvironment6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardTransactionEnvironment6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardTransactionEnvironment6( GenericIdentification73 reqSendingInstitution,GenericIdentification73 reqReceivingInstitution )
    {
        SendingInstitution = reqSendingInstitution;
        ReceivingInstitution = reqReceivingInstitution;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Institution initiator of the reconciliation (correspond to the ISO 8583 field 94).
    /// </summary>
    [IsoId("_hV6o0XvDEeSKFIcWw3l4Yw")]
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
    /// Institution destination of the reconciliation (correspond to the ISO 8583 field 93).
    /// </summary>
    [IsoId("_hV6o03vDEeSKFIcWw3l4Yw")]
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
    
    
    #nullable disable
    
}
