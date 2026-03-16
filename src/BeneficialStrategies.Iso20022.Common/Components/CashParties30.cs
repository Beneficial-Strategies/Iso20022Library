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
[IsoId("_5nBVr5NLEeWGlc8L7oPDIg")]
[DisplayName("Cash Parties")]
public record CashParties30
{
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_5nBVsZNLEeWGlc8L7oPDIg")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentificationAndAccount133? Debtor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_5nBVy5NLEeWGlc8L7oPDIg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public PartyIdentificationAndAccount134? DebtorAgent { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_5nBV5ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentificationAndAccount133? Creditor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_5nBV_5NLEeWGlc8L7oPDIg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public PartyIdentificationAndAccount134? CreditorAgent { get; init; }

    /// <summary>
    /// Financial institution through which the transaction must pass to reach the account with institution.
    /// </summary>
    [IsoId("_5nBWGZNLEeWGlc8L7oPDIg")]
    [DisplayName("Intermediary")]
    [IsoXmlTag("Intrmy")]
    public PartyIdentificationAndAccount134? Intermediary { get; init; }
}
