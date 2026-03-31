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
[IsoId("_K14C--aOEd-q8fx_Zl_34A")]
[DisplayName("Cash Parties")]
public record CashParties7
{
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_K2BzUeaOEd-q8fx_Zl_34A")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentificationAndAccount38? Debtor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_K2BzU-aOEd-q8fx_Zl_34A")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public PartyIdentificationAndAccount50? DebtorAgent { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_K2BzVeaOEd-q8fx_Zl_34A")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentificationAndAccount38? Creditor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_K2BzV-aOEd-q8fx_Zl_34A")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public PartyIdentificationAndAccount50? CreditorAgent { get; init; }
}
