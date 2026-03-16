// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies settlement parties (delivering/receiving).
/// </summary>
[IsoId("_ckENhZKQEeWHWpTQn1FFVg")]
[DisplayName("Settlement Parties")]
public record SettlementParties43
{
    /// <summary>
    /// First receiving party in the settlement chain. In a plain vanilla settlement, it is the central securities depository where the receiving side of the transaction requests to receive the financial instrument.
    /// </summary>
    [IsoId("_ckENi5KQEeWHWpTQn1FFVg")]
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public PartyIdentification102? Depository { get; init; }

    /// <summary>
    /// Party that interacts with the depository.
    /// </summary>
    [IsoId("_ckENk5KQEeWHWpTQn1FFVg")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty1")]
    public PartyIdentificationAndAccount128? Party1 { get; init; }

    /// <summary>
    /// Party that interacts with the party1.
    /// </summary>
    [IsoId("_ckENm5KQEeWHWpTQn1FFVg")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty2")]
    public PartyIdentificationAndAccount128? Party2 { get; init; }

    /// <summary>
    /// Party that interacts with the party2.
    /// </summary>
    [IsoId("_ckENtZKQEeWHWpTQn1FFVg")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty3")]
    public PartyIdentificationAndAccount128? Party3 { get; init; }
}
