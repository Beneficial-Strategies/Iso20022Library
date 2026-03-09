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
/// Set of characteristics that apply to the the direct debit transaction(s).
/// </summary>
[IsoId("_PwF5wNp-Ed-ak6NoX_4Aeg_-698254258")]
[DisplayName("Direct Debit Transaction Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DirectDebitTransactionInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DirectDebitTransactionInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DirectDebitTransactionInformation1( PaymentIdentification1 reqPaymentIdentification,CurrencyAndAmount reqInstructedAmount,BranchAndFinancialInstitutionIdentification3 reqDebtorAgent,PartyIdentification8 reqDebtor,CashAccount7 reqDebtorAccount )
    {
        PaymentIdentification = reqPaymentIdentification;
        InstructedAmount = reqInstructedAmount;
        DebtorAgent = reqDebtorAgent;
        Debtor = reqDebtor;
        DebtorAccount = reqDebtorAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements to reference a payment instruction.
    /// </summary>
    [IsoId("_PwF5wdp-Ed-ak6NoX_4Aeg_-697330319")]
    [DisplayName("Payment Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtId")]
    #endif
    [IsoXmlTag("PmtId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentIdentification1 PaymentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentIdentification1 PaymentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentIdentification1 PaymentIdentification { get; init; } 
    #else
    public PaymentIdentification1 PaymentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_PwF5wtp-Ed-ak6NoX_4Aeg_709731807")]
    [DisplayName("Payment Type Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTpInf")]
    #endif
    [IsoXmlTag("PmtTpInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTypeInformation2? PaymentTypeInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTypeInformation2? PaymentTypeInformation { get; init; } 
    #else
    public PaymentTypeInformation2? PaymentTypeInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_PwF5w9p-Ed-ak6NoX_4Aeg_-1231988816")]
    [DisplayName("Instructed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdAmt")]
    #endif
    [IsoXmlTag("InstdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount InstructedAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount InstructedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount InstructedAmount { get; init; } 
    #else
    public CurrencyAndAmount InstructedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_PwF5xNp-Ed-ak6NoX_4Aeg_-134577148")]
    [DisplayName("Charge Bearer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgBr")]
    #endif
    [IsoXmlTag("ChrgBr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    #else
    public ChargeBearerType1Code? ChargeBearer { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements providing information specific to the direct debit mandate.
    /// </summary>
    [IsoId("_PwF5xdp-Ed-ak6NoX_4Aeg_-80903261")]
    [DisplayName("Direct Debit Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrctDbtTx")]
    #endif
    [IsoXmlTag("DrctDbtTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DirectDebitTransaction1? DirectDebitTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DirectDebitTransaction1? DirectDebitTransaction { get; init; } 
    #else
    public DirectDebitTransaction1? DirectDebitTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_PwF5xtp-Ed-ak6NoX_4Aeg_671768228")]
    [DisplayName("Ultimate Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtCdtr")]
    #endif
    [IsoXmlTag("UltmtCdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification8? UltimateCreditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8? UltimateCreditor { get; init; } 
    #else
    public PartyIdentification8? UltimateCreditor { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_PwF5x9p-Ed-ak6NoX_4Aeg_-726885796")]
    [DisplayName("Debtor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAgt")]
    #endif
    [IsoXmlTag("DbtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification3 DebtorAgent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification3 DebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3 DebtorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3 DebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_PwF5yNp-Ed-ak6NoX_4Aeg_-725962912")]
    [DisplayName("Debtor Agent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAgtAcct")]
    #endif
    [IsoXmlTag("DbtrAgtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount7? DebtorAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount7? DebtorAgentAccount { get; init; } 
    #else
    public CashAccount7? DebtorAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_PwF5ydp-Ed-ak6NoX_4Aeg_-727807794")]
    [DisplayName("Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dbtr")]
    #endif
    [IsoXmlTag("Dbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification8 Debtor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification8 Debtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8 Debtor { get; init; } 
    #else
    public PartyIdentification8 Debtor { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the account of the debtor to which a debit entry will be made to execute the transfer.
    /// </summary>
    [IsoId("_PwPDsNp-Ed-ak6NoX_4Aeg_-727806805")]
    [DisplayName("Debtor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAcct")]
    #endif
    [IsoXmlTag("DbtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount7 DebtorAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount7 DebtorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount7 DebtorAccount { get; init; } 
    #else
    public CashAccount7 DebtorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_PwPDsdp-Ed-ak6NoX_4Aeg_-694562141")]
    [DisplayName("Ultimate Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtDbtr")]
    #endif
    [IsoXmlTag("UltmtDbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification8? UltimateDebtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8? UltimateDebtor { get; init; } 
    #else
    public PartyIdentification8? UltimateDebtor { get; set; } 
    #endif
    
    /// <summary>
    /// Further information, related to the processing of the payment instruction, that may need to be acted upon by the creditor agent, depending on agreement between creditor and the creditor agent.
    /// </summary>
    [IsoId("_PwPDstp-Ed-ak6NoX_4Aeg_1236038580")]
    [DisplayName("Instruction For Creditor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrForCdtrAgt")]
    #endif
    [IsoXmlTag("InstrForCdtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? InstructionForCreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructionForCreditorAgent { get; init; } 
    #else
    public System.String? InstructionForCreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Underlying reason for the payment transaction, eg, a charity payment, or a commercial agreement between the creditor and the debtor. ||Usage: purpose is used by the end-customers, ie originating party, initiating party, debtor, creditor, final party, to provide information concerning the nature of the payment transaction. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_PwPDs9p-Ed-ak6NoX_4Aeg_-697332656")]
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
    /// Information needed due to regulatory and statutory requirements.
    /// </summary>
    [IsoId("_PwPDtNp-Ed-ak6NoX_4Aeg_-696409271")]
    [DisplayName("Regulatory Reporting")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RgltryRptg")]
    #endif
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting2> RegulatoryReporting { get; init; } = new ValueList<RegulatoryReporting2>(){};
    
    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters such as thresholds or income.
    /// </summary>
    [IsoId("_PwPDtdp-Ed-ak6NoX_4Aeg_-696409073")]
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
    /// Information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_PwPDttp-Ed-ak6NoX_4Aeg_-694561639")]
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
    [IsoId("_PwPDt9p-Ed-ak6NoX_4Aeg_-696410019")]
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
    
    
    #nullable disable
    
}
