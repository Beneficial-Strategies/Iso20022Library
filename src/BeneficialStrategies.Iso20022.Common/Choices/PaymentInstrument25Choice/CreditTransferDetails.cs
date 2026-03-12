// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument25Choice
{
    /// <summary>
    /// Payment instrument between a debtor and a creditor that flows through one or more financial institutions or systems.
    /// </summary>
    [IsoId("_M8JPUf8REemYYvJytExgzA")]
    [DisplayName("Credit Transfer Details")]
    public partial record CreditTransferDetails : PaymentInstrument25Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Party that owes an amount of money to the (ultimate) creditor. In the context of the payment model, the debtor is also the debit account owner.
        /// </summary>
        [IsoId("_zEgdd03zEeiQHa-q1Uephw")]
        [DisplayName("Debtor")]
        [IsoXmlTag("Dbtr")]
        public PartyIdentification132? Debtor { get; init; } 
        
        /// <summary>
        /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
        /// </summary>
        [IsoId("_zEgdeU3zEeiQHa-q1Uephw")]
        [DisplayName("Debtor Account")]
        [IsoXmlTag("DbtrAcct")]
        public AccountIdentificationAndName6? DebtorAccount { get; init; } 
        
        /// <summary>
        /// Financial institution servicing the account for the debtor.
        /// </summary>
        [IsoId("_zEgde03zEeiQHa-q1Uephw")]
        [DisplayName("Debtor Agent")]
        [IsoXmlTag("DbtrAgt")]
        public FinancialInstitutionIdentification16? DebtorAgent { get; init; } 
        
        /// <summary>
        /// Identifies the account of the debtor&apos;s agent.
        /// </summary>
        [IsoId("_zEgdfU3zEeiQHa-q1Uephw")]
        [DisplayName("Debtor Agent Account")]
        [IsoXmlTag("DbtrAgtAcct")]
        public AccountIdentificationAndName6? DebtorAgentAccount { get; init; } 
        
        /// <summary>
        /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.
        /// </summary>
        [IsoId("_zEgdf03zEeiQHa-q1Uephw")]
        [DisplayName("Intermediary Agent")]
        [IsoXmlTag("IntrmyAgt1")]
        public FinancialInstitutionIdentification16? IntermediaryAgent1 { get; init; } 
        
        /// <summary>
        /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
        /// </summary>
        [IsoId("_zEgdgU3zEeiQHa-q1Uephw")]
        [DisplayName("Intermediary Agent 1 Account")]
        [IsoXmlTag("IntrmyAgt1Acct")]
        public AccountIdentificationAndName6? IntermediaryAgent1Account { get; init; } 
        
        /// <summary>
        /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.
        /// </summary>
        [IsoId("_zEgdg03zEeiQHa-q1Uephw")]
        [DisplayName("Intermediary Agent")]
        [IsoXmlTag("IntrmyAgt2")]
        public FinancialInstitutionIdentification16? IntermediaryAgent2 { get; init; } 
        
        /// <summary>
        /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
        /// </summary>
        [IsoId("_zEgdhU3zEeiQHa-q1Uephw")]
        [DisplayName("Intermediary Agent 2 Account")]
        [IsoXmlTag("IntrmyAgt2Acct")]
        public AccountIdentificationAndName6? IntermediaryAgent2Account { get; init; } 
        
        /// <summary>
        /// Financial institution servicing the account for the creditor.
        /// </summary>
        [IsoId("_zEgdh03zEeiQHa-q1Uephw")]
        [DisplayName("Creditor Agent")]
        [IsoXmlTag("CdtrAgt")]
        public required FinancialInstitutionIdentification16 CreditorAgent { get; init; } 
        
        /// <summary>
        /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
        /// </summary>
        [IsoId("_zEgdiU3zEeiQHa-q1Uephw")]
        [DisplayName("Creditor Agent Account")]
        [IsoXmlTag("CdtrAgtAcct")]
        public AccountIdentificationAndName6? CreditorAgentAccount { get; init; } 
        
        /// <summary>
        /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
        /// </summary>
        [IsoId("_zEgdi03zEeiQHa-q1Uephw")]
        [DisplayName("Creditor")]
        [IsoXmlTag("Cdtr")]
        public PartyIdentification132? Creditor { get; init; } 
        
        /// <summary>
        /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
        /// </summary>
        [IsoId("_zEgdjU3zEeiQHa-q1Uephw")]
        [DisplayName("Creditor Account")]
        [IsoXmlTag("CdtrAcct")]
        public required AccountIdentificationAndName6 CreditorAccount { get; init; } 
        
        
        #nullable disable
        
    }
}
