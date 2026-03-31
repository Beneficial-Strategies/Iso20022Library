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
[IsoId("_EoZh0Y-4Eeaoj_JbcpWKgg")]
[DisplayName("Cash Parties")]
public record CashParties33
{
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_E2r1c4-4Eeaoj_JbcpWKgg")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentificationAndAccount148? Debtor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_E2r1jY-4Eeaoj_JbcpWKgg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public PartyIdentificationAndAccount148? DebtorAgent { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_E2r1p4-4Eeaoj_JbcpWKgg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentificationAndAccount148? Creditor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_E2r1wY-4Eeaoj_JbcpWKgg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public PartyIdentificationAndAccount148? CreditorAgent { get; init; }

    /// <summary>
    /// Financial institution through which the transaction must pass to reach the account with institution.
    /// </summary>
    [IsoId("_E2r124-4Eeaoj_JbcpWKgg")]
    [DisplayName("Intermediary")]
    [IsoXmlTag("Intrmy")]
    public PartyIdentificationAndAccount148? Intermediary { get; init; }
}
