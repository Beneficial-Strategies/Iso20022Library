// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Chain of parties involved in the settlement of a transaction.
/// </summary>
[IsoId("_27tMwQVMEeq4ZaI1b_-GPA")]
[DisplayName("Settlement Parties")]
public record SettlementParties94
{
    /// <summary>
    /// First party in the settlement chain. In a plain vanilla settlement, it is the Central Securities Depository where the counterparty requests to receive the financial instrument or from where the counterparty delivers the financial instruments. This party may be a transfer agent.
    /// </summary>
    [IsoId("_3RIDMQVMEeq4ZaI1b_-GPA")]
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public PartyIdentification141? Depository { get; init; }

    /// <summary>
    /// Party that, in a settlement chain, interacts with the depository.
    /// </summary>
    [IsoId("_3RIDOQVMEeq4ZaI1b_-GPA")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty1")]
    public PartyIdentificationAndAccount194? Party1 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain, interacts with the party 1.
    /// </summary>
    [IsoId("_3RIDQQVMEeq4ZaI1b_-GPA")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty2")]
    public PartyIdentificationAndAccount194? Party2 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain, interacts with the party 2.
    /// </summary>
    [IsoId("_3RIDWwVMEeq4ZaI1b_-GPA")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty3")]
    public PartyIdentificationAndAccount194? Party3 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain, interacts with the party 3.
    /// </summary>
    [IsoId("_3RIDbwVMEeq4ZaI1b_-GPA")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty4")]
    public PartyIdentificationAndAccount194? Party4 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain, interacts with the party 4.
    /// </summary>
    [IsoId("_3RIDfQVMEeq4ZaI1b_-GPA")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty5")]
    public PartyIdentificationAndAccount194? Party5 { get; init; }
}
