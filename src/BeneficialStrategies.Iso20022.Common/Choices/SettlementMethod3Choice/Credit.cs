// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.SettlementMethod3Choice
{
    /// <summary>
    /// Specifies details of the payment to be made by the old account servicer to the new account servicer in case of a positive closing balance.
    /// </summary>
    [IsoId("_P06-QcQAEemsic1bQcEtLA")]
    [DisplayName("Credit")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Credit : SettlementMethod3Choice_
    #else
    public partial class Credit : SettlementMethod3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Credit instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Credit( PaymentIdentification6 reqPaymentIdentification,ActiveCurrencyAndAmount reqAmount,BranchAndFinancialInstitutionIdentification6 reqCreditorAgent )
        {
            PaymentIdentification = reqPaymentIdentification;
            Amount = reqAmount;
            CreditorAgent = reqCreditorAgent;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Set of elements used to reference a payment instruction. 
        /// </summary>
        [IsoId("_QA49vcQAEemsic1bQcEtLA")]
        [DisplayName("Payment Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PmtId")]
        #endif
        [IsoXmlTag("PmtId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PaymentIdentification6 PaymentIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PaymentIdentification6 PaymentIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PaymentIdentification6 PaymentIdentification { get; init; } 
        #else
        public PaymentIdentification6 PaymentIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Set of elements used to further specify the type of transaction.
        /// </summary>
        [IsoId("_QA49v8QAEemsic1bQcEtLA")]
        [DisplayName("Payment Type Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PmtTpInf")]
        #endif
        [IsoXmlTag("PmtTpInf")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PaymentTypeInformation26? PaymentTypeInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PaymentTypeInformation26? PaymentTypeInformation { get; init; } 
        #else
        public PaymentTypeInformation26? PaymentTypeInformation { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the rate of tax levied.
        /// </summary>
        [IsoId("_QA49wcQAEemsic1bQcEtLA")]
        [DisplayName("Tax Rate Marker")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TaxRateMrkr")]
        #endif
        [IsoXmlTag("TaxRateMrkr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TaxRateMarker1Code? TaxRateMarker { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TaxRateMarker1Code? TaxRateMarker { get; init; } 
        #else
        public TaxRateMarker1Code? TaxRateMarker { get; set; } 
        #endif
        
        /// <summary>
        /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
        /// </summary>
        [IsoId("_QA49w8QAEemsic1bQcEtLA")]
        [DisplayName("Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Amt")]
        #endif
        [IsoXmlTag("Amt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveCurrencyAndAmount Amount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ActiveCurrencyAndAmount Amount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveCurrencyAndAmount Amount { get; init; } 
        #else
        public ActiveCurrencyAndAmount Amount { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
        /// </summary>
        [IsoId("_QA49xcQAEemsic1bQcEtLA")]
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
        /// Set of elements needed to issue a cheque.
        /// </summary>
        [IsoId("_QA49x8QAEemsic1bQcEtLA")]
        [DisplayName("Cheque Instruction")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ChqInstr")]
        #endif
        [IsoXmlTag("ChqInstr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Cheque11? ChequeInstruction { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Cheque11? ChequeInstruction { get; init; } 
        #else
        public Cheque11? ChequeInstruction { get; set; } 
        #endif
        
        /// <summary>
        /// The schedule for a credit payment arrangement. 
        /// </summary>
        [IsoId("_QA49ycQAEemsic1bQcEtLA")]
        [DisplayName("Frequency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Frqcy")]
        #endif
        [IsoXmlTag("Frqcy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Frequency1? Frequency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Frequency1? Frequency { get; init; } 
        #else
        public Frequency1? Frequency { get; set; } 
        #endif
        
        /// <summary>
        /// Provides further information about the status of transferred scheduled payment(s).
        /// </summary>
        [IsoId("_QA49y8QAEemsic1bQcEtLA")]
        [DisplayName("Transfer Instruction")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TrfInstr")]
        #endif
        [IsoXmlTag("TrfInstr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TransferInstruction1? TransferInstruction { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TransferInstruction1? TransferInstruction { get; init; } 
        #else
        public TransferInstruction1? TransferInstruction { get; set; } 
        #endif
        
        /// <summary>
        /// Ultimate party that owes an amount of money to the (ultimate) creditor.
        /// </summary>
        [IsoId("_QA49zcQAEemsic1bQcEtLA")]
        [DisplayName("Ultimate Debtor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UltmtDbtr")]
        #endif
        [IsoXmlTag("UltmtDbtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification135? UltimateDebtor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification135? UltimateDebtor { get; init; } 
        #else
        public PartyIdentification135? UltimateDebtor { get; set; } 
        #endif
        
        /// <summary>
        /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
        /// </summary>
        [IsoId("_QA49z8QAEemsic1bQcEtLA")]
        [DisplayName("Intermediary Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IntrmyAgt1")]
        #endif
        [IsoXmlTag("IntrmyAgt1")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; set; } 
        #endif
        
        /// <summary>
        /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
        /// </summary>
        [IsoId("_QA490cQAEemsic1bQcEtLA")]
        [DisplayName("Intermediary Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IntrmyAgt2")]
        #endif
        [IsoXmlTag("IntrmyAgt2")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; set; } 
        #endif
        
        /// <summary>
        /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
        /// </summary>
        [IsoId("_QA4908QAEemsic1bQcEtLA")]
        [DisplayName("Intermediary Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IntrmyAgt3")]
        #endif
        [IsoXmlTag("IntrmyAgt3")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; set; } 
        #endif
        
        /// <summary>
        /// Financial institution servicing an account for the creditor.
        /// </summary>
        [IsoId("_QA491cQAEemsic1bQcEtLA")]
        [DisplayName("Creditor Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CdtrAgt")]
        #endif
        [IsoXmlTag("CdtrAgt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; set; } 
        #endif
        
        /// <summary>
        /// Party to which an amount of money is due.
        /// </summary>
        [IsoId("_QA4918QAEemsic1bQcEtLA")]
        [DisplayName("Creditor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Cdtr")]
        #endif
        [IsoXmlTag("Cdtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification135? Creditor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification135? Creditor { get; init; } 
        #else
        public PartyIdentification135? Creditor { get; set; } 
        #endif
        
        /// <summary>
        /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
        /// </summary>
        [IsoId("_QA492cQAEemsic1bQcEtLA")]
        [DisplayName("Creditor Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CdtrAcct")]
        #endif
        [IsoXmlTag("CdtrAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CashAccount38? CreditorAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashAccount38? CreditorAccount { get; init; } 
        #else
        public CashAccount38? CreditorAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Ultimate party to which an amount of money is due.
        /// </summary>
        [IsoId("_QA4928QAEemsic1bQcEtLA")]
        [DisplayName("Ultimate Creditor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UltmtCdtr")]
        #endif
        [IsoXmlTag("UltmtCdtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification135? UltimateCreditor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification135? UltimateCreditor { get; init; } 
        #else
        public PartyIdentification135? UltimateCreditor { get; set; } 
        #endif
        
        /// <summary>
        /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor agent.
        /// </summary>
        [IsoId("_QA493cQAEemsic1bQcEtLA")]
        [DisplayName("Instruction For Creditor Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InstrForCdtrAgt")]
        #endif
        [IsoXmlTag("InstrForCdtrAgt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public InstructionForCreditorAgent3? InstructionForCreditorAgent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InstructionForCreditorAgent3? InstructionForCreditorAgent { get; init; } 
        #else
        public InstructionForCreditorAgent3? InstructionForCreditorAgent { get; set; } 
        #endif
        
        /// <summary>
        /// Underlying reason for the payment transaction.
        /// Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
        /// </summary>
        [IsoId("_QA4938QAEemsic1bQcEtLA")]
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
        /// Information needed due to regulatory and statutory requirements.
        /// </summary>
        [IsoId("_QA494cQAEemsic1bQcEtLA")]
        [DisplayName("Regulatory Reporting")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RgltryRptg")]
        #endif
        [IsoXmlTag("RgltryRptg")]
        [MinLength(0)]
        [MaxLength(10)]
        public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = new ValueList<RegulatoryReporting3>(){};
        
        /// <summary>
        /// Provides details on the tax.
        /// </summary>
        [IsoId("_QA4948QAEemsic1bQcEtLA")]
        [DisplayName("Tax")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tax")]
        #endif
        [IsoXmlTag("Tax")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TaxInformation8? Tax { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TaxInformation8? Tax { get; init; } 
        #else
        public TaxInformation8? Tax { get; set; } 
        #endif
        
        /// <summary>
        /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
        /// </summary>
        [IsoId("_QA495cQAEemsic1bQcEtLA")]
        [DisplayName("Related Remittance Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RltdRmtInf")]
        #endif
        [IsoXmlTag("RltdRmtInf")]
        [MinLength(0)]
        [MaxLength(10)]
        public ValueList<RemittanceLocation6> RelatedRemittanceInformation { get; init; } = new ValueList<RemittanceLocation6>(){};
        
        /// <summary>
        /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
        /// </summary>
        [IsoId("_QA4958QAEemsic1bQcEtLA")]
        [DisplayName("Remittance Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RmtInf")]
        #endif
        [IsoXmlTag("RmtInf")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public RemittanceInformation16? RemittanceInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RemittanceInformation16? RemittanceInformation { get; init; } 
        #else
        public RemittanceInformation16? RemittanceInformation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
