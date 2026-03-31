// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment instrument between a debtor and a creditor, which flows through one or more financial institutions or systems.
/// </summary>
[IsoId("_Qcynu9p-Ed-ak6NoX_4Aeg_86583344")]
[DisplayName("Credit Transfer")]
public record CreditTransfer6
{
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [IsoId("_QcynvNp-Ed-ak6NoX_4Aeg_86583379")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Reference { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor. In the context of the payment model, the debtor is also the debit account owner.
    /// </summary>
    [IsoId("_Qcynvdp-Ed-ak6NoX_4Aeg_1082187783")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification2Choice_? Debtor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_Qcynvtp-Ed-ak6NoX_4Aeg_1082187817")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public AccountIdentificationAndName3? DebtorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_Qc8YsNp-Ed-ak6NoX_4Aeg_1082187800")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public FinancialInstitutionIdentification3Choice_? DebtorAgent { get; init; }

    /// <summary>
    /// Identifies the account of the debtor&apos;s agent.
    /// </summary>
    [IsoId("_Qc8Ysdp-Ed-ak6NoX_4Aeg_1407001793")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public AccountIdentificationAndName3? DebtorAgentAccount { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.
    /// </summary>
    [IsoId("_Qc8Ystp-Ed-ak6NoX_4Aeg_-1856986758")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public FinancialInstitutionIdentification3Choice_? IntermediaryAgent1 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Qc8Ys9p-Ed-ak6NoX_4Aeg_-1831128514")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public AccountIdentificationAndName3? IntermediaryAgent1Account { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.
    /// </summary>
    [IsoId("_Qc8YtNp-Ed-ak6NoX_4Aeg_-69049453")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public FinancialInstitutionIdentification3Choice_? IntermediaryAgent2 { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_Qc8Ytdp-Ed-ak6NoX_4Aeg_60241180")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public AccountIdentificationAndName3? IntermediaryAgent2Account { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_Qc8Yttp-Ed-ak6NoX_4Aeg_1162659793")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required FinancialInstitutionIdentification3Choice_ CreditorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_Qc8Yt9p-Ed-ak6NoX_4Aeg_1562544074")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public AccountIdentificationAndName3? CreditorAgentAccount { get; init; }

    /// <summary>
    /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
    /// </summary>
    [IsoId("_Qc8YuNp-Ed-ak6NoX_4Aeg_1975357297")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification2Choice_? Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_Qc8Yudp-Ed-ak6NoX_4Aeg_2089876270")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public required AccountIdentificationAndName3 CreditorAccount { get; init; }
}
