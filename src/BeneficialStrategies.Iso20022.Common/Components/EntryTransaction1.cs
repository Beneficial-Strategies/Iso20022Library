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
/// Posting to an account that results in an increase or decrease to a balance.
/// </summary>
[IsoId("_T7aqvNp-Ed-ak6NoX_4Aeg_-2096191844")]
[DisplayName("Entry Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EntryTransaction1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements providing the identification of the underlying transaction.
    /// </summary>
    [IsoId("_T7aqvdp-Ed-ak6NoX_4Aeg_1144771756")]
    [DisplayName("References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Refs")]
    #endif
    [IsoXmlTag("Refs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionReferences1? References { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionReferences1? References { get; init; } 
    #else
    public TransactionReferences1? References { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements providing details information on the original amount.||Usage: This component (on transaction level) should be used in case booking is for a single transaction and the original amount is different from the entry amount. It can also be used in case individual original amounts are provided in case of a batch or aggregate booking.
    /// </summary>
    [IsoId("_T7kbsNp-Ed-ak6NoX_4Aeg_-2095270311")]
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
    /// Set of elements used to indicate when the booked funds will become available, ie can be accessed and start generating interest. ||Usage: this type of info is eg used in US, and is linked to particular instruments, such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the funds will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    [IsoId("_T7kbsdp-Ed-ak6NoX_4Aeg_-2095271147")]
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
    [IsoId("_T7kbstp-Ed-ak6NoX_4Aeg_-2095270853")]
    [DisplayName("Bank Transaction Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkTxCd")]
    #endif
    [IsoXmlTag("BkTxCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BankTransactionCodeStructure1? BankTransactionCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BankTransactionCodeStructure1? BankTransactionCode { get; init; } 
    #else
    public BankTransactionCodeStructure1? BankTransactionCode { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the charges included in the entry amount.||Usage: This component (on transaction level) can be used in case the booking is for a single transaction, and charges are included in the entry amount. It can also be used in case individual charge amounts are applied to individual transactions in case of a batch or aggregate amount booking.
    /// </summary>
    [IsoId("_T7kbs9p-Ed-ak6NoX_4Aeg_-2095270371")]
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
    /// Set of elements providing details on the interest amount included in the entry amount.||Usage: This component (on transaction level) can be used in case the booking is for a single transaction, and interest amount is included in the entry amount. It can also be used in case individual interest amounts are applied to individual transactions in case of a batch or aggregate amount booking.
    /// </summary>
    [IsoId("_T7kbtNp-Ed-ak6NoX_4Aeg_-2095270449")]
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
    /// Set of elements identifying the parties related to the underlying transaction.
    /// </summary>
    [IsoId("_T7kbtdp-Ed-ak6NoX_4Aeg_-889275227")]
    [DisplayName("Related Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdPties")]
    #endif
    [IsoXmlTag("RltdPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionParty1? RelatedParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionParty1? RelatedParties { get; init; } 
    #else
    public TransactionParty1? RelatedParties { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements identifying the agents related to the underlying transaction.
    /// </summary>
    [IsoId("_T7kbttp-Ed-ak6NoX_4Aeg_-295451856")]
    [DisplayName("Related Agents")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdAgts")]
    #endif
    [IsoXmlTag("RltdAgts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionAgents1? RelatedAgents { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionAgents1? RelatedAgents { get; init; } 
    #else
    public TransactionAgents1? RelatedAgents { get; set; } 
    #endif
    
    /// <summary>
    /// Underlying reason for the payment transaction, eg, a charity payment, or a commercial agreement between the creditor and the debtor. ||Usage: purpose is used by the end-customers, ie originating party, initiating party, debtor, creditor, final party, to provide information concerning the nature of the payment transaction. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_T7kbt9p-Ed-ak6NoX_4Aeg_-1664909682")]
    [DisplayName("Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Purp")]
    #endif
    [IsoXmlTag("Purp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Purpose1Choice_? Purpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Purpose1Choice_? Purpose { get; init; } 
    #else
    public Purpose1Choice_? Purpose { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_T7kbuNp-Ed-ak6NoX_4Aeg_-1664910015")]
    [DisplayName("Related Remittance Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRmtInf")]
    #endif
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation1> RelatedRemittanceInformation { get; init; } = new ValueList<RemittanceLocation1>(){};
    
    /// <summary>
    /// Information that enables the matching, ie, reconciliation, of a payment with the items that the payment is intended to settle, eg, commercial invoices in an account receivable system.
    /// </summary>
    [IsoId("_T7kbudp-Ed-ak6NoX_4Aeg_-1665831077")]
    [DisplayName("Remittance Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtInf")]
    #endif
    [IsoXmlTag("RmtInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RemittanceInformation1? RemittanceInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RemittanceInformation1? RemittanceInformation { get; init; } 
    #else
    public RemittanceInformation1? RemittanceInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements identifying the dates related to the underlying transactions.
    /// </summary>
    [IsoId("_T7tloNp-Ed-ak6NoX_4Aeg_1626914205")]
    [DisplayName("Related Dates")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdDts")]
    #endif
    [IsoXmlTag("RltdDts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionDates1? RelatedDates { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionDates1? RelatedDates { get; init; } 
    #else
    public TransactionDates1? RelatedDates { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements identifying the price information related to the underlying transaction.
    /// </summary>
    [IsoId("_T7tlodp-Ed-ak6NoX_4Aeg_1524073475")]
    [DisplayName("Related Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdPric")]
    #endif
    [IsoXmlTag("RltdPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionPrice1Choice_? RelatedPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionPrice1Choice_? RelatedPrice { get; init; } 
    #else
    public TransactionPrice1Choice_? RelatedPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies related quantities (eg of securities) in the underlying transaction.
    /// </summary>
    [IsoId("_T7tlotp-Ed-ak6NoX_4Aeg_1681931917")]
    [DisplayName("Related Quantities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdQties")]
    #endif
    [IsoXmlTag("RltdQties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionQuantities1Choice_? RelatedQuantities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionQuantities1Choice_? RelatedQuantities { get; init; } 
    #else
    public TransactionQuantities1Choice_? RelatedQuantities { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_T7tlo9p-Ed-ak6NoX_4Aeg_-332904796")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification4Choice_? FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification4Choice_? FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification4Choice_? FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters such as thresholds or income.
    /// </summary>
    [IsoId("_T7tlpNp-Ed-ak6NoX_4Aeg_-1664910068")]
    [DisplayName("Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tax")]
    #endif
    [IsoXmlTag("Tax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxInformation2? Tax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxInformation2? Tax { get; init; } 
    #else
    public TaxInformation2? Tax { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements specifying the return information.
    /// </summary>
    [IsoId("_T7tlpdp-Ed-ak6NoX_4Aeg_-1837962618")]
    [DisplayName("Return Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrInf")]
    #endif
    [IsoXmlTag("RtrInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReturnReasonInformation5? ReturnInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReturnReasonInformation5? ReturnInformation { get; init; } 
    #else
    public ReturnReasonInformation5? ReturnInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements identifying the underlying corporate action.
    /// </summary>
    [IsoId("_T7tlptp-Ed-ak6NoX_4Aeg_-1765613668")]
    [DisplayName("Corporate Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActn")]
    #endif
    [IsoXmlTag("CorpActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateAction1? CorporateAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateAction1? CorporateAction { get; init; } 
    #else
    public CorporateAction1? CorporateAction { get; set; } 
    #endif
    
    /// <summary>
    /// Safekeeping or investment account. A safekeeping account is an account on which a securities entry is made. An investment account is an account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    [IsoId("_T7tlp9p-Ed-ak6NoX_4Aeg_1414929040")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount7? SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount7? SafekeepingAccount { get; init; } 
    #else
    public CashAccount7? SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the transaction details.
    /// </summary>
    [IsoId("_T7tlqNp-Ed-ak6NoX_4Aeg_-2096191507")]
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
    
    
    #nullable disable
    
}
