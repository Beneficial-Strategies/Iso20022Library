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
namespace BeneficialStrategies.Iso20022.Choices.SettlementMethod1Choice
{
    /// <summary>
    /// Specifies details of the payment to be made by the new account servicer to the old account servicer in case of a negative closing balance.
    /// </summary>
    [IsoId("_mxmv4A2uEeSNWNtJlXOAhg")]
    [DisplayName("Debit")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Debit : SettlementMethod1Choice_
    #else
    public partial class Debit : SettlementMethod1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Debit instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Debit( PaymentIdentification1 reqPaymentIdentification,ActiveCurrencyAndAmount reqAmount,BranchAndFinancialInstitutionIdentification5 reqCreditorAgent )
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
        [IsoId("_AyXSNORsEeaY150p1rZlTg")]
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
        [IsoId("_AyXSNeRsEeaY150p1rZlTg")]
        [DisplayName("Payment Type Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PmtTpInf")]
        #endif
        [IsoXmlTag("PmtTpInf")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PaymentTypeInformation19? PaymentTypeInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PaymentTypeInformation19? PaymentTypeInformation { get; init; } 
        #else
        public PaymentTypeInformation19? PaymentTypeInformation { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the rate of tax levied.
        /// </summary>
        [IsoId("_4llC0D_EEeeQPJppX1jsXQ")]
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
        [IsoId("_AyX5QORsEeaY150p1rZlTg")]
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
        [IsoId("_AyXSP-RsEeaY150p1rZlTg")]
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
        [IsoId("_AyX5QuRsEeaY150p1rZlTg")]
        [DisplayName("Cheque Instruction")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ChqInstr")]
        #endif
        [IsoXmlTag("ChqInstr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Cheque7? ChequeInstruction { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Cheque7? ChequeInstruction { get; init; } 
        #else
        public Cheque7? ChequeInstruction { get; set; } 
        #endif
        
        /// <summary>
        /// The schedule for a credit payment arrangement. 
        /// </summary>
        [IsoId("_AsXjwD_FEeeQPJppX1jsXQ")]
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
        [IsoId("_6ti8QFDYEeeunetnjWUhcA")]
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
        [IsoId("_AyXSPuRsEeaY150p1rZlTg")]
        [DisplayName("Ultimate Debtor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UltmtDbtr")]
        #endif
        [IsoXmlTag("UltmtDbtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification125? UltimateDebtor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification125? UltimateDebtor { get; init; } 
        #else
        public PartyIdentification125? UltimateDebtor { get; set; } 
        #endif
        
        /// <summary>
        /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
        /// </summary>
        [IsoId("_AyXSOORsEeaY150p1rZlTg")]
        [DisplayName("Intermediary Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IntrmyAgt1")]
        #endif
        [IsoXmlTag("IntrmyAgt1")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; set; } 
        #endif
        
        /// <summary>
        /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
        /// </summary>
        [IsoId("_AyXSQORsEeaY150p1rZlTg")]
        [DisplayName("Intermediary Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IntrmyAgt2")]
        #endif
        [IsoXmlTag("IntrmyAgt2")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; set; } 
        #endif
        
        /// <summary>
        /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
        /// </summary>
        [IsoId("_AyXSMeRsEeaY150p1rZlTg")]
        [DisplayName("Intermediary Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IntrmyAgt3")]
        #endif
        [IsoXmlTag("IntrmyAgt3")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; set; } 
        #endif
        
        /// <summary>
        /// Financial institution servicing an account for the creditor.
        /// </summary>
        [IsoId("_AyX5RORsEeaY150p1rZlTg")]
        [DisplayName("Creditor Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CdtrAgt")]
        #endif
        [IsoXmlTag("CdtrAgt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; set; } 
        #endif
        
        /// <summary>
        /// Party to which an amount of money is due.
        /// </summary>
        [IsoId("_AyX5ReRsEeaY150p1rZlTg")]
        [DisplayName("Creditor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Cdtr")]
        #endif
        [IsoXmlTag("Cdtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification125? Creditor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification125? Creditor { get; init; } 
        #else
        public PartyIdentification125? Creditor { get; set; } 
        #endif
        
        /// <summary>
        /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
        /// </summary>
        [IsoId("_AyXSO-RsEeaY150p1rZlTg")]
        [DisplayName("Creditor Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CdtrAcct")]
        #endif
        [IsoXmlTag("CdtrAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CashAccount24? CreditorAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashAccount24? CreditorAccount { get; init; } 
        #else
        public CashAccount24? CreditorAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Ultimate party to which an amount of money is due.
        /// </summary>
        [IsoId("_AyXSOuRsEeaY150p1rZlTg")]
        [DisplayName("Ultimate Creditor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UltmtCdtr")]
        #endif
        [IsoXmlTag("UltmtCdtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification125? UltimateCreditor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification125? UltimateCreditor { get; init; } 
        #else
        public PartyIdentification125? UltimateCreditor { get; set; } 
        #endif
        
        /// <summary>
        /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor agent.
        /// </summary>
        [IsoId("_AyXSOeRsEeaY150p1rZlTg")]
        [DisplayName("Instruction For Creditor Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InstrForCdtrAgt")]
        #endif
        [IsoXmlTag("InstrForCdtrAgt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public InstructionForCreditorAgent1? InstructionForCreditorAgent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InstructionForCreditorAgent1? InstructionForCreditorAgent { get; init; } 
        #else
        public InstructionForCreditorAgent1? InstructionForCreditorAgent { get; set; } 
        #endif
        
        /// <summary>
        /// Underlying reason for the payment transaction.
        /// Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
        /// </summary>
        [IsoId("_AyXSQuRsEeaY150p1rZlTg")]
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
        [IsoId("_AyXSNuRsEeaY150p1rZlTg")]
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
        [IsoId("_AyXSMuRsEeaY150p1rZlTg")]
        [DisplayName("Tax")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tax")]
        #endif
        [IsoXmlTag("Tax")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TaxInformation6? Tax { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TaxInformation6? Tax { get; init; } 
        #else
        public TaxInformation6? Tax { get; set; } 
        #endif
        
        /// <summary>
        /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
        /// </summary>
        [IsoId("_AyXSM-RsEeaY150p1rZlTg")]
        [DisplayName("Related Remittance Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RltdRmtInf")]
        #endif
        [IsoXmlTag("RltdRmtInf")]
        [MinLength(0)]
        [MaxLength(10)]
        public ValueList<RemittanceLocation2> RelatedRemittanceInformation { get; init; } = new ValueList<RemittanceLocation2>(){};
        
        /// <summary>
        /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
        /// </summary>
        [IsoId("_AyXSPORsEeaY150p1rZlTg")]
        [DisplayName("Remittance Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RmtInf")]
        #endif
        [IsoXmlTag("RmtInf")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public RemittanceInformation14? RemittanceInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RemittanceInformation14? RemittanceInformation { get; init; } 
        #else
        public RemittanceInformation14? RemittanceInformation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
