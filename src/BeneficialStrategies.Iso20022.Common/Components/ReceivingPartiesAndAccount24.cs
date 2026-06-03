// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the parties and accounts involved in the receiving side of the transaction.
/// </summary>
[IsoId("13f34c81-a583-4d11-b4e2-d62551fc1ceb")]
[DisplayName("Receiving Parties And Account24")]
public record ReceivingPartiesAndAccount24
{
    /// <summary>
    /// Party that acts on behalf of the receiver agent and holds the securities.
    /// </summary>
    [IsoId("b8a2f3e1-c4d5-4e6f-a7b8-c9d0e1f2a3b4")]
    [DisplayName("Receivers Custodian Details")]
    [IsoXmlTag("RcvrsCtdnDtls")]
    public PartyIdentificationAndAccount235? ReceiversCustodianDetails { get; init; }

    /// <summary>
    /// First intermediary party involved in the reception of the securities.
    /// </summary>
    [IsoId("c5d6e7f8-a9b0-4c1d-b2e3-f4a5b6c7d8e9")]
    [DisplayName("Receivers Intermediary1 Details")]
    [IsoXmlTag("RcvrsIntrmy1Dtls")]
    public PartyIdentificationAndAccount235? ReceiversIntermediary1Details { get; init; }

    /// <summary>
    /// Second intermediary party involved in the reception of the securities.
    /// </summary>
    [IsoId("d6e7f8a9-b0c1-4d2e-c3f4-a5b6c7d8e9f0")]
    [DisplayName("Receivers Intermediary2 Details")]
    [IsoXmlTag("RcvrsIntrmy2Dtls")]
    public PartyIdentificationAndAccount235? ReceiversIntermediary2Details { get; init; }

    /// <summary>
    /// Party that receives the securities on behalf of the beneficiary.
    /// </summary>
    [IsoId("e7f8a9b0-c1d2-4e3f-d4a5-b6c7d8e9f0a1")]
    [DisplayName("Receiving Agent Details")]
    [IsoXmlTag("RcvgAgtDtls")]
    public required PartyIdentificationAndAccount235 ReceivingAgentDetails { get; init; }
}
