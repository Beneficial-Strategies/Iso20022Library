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
/// Reference and status information concerning the original transactions, included in the original instruction, to which the reversal message applies.
/// </summary>
[IsoId("_Pr6kbtp-Ed-ak6NoX_4Aeg_2146802204")]
[DisplayName("Payment Transaction Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTransactionInformation4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification as assigned by an instructing party for an instructed party to unambiguously identify the reversed transaction.
    /// </summary>
    [IsoId("_PsEVYNp-Ed-ak6NoX_4Aeg_2146802222")]
    [DisplayName("Reversal Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvslId")]
    #endif
    [IsoXmlTag("RvslId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReversalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReversalIdentification { get; init; } 
    #else
    public System.String? ReversalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of the original payment information block as assigned by the original sending party.
    /// </summary>
    [IsoId("_PsEVYdp-Ed-ak6NoX_4Aeg_2146802256")]
    [DisplayName("Original Payment Information Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlPmtInfId")]
    #endif
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalPaymentInformationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalPaymentInformationIdentification { get; init; } 
    #else
    public System.String? OriginalPaymentInformationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Original unique instruction identification as assigned by an instructing party for an instructed party to unambiguously identify the original instruction.||Usage: the original instruction identification is the original point to point reference used between the instructing party and the instructed party to refer to the original instruction.
    /// </summary>
    [IsoId("_PsEVYtp-Ed-ak6NoX_4Aeg_2146802516")]
    [DisplayName("Original Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlInstrId")]
    #endif
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalInstructionIdentification { get; init; } 
    #else
    public System.String? OriginalInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Original unique identification assigned by the initiating party to unambiguously identify the original transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.
    /// </summary>
    [IsoId("_PsEVY9p-Ed-ak6NoX_4Aeg_2146802533")]
    [DisplayName("Original End To End Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlEndToEndId")]
    #endif
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalEndToEndIdentification { get; init; } 
    #else
    public System.String? OriginalEndToEndIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be moved between the debtor and the creditor, before deduction of charges, expressed in the currency as ordered by the initiating party in the original transaction.
    /// </summary>
    [IsoId("_PsEVZNp-Ed-ak6NoX_4Aeg_1381325256")]
    [DisplayName("Original Instructed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlInstdAmt")]
    #endif
    [IsoXmlTag("OrgnlInstdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? OriginalInstructedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? OriginalInstructedAmount { get; init; } 
    #else
    public CurrencyAndAmount? OriginalInstructedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be moved between the debtor and the creditor, before deduction of charges, in the reversed transaction.
    /// </summary>
    [IsoId("_PsEVZdp-Ed-ak6NoX_4Aeg_2146802593")]
    [DisplayName("Reversed Instructed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvsdInstdAmt")]
    #endif
    [IsoXmlTag("RvsdInstdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? ReversedInstructedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? ReversedInstructedAmount { get; init; } 
    #else
    public CurrencyAndAmount? ReversedInstructedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the creditor and/or debtor will bear the charges associated with the processing of the payment transaction.||Usage: The ChargeBearer applies to the reversal message, not to the original instruction.
    /// </summary>
    [IsoId("_PsEVZtp-Ed-ak6NoX_4Aeg_-2147244601")]
    [DisplayName("Charge Bearer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgBr")]
    #endif
    [IsoXmlTag("ChrgBr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    #else
    public ChargeBearerType1Code? ChargeBearer { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information on the reversal reason.
    /// </summary>
    [IsoId("_PsEVZ9p-Ed-ak6NoX_4Aeg_-2147244463")]
    [DisplayName("Reversal Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvslRsnInf")]
    #endif
    [IsoXmlTag("RvslRsnInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReversalReasonInformation1? ReversalReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReversalReasonInformation1? ReversalReasonInformation { get; init; } 
    #else
    public ReversalReasonInformation1? ReversalReasonInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Set of key elements of the original transaction being referred to.
    /// </summary>
    [IsoId("_PsEVaNp-Ed-ak6NoX_4Aeg_-2147244048")]
    [DisplayName("Original Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlTxRef")]
    #endif
    [IsoXmlTag("OrgnlTxRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalTransactionReference1? OriginalTransactionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalTransactionReference1? OriginalTransactionReference { get; init; } 
    #else
    public OriginalTransactionReference1? OriginalTransactionReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
