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
/// Breakdown of unallocated securities transactions.
/// </summary>
[IsoId("_t5zBfQ-rEeuE0Pnt-OcNOA")]
[DisplayName("Corporate Action Unallocated Securities Transaction Details SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionUnallocatedSecuritiesTransactionDetailsSD8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionUnallocatedSecuritiesTransactionDetailsSD8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionUnallocatedSecuritiesTransactionDetailsSD8( CreditDebitCode reqCreditDebitIndicator )
    {
        CreditDebitIndicator = reqCreditDebitIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    [IsoId("_uPhZwQ-rEeuE0Pnt-OcNOA")]
    [DisplayName("Credit Debit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbtInd")]
    #endif
    [IsoXmlTag("CdtDbtInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode CreditDebitIndicator { get; init; } 
    #else
    public CreditDebitCode CreditDebitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying the available corporate action option.
    /// </summary>
    [IsoId("__oge1A-rEeuE0Pnt-OcNOA")]
    [DisplayName("Option Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnNb")]
    #endif
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact3NumericText? OptionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OptionNumber { get; init; } 
    #else
    public System.String? OptionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the corporate action option available to the account owner.
    /// </summary>
    [IsoId("_UHqqpA-sEeuE0Pnt-OcNOA")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionOption11Code? OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption11Code? OptionType { get; init; } 
    #else
    public CorporateActionOption11Code? OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction reason.
    /// </summary>
    [IsoId("_uPhZyQ-rEeuE0Pnt-OcNOA")]
    [DisplayName("Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsnCd")]
    #endif
    [IsoXmlTag("RsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCAdjustmentPaymentType5Code? ReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCAdjustmentPaymentType5Code? ReasonCode { get; init; } 
    #else
    public DTCAdjustmentPaymentType5Code? ReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Resulting quantity of securities concerned in this transaction.
    /// </summary>
    [IsoId("_uPhZ0Q-rEeuE0Pnt-OcNOA")]
    [DisplayName("Transaction Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxQty")]
    #endif
    [IsoXmlTag("TxQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? TransactionQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? TransactionQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? TransactionQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for the unallocation.
    /// </summary>
    [IsoId("_uPhZ2Q-rEeuE0Pnt-OcNOA")]
    [DisplayName("Unallocated Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UallctdRsnCd")]
    #endif
    [IsoXmlTag("UallctdRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCUnallocatedAdjustmentReason4Code? UnallocatedReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCUnallocatedAdjustmentReason4Code? UnallocatedReasonCode { get; init; } 
    #else
    public DTCUnallocatedAdjustmentReason4Code? UnallocatedReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction contra participant identification when shares are distributed/delivered to/from another participant.
    /// </summary>
    [IsoId("_uPhZ4Q-rEeuE0Pnt-OcNOA")]
    [DisplayName("Contra Participant Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ContraPtcptNb")]
    #endif
    [IsoXmlTag("ContraPtcptNb")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax8Text? ContraParticipantNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ContraParticipantNumber { get; init; } 
    #else
    public System.String? ContraParticipantNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the movement was due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_uPhZ6Q-rEeuE0Pnt-OcNOA")]
    [DisplayName("Earliest Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlstPmtDt")]
    #endif
    [IsoXmlTag("EarlstPmtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat48Choice_? EarliestPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat48Choice_? EarliestPaymentDate { get; init; } 
    #else
    public DateFormat48Choice_? EarliestPaymentDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
