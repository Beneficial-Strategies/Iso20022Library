// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information needed to move funds from the debtor's account to the creditor.
/// </summary>
[IsoId("94360db3-d49d-45e1-8a89-02011544ab99")]
[DisplayName("Credit Transfer12")]
public record CreditTransfer12
{
    /// <summary>
    /// Unique identification as assigned by an instructing party for an instructed party to unambiguously identify the instruction.
    /// </summary>
    [IsoId("b5a12345-0001-0001-0001-94360db3d49d")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public IsoMax35Text? Reference { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("b5a12345-0002-0002-0002-94360db3d49d")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification139? Debtor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made.
    /// </summary>
    [IsoId("b5a12345-0003-0003-0003-94360db3d49d")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public AccountIdentificationAndName8? DebtorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("b5a12345-0004-0004-0004-94360db3d49d")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public FinancialInstitutionIdentification17? DebtorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent.
    /// </summary>
    [IsoId("b5a12345-0005-0005-0005-94360db3d49d")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public AccountIdentificationAndName8? DebtorAgentAccount { get; init; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.
    /// </summary>
    [IsoId("b5a12345-0006-0006-0006-94360db3d49d")]
    [DisplayName("Intermediary Agent1")]
    [IsoXmlTag("IntrmyAgt1")]
    public FinancialInstitutionIdentification17? IntermediaryAgent1 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent.
    /// </summary>
    [IsoId("b5a12345-0007-0007-0007-94360db3d49d")]
    [DisplayName("Intermediary Agent1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public AccountIdentificationAndName8? IntermediaryAgent1Account { get; init; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.
    /// </summary>
    [IsoId("b5a12345-0008-0008-0008-94360db3d49d")]
    [DisplayName("Intermediary Agent2")]
    [IsoXmlTag("IntrmyAgt2")]
    public FinancialInstitutionIdentification17? IntermediaryAgent2 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent.
    /// </summary>
    [IsoId("b5a12345-0009-0009-0009-94360db3d49d")]
    [DisplayName("Intermediary Agent2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public AccountIdentificationAndName8? IntermediaryAgent2Account { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("b5a12345-0010-0010-0010-94360db3d49d")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required FinancialInstitutionIdentification17 CreditorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent.
    /// </summary>
    [IsoId("b5a12345-0011-0011-0011-94360db3d49d")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public AccountIdentificationAndName8? CreditorAgentAccount { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("b5a12345-0012-0012-0012-94360db3d49d")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification139? Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted.
    /// </summary>
    [IsoId("b5a12345-0013-0013-0013-94360db3d49d")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public required AccountIdentificationAndName8 CreditorAccount { get; init; }
}
