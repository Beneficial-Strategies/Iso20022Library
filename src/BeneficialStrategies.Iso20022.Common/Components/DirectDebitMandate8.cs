// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Direct Debit Mandate8.
/// </summary>
[IsoId("_5v46AxwMEe6O0NdiBuX__w")]
[DisplayName("Direct Debit Mandate8")]
public partial record DirectDebitMandate8
{
    #nullable enable

    /// <summary>
    /// Creditor.
    /// </summary>
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification139? Creditor { get; init; } 

    /// <summary>
    /// Creditor Agent.
    /// </summary>
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public FinancialInstitutionIdentification15? CreditorAgent { get; init; } 

    /// <summary>
    /// Creditor Agent Branch.
    /// </summary>
    [DisplayName("Creditor Agent Branch")]
    [IsoXmlTag("CdtrAgtBrnch")]
    public BranchData4? CreditorAgentBranch { get; init; } 

    /// <summary>
    /// Debtor.
    /// </summary>
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification139? Debtor { get; init; } 

    /// <summary>
    /// Debtor Account.
    /// </summary>
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required AccountIdentificationAndName5 DebtorAccount { get; init; } 

    /// <summary>
    /// Debtor Agent.
    /// </summary>
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required FinancialInstitutionIdentification15 DebtorAgent { get; init; } 

    /// <summary>
    /// Debtor Agent Branch.
    /// </summary>
    [DisplayName("Debtor Agent Branch")]
    [IsoXmlTag("DbtrAgtBrnch")]
    public BranchData4? DebtorAgentBranch { get; init; } 

    /// <summary>
    /// Debtor National Registration Number.
    /// </summary>
    [DisplayName("Debtor National Registration Number")]
    [IsoXmlTag("DbtrNtlRegnNb")]
    public IsoMax35Text? DebtorNationalRegistrationNumber { get; init; } 

    /// <summary>
    /// Debtor Tax Identification Number.
    /// </summary>
    [DisplayName("Debtor Tax Identification Number")]
    [IsoXmlTag("DbtrTaxIdNb")]
    public IsoMax35Text? DebtorTaxIdentificationNumber { get; init; } 

    /// <summary>
    /// Mandate Identification.
    /// </summary>
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    public IsoMax35Text? MandateIdentification { get; init; } 

    /// <summary>
    /// Registration Identification.
    /// </summary>
    [DisplayName("Registration Identification")]
    [IsoXmlTag("RegnId")]
    public IsoMax35Text? RegistrationIdentification { get; init; } 

    
    #nullable disable
    
}
