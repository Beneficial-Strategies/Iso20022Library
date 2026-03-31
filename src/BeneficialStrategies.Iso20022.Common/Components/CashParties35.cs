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
[IsoId("_5Pe-0dLCEeiN28wlpBQScw")]
[DisplayName("Cash Parties")]
public record CashParties35
{
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_5g4349LCEeiN28wlpBQScw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentificationAndAccount164? Debtor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_5g43_dLCEeiN28wlpBQScw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public PartyIdentificationAndAccount171? DebtorAgent { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_5g44F9LCEeiN28wlpBQScw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentificationAndAccount164? Creditor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_5g44MdLCEeiN28wlpBQScw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public PartyIdentificationAndAccount171? CreditorAgent { get; init; }
}
