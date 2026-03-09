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
/// Details of a payment instruction. The information contained in this component is sufficient to retrieve a payment instruction.
/// </summary>
[IsoId("_VQgOUtp-Ed-ak6NoX_4Aeg_-769020295")]
[DisplayName("Payment Instruction Extract")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentInstructionExtract
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the payment instruction (eg, field 20 of an MT 103) when meaningful to the case assigner.
    /// </summary>
    [IsoId("_VQgOU9p-Ed-ak6NoX_4Aeg_56776664")]
    [DisplayName("Assigner Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssgnrInstrId")]
    #endif
    [IsoXmlTag("AssgnrInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AssignerInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AssignerInstructionIdentification { get; init; } 
    #else
    public System.String? AssignerInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the payment instruction (eg, field 20 of an MT 103) when meaningful to the case assignee.
    /// </summary>
    [IsoId("_VQgOVNp-Ed-ak6NoX_4Aeg_585203601")]
    [DisplayName("Assignee Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssgneInstrId")]
    #endif
    [IsoXmlTag("AssgneInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AssigneeInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AssigneeInstructionIdentification { get; init; } 
    #else
    public System.String? AssigneeInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the payment. Depending on the context it can be either the amount settled (UnableToApply) or the instructed amount (RequestToCancel, RequestToModify, ClaimNonReceipt).
    /// </summary>
    [IsoId("_VQgOVdp-Ed-ak6NoX_4Aeg_-745398050")]
    [DisplayName("Currency Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyAmt")]
    #endif
    [IsoXmlTag("CcyAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? CurrencyAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? CurrencyAmount { get; init; } 
    #else
    public CurrencyAndAmount? CurrencyAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Value date of the payment.
    /// </summary>
    [IsoId("_VQgOVtp-Ed-ak6NoX_4Aeg_-659512363")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ValueDate { get; init; } 
    #else
    public System.DateTime? ValueDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
