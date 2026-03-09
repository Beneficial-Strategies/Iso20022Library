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
/// Specifies the conditions for the execution of the payment.
/// </summary>
[IsoId("_BmRRkHVjEeiEU7thYTAN1w")]
[DisplayName("Payment Condition")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentCondition1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentCondition1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentCondition1( System.String reqAmountModificationAllowed,System.String reqEarlyPaymentAllowed,System.String reqGuaranteedPaymentRequested )
    {
        AmountModificationAllowed = reqAmountModificationAllowed;
        EarlyPaymentAllowed = reqEarlyPaymentAllowed;
        GuaranteedPaymentRequested = reqGuaranteedPaymentRequested;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates if the debtor is allowed to pay a different amount then the requested amount.
    /// </summary>
    [IsoId("_zg-VYHVjEeiEU7thYTAN1w")]
    [DisplayName("Amount Modification Allowed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtModAllwd")]
    #endif
    [IsoXmlTag("AmtModAllwd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator AmountModificationAllowed { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AmountModificationAllowed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AmountModificationAllowed { get; init; } 
    #else
    public System.String AmountModificationAllowed { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the debtor is allowed to pay before the requested execution date.
    /// </summary>
    [IsoId("_3QRRoXVjEeiEU7thYTAN1w")]
    [DisplayName("Early Payment Allowed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlyPmtAllwd")]
    #endif
    [IsoXmlTag("EarlyPmtAllwd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator EarlyPaymentAllowed { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String EarlyPaymentAllowed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String EarlyPaymentAllowed { get; init; } 
    #else
    public System.String EarlyPaymentAllowed { get; set; } 
    #endif
    
    /// <summary>
    /// Penalty to be applied for a delayed payment, that is when the payment is made after the requested execution date.
    /// </summary>
    [IsoId("_YiSE4HVkEeiEU7thYTAN1w")]
    [DisplayName("Delay Penalty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DelyPnlty")]
    #endif
    [IsoXmlTag("DelyPnlty")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? DelayPenalty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DelayPenalty { get; init; } 
    #else
    public System.String? DelayPenalty { get; set; } 
    #endif
    
    /// <summary>
    /// Discount rate applied for immediate payment upon receipt of the request.
    /// </summary>
    [IsoId("_jw1A8HVkEeiEU7thYTAN1w")]
    [DisplayName("Immediate Payment Rebate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ImdtPmtRbt")]
    #endif
    [IsoXmlTag("ImdtPmtRbt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountOrRate1Choice_? ImmediatePaymentRebate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountOrRate1Choice_? ImmediatePaymentRebate { get; init; } 
    #else
    public AmountOrRate1Choice_? ImmediatePaymentRebate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if a payment guarantee is requested, assuming a payment guarantee contract exists between the different actors.
    /// </summary>
    [IsoId("_-63wYHVkEeiEU7thYTAN1w")]
    [DisplayName("Guaranteed Payment Requested")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrntedPmtReqd")]
    #endif
    [IsoXmlTag("GrntedPmtReqd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator GuaranteedPaymentRequested { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String GuaranteedPaymentRequested { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String GuaranteedPaymentRequested { get; init; } 
    #else
    public System.String GuaranteedPaymentRequested { get; set; } 
    #endif
    
    
    #nullable disable
    
}
