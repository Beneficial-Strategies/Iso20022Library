// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument21Choice
{
    /// <summary>
    /// Payment instrument between a debtor and a creditor, which flows through one or more financial institutions or systems.
    /// </summary>
    [IsoId("_4MizEzbsEead9bDRE_1DAQ")]
    [DisplayName("Credit Transfer Details")]
    public record CreditTransferDetails : PaymentInstrument21Choice_
    {
        /// <summary>
        /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
        /// </summary>
        [IsoId("_yCJGVTbsEead9bDRE_1DAQ")]
        [DisplayName("Reference")]
        [IsoXmlTag("Ref")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Reference { get; init; }

        /// <summary>
        /// Party that owes an amount of money to the (ultimate) creditor. In the context of the payment model, the debtor is also the debit account owner.
        /// </summary>
        [IsoId("_yCJGVzbsEead9bDRE_1DAQ")]
        [DisplayName("Debtor")]
        [IsoXmlTag("Dbtr")]
        public PartyIdentification113? Debtor { get; init; }

        /// <summary>
        /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
        /// </summary>
        [IsoId("_yCJGWTbsEead9bDRE_1DAQ")]
        [DisplayName("Debtor Account")]
        [IsoXmlTag("DbtrAcct")]
        public AccountIdentificationAndName5? DebtorAccount { get; init; }

        /// <summary>
        /// Financial institution servicing an account for the debtor.
        /// </summary>
        [IsoId("_yCJGWzbsEead9bDRE_1DAQ")]
        [DisplayName("Debtor Agent")]
        [IsoXmlTag("DbtrAgt")]
        public FinancialInstitutionIdentification10? DebtorAgent { get; init; }

        /// <summary>
        /// Identifies the account of the debtor&apos;s agent.
        /// </summary>
        [IsoId("_yCJGXTbsEead9bDRE_1DAQ")]
        [DisplayName("Debtor Agent Account")]
        [IsoXmlTag("DbtrAgtAcct")]
        public AccountIdentificationAndName5? DebtorAgentAccount { get; init; }

        /// <summary>
        /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.
        /// </summary>
        [IsoId("_yCJGXzbsEead9bDRE_1DAQ")]
        [DisplayName("Intermediary Agent")]
        [IsoXmlTag("IntrmyAgt1")]
        public FinancialInstitutionIdentification10? IntermediaryAgent1 { get; init; }

        /// <summary>
        /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
        /// </summary>
        [IsoId("_yCJGYTbsEead9bDRE_1DAQ")]
        [DisplayName("Intermediary Agent 1 Account")]
        [IsoXmlTag("IntrmyAgt1Acct")]
        public AccountIdentificationAndName5? IntermediaryAgent1Account { get; init; }

        /// <summary>
        /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.
        /// </summary>
        [IsoId("_yCJGYzbsEead9bDRE_1DAQ")]
        [DisplayName("Intermediary Agent")]
        [IsoXmlTag("IntrmyAgt2")]
        public FinancialInstitutionIdentification10? IntermediaryAgent2 { get; init; }

        /// <summary>
        /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
        /// </summary>
        [IsoId("_yCJGZTbsEead9bDRE_1DAQ")]
        [DisplayName("Intermediary Agent 2 Account")]
        [IsoXmlTag("IntrmyAgt2Acct")]
        public AccountIdentificationAndName5? IntermediaryAgent2Account { get; init; }

        /// <summary>
        /// Financial institution servicing an account for the creditor.
        /// </summary>
        [IsoId("_yCJGZzbsEead9bDRE_1DAQ")]
        [DisplayName("Creditor Agent")]
        [IsoXmlTag("CdtrAgt")]
        public required FinancialInstitutionIdentification10 CreditorAgent { get; init; }

        /// <summary>
        /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
        /// </summary>
        [IsoId("_yCJGaTbsEead9bDRE_1DAQ")]
        [DisplayName("Creditor Agent Account")]
        [IsoXmlTag("CdtrAgtAcct")]
        public AccountIdentificationAndName5? CreditorAgentAccount { get; init; }

        /// <summary>
        /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
        /// </summary>
        [IsoId("_yCJGazbsEead9bDRE_1DAQ")]
        [DisplayName("Creditor")]
        [IsoXmlTag("Cdtr")]
        public PartyIdentification113? Creditor { get; init; }

        /// <summary>
        /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
        /// </summary>
        [IsoId("_yCJGbTbsEead9bDRE_1DAQ")]
        [DisplayName("Creditor Account")]
        [IsoXmlTag("CdtrAcct")]
        public required AccountIdentificationAndName5 CreditorAccount { get; init; }
    }
}
