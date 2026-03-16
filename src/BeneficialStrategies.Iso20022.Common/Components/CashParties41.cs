// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash Parties41.
/// </summary>
[IsoId("_oA-iYZBPEe-COKgew96POA")]
[DisplayName("Cash Parties41")]
public record CashParties41
{
    /// <summary>
    /// Creditor.
    /// </summary>
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentificationAndAccount223? Creditor { get; init; }

    /// <summary>
    /// Creditor Agent.
    /// </summary>
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public PartyIdentificationAndAccount224? CreditorAgent { get; init; }

    /// <summary>
    /// Debtor.
    /// </summary>
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentificationAndAccount223? Debtor { get; init; }

    /// <summary>
    /// Debtor Agent.
    /// </summary>
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public PartyIdentificationAndAccount224? DebtorAgent { get; init; }

    /// <summary>
    /// Intermediary.
    /// </summary>
    [DisplayName("Intermediary")]
    [IsoXmlTag("Intrmy")]
    public PartyIdentificationAndAccount224? Intermediary { get; init; }
}
