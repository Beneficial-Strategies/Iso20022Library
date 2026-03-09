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
/// Identifies the underlying transaction.
/// </summary>
[IsoId("_bZJMRdcZEeqRFcf2R4bPBw")]
[DisplayName("Entry Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EntryTransaction11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the underlying transaction.
    /// </summary>
    [IsoId("_baeB8dcZEeqRFcf2R4bPBw")]
    [DisplayName("References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Refs")]
    #endif
    [IsoXmlTag("Refs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionReferences6? References { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionReferences6? References { get; init; } 
    #else
    public TransactionReferences6? References { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money in the cash transaction.
    /// </summary>
    [IsoId("_baeB89cZEeqRFcf2R4bPBw")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? Amount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the transaction is a credit or a debit transaction.
    /// </summary>
    [IsoId("_baeB9dcZEeqRFcf2R4bPBw")]
    [DisplayName("Credit Debit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbtInd")]
    #endif
    [IsoXmlTag("CdtDbtInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    #else
    public CreditDebitCode? CreditDebitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the original amount.||Usage: This component (on transaction level) should be used in case booking is for a single transaction and the original amount is different from the entry amount. It can also be used in case individual original amounts are provided in case of a batch or aggregate booking.
    /// </summary>
    [IsoId("_baeB99cZEeqRFcf2R4bPBw")]
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
    /// Indicates when the booked amount of money will become available, that is can be accessed and starts generating interest. ||Usage: This type of information is used in the US and is linked to particular instruments such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the amount of money will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    [IsoId("_baeB-dcZEeqRFcf2R4bPBw")]
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
    [IsoId("_baeB-9cZEeqRFcf2R4bPBw")]
    [DisplayName("Bank Transaction Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkTxCd")]
    #endif
    [IsoXmlTag("BkTxCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BankTransactionCodeStructure4? BankTransactionCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BankTransactionCodeStructure4? BankTransactionCode { get; init; } 
    #else
    public BankTransactionCodeStructure4? BankTransactionCode { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the charges, pre-advised or included in the entry amount.
    /// Usage: This component (on transaction level) can be used in case the booking is for a single transaction, and charges are included in the entry amount. It can also be used in case individual charge amounts are applied to individual transactions in case of a batch or aggregate amount booking.
    /// </summary>
    [IsoId("_baeB_dcZEeqRFcf2R4bPBw")]
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
    /// Provides details of the interest amount included in the entry amount.||Usage: This component (on transaction level) can be used if the booking is for a single transaction, and interest amount is included in the entry amount. It can also be used if individual interest amounts are applied to individual transactions in the case of a batch or aggregate amount booking.
    /// </summary>
    [IsoId("_baeB_9cZEeqRFcf2R4bPBw")]
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
    /// Set of elements used to identify the parties related to the underlying transaction.
    /// </summary>
    [IsoId("_baeCAdcZEeqRFcf2R4bPBw")]
    [DisplayName("Related Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdPties")]
    #endif
    [IsoXmlTag("RltdPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionParties9? RelatedParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionParties9? RelatedParties { get; init; } 
    #else
    public TransactionParties9? RelatedParties { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to identify the agents related to the underlying transaction.
    /// </summary>
    [IsoId("_baeCA9cZEeqRFcf2R4bPBw")]
    [DisplayName("Related Agents")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdAgts")]
    #endif
    [IsoXmlTag("RltdAgts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionAgents5? RelatedAgents { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionAgents5? RelatedAgents { get; init; } 
    #else
    public TransactionAgents5? RelatedAgents { get; set; } 
    #endif
    
    /// <summary>
    /// User community specific instrument.|Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level.
    /// </summary>
    [IsoId("_baeCBdcZEeqRFcf2R4bPBw")]
    [DisplayName("Local Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclInstrm")]
    #endif
    [IsoXmlTag("LclInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LocalInstrument2Choice_? LocalInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LocalInstrument2Choice_? LocalInstrument { get; init; } 
    #else
    public LocalInstrument2Choice_? LocalInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_baeCB9cZEeqRFcf2R4bPBw")]
    [DisplayName("Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Purp")]
    #endif
    [IsoXmlTag("Purp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Purpose2Choice_? Purpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Purpose2Choice_? Purpose { get; init; } 
    #else
    public Purpose2Choice_? Purpose { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_baeCCdcZEeqRFcf2R4bPBw")]
    [DisplayName("Related Remittance Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRmtInf")]
    #endif
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation7> RelatedRemittanceInformation { get; init; } = new ValueList<RemittanceLocation7>(){};
    
    /// <summary>
    /// Structured information that enables the matching, that is reconciliation, of a payment with the items that the payment is intended to settle, such as commercial invoices in an account receivable system.
    /// </summary>
    [IsoId("_baeCC9cZEeqRFcf2R4bPBw")]
    [DisplayName("Remittance Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtInf")]
    #endif
    [IsoXmlTag("RmtInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RemittanceInformation21? RemittanceInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RemittanceInformation21? RemittanceInformation { get; init; } 
    #else
    public RemittanceInformation21? RemittanceInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to identify the dates related to the underlying transactions.
    /// </summary>
    [IsoId("_baepAdcZEeqRFcf2R4bPBw")]
    [DisplayName("Related Dates")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdDts")]
    #endif
    [IsoXmlTag("RltdDts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionDates3? RelatedDates { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionDates3? RelatedDates { get; init; } 
    #else
    public TransactionDates3? RelatedDates { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to identify the price information related to the underlying transaction.
    /// </summary>
    [IsoId("_baepA9cZEeqRFcf2R4bPBw")]
    [DisplayName("Related Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdPric")]
    #endif
    [IsoXmlTag("RltdPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionPrice4Choice_? RelatedPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionPrice4Choice_? RelatedPrice { get; init; } 
    #else
    public TransactionPrice4Choice_? RelatedPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to identify the related quantities, such as securities, in the underlying transaction.
    /// </summary>
    [IsoId("_baepBdcZEeqRFcf2R4bPBw")]
    [DisplayName("Related Quantities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdQties")]
    #endif
    [IsoXmlTag("RltdQties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionQuantities3Choice_? RelatedQuantities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionQuantities3Choice_? RelatedQuantities { get; init; } 
    #else
    public TransactionQuantities3Choice_? RelatedQuantities { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_baepB9cZEeqRFcf2R4bPBw")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification19? FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the tax.
    /// </summary>
    [IsoId("_baepCdcZEeqRFcf2R4bPBw")]
    [DisplayName("Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tax")]
    #endif
    [IsoXmlTag("Tax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxInformation10? Tax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxInformation10? Tax { get; init; } 
    #else
    public TaxInformation10? Tax { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the return information.
    /// </summary>
    [IsoId("_baepC9cZEeqRFcf2R4bPBw")]
    [DisplayName("Return Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrInf")]
    #endif
    [IsoXmlTag("RtrInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentReturnReason5? ReturnInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentReturnReason5? ReturnInformation { get; init; } 
    #else
    public PaymentReturnReason5? ReturnInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to identify the underlying corporate action.
    /// </summary>
    [IsoId("_baepDdcZEeqRFcf2R4bPBw")]
    [DisplayName("Corporate Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActn")]
    #endif
    [IsoXmlTag("CorpActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateAction9? CorporateAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateAction9? CorporateAction { get; init; } 
    #else
    public CorporateAction9? CorporateAction { get; set; } 
    #endif
    
    /// <summary>
    /// Safekeeping or investment account. A safekeeping account is an account on which a securities entry is made. An investment account is an account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    [IsoId("_baepD9cZEeqRFcf2R4bPBw")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount19? SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the details of a cash deposit for an amount of money in cash notes and/or coins.
    /// </summary>
    [IsoId("_baepEdcZEeqRFcf2R4bPBw")]
    [DisplayName("Cash Deposit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshDpst")]
    #endif
    [IsoXmlTag("CshDpst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashDeposit1? CashDeposit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashDeposit1? CashDeposit { get; init; } 
    #else
    public CashDeposit1? CashDeposit { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the data related to the card (number, scheme), terminal (number, identification) and transactional data used to uniquely identify a card transaction.
    /// </summary>
    [IsoId("_baepE9cZEeqRFcf2R4bPBw")]
    [DisplayName("Card Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardTx")]
    #endif
    [IsoXmlTag("CardTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardTransaction18? CardTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardTransaction18? CardTransaction { get; init; } 
    #else
    public CardTransaction18? CardTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Further details of the transaction.
    /// </summary>
    [IsoId("_baepFdcZEeqRFcf2R4bPBw")]
    [DisplayName("Additional Transaction Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlTxInf")]
    #endif
    [IsoXmlTag("AddtlTxInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax500Text? AdditionalTransactionInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalTransactionInformation { get; init; } 
    #else
    public System.String? AdditionalTransactionInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_baepF9cZEeqRFcf2R4bPBw")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
