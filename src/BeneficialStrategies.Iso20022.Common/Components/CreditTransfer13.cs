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
[IsoId("a33039aa-bf55-47e6-a598-68f0ecf7e0e0")]
[DisplayName("Credit Transfer13")]
public record CreditTransfer13
{
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("a33039aa-0001-0001-0001-bf5547e6a598")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification132? Debtor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made.
    /// </summary>
    [IsoId("a33039aa-0002-0002-0002-bf5547e6a598")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public AccountIdentificationAndName9? DebtorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("a33039aa-0003-0003-0003-bf5547e6a598")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public FinancialInstitutionIdentification16? DebtorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent.
    /// </summary>
    [IsoId("a33039aa-0004-0004-0004-bf5547e6a598")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public AccountIdentificationAndName9? DebtorAgentAccount { get; init; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.
    /// </summary>
    [IsoId("a33039aa-0005-0005-0005-bf5547e6a598")]
    [DisplayName("Intermediary Agent1")]
    [IsoXmlTag("IntrmyAgt1")]
    public FinancialInstitutionIdentification16? IntermediaryAgent1 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent.
    /// </summary>
    [IsoId("a33039aa-0006-0006-0006-bf5547e6a598")]
    [DisplayName("Intermediary Agent1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public AccountIdentificationAndName9? IntermediaryAgent1Account { get; init; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.
    /// </summary>
    [IsoId("a33039aa-0007-0007-0007-bf5547e6a598")]
    [DisplayName("Intermediary Agent2")]
    [IsoXmlTag("IntrmyAgt2")]
    public FinancialInstitutionIdentification16? IntermediaryAgent2 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent.
    /// </summary>
    [IsoId("a33039aa-0008-0008-0008-bf5547e6a598")]
    [DisplayName("Intermediary Agent2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public AccountIdentificationAndName9? IntermediaryAgent2Account { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("a33039aa-0009-0009-0009-bf5547e6a598")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required FinancialInstitutionIdentification16 CreditorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent.
    /// </summary>
    [IsoId("a33039aa-0010-0010-0010-bf5547e6a598")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public AccountIdentificationAndName9? CreditorAgentAccount { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("a33039aa-0011-0011-0011-bf5547e6a598")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification132? Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted.
    /// </summary>
    [IsoId("a33039aa-0012-0012-0012-bf5547e6a598")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public required AccountIdentificationAndName9 CreditorAccount { get; init; }
}
