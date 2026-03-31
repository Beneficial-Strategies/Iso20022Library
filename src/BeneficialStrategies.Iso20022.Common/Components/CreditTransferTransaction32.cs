// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details specific to the individual transaction(s) included in the message.
/// </summary>
[IsoId("_ZooK0YtlEee-OJ-wXSj3YQ")]
[DisplayName("Credit Transfer Transaction")]
public record CreditTransferTransaction32
{
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_Zx_iQ4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification125? UltimateDebtor { get; init; }

    /// <summary>
    /// Party that initiates the payment.|Usage: This can be either the debtor or a party that initiates the credit transfer on behalf of the debtor.
    /// </summary>
    [IsoId("_Zx_iRYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification125? InitiatingParty { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_Zx_iR4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification125 Debtor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_Zx_iSYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_Zx_iS4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Zx_iTYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_ns2ThotlEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent1 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_ns2Th4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent 1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    public CashAccount24? PreviousInstructingAgent1Account { get; init; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_ns2TiItlEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent2 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_ns2TiYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent 2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    public CashAccount24? PreviousInstructingAgent2Account { get; init; }

    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    [IsoId("_ns2TiotlEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent3 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_ns2Ti4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent 3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    public CashAccount24? PreviousInstructingAgent3Account { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    [IsoId("_Zx_iU4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Zx_iVYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount24? IntermediaryAgent1Account { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    [IsoId("_Zx_iV4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Zx_iWYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount24? IntermediaryAgent2Account { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    [IsoId("_Zx_iW4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Zx_iXYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount24? IntermediaryAgent3Account { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_Zx_iX4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_Zx_iYYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_Zx_iY4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification125 Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_Zx_iZYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_Zx_iZ4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification125? UltimateCreditor { get; init; }

    /// <summary>
    /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor agent.
    /// </summary>
    [IsoId("_Zx_iaYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent1> InstructionForCreditorAgent { get; init; } = [];

    /// <summary>
    /// Further information related to the processing of the payment instruction that may need to be acted upon by the next agent.
    /// </summary>
    [IsoId("_Zx_ia4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <summary>
    /// Provides details on the tax.
    /// </summary>
    [IsoId("_Zx_ibYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation6? Tax { get; init; }

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [IsoId("_Zx_ib4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation15? RemittanceInformation { get; init; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_Zx_icYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }
}
