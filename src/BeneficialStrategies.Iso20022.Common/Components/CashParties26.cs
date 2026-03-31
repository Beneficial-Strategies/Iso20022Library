// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment processes required to transfer cash from the debtor to the creditor.
/// </summary>
[IsoId("_F1RDiR5gEeWE3PufGMdJ3w")]
[DisplayName("Cash Parties")]
public record CashParties26
{
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_GUNo0x5gEeWE3PufGMdJ3w")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentificationAndAccount111? Debtor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_GUNo7R5gEeWE3PufGMdJ3w")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public PartyIdentificationAndAccount112? DebtorAgent { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_GUNpBx5gEeWE3PufGMdJ3w")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentificationAndAccount111? Creditor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_GUNpIR5gEeWE3PufGMdJ3w")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public PartyIdentificationAndAccount112? CreditorAgent { get; init; }

    /// <summary>
    /// Financial institution through which the transaction must pass to reach the account with institution.
    /// </summary>
    [IsoId("_GUNpOx5gEeWE3PufGMdJ3w")]
    [DisplayName("Intermediary")]
    [IsoXmlTag("Intrmy")]
    public PartyIdentificationAndAccount112? Intermediary { get; init; }
}
