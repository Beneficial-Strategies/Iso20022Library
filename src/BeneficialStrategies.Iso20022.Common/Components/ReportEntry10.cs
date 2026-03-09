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
/// Provides further details on an entry in the report.
/// </summary>
[IsoId("_-IPyH248EeiU9cctagi5ow")]
[DisplayName("Report Entry")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportEntry10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportEntry10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportEntry10( ActiveOrHistoricCurrencyAndAmount reqAmount,CreditDebitCode reqCreditDebitIndicator,EntryStatus1Choice_ reqStatus,BankTransactionCodeStructure4 reqBankTransactionCode )
    {
        Amount = reqAmount;
        CreditDebitIndicator = reqCreditDebitIndicator;
        Status = reqStatus;
        BankTransactionCode = reqBankTransactionCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique reference for the entry.
    /// </summary>
    [IsoId("_-Ro-pW48EeiU9cctagi5ow")]
    [DisplayName("Entry Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtryRef")]
    #endif
    [IsoXmlTag("NtryRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? EntryReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EntryReference { get; init; } 
    #else
    public System.String? EntryReference { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    [IsoId("_-Ro-p248EeiU9cctagi5ow")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the entry is a credit or a debit entry.
    /// </summary>
    [IsoId("_-Ro-qW48EeiU9cctagi5ow")]
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
    /// Indicates whether or not the entry is the result of a reversal.|Usage: This element should only be present if the entry is the result of a reversal.|If the CreditDebitIndicator is CRDT and ReversalIndicator is Yes, the original operation was a debit entry.|If the CreditDebitIndicator is DBIT and ReversalIndicator is Yes, the original operation was a credit entry.
    /// </summary>
    [IsoId("_-Ro-q248EeiU9cctagi5ow")]
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
    [IsoId("_-Ro-rW48EeiU9cctagi5ow")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EntryStatus1Choice_ Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EntryStatus1Choice_ Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EntryStatus1Choice_ Status { get; init; } 
    #else
    public EntryStatus1Choice_ Status { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time when an entry is posted to an account on the account servicer&apos;s books.||Usage: Booking date is the expected booking date, unless the status is booked, in which case it is the actual booking date.
    /// </summary>
    [IsoId("_-Ro-r248EeiU9cctagi5ow")]
    [DisplayName("Booking Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BookgDt")]
    #endif
    [IsoXmlTag("BookgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? BookingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? BookingDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? BookingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which assets become available to the account owner in case of a credit entry, or cease to be available to the account owner in case of a debit entry.|Usage: If entry status is pending and value date is present, then the value date refers to an expected/requested value date.|For entries subject to availability/float and for which availability information is provided, the value date must not be used. In this case the availability component identifies the number of availability days.
    /// </summary>
    [IsoId("_-Ro-sW48EeiU9cctagi5ow")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? ValueDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Unique reference as assigned by the account servicing institution to unambiguously identify the entry.
    /// </summary>
    [IsoId("_-Ro-s248EeiU9cctagi5ow")]
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
    /// Indicates when the booked amount of money will become available, that is can be accessed and starts generating interest. ||Usage: This type of information is used in the US and is linked to particular instruments such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the amount of money will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    [IsoId("_-Ro-tW48EeiU9cctagi5ow")]
    [DisplayName("Availability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Avlbty")]
    #endif
    [IsoXmlTag("Avlbty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAvailability1? Availability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAvailability1? Availability { get; init; } 
    #else
    public CashAvailability1? Availability { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to fully identify the type of underlying transaction resulting in an entry.
    /// </summary>
    [IsoId("_-Ro-t248EeiU9cctagi5ow")]
    [DisplayName("Bank Transaction Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkTxCd")]
    #endif
    [IsoXmlTag("BkTxCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BankTransactionCodeStructure4 BankTransactionCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BankTransactionCodeStructure4 BankTransactionCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BankTransactionCodeStructure4 BankTransactionCode { get; init; } 
    #else
    public BankTransactionCodeStructure4 BankTransactionCode { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the transaction is exempt from commission.
    /// </summary>
    [IsoId("_-Ro-uW48EeiU9cctagi5ow")]
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
    /// Indicates whether the underlying transaction details are provided through a separate message, as in the case of aggregate bookings.
    /// </summary>
    [IsoId("_-Ro-u248EeiU9cctagi5ow")]
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
    /// Provides information on the original amount.||Usage: This component (on entry level) should be used when a total original batch or aggregate amount has to be provided. If required, the individual original amounts can be included in the same component on transaction details level.
    /// </summary>
    [IsoId("_-Ro-vW48EeiU9cctagi5ow")]
    [DisplayName("Amount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtDtls")]
    #endif
    [IsoXmlTag("AmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndCurrencyExchange3? AmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndCurrencyExchange3? AmountDetails { get; init; } 
    #else
    public AmountAndCurrencyExchange3? AmountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the charges, pre-advised or included in the entry amount.
    /// Usage: This component is used on entry level in case of batch or aggregate bookings.
    /// </summary>
    [IsoId("_-Ro-v248EeiU9cctagi5ow")]
    [DisplayName("Charges")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Chrgs")]
    #endif
    [IsoXmlTag("Chrgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Charges6? Charges { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Charges6? Charges { get; init; } 
    #else
    public Charges6? Charges { get; set; } 
    #endif
    
    /// <summary>
    /// Channel used to technically input the instruction related to the entry.
    /// </summary>
    [IsoId("_-Ro-wW48EeiU9cctagi5ow")]
    [DisplayName("Technical Input Channel")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TechInptChanl")]
    #endif
    [IsoXmlTag("TechInptChanl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TechnicalInputChannel1Choice_? TechnicalInputChannel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TechnicalInputChannel1Choice_? TechnicalInputChannel { get; init; } 
    #else
    public TechnicalInputChannel1Choice_? TechnicalInputChannel { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details of the interest amount included in the entry amount.||Usage: This component is used on entry level in the case of batch or aggregate bookings.
    /// </summary>
    [IsoId("_-Ro-w248EeiU9cctagi5ow")]
    [DisplayName("Interest")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Intrst")]
    #endif
    [IsoXmlTag("Intrst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionInterest4? Interest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionInterest4? Interest { get; init; } 
    #else
    public TransactionInterest4? Interest { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details of the card transaction included in the entry amount, when globalised by the account servicer.
    /// </summary>
    [IsoId("_-Ro-xW48EeiU9cctagi5ow")]
    [DisplayName("Card Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardTx")]
    #endif
    [IsoXmlTag("CardTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardEntry4? CardTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardEntry4? CardTransaction { get; init; } 
    #else
    public CardEntry4? CardTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the entry.
    /// </summary>
    [IsoId("_-Ro-x248EeiU9cctagi5ow")]
    [DisplayName("Entry Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtryDtls")]
    #endif
    [IsoXmlTag("NtryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EntryDetails9? EntryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EntryDetails9? EntryDetails { get; init; } 
    #else
    public EntryDetails9? EntryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Further details of the entry.
    /// </summary>
    [IsoId("_-Ro-yW48EeiU9cctagi5ow")]
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
