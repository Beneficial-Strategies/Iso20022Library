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
/// Breakdown of unallocated cash transactions.
/// </summary>
[IsoId("_BZLHQZEtEeajS_7NioJdVA")]
[DisplayName("Corporate Action Unallocated Cash Transaction Details SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionUnallocatedCashTransactionDetailsSD5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionUnallocatedCashTransactionDetailsSD5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionUnallocatedCashTransactionDetailsSD5( CreditDebitCode reqCreditDebitIndicator )
    {
        CreditDebitIndicator = reqCreditDebitIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    [IsoId("_BxuKIZEtEeajS_7NioJdVA")]
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
    /// Transaction reason.
    /// </summary>
    [IsoId("_BxuKKZEtEeajS_7NioJdVA")]
    [DisplayName("Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsnCd")]
    #endif
    [IsoXmlTag("RsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCAdjustmentPaymentType3Code? ReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCAdjustmentPaymentType3Code? ReasonCode { get; init; } 
    #else
    public DTCAdjustmentPaymentType3Code? ReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Resulting cash amount concerned in this transaction.
    /// </summary>
    [IsoId("_BxuKMZEtEeajS_7NioJdVA")]
    [DisplayName("Transaction Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxAmt")]
    #endif
    [IsoXmlTag("TxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? TransactionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? TransactionAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? TransactionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for the unallocation.
    /// </summary>
    [IsoId("_BxuKOZEtEeajS_7NioJdVA")]
    [DisplayName("Unallocated Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UallctdRsnCd")]
    #endif
    [IsoXmlTag("UallctdRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCUnallocatedAdjustmentReason3Code? UnallocatedReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCUnallocatedAdjustmentReason3Code? UnallocatedReasonCode { get; init; } 
    #else
    public DTCUnallocatedAdjustmentReason3Code? UnallocatedReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction contra participant identification when shares are distributed / delivered to / from another participant.
    /// </summary>
    [IsoId("_BxuKQZEtEeajS_7NioJdVA")]
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
    [IsoId("_BxuKSZEtEeajS_7NioJdVA")]
    [DisplayName("Earliest Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlstPmtDt")]
    #endif
    [IsoXmlTag("EarlstPmtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat28Choice_? EarliestPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat28Choice_? EarliestPaymentDate { get; init; } 
    #else
    public DateFormat28Choice_? EarliestPaymentDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
