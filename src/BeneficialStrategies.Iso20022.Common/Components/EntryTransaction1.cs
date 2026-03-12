// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Posting to an account that results in an increase or decrease to a balance.
/// </summary>
[IsoId("_T7aqvNp-Ed-ak6NoX_4Aeg_-2096191844")]
[DisplayName("Entry Transaction")]
public partial record EntryTransaction1
{
    #nullable enable
    
    /// <summary>
    /// Set of elements providing the identification of the underlying transaction.
    /// </summary>
    [IsoId("_T7aqvdp-Ed-ak6NoX_4Aeg_1144771756")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public TransactionReferences1? References { get; init; } 
    
    /// <summary>
    /// Set of elements providing details information on the original amount.||Usage: This component (on transaction level) should be used in case booking is for a single transaction and the original amount is different from the entry amount. It can also be used in case individual original amounts are provided in case of a batch or aggregate booking.
    /// </summary>
    [IsoId("_T7kbsNp-Ed-ak6NoX_4Aeg_-2095270311")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public AmountAndCurrencyExchange2? AmountDetails { get; init; } 
    
    /// <summary>
    /// Set of elements used to indicate when the booked funds will become available, ie can be accessed and start generating interest. ||Usage: this type of info is eg used in US, and is linked to particular instruments, such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the funds will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    [IsoId("_T7kbsdp-Ed-ak6NoX_4Aeg_-2095271147")]
    [DisplayName("Availability")]
    [IsoXmlTag("Avlbty")]
    public CashBalanceAvailability1? Availability { get; init; } 
    
    /// <summary>
    /// Set of elements to fully identify the type of underlying transaction resulting in an entry.
    /// </summary>
    [IsoId("_T7kbstp-Ed-ak6NoX_4Aeg_-2095270853")]
    [DisplayName("Bank Transaction Code")]
    [IsoXmlTag("BkTxCd")]
    public BankTransactionCodeStructure1? BankTransactionCode { get; init; } 
    
    /// <summary>
    /// Provides information on the charges included in the entry amount.||Usage: This component (on transaction level) can be used in case the booking is for a single transaction, and charges are included in the entry amount. It can also be used in case individual charge amounts are applied to individual transactions in case of a batch or aggregate amount booking.
    /// </summary>
    [IsoId("_T7kbs9p-Ed-ak6NoX_4Aeg_-2095270371")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public ChargesInformation3? Charges { get; init; } 
    
    /// <summary>
    /// Set of elements providing details on the interest amount included in the entry amount.||Usage: This component (on transaction level) can be used in case the booking is for a single transaction, and interest amount is included in the entry amount. It can also be used in case individual interest amounts are applied to individual transactions in case of a batch or aggregate amount booking.
    /// </summary>
    [IsoId("_T7kbtNp-Ed-ak6NoX_4Aeg_-2095270449")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public TransactionInterest1? Interest { get; init; } 
    
    /// <summary>
    /// Set of elements identifying the parties related to the underlying transaction.
    /// </summary>
    [IsoId("_T7kbtdp-Ed-ak6NoX_4Aeg_-889275227")]
    [DisplayName("Related Parties")]
    [IsoXmlTag("RltdPties")]
    public TransactionParty1? RelatedParties { get; init; } 
    
    /// <summary>
    /// Set of elements identifying the agents related to the underlying transaction.
    /// </summary>
    [IsoId("_T7kbttp-Ed-ak6NoX_4Aeg_-295451856")]
    [DisplayName("Related Agents")]
    [IsoXmlTag("RltdAgts")]
    public TransactionAgents1? RelatedAgents { get; init; } 
    
    /// <summary>
    /// Underlying reason for the payment transaction, eg, a charity payment, or a commercial agreement between the creditor and the debtor. ||Usage: purpose is used by the end-customers, ie originating party, initiating party, debtor, creditor, final party, to provide information concerning the nature of the payment transaction. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_T7kbt9p-Ed-ak6NoX_4Aeg_-1664909682")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose1Choice_? Purpose { get; init; } 
    
    /// <summary>
    /// Information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_T7kbuNp-Ed-ak6NoX_4Aeg_-1664910015")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation1> RelatedRemittanceInformation { get; init; } = new ValueList<RemittanceLocation1>(){};
    
    /// <summary>
    /// Information that enables the matching, ie, reconciliation, of a payment with the items that the payment is intended to settle, eg, commercial invoices in an account receivable system.
    /// </summary>
    [IsoId("_T7kbudp-Ed-ak6NoX_4Aeg_-1665831077")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation1? RemittanceInformation { get; init; } 
    
    /// <summary>
    /// Set of elements identifying the dates related to the underlying transactions.
    /// </summary>
    [IsoId("_T7tloNp-Ed-ak6NoX_4Aeg_1626914205")]
    [DisplayName("Related Dates")]
    [IsoXmlTag("RltdDts")]
    public TransactionDates1? RelatedDates { get; init; } 
    
    /// <summary>
    /// Set of elements identifying the price information related to the underlying transaction.
    /// </summary>
    [IsoId("_T7tlodp-Ed-ak6NoX_4Aeg_1524073475")]
    [DisplayName("Related Price")]
    [IsoXmlTag("RltdPric")]
    public TransactionPrice1Choice_? RelatedPrice { get; init; } 
    
    /// <summary>
    /// Identifies related quantities (eg of securities) in the underlying transaction.
    /// </summary>
    [IsoId("_T7tlotp-Ed-ak6NoX_4Aeg_1681931917")]
    [DisplayName("Related Quantities")]
    [IsoXmlTag("RltdQties")]
    public TransactionQuantities1Choice_? RelatedQuantities { get; init; } 
    
    /// <summary>
    /// Identification of a security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_T7tlo9p-Ed-ak6NoX_4Aeg_-332904796")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification4Choice_? FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters such as thresholds or income.
    /// </summary>
    [IsoId("_T7tlpNp-Ed-ak6NoX_4Aeg_-1664910068")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation2? Tax { get; init; } 
    
    /// <summary>
    /// Set of elements specifying the return information.
    /// </summary>
    [IsoId("_T7tlpdp-Ed-ak6NoX_4Aeg_-1837962618")]
    [DisplayName("Return Information")]
    [IsoXmlTag("RtrInf")]
    public ReturnReasonInformation5? ReturnInformation { get; init; } 
    
    /// <summary>
    /// Set of elements identifying the underlying corporate action.
    /// </summary>
    [IsoId("_T7tlptp-Ed-ak6NoX_4Aeg_-1765613668")]
    [DisplayName("Corporate Action")]
    [IsoXmlTag("CorpActn")]
    public CorporateAction1? CorporateAction { get; init; } 
    
    /// <summary>
    /// Safekeeping or investment account. A safekeeping account is an account on which a securities entry is made. An investment account is an account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    [IsoId("_T7tlp9p-Ed-ak6NoX_4Aeg_1414929040")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public CashAccount7? SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Further details on the transaction details.
    /// </summary>
    [IsoId("_T7tlqNp-Ed-ak6NoX_4Aeg_-2096191507")]
    [DisplayName("Additional Transaction Information")]
    [IsoXmlTag("AddtlTxInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? AdditionalTransactionInformation { get; init; } 
    
    
    #nullable disable
    
}
