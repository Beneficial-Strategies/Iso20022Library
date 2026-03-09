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
/// Instruction to pay an amount of money to an ultimate beneficiary, on behalf of an originator. This instruction may have to be forwarded several times to complete the settlement chain.|.
/// </summary>
[IsoId("_8C5sEKMgEeCJ6YNENx4h-w_-792076459")]
[DisplayName("Payment Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentInstruction3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date at which the initiating party requests that the payment instruction be processed. |.
    /// </summary>
    [IsoId("_8C5sEaMgEeCJ6YNENx4h-w_1832250156")]
    [DisplayName("Requested Execution Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdExctnDtTm")]
    #endif
    [IsoXmlTag("ReqdExctnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? RequestedExecutionDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? RequestedExecutionDateTime { get; init; } 
    #else
    public System.DateTime? RequestedExecutionDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Type, or nature, of the payment, for example an express payment.
    /// </summary>
    [IsoId("_8C5sEqMgEeCJ6YNENx4h-w_1116036764")]
    [DisplayName("Payment Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTp")]
    #endif
    [IsoXmlTag("PmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentType3Choice_? PaymentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentType3Choice_? PaymentType { get; init; } 
    #else
    public PaymentType3Choice_? PaymentType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
