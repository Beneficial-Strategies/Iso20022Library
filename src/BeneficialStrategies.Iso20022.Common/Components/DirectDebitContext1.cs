// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Direct Debit Context1.
/// </summary>
[IsoId("_BBFWkKWVEe-ymImuWN-uZA")]
[DisplayName("Direct Debit Context1")]
public record DirectDebitContext1
{
    /// <summary>
    /// Creditor.
    /// </summary>
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification272? Creditor { get; init; }

    /// <summary>
    /// Creditor Account.
    /// </summary>
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <summary>
    /// Debtor.
    /// </summary>
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification272? Debtor { get; init; }

    /// <summary>
    /// Debtor Account.
    /// </summary>
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <summary>
    /// Mandate Related Information.
    /// </summary>
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public required MandateRelatedInformation17 MandateRelatedInformation { get; init; }

    /// <summary>
    /// Protected Creditor Account.
    /// </summary>
    [DisplayName("Protected Creditor Account")]
    [IsoXmlTag("PrtctdCdtrAcct")]
    public ContentInformationType39? ProtectedCreditorAccount { get; init; }

    /// <summary>
    /// Protected Debtor Account.
    /// </summary>
    [DisplayName("Protected Debtor Account")]
    [IsoXmlTag("PrtctdDbtrAcct")]
    public ContentInformationType39? ProtectedDebtorAccount { get; init; }
}
