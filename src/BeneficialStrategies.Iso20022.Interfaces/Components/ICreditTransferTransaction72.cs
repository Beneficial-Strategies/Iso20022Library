// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details specific to the individual transaction(s) included in the message.
/// </summary>
[IsoId("83c0d23e-26b3-45a5-9881-5eba6c105141")]
public interface ICreditTransferTransaction72 : IIsoComponent
{
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("83c0d23e-0001-0001-0001-26b345a59881")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    IPaymentIdentification13? PaymentIdentification { get; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("83c0d23e-0002-0002-0002-26b345a59881")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    IPaymentTypeInformation28? PaymentTypeInformation { get; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("83c0d23e-0003-0003-0003-26b345a59881")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    IPartyIdentification272? UltimateDebtor { get; }

    /// <summary>
    /// Party that initiates the payment message.
    /// </summary>
    [IsoId("83c0d23e-0004-0004-0004-26b345a59881")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    IPartyIdentification272? InitiatingParty { get; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("83c0d23e-0005-0005-0005-26b345a59881")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    IPartyIdentification272 Debtor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made.
    /// </summary>
    [IsoId("83c0d23e-0006-0006-0006-26b345a59881")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    ICashAccount40? DebtorAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("83c0d23e-0007-0007-0007-26b345a59881")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    IBranchAndFinancialInstitutionIdentification8 DebtorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent.
    /// </summary>
    [IsoId("83c0d23e-0008-0008-0008-26b345a59881")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    ICashAccount40? DebtorAgentAccount { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (previous instructing agent 1).
    /// </summary>
    [IsoId("83c0d23e-0009-0009-0009-26b345a59881")]
    [DisplayName("Previous Instructing Agent1")]
    [IsoXmlTag("PrvsInstgAgt1")]
    IBranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent1 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent 1.
    /// </summary>
    [IsoId("83c0d23e-0010-0010-0010-26b345a59881")]
    [DisplayName("Previous Instructing Agent1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    ICashAccount40? PreviousInstructingAgent1Account { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (previous instructing agent 2).
    /// </summary>
    [IsoId("83c0d23e-0011-0011-0011-26b345a59881")]
    [DisplayName("Previous Instructing Agent2")]
    [IsoXmlTag("PrvsInstgAgt2")]
    IBranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent2 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent 2.
    /// </summary>
    [IsoId("83c0d23e-0012-0012-0012-26b345a59881")]
    [DisplayName("Previous Instructing Agent2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    ICashAccount40? PreviousInstructingAgent2Account { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (previous instructing agent 3).
    /// </summary>
    [IsoId("83c0d23e-0013-0013-0013-26b345a59881")]
    [DisplayName("Previous Instructing Agent3")]
    [IsoXmlTag("PrvsInstgAgt3")]
    IBranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent3 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent 3.
    /// </summary>
    [IsoId("83c0d23e-0014-0014-0014-26b345a59881")]
    [DisplayName("Previous Instructing Agent3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    ICashAccount40? PreviousInstructingAgent3Account { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (intermediary agent 1).
    /// </summary>
    [IsoId("83c0d23e-0015-0015-0015-26b345a59881")]
    [DisplayName("Intermediary Agent1")]
    [IsoXmlTag("IntrmyAgt1")]
    IBranchAndFinancialInstitutionIdentification8? IntermediaryAgent1 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1.
    /// </summary>
    [IsoId("83c0d23e-0016-0016-0016-26b345a59881")]
    [DisplayName("Intermediary Agent1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    ICashAccount40? IntermediaryAgent1Account { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (intermediary agent 2).
    /// </summary>
    [IsoId("83c0d23e-0017-0017-0017-26b345a59881")]
    [DisplayName("Intermediary Agent2")]
    [IsoXmlTag("IntrmyAgt2")]
    IBranchAndFinancialInstitutionIdentification8? IntermediaryAgent2 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2.
    /// </summary>
    [IsoId("83c0d23e-0018-0018-0018-26b345a59881")]
    [DisplayName("Intermediary Agent2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    ICashAccount40? IntermediaryAgent2Account { get; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent (intermediary agent 3).
    /// </summary>
    [IsoId("83c0d23e-0019-0019-0019-26b345a59881")]
    [DisplayName("Intermediary Agent3")]
    [IsoXmlTag("IntrmyAgt3")]
    IBranchAndFinancialInstitutionIdentification8? IntermediaryAgent3 { get; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3.
    /// </summary>
    [IsoId("83c0d23e-0020-0020-0020-26b345a59881")]
    [DisplayName("Intermediary Agent3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    ICashAccount40? IntermediaryAgent3Account { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("83c0d23e-0021-0021-0021-26b345a59881")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification8 CreditorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent.
    /// </summary>
    [IsoId("83c0d23e-0022-0022-0022-26b345a59881")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    ICashAccount40? CreditorAgentAccount { get; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("83c0d23e-0023-0023-0023-26b345a59881")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    IPartyIdentification272 Creditor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted.
    /// </summary>
    [IsoId("83c0d23e-0024-0024-0024-26b345a59881")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    ICashAccount40? CreditorAccount { get; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("83c0d23e-0025-0025-0025-26b345a59881")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    IPartyIdentification272? UltimateCreditor { get; }

    /// <summary>
    /// Underlying reason for the payment transaction.
    /// </summary>
    [IsoId("83c0d23e-0026-0026-0026-26b345a59881")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    IPurpose2Choice? Purpose { get; }

    /// <summary>
    /// Further instructions concerning the processing of the payment instruction.
    /// </summary>
    [IsoId("83c0d23e-0027-0027-0027-26b345a59881")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    IEnumerable<IInstructionForCreditorAgent3> InstructionForCreditorAgent { get; }

    /// <summary>
    /// Further instructions concerning the processing of the payment instruction to the next agent.
    /// </summary>
    [IsoId("83c0d23e-0028-0028-0028-26b345a59881")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    IEnumerable<IInstructionForNextAgent1> InstructionForNextAgent { get; }

    /// <summary>
    /// Tax information.
    /// </summary>
    [IsoId("83c0d23e-0029-0029-0029-26b345a59881")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    ITaxData1? Tax { get; }

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle.
    /// </summary>
    [IsoId("83c0d23e-0030-0030-0030-26b345a59881")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    IRemittanceInformation26? RemittanceInformation { get; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges.
    /// </summary>
    [IsoId("83c0d23e-0031-0031-0031-26b345a59881")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; }
}
