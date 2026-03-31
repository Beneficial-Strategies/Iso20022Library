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
[IsoId("_VMep9tp-Ed-ak6NoX_4Aeg_-615142722")]
[DisplayName("Direct Debit Mandate")]
public record DirectDebitMandate2
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_VMep99p-Ed-ak6NoX_4Aeg_-615142697")]
    [DisplayName("Debtor Account Identification")]
    [IsoXmlTag("DbtrAcctId")]
    public required CashAccountIdentification1Choice_ DebtorAccountIdentification { get; init; }

    /// <summary>
    /// Party that owes the cash to the creditor/final party. The debtor is also the debit account owner.
    /// </summary>
    [IsoId("_VMep-Np-Ed-ak6NoX_4Aeg_-615142680")]
    [DisplayName("Debtor Identification")]
    [IsoXmlTag("DbtrId")]
    public PartyIdentification2Choice_? DebtorIdentification { get; init; }

    /// <summary>
    /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
    /// </summary>
    [IsoId("_VMep-dp-Ed-ak6NoX_4Aeg_-615142662")]
    [DisplayName("Creditor Identification")]
    [IsoXmlTag("CdtrId")]
    public PartyIdentification2Choice_? CreditorIdentification { get; init; }

    /// <summary>
    /// Financial institution that receives the direct debit instruction from the creditor or other authorised party.
    /// </summary>
    [IsoId("_VMep-tp-Ed-ak6NoX_4Aeg_-615142645")]
    [DisplayName("First Agent")]
    [IsoXmlTag("FrstAgt")]
    public required FinancialInstitutionIdentification3Choice_ FirstAgent { get; init; }

    /// <summary>
    /// Financial institution that receives the payment transaction on behalf of the creditor, or other nominated party, and credits the account.
    /// </summary>
    [IsoId("_VMep-9p-Ed-ak6NoX_4Aeg_-615142627")]
    [DisplayName("Final Agent")]
    [IsoXmlTag("FnlAgt")]
    public FinancialInstitutionIdentification3Choice_? FinalAgent { get; init; }

    /// <summary>
    /// Reference assigned to a creditor by its financial institution, or relevant authority, authorising the creditor to take part in a direct debit scheme.
    /// </summary>
    [IsoId("_VMep_Np-Ed-ak6NoX_4Aeg_-615142354")]
    [DisplayName("Registration Identification")]
    [IsoXmlTag("RegnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RegistrationIdentification { get; init; }

    /// <summary>
    /// Reference of the direct debit mandate that has been agreed upon by the debtor and creditor.
    /// </summary>
    [IsoId("_VMoa8Np-Ed-ak6NoX_4Aeg_-615142337")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateIdentification { get; init; }
}
