// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementMethod4Choice
{
    /// <summary>
    /// Specifies details of the payment to be made by the new account servicer to the old account servicer in case of a negative closing balance.
    /// </summary>
    [IsoId("_dYSZg9cZEeqRFcf2R4bPBw")]
    [DisplayName("Debit")]
    public partial record Debit : SettlementMethod4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Set of elements used to reference a payment instruction. 
        /// </summary>
        [IsoId("_bk8zq9cZEeqRFcf2R4bPBw")]
        [DisplayName("Payment Identification")]
        [IsoXmlTag("PmtId")]
        public required PaymentIdentification6 PaymentIdentification { get; init; } 
        
        /// <summary>
        /// Set of elements used to further specify the type of transaction.
        /// </summary>
        [IsoId("_bk8zrdcZEeqRFcf2R4bPBw")]
        [DisplayName("Payment Type Information")]
        [IsoXmlTag("PmtTpInf")]
        public PaymentTypeInformation26? PaymentTypeInformation { get; init; } 
        
        /// <summary>
        /// Specifies the rate of tax levied.
        /// </summary>
        [IsoId("_bk8zr9cZEeqRFcf2R4bPBw")]
        [DisplayName("Tax Rate Marker")]
        [IsoXmlTag("TaxRateMrkr")]
        public TaxRateMarker1Code? TaxRateMarker { get; init; } 
        
        /// <summary>
        /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
        /// </summary>
        [IsoId("_bk8zsdcZEeqRFcf2R4bPBw")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAndAmount Amount { get; init; } 
        
        /// <summary>
        /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
        /// </summary>
        [IsoId("_bk8zs9cZEeqRFcf2R4bPBw")]
        [DisplayName("Charge Bearer")]
        [IsoXmlTag("ChrgBr")]
        public ChargeBearerType1Code? ChargeBearer { get; init; } 
        
        /// <summary>
        /// Set of elements needed to issue a cheque.
        /// </summary>
        [IsoId("_bk8ztdcZEeqRFcf2R4bPBw")]
        [DisplayName("Cheque Instruction")]
        [IsoXmlTag("ChqInstr")]
        public Cheque11? ChequeInstruction { get; init; } 
        
        /// <summary>
        /// The schedule for a credit payment arrangement. 
        /// </summary>
        [IsoId("_bk8zt9cZEeqRFcf2R4bPBw")]
        [DisplayName("Frequency")]
        [IsoXmlTag("Frqcy")]
        public Frequency1? Frequency { get; init; } 
        
        /// <summary>
        /// Provides further information about the status of transferred scheduled payment(s).
        /// </summary>
        [IsoId("_bk8zudcZEeqRFcf2R4bPBw")]
        [DisplayName("Transfer Instruction")]
        [IsoXmlTag("TrfInstr")]
        public TransferInstruction1? TransferInstruction { get; init; } 
        
        /// <summary>
        /// Ultimate party that owes an amount of money to the (ultimate) creditor.
        /// </summary>
        [IsoId("_bk8zu9cZEeqRFcf2R4bPBw")]
        [DisplayName("Ultimate Debtor")]
        [IsoXmlTag("UltmtDbtr")]
        public PartyIdentification135? UltimateDebtor { get; init; } 
        
        /// <summary>
        /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
        /// </summary>
        [IsoId("_bk8zvdcZEeqRFcf2R4bPBw")]
        [DisplayName("Intermediary Agent")]
        [IsoXmlTag("IntrmyAgt1")]
        public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; } 
        
        /// <summary>
        /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
        /// </summary>
        [IsoId("_bk8zv9cZEeqRFcf2R4bPBw")]
        [DisplayName("Intermediary Agent")]
        [IsoXmlTag("IntrmyAgt2")]
        public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; } 
        
        /// <summary>
        /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
        /// </summary>
        [IsoId("_bk8zwdcZEeqRFcf2R4bPBw")]
        [DisplayName("Intermediary Agent")]
        [IsoXmlTag("IntrmyAgt3")]
        public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; } 
        
        /// <summary>
        /// Financial institution servicing an account for the creditor.
        /// </summary>
        [IsoId("_bk8zw9cZEeqRFcf2R4bPBw")]
        [DisplayName("Creditor Agent")]
        [IsoXmlTag("CdtrAgt")]
        public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; } 
        
        /// <summary>
        /// Party to which an amount of money is due.
        /// </summary>
        [IsoId("_bk8zxdcZEeqRFcf2R4bPBw")]
        [DisplayName("Creditor")]
        [IsoXmlTag("Cdtr")]
        public PartyIdentification135? Creditor { get; init; } 
        
        /// <summary>
        /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
        /// </summary>
        [IsoId("_bk8zx9cZEeqRFcf2R4bPBw")]
        [DisplayName("Creditor Account")]
        [IsoXmlTag("CdtrAcct")]
        public CashAccount40? CreditorAccount { get; init; } 
        
        /// <summary>
        /// Ultimate party to which an amount of money is due.
        /// </summary>
        [IsoId("_bk8zydcZEeqRFcf2R4bPBw")]
        [DisplayName("Ultimate Creditor")]
        [IsoXmlTag("UltmtCdtr")]
        public PartyIdentification135? UltimateCreditor { get; init; } 
        
        /// <summary>
        /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor agent.
        /// </summary>
        [IsoId("_bk8zy9cZEeqRFcf2R4bPBw")]
        [DisplayName("Instruction For Creditor Agent")]
        [IsoXmlTag("InstrForCdtrAgt")]
        public InstructionForCreditorAgent3? InstructionForCreditorAgent { get; init; } 
        
        /// <summary>
        /// Underlying reason for the payment transaction.
        /// Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
        /// </summary>
        [IsoId("_bk8zzdcZEeqRFcf2R4bPBw")]
        [DisplayName("Purpose")]
        [IsoXmlTag("Purp")]
        public Purpose2Choice_? Purpose { get; init; } 
        
        /// <summary>
        /// Information needed due to regulatory and statutory requirements.
        /// </summary>
        [IsoId("_bk8zz9cZEeqRFcf2R4bPBw")]
        [DisplayName("Regulatory Reporting")]
        [IsoXmlTag("RgltryRptg")]
        [MinLength(0)]
        [MaxLength(10)]
        public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = new ValueList<RegulatoryReporting3>(){};
        
        /// <summary>
        /// Provides details on the tax.
        /// </summary>
        [IsoId("_bk8z0dcZEeqRFcf2R4bPBw")]
        [DisplayName("Tax")]
        [IsoXmlTag("Tax")]
        public TaxInformation10? Tax { get; init; } 
        
        /// <summary>
        /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
        /// </summary>
        [IsoId("_bk8z09cZEeqRFcf2R4bPBw")]
        [DisplayName("Related Remittance Information")]
        [IsoXmlTag("RltdRmtInf")]
        [MinLength(0)]
        [MaxLength(10)]
        public ValueList<RemittanceLocation6> RelatedRemittanceInformation { get; init; } = new ValueList<RemittanceLocation6>(){};
        
        /// <summary>
        /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
        /// </summary>
        [IsoId("_bk8z1dcZEeqRFcf2R4bPBw")]
        [DisplayName("Remittance Information")]
        [IsoXmlTag("RmtInf")]
        public RemittanceInformation21? RemittanceInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
