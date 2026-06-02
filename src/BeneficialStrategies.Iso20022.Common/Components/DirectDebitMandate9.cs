// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction, initiated by the creditor, to debit a debtor's account in favour of the creditor. A direct debit can be pre-authorised or not. In most countries, authorisation is in the form of a mandate between the debtor and creditor.
/// </summary>
[IsoId("db3ffb7d-6517-4222-8db1-5553a23a09ed")]
[DisplayName("Direct Debit Mandate9")]
public record DirectDebitMandate9
{
    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("07943444-8086-4135-8214-c3e1e89fc628")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required AccountIdentificationAndName8 DebtorAccount { get; init; }

    /// <summary>
    /// Party that owes the cash to the creditor/final party. The debtor is also the debit account owner.
    /// </summary>
    [IsoId("79f12469-7e02-4fbe-8159-010cee6b7065")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification139? Debtor { get; init; }

    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    [IsoId("c6223f8a-cee2-445b-ad32-a3bfe5e07236")]
    [DisplayName("Debtor Tax Identification Number")]
    [IsoXmlTag("DbtrTaxIdNb")]
    public IsoMax35Text? DebtorTaxIdentificationNumber { get; init; }

    /// <summary>
    /// Number assigned by a national registration authority to an entity.
    /// </summary>
    [IsoId("9f6b5810-7906-4a12-acb6-83669cf12a7d")]
    [DisplayName("Debtor National Registration Number")]
    [IsoXmlTag("DbtrNtlRegnNb")]
    public IsoMax35Text? DebtorNationalRegistrationNumber { get; init; }

    /// <summary>
    /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
    /// </summary>
    [IsoId("11a2e17d-572e-40e8-a101-6f90f44154eb")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification139? Creditor { get; init; }

    /// <summary>
    /// Financial institution that receives the direct debit instruction from the creditor or other authorised party.
    /// </summary>
    [IsoId("ca0b883f-f1c4-4e66-be0e-03ae1be1044b")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required FinancialInstitutionIdentification17 DebtorAgent { get; init; }

    /// <summary>
    /// Information identifying a specific branch of a financial institution.
    /// </summary>
    [IsoId("d03b822a-9179-4244-b621-d49dfa533b38")]
    [DisplayName("Debtor Agent Branch")]
    [IsoXmlTag("DbtrAgtBrnch")]
    public BranchData4? DebtorAgentBranch { get; init; }

    /// <summary>
    /// Financial institution that receives the payment transaction on behalf of the creditor, or other nominated party, and credits the account.
    /// </summary>
    [IsoId("c4abe247-89ee-42c5-8b90-88807bb75c41")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public FinancialInstitutionIdentification17? CreditorAgent { get; init; }

    /// <summary>
    /// Information identifying a specific branch of a financial institution.
    /// </summary>
    [IsoId("c24cf633-dceb-4578-a6b7-06eafde6a6fa")]
    [DisplayName("Creditor Agent Branch")]
    [IsoXmlTag("CdtrAgtBrnch")]
    public BranchData4? CreditorAgentBranch { get; init; }

    /// <summary>
    /// Reference assigned to a creditor by its financial institution, or relevant authority, authorising the creditor to take part in a direct debit scheme.
    /// </summary>
    [IsoId("c839fe41-ab38-4632-8d9b-d3fc163092ce")]
    [DisplayName("Registration Identification")]
    [IsoXmlTag("RegnId")]
    public IsoMax35Text? RegistrationIdentification { get; init; }

    /// <summary>
    /// Reference of the direct debit mandate that has been agreed upon by the debtor and creditor.
    /// </summary>
    [IsoId("d656854b-08c5-4ac7-aeb4-5e803ffc7cad")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    public IsoMax35Text? MandateIdentification { get; init; }
}
