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
/// Specifies the details on the status of the payment conditions.
/// </summary>
[IsoId("_IGiOt3VlEeiEU7thYTAN1w")]
[DisplayName("Payment Condition Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentConditionStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentConditionStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentConditionStatus1( System.String reqGuaranteedPayment,System.String reqEarlyPayment )
    {
        GuaranteedPayment = reqGuaranteedPayment;
        EarlyPayment = reqEarlyPayment;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount accepted to be paid.
    /// Usage:
    /// May only be present when AmountModificationAllowed is present in the request.
    /// </summary>
    [IsoId("_p7y48HVlEeiEU7thYTAN1w")]
    [DisplayName("Accepted Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptdAmt")]
    #endif
    [IsoXmlTag("AccptdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? AcceptedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? AcceptedAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? AcceptedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the DebtorAgent guarantees the payment, assuming a payment guarantee contract exists between the different actors.
    /// </summary>
    [IsoId("_IGiOvXVlEeiEU7thYTAN1w")]
    [DisplayName("Guaranteed Payment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrntedPmt")]
    #endif
    [IsoXmlTag("GrntedPmt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator GuaranteedPayment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String GuaranteedPayment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String GuaranteedPayment { get; init; } 
    #else
    public System.String GuaranteedPayment { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the debtor will pay before the requested execution date.
    /// </summary>
    [IsoId("_IGiOuHVlEeiEU7thYTAN1w")]
    [DisplayName("Early Payment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlyPmt")]
    #endif
    [IsoXmlTag("EarlyPmt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator EarlyPayment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String EarlyPayment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String EarlyPayment { get; init; } 
    #else
    public System.String EarlyPayment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
