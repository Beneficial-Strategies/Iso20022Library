// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Direct debit mandate parties and accounts.
/// </summary>
[IsoId("_avW_gZTBEemqYPWMBuVawg")]
[DisplayName("Direct Debit Mandate")]
public partial record DirectDebitMandate7
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_bCsyQ5TBEemqYPWMBuVawg")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required AccountIdentificationAndName5 DebtorAccount { get; init; } 
    
    /// <summary>
    /// Party that owes the cash to the creditor/final party. The debtor is also the debit account owner.
    /// </summary>
    [IsoId("_bCsyRZTBEemqYPWMBuVawg")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification125Choice_? Debtor { get; init; } 
    
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    [IsoId("_bCsyR5TBEemqYPWMBuVawg")]
    [DisplayName("Debtor Tax Identification Number")]
    [IsoXmlTag("DbtrTaxIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DebtorTaxIdentificationNumber { get; init; } 
    
    /// <summary>
    /// Number assigned by a national registration authority to an entity.
    /// </summary>
    [IsoId("_bCsySZTBEemqYPWMBuVawg")]
    [DisplayName("Debtor National Registration Number")]
    [IsoXmlTag("DbtrNtlRegnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DebtorNationalRegistrationNumber { get; init; } 
    
    /// <summary>
    /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
    /// </summary>
    [IsoId("_bCsyS5TBEemqYPWMBuVawg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification125Choice_? Creditor { get; init; } 
    
    /// <summary>
    /// Financial institution that receives the direct debit instruction from the creditor or other authorised party.
    /// </summary>
    [IsoId("_bCsyTZTBEemqYPWMBuVawg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required FinancialInstitutionIdentification11Choice_ DebtorAgent { get; init; } 
    
    /// <summary>
    /// Information identifying a specific branch of a financial institution.||Usage: this component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
    /// </summary>
    [IsoId("_bCsyT5TBEemqYPWMBuVawg")]
    [DisplayName("Debtor Agent Branch")]
    [IsoXmlTag("DbtrAgtBrnch")]
    public BranchData4? DebtorAgentBranch { get; init; } 
    
    /// <summary>
    /// Financial institution that receives the payment transaction on behalf of the creditor, or other nominated party, and credits the account.
    /// </summary>
    [IsoId("_bCsyUZTBEemqYPWMBuVawg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public FinancialInstitutionIdentification11Choice_? CreditorAgent { get; init; } 
    
    /// <summary>
    /// Information identifying a specific branch of a financial institution.||Usage: this component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
    /// </summary>
    [IsoId("_bCsyU5TBEemqYPWMBuVawg")]
    [DisplayName("Creditor Agent Branch")]
    [IsoXmlTag("CdtrAgtBrnch")]
    public BranchData4? CreditorAgentBranch { get; init; } 
    
    /// <summary>
    /// Reference assigned to a creditor by its financial institution, or relevant authority, authorising the creditor to take part in a direct debit scheme.
    /// </summary>
    [IsoId("_bCsyVZTBEemqYPWMBuVawg")]
    [DisplayName("Registration Identification")]
    [IsoXmlTag("RegnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RegistrationIdentification { get; init; } 
    
    /// <summary>
    /// Reference of the direct debit mandate that has been agreed upon by the debtor and creditor.
    /// </summary>
    [IsoId("_bCsyV5TBEemqYPWMBuVawg")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MandateIdentification { get; init; } 
    
    
    #nullable disable
    
}
