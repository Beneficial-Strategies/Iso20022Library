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
/// Specifies the elements of an entry in the report.
/// </summary>
[IsoId("_T6000Np-Ed-ak6NoX_4Aeg_-1317508151")]
[DisplayName("Statement Entry")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatementEntry1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatementEntry1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatementEntry1( CurrencyAndAmount reqAmount,CreditDebitCode reqCreditDebitIndicator,EntryStatus3Code reqStatus,BankTransactionCodeStructure1 reqBankTransactionCode )
    {
        Amount = reqAmount;
        CreditDebitIndicator = reqCreditDebitIndicator;
        Status = reqStatus;
        BankTransactionCode = reqBankTransactionCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    [IsoId("_T6000dp-Ed-ak6NoX_4Aeg_-1317508132")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount Amount { get; init; } 
    #else
    public CurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if an entry is a credit or a debit.
    /// </summary>
    [IsoId("_T6000tp-Ed-ak6NoX_4Aeg_-1317508073")]
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
    /// Indicates whether the entry is the result of a reversal operation.||Usage: this element should only be present if the entry is the result of a reversal operation.|If the CreditDebitIndicator is CRDT and ReversalIndicator is Yes, the original operation was a debit entry.|If the CreditDebitIndicator is DBIT and ReversalIndicator is Yes, the original operation was a credit entry.
    /// </summary>
    [IsoId("_T60009p-Ed-ak6NoX_4Aeg_-1317507996")]
    [DisplayName("Reversal Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvslInd")]
    #endif
    [IsoXmlTag("RvslInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ReversalIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReversalIndicator { get; init; } 
    #else
    public System.String? ReversalIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Status of an entry on the books of the account servicer.
    /// </summary>
    [IsoId("_T6001Np-Ed-ak6NoX_4Aeg_-1317507936")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EntryStatus3Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EntryStatus3Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EntryStatus3Code Status { get; init; } 
    #else
    public EntryStatus3Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time when an entry is posted to an account on the account servicer&apos;s books.
    /// </summary>
    [IsoId("_T6001dp-Ed-ak6NoX_4Aeg_-1317506589")]
    [DisplayName("Booking Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BookgDt")]
    #endif
    [IsoXmlTag("BookgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? BookingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? BookingDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? BookingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time assets become available to the account owner (in a credit entry), or cease to be available to the account owner (in a debit entry).||Usage: For entries which are subject to availability/float (and for which availability information is present), value date must not be used, as the availability component identifies the number of availability days.
    /// </summary>
    [IsoId("_T69-wNp-Ed-ak6NoX_4Aeg_-1317506667")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? ValueDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Account servicing institution&apos;s reference for the underlying transaction.
    /// </summary>
    [IsoId("_T69-wdp-Ed-ak6NoX_4Aeg_-1317507624")]
    [DisplayName("Account Servicer Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcrRef")]
    #endif
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountServicerReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountServicerReference { get; init; } 
    #else
    public System.String? AccountServicerReference { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to indicate when the booked funds will become available, ie can be accessed and start generating interest. ||Usage: this type of info is eg used in US, and is linked to particular instruments, such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the funds will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    [IsoId("_T69-wtp-Ed-ak6NoX_4Aeg_-1317506961")]
    [DisplayName("Availability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Avlbty")]
    #endif
    [IsoXmlTag("Avlbty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashBalanceAvailability1? Availability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashBalanceAvailability1? Availability { get; init; } 
    #else
    public CashBalanceAvailability1? Availability { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements to fully identify the type of underlying transaction resulting in an entry.
    /// </summary>
    [IsoId("_T69-w9p-Ed-ak6NoX_4Aeg_-1317507021")]
    [DisplayName("Bank Transaction Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkTxCd")]
    #endif
    [IsoXmlTag("BkTxCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BankTransactionCodeStructure1 BankTransactionCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BankTransactionCodeStructure1 BankTransactionCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BankTransactionCodeStructure1 BankTransactionCode { get; init; } 
    #else
    public BankTransactionCodeStructure1 BankTransactionCode { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the transaction is exempt from commission.
    /// </summary>
    [IsoId("_T69-xNp-Ed-ak6NoX_4Aeg_-1317507893")]
    [DisplayName("Commission Waiver Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComssnWvrInd")]
    #endif
    [IsoXmlTag("ComssnWvrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CommissionWaiverIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CommissionWaiverIndicator { get; init; } 
    #else
    public System.String? CommissionWaiverIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the underlying transaction details are provided through a separate message, eg in case of aggregate bookings.
    /// </summary>
    [IsoId("_T69-xdp-Ed-ak6NoX_4Aeg_-1317507081")]
    [DisplayName("Additional Information Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInfInd")]
    #endif
    [IsoXmlTag("AddtlInfInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageIdentification2? AdditionalInformationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification2? AdditionalInformationIndicator { get; init; } 
    #else
    public MessageIdentification2? AdditionalInformationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements providing details on batched transactions.||Usage: this element can be repeated in case more than one batch is included in the entry, eg, in lockbox scenarios, to specify the ID and number of transactions included in each of the batches.
    /// </summary>
    [IsoId("_T69-xtp-Ed-ak6NoX_4Aeg_-1316586540")]
    [DisplayName("Batch")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Btch")]
    #endif
    [IsoXmlTag("Btch")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BatchInformation1? Batch { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BatchInformation1? Batch { get; init; } 
    #else
    public BatchInformation1? Batch { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements providing information on the original amount.||Usage: This component (on entry level) should be used when a total original batch or aggregate amount has to be provided. (If required, the original amounts for each individual transaction can be included in the same component on transaction details level.).
    /// </summary>
    [IsoId("_T69-x9p-Ed-ak6NoX_4Aeg_-1317507519")]
    [DisplayName("Amount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtDtls")]
    #endif
    [IsoXmlTag("AmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndCurrencyExchange2? AmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndCurrencyExchange2? AmountDetails { get; init; } 
    #else
    public AmountAndCurrencyExchange2? AmountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the charges included in the entry amount.||Usage: this component is used in case of batch or aggregate bookings.
    /// </summary>
    [IsoId("_T69-yNp-Ed-ak6NoX_4Aeg_-1317507194")]
    [DisplayName("Charges")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Chrgs")]
    #endif
    [IsoXmlTag("Chrgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargesInformation3? Charges { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargesInformation3? Charges { get; init; } 
    #else
    public ChargesInformation3? Charges { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements providing details on the interest amount included in the entry amount.||Usage: it is used in case of batch or aggregate bookings.
    /// </summary>
    [IsoId("_T69-ydp-Ed-ak6NoX_4Aeg_-1317507141")]
    [DisplayName("Interest")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Intrst")]
    #endif
    [IsoXmlTag("Intrst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionInterest1? Interest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionInterest1? Interest { get; init; } 
    #else
    public TransactionInterest1? Interest { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements providing information on the underlying transaction (s).
    /// </summary>
    [IsoId("_T7HvwNp-Ed-ak6NoX_4Aeg_-1317507580")]
    [DisplayName("Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDtls")]
    #endif
    [IsoXmlTag("TxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EntryTransaction1? TransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EntryTransaction1? TransactionDetails { get; init; } 
    #else
    public EntryTransaction1? TransactionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the entry details.
    /// </summary>
    [IsoId("_T7Hvwdp-Ed-ak6NoX_4Aeg_-1317508031")]
    [DisplayName("Additional Entry Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlNtryInf")]
    #endif
    [IsoXmlTag("AddtlNtryInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax500Text? AdditionalEntryInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalEntryInformation { get; init; } 
    #else
    public System.String? AdditionalEntryInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
