// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument18Choice
{
    /// <summary>
    /// Settlement instructions for a payment by direct debit.
    /// </summary>
    [IsoId("_fprtBSC1EeWJd9HF2tO7BA")]
    [DisplayName("Direct Debit Details")]
    public partial record DirectDebitDetails : PaymentInstrument18Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
        /// </summary>
        [IsoId("_DwqQUyC4EeWJd9HF2tO7BA")]
        [DisplayName("Debtor Account")]
        [IsoXmlTag("DbtrAcct")]
        public required AccountIdentificationAndName5 DebtorAccount { get; init; } 
        
        /// <summary>
        /// Party that owes the cash to the creditor/final party. The debtor is also the debit account owner.
        /// </summary>
        [IsoId("_DwqQVSC4EeWJd9HF2tO7BA")]
        [DisplayName("Debtor")]
        [IsoXmlTag("Dbtr")]
        public PartyIdentification70Choice_? Debtor { get; init; } 
        
        /// <summary>
        /// Number assigned by a tax authority to an entity.
        /// </summary>
        [IsoId("_DwqQVyC4EeWJd9HF2tO7BA")]
        [DisplayName("Debtor Tax Identification Number")]
        [IsoXmlTag("DbtrTaxIdNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? DebtorTaxIdentificationNumber { get; init; } 
        
        /// <summary>
        /// Number assigned by a national registration authority to an entity.
        /// </summary>
        [IsoId("_DwqQWSC4EeWJd9HF2tO7BA")]
        [DisplayName("Debtor National Registration Number")]
        [IsoXmlTag("DbtrNtlRegnNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? DebtorNationalRegistrationNumber { get; init; } 
        
        /// <summary>
        /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
        /// </summary>
        [IsoId("_DwqQWyC4EeWJd9HF2tO7BA")]
        [DisplayName("Creditor")]
        [IsoXmlTag("Cdtr")]
        public PartyIdentification70Choice_? Creditor { get; init; } 
        
        /// <summary>
        /// Financial institution that receives the direct debit instruction from the creditor or other authorised party.
        /// </summary>
        [IsoId("_DwqQXSC4EeWJd9HF2tO7BA")]
        [DisplayName("Debtor Agent")]
        [IsoXmlTag("DbtrAgt")]
        public required FinancialInstitutionIdentification7Choice_ DebtorAgent { get; init; } 
        
        /// <summary>
        /// Information identifying a specific branch of a financial institution.||Usage: this component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
        /// </summary>
        [IsoId("_DwqQXyC4EeWJd9HF2tO7BA")]
        [DisplayName("Debtor Agent Branch")]
        [IsoXmlTag("DbtrAgtBrnch")]
        public BranchData? DebtorAgentBranch { get; init; } 
        
        /// <summary>
        /// Financial institution that receives the payment transaction on behalf of the creditor, or other nominated party, and credits the account.
        /// </summary>
        [IsoId("_DwqQYSC4EeWJd9HF2tO7BA")]
        [DisplayName("Creditor Agent")]
        [IsoXmlTag("CdtrAgt")]
        public FinancialInstitutionIdentification7Choice_? CreditorAgent { get; init; } 
        
        /// <summary>
        /// Information identifying a specific branch of a financial institution.||Usage: this component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
        /// </summary>
        [IsoId("_DwqQYyC4EeWJd9HF2tO7BA")]
        [DisplayName("Creditor Agent Branch")]
        [IsoXmlTag("CdtrAgtBrnch")]
        public BranchData? CreditorAgentBranch { get; init; } 
        
        /// <summary>
        /// Reference assigned to a creditor by its financial institution, or relevant authority, authorising the creditor to take part in a direct debit scheme.
        /// </summary>
        [IsoId("_DwqQZSC4EeWJd9HF2tO7BA")]
        [DisplayName("Registration Identification")]
        [IsoXmlTag("RegnId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? RegistrationIdentification { get; init; } 
        
        /// <summary>
        /// Reference of the direct debit mandate that has been agreed upon by the debtor and creditor.
        /// </summary>
        [IsoId("_DwqQZyC4EeWJd9HF2tO7BA")]
        [DisplayName("Mandate Identification")]
        [IsoXmlTag("MndtId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? MandateIdentification { get; init; } 
        
        
        #nullable disable
        
    }
}
