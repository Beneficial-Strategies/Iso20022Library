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
[IsoId("f13e2d50-e9a8-4f0e-9fa7-6c05f877f4ae")]
[DisplayName("Settlement Parties131")]
public record SettlementParties131
{
    [IsoId("1d3e3083-b7e3-4378-bf03-11ca984b3704")]
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public PartyIdentification315? Depository { get; init; }

    [IsoId("fb3cd446-3228-434b-9322-7ddaa5351745")]
    [DisplayName("Party1")]
    [IsoXmlTag("Pty1")]
    public PartyIdentificationAndAccount194? Party1 { get; init; }

    [IsoId("a2ef6ec5-bb0c-4b59-bce8-ebf9f4442a48")]
    [DisplayName("Party2")]
    [IsoXmlTag("Pty2")]
    public PartyIdentificationAndAccount194? Party2 { get; init; }

    [IsoId("d9812d70-d449-4312-953b-4aaeec78748e")]
    [DisplayName("Party3")]
    [IsoXmlTag("Pty3")]
    public PartyIdentificationAndAccount194? Party3 { get; init; }

    [IsoId("46b08562-11d7-4508-b1fa-13d859ff8186")]
    [DisplayName("Party4")]
    [IsoXmlTag("Pty4")]
    public PartyIdentificationAndAccount194? Party4 { get; init; }

    [IsoId("24b54d51-923a-447a-9d66-a96abb64da36")]
    [DisplayName("Party5")]
    [IsoXmlTag("Pty5")]
    public PartyIdentificationAndAccount194? Party5 { get; init; }
}
