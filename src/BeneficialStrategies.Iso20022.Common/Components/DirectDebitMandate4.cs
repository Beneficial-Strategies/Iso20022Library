// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction, initiated by the creditor, to debit a debtor&apos;s account in favour of the creditor. A direct debit can be pre-authorised or not. In most countries, authorisation is in the form of a mandate between the debtor and creditor.
/// </summary>
[IsoId("_QdGJudp-Ed-ak6NoX_4Aeg_1879697")]
[DisplayName("Direct Debit Mandate")]
public record DirectDebitMandate4
{
    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_QdGJutp-Ed-ak6NoX_4Aeg_1879706")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required AccountIdentificationAndName3 DebtorAccount { get; init; }

    /// <summary>
    /// Party that owes the cash to the creditor/final party. The debtor is also the debit account owner.
    /// </summary>
    [IsoId("_QdGJu9p-Ed-ak6NoX_4Aeg_1879782")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification2Choice_? Debtor { get; init; }

    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    [IsoId("_QdGJvNp-Ed-ak6NoX_4Aeg_1879799")]
    [DisplayName("Debtor Tax Identification Number")]
    [IsoXmlTag("DbtrTaxIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DebtorTaxIdentificationNumber { get; init; }

    /// <summary>
    /// Number assigned by a national registration authority to an entity.
    /// </summary>
    [IsoId("_QdGJvdp-Ed-ak6NoX_4Aeg_1879817")]
    [DisplayName("Debtor National Registration Number")]
    [IsoXmlTag("DbtrNtlRegnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DebtorNationalRegistrationNumber { get; init; }

    /// <summary>
    /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
    /// </summary>
    [IsoId("_QdGJvtp-Ed-ak6NoX_4Aeg_1879877")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification2Choice_? Creditor { get; init; }

    /// <summary>
    /// Financial institution that receives the direct debit instruction from the creditor or other authorised party.
    /// </summary>
    [IsoId("_QdPToNp-Ed-ak6NoX_4Aeg_1879912")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required FinancialInstitutionIdentification3Choice_ DebtorAgent { get; init; }

    /// <summary>
    /// Information identifying a specific branch of a financial institution.||Usage: this component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
    /// </summary>
    [IsoId("_QdPTodp-Ed-ak6NoX_4Aeg_1880154")]
    [DisplayName("Debtor Agent Branch")]
    [IsoXmlTag("DbtrAgtBrnch")]
    public BranchData? DebtorAgentBranch { get; init; }

    /// <summary>
    /// Financial institution that receives the payment transaction on behalf of the creditor, or other nominated party, and credits the account.
    /// </summary>
    [IsoId("_QdPTotp-Ed-ak6NoX_4Aeg_1880189")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public FinancialInstitutionIdentification3Choice_? CreditorAgent { get; init; }

    /// <summary>
    /// Information identifying a specific branch of a financial institution.||Usage: this component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
    /// </summary>
    [IsoId("_QdPTo9p-Ed-ak6NoX_4Aeg_1880206")]
    [DisplayName("Creditor Agent Branch")]
    [IsoXmlTag("CdtrAgtBrnch")]
    public BranchData? CreditorAgentBranch { get; init; }

    /// <summary>
    /// Reference assigned to a creditor by its financial institution, or relevant authority, authorising the creditor to take part in a direct debit scheme.
    /// </summary>
    [IsoId("_QdPTpNp-Ed-ak6NoX_4Aeg_1880224")]
    [DisplayName("Registration Identification")]
    [IsoXmlTag("RegnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RegistrationIdentification { get; init; }

    /// <summary>
    /// Reference of the direct debit mandate that has been agreed upon by the debtor and creditor.
    /// </summary>
    [IsoId("_QdPTpdp-Ed-ak6NoX_4Aeg_1880249")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateIdentification { get; init; }
}
