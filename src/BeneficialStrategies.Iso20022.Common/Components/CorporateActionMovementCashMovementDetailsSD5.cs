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
/// Provides additional information regarding corporate action movement details.
/// </summary>
[IsoId("_0_1QUb5ZEeexmbB7KsjCwA")]
[DisplayName("Corporate Action Movement Cash Movement Details SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionMovementCashMovementDetailsSD5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionMovementCashMovementDetailsSD5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionMovementCashMovementDetailsSD5( CreditDebitCode reqCreditDebitIndicator,DTCCPayoutType5Code reqPayoutType )
    {
        CreditDebitIndicator = reqCreditDebitIndicator;
        PayoutType = reqPayoutType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_1R4Ckb5ZEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    [IsoId("_1R4Ck75ZEeexmbB7KsjCwA")]
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
    /// Specifies the type of payout associated with the event (for example: principal, long term capital gain).
    /// </summary>
    [IsoId("_1R4Cm75ZEeexmbB7KsjCwA")]
    [DisplayName("Payout Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PyoutTp")]
    #endif
    [IsoXmlTag("PyoutTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DTCCPayoutType5Code PayoutType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DTCCPayoutType5Code PayoutType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCCPayoutType5Code PayoutType { get; init; } 
    #else
    public DTCCPayoutType5Code PayoutType { get; set; } 
    #endif
    
    /// <summary>
    /// Resulting cash amount concerned in this transaction.
    /// </summary>
    [IsoId("_1R4Cnb5ZEeexmbB7KsjCwA")]
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
    /// Transaction reason.
    /// </summary>
    [IsoId("_1R4Cpb5ZEeexmbB7KsjCwA")]
    [DisplayName("Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsnCd")]
    #endif
    [IsoXmlTag("RsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCAdjustmentPaymentType4Code? ReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCAdjustmentPaymentType4Code? ReasonCode { get; init; } 
    #else
    public DTCAdjustmentPaymentType4Code? ReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction sub reason.
    /// </summary>
    [IsoId("_1R4Crb5ZEeexmbB7KsjCwA")]
    [DisplayName("Sub Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubRsnCd")]
    #endif
    [IsoXmlTag("SubRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCAdjustmentPaymentSubReason2Code? SubReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCAdjustmentPaymentSubReason2Code? SubReasonCode { get; init; } 
    #else
    public DTCAdjustmentPaymentSubReason2Code? SubReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction contra participant identification when shares are distributed / delivered to / from another participant.
    /// </summary>
    [IsoId("_1R4Cr75ZEeexmbB7KsjCwA")]
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
    /// Date/Time on which the posting / draft of cash is scheduled to take place for a transaction.
    /// </summary>
    [IsoId("_1R4Ct75ZEeexmbB7KsjCwA")]
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
    
    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy CCF records. The element will be populated to all levels of the message (event details, options, movements) where applicable to indicate how values are sourced from CCF legacy files. For example: event has 2 related activity types 74, and 54. If event details and cash option are sourced from the activity type 74, then activity type 74 will be in RDP reference number in event details, and also on the cash option. The activity type 54 will be &quot;on&quot; the security option. Also, usage rules will specify the different layouts of the RDP reference number based on DTCC event group (reorganization, distribution, or redemption).
    /// </summary>
    [IsoId("_1R4Cv75ZEeexmbB7KsjCwA")]
    [DisplayName("RDP Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RDPRefNb")]
    #endif
    [IsoXmlTag("RDPRefNb")]
    [IsoSimpleType(IsoSimpleType.Exact32AlphaNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RDPReferenceNumber { get; init; } 
    #else
    public System.String? RDPReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Set of the DTC legacy sub reason codes representing tax rate. Used with reason codes ‘TJXD’ ‘TJXF’ ‘TJXI’ ‘TJXL’ ‘TJXR’ ‘TJXT’ ‘TJXU’ to identify the correct tax rate.
    /// </summary>
    [IsoId("_1R4Cwb5ZEeexmbB7KsjCwA")]
    [DisplayName("Tax Adjustment Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxAdjstmntRate")]
    #endif
    [IsoXmlTag("TaxAdjstmntRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? TaxAdjustmentRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxAdjustmentRate { get; init; } 
    #else
    public System.Decimal? TaxAdjustmentRate { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity used on adjustment transactions which when summed across all extension movements equals the relevant balance in the core message. For example, a summation of loan and borrow movements when summed which is negative will show the net total in the borrow balance in the core message. While a summation of loan and borrow movements which is positive will show in the loan balance.
    /// </summary>
    [IsoId("_ytRWsL_sEeeb2ZBoAlSG1Q")]
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
    
    
    #nullable disable
    
}
