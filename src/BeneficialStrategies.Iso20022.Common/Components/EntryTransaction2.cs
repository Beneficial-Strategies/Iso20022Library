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
/// Set of elements used to identify the underlying transaction.
/// </summary>
[IsoId("_T8KRltp-Ed-ak6NoX_4Aeg_-609394874")]
[DisplayName("Entry Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EntryTransaction2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide the identification of the underlying transaction.
    /// </summary>
    [IsoId("_T8KRl9p-Ed-ak6NoX_4Aeg_-608473586")]
    [DisplayName("References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Refs")]
    #endif
    [IsoXmlTag("Refs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionReferences2? References { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionReferences2? References { get; init; } 
    #else
    public TransactionReferences2? References { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements providing detailed information on the original amount.||Usage: This component (on transaction level) should be used in case booking is for a single transaction and the original amount is different from the entry amount. It can also be used in case individual original amounts are provided in case of a batch or aggregate booking.
    /// </summary>
    [IsoId("_T8KRmNp-Ed-ak6NoX_4Aeg_-609394203")]
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
    /// Set of elements used to indicate when the booked amount of money will become available, that is can be accessed and starts generating interest. ||Usage: This type of information is used in the US and is linked to particular instruments such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the amount of money will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    [IsoId("_T8KRmdp-Ed-ak6NoX_4Aeg_-609394750")]
    [DisplayName("Availability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Avlbty")]
    #endif
    [IsoXmlTag("Avlbty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashBalanceAvailability2? Availability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashBalanceAvailability2? Availability { get; init; } 
    #else
    public CashBalanceAvailability2? Availability { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to fully identify the type of underlying transaction resulting in an entry.
    /// </summary>
    [IsoId("_T8KRmtp-Ed-ak6NoX_4Aeg_-609394409")]
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
    /// Provides information on the charges included in the entry amount.||Usage: This component (on transaction level) can be used in case the booking is for a single transaction, and charges are included in the entry amount. It can also be used in case individual charge amounts are applied to individual transactions in case of a batch or aggregate amount booking.
    /// </summary>
    [IsoId("_T8UCkNp-Ed-ak6NoX_4Aeg_-608473831")]
    [DisplayName("Charges")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Chrgs")]
    #endif
    [IsoXmlTag("Chrgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargesInformation6? Charges { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargesInformation6? Charges { get; init; } 
    #else
    public ChargesInformation6? Charges { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide details of the interest amount included in the entry amount.||Usage: This component (on transaction level) can be used if the booking is for a single transaction, and interest amount is included in the entry amount. It can also be used if individual interest amounts are applied to individual transactions in the case of a batch or aggregate amount booking.
    /// </summary>
    [IsoId("_T8UCkdp-Ed-ak6NoX_4Aeg_-609394356")]
    [DisplayName("Interest")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Intrst")]
    #endif
    [IsoXmlTag("Intrst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionInterest2? Interest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionInterest2? Interest { get; init; } 
    #else
    public TransactionInterest2? Interest { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to identify the parties related to the underlying transaction.
    /// </summary>
    [IsoId("_T8UCktp-Ed-ak6NoX_4Aeg_-609393925")]
    [DisplayName("Related Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdPties")]
    #endif
    [IsoXmlTag("RltdPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionParty2? RelatedParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionParty2? RelatedParties { get; init; } 
    #else
    public TransactionParty2? RelatedParties { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to identify the agents related to the underlying transaction.
    /// </summary>
    [IsoId("_T8UCk9p-Ed-ak6NoX_4Aeg_-609393894")]
    [DisplayName("Related Agents")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdAgts")]
    #endif
    [IsoXmlTag("RltdAgts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionAgents2? RelatedAgents { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionAgents2? RelatedAgents { get; init; } 
    #else
    public TransactionAgents2? RelatedAgents { get; set; } 
    #endif
    
    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_T8UClNp-Ed-ak6NoX_4Aeg_-608473563")]
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
    /// Set of elements used to provide information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_T8UCldp-Ed-ak6NoX_4Aeg_-608473254")]
    [DisplayName("Related Remittance Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRmtInf")]
    #endif
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation2> RelatedRemittanceInformation { get; init; } = new ValueList<RemittanceLocation2>(){};
    
    /// <summary>
    /// Structured information that enables the matching, ie, reconciliation, of a payment with the items that the payment is intended to settle, such as commercial invoices in an account receivable system.
    /// </summary>
    [IsoId("_T8UCltp-Ed-ak6NoX_4Aeg_-608473801")]
    [DisplayName("Remittance Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtInf")]
    #endif
    [IsoXmlTag("RmtInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RemittanceInformation5? RemittanceInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RemittanceInformation5? RemittanceInformation { get; init; } 
    #else
    public RemittanceInformation5? RemittanceInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to identify the dates related to the underlying transactions.
    /// </summary>
    [IsoId("_T8UCl9p-Ed-ak6NoX_4Aeg_-608473647")]
    [DisplayName("Related Dates")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdDts")]
    #endif
    [IsoXmlTag("RltdDts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionDates2? RelatedDates { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionDates2? RelatedDates { get; init; } 
    #else
    public TransactionDates2? RelatedDates { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to identify the price information related to the underlying transaction.
    /// </summary>
    [IsoId("_T8UCmNp-Ed-ak6NoX_4Aeg_-608473709")]
    [DisplayName("Related Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdPric")]
    #endif
    [IsoXmlTag("RltdPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionPrice2Choice_? RelatedPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionPrice2Choice_? RelatedPrice { get; init; } 
    #else
    public TransactionPrice2Choice_? RelatedPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to identify the related quantities, such as securities, in the underlying transaction.
    /// </summary>
    [IsoId("_T8UCmdp-Ed-ak6NoX_4Aeg_-609394295")]
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
    [IsoId("_T8dMgNp-Ed-ak6NoX_4Aeg_-609394781")]
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
    /// Set of elements used to provide details on the tax.
    /// </summary>
    [IsoId("_T8dMgdp-Ed-ak6NoX_4Aeg_-608473739")]
    [DisplayName("Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tax")]
    #endif
    [IsoXmlTag("Tax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxInformation3? Tax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxInformation3? Tax { get; init; } 
    #else
    public TaxInformation3? Tax { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide the return information.
    /// </summary>
    [IsoId("_T8dMgtp-Ed-ak6NoX_4Aeg_-608473192")]
    [DisplayName("Return Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrInf")]
    #endif
    [IsoXmlTag("RtrInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReturnReasonInformation10? ReturnInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReturnReasonInformation10? ReturnInformation { get; init; } 
    #else
    public ReturnReasonInformation10? ReturnInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to identify the underlying corporate action.
    /// </summary>
    [IsoId("_T8dMg9p-Ed-ak6NoX_4Aeg_-608473284")]
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
    [IsoId("_T8dMhNp-Ed-ak6NoX_4Aeg_-609393833")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount16? SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount16? SafekeepingAccount { get; init; } 
    #else
    public CashAccount16? SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Further details of the transaction.
    /// </summary>
    [IsoId("_T8dMhdp-Ed-ak6NoX_4Aeg_-609394843")]
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
