// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify the underlying transaction.
/// </summary>
[IsoId("_T8KRltp-Ed-ak6NoX_4Aeg_-609394874")]
[DisplayName("Entry Transaction")]
public partial record EntryTransaction2
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide the identification of the underlying transaction.
    /// </summary>
    [IsoId("_T8KRl9p-Ed-ak6NoX_4Aeg_-608473586")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public TransactionReferences2? References { get; init; } 
    
    /// <summary>
    /// Set of elements providing detailed information on the original amount.||Usage: This component (on transaction level) should be used in case booking is for a single transaction and the original amount is different from the entry amount. It can also be used in case individual original amounts are provided in case of a batch or aggregate booking.
    /// </summary>
    [IsoId("_T8KRmNp-Ed-ak6NoX_4Aeg_-609394203")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public AmountAndCurrencyExchange3? AmountDetails { get; init; } 
    
    /// <summary>
    /// Set of elements used to indicate when the booked amount of money will become available, that is can be accessed and starts generating interest. ||Usage: This type of information is used in the US and is linked to particular instruments such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the amount of money will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    [IsoId("_T8KRmdp-Ed-ak6NoX_4Aeg_-609394750")]
    [DisplayName("Availability")]
    [IsoXmlTag("Avlbty")]
    public CashBalanceAvailability2? Availability { get; init; } 
    
    /// <summary>
    /// Set of elements used to fully identify the type of underlying transaction resulting in an entry.
    /// </summary>
    [IsoId("_T8KRmtp-Ed-ak6NoX_4Aeg_-609394409")]
    [DisplayName("Bank Transaction Code")]
    [IsoXmlTag("BkTxCd")]
    public BankTransactionCodeStructure4? BankTransactionCode { get; init; } 
    
    /// <summary>
    /// Provides information on the charges included in the entry amount.||Usage: This component (on transaction level) can be used in case the booking is for a single transaction, and charges are included in the entry amount. It can also be used in case individual charge amounts are applied to individual transactions in case of a batch or aggregate amount booking.
    /// </summary>
    [IsoId("_T8UCkNp-Ed-ak6NoX_4Aeg_-608473831")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public ChargesInformation6? Charges { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide details of the interest amount included in the entry amount.||Usage: This component (on transaction level) can be used if the booking is for a single transaction, and interest amount is included in the entry amount. It can also be used if individual interest amounts are applied to individual transactions in the case of a batch or aggregate amount booking.
    /// </summary>
    [IsoId("_T8UCkdp-Ed-ak6NoX_4Aeg_-609394356")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public TransactionInterest2? Interest { get; init; } 
    
    /// <summary>
    /// Set of elements used to identify the parties related to the underlying transaction.
    /// </summary>
    [IsoId("_T8UCktp-Ed-ak6NoX_4Aeg_-609393925")]
    [DisplayName("Related Parties")]
    [IsoXmlTag("RltdPties")]
    public TransactionParty2? RelatedParties { get; init; } 
    
    /// <summary>
    /// Set of elements used to identify the agents related to the underlying transaction.
    /// </summary>
    [IsoId("_T8UCk9p-Ed-ak6NoX_4Aeg_-609393894")]
    [DisplayName("Related Agents")]
    [IsoXmlTag("RltdAgts")]
    public TransactionAgents2? RelatedAgents { get; init; } 
    
    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_T8UClNp-Ed-ak6NoX_4Aeg_-608473563")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_T8UCldp-Ed-ak6NoX_4Aeg_-608473254")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation2> RelatedRemittanceInformation { get; init; } = [];
    
    /// <summary>
    /// Structured information that enables the matching, ie, reconciliation, of a payment with the items that the payment is intended to settle, such as commercial invoices in an account receivable system.
    /// </summary>
    [IsoId("_T8UCltp-Ed-ak6NoX_4Aeg_-608473801")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation5? RemittanceInformation { get; init; } 
    
    /// <summary>
    /// Set of elements used to identify the dates related to the underlying transactions.
    /// </summary>
    [IsoId("_T8UCl9p-Ed-ak6NoX_4Aeg_-608473647")]
    [DisplayName("Related Dates")]
    [IsoXmlTag("RltdDts")]
    public TransactionDates2? RelatedDates { get; init; } 
    
    /// <summary>
    /// Set of elements used to identify the price information related to the underlying transaction.
    /// </summary>
    [IsoId("_T8UCmNp-Ed-ak6NoX_4Aeg_-608473709")]
    [DisplayName("Related Price")]
    [IsoXmlTag("RltdPric")]
    public TransactionPrice2Choice_? RelatedPrice { get; init; } 
    
    /// <summary>
    /// Set of elements used to identify the related quantities, such as securities, in the underlying transaction.
    /// </summary>
    [IsoId("_T8UCmdp-Ed-ak6NoX_4Aeg_-609394295")]
    [DisplayName("Related Quantities")]
    [IsoXmlTag("RltdQties")]
    public TransactionQuantities1Choice_? RelatedQuantities { get; init; } 
    
    /// <summary>
    /// Identification of a security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_T8dMgNp-Ed-ak6NoX_4Aeg_-609394781")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification4Choice_? FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide details on the tax.
    /// </summary>
    [IsoId("_T8dMgdp-Ed-ak6NoX_4Aeg_-608473739")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation3? Tax { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide the return information.
    /// </summary>
    [IsoId("_T8dMgtp-Ed-ak6NoX_4Aeg_-608473192")]
    [DisplayName("Return Information")]
    [IsoXmlTag("RtrInf")]
    public ReturnReasonInformation10? ReturnInformation { get; init; } 
    
    /// <summary>
    /// Set of elements used to identify the underlying corporate action.
    /// </summary>
    [IsoId("_T8dMg9p-Ed-ak6NoX_4Aeg_-608473284")]
    [DisplayName("Corporate Action")]
    [IsoXmlTag("CorpActn")]
    public CorporateAction1? CorporateAction { get; init; } 
    
    /// <summary>
    /// Safekeeping or investment account. A safekeeping account is an account on which a securities entry is made. An investment account is an account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    [IsoId("_T8dMhNp-Ed-ak6NoX_4Aeg_-609393833")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public CashAccount16? SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Further details of the transaction.
    /// </summary>
    [IsoId("_T8dMhdp-Ed-ak6NoX_4Aeg_-609394843")]
    [DisplayName("Additional Transaction Information")]
    [IsoXmlTag("AddtlTxInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? AdditionalTransactionInformation { get; init; } 
    
    
    #nullable disable
    
}
