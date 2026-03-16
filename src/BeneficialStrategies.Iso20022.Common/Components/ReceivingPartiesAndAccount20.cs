// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Receiving Parties And Account20.
/// </summary>
[IsoId("_27_2ExwMEe6O0NdiBuX__w")]
[DisplayName("Receiving Parties And Account20")]
public record ReceivingPartiesAndAccount20
{
    /// <summary>
    /// Receivers Custodian Details.
    /// </summary>
    [DisplayName("Receivers Custodian Details")]
    [IsoXmlTag("RcvrsCtdnDtls")]
    public PartyIdentificationAndAccount222? ReceiversCustodianDetails { get; init; }

    /// <summary>
    /// Receivers Intermediary1Details.
    /// </summary>
    [DisplayName("Receivers Intermediary1Details")]
    [IsoXmlTag("RcvrsIntrmy1Dtls")]
    public PartyIdentificationAndAccount222? ReceiversIntermediary1Details { get; init; }

    /// <summary>
    /// Receivers Intermediary2Details.
    /// </summary>
    [DisplayName("Receivers Intermediary2Details")]
    [IsoXmlTag("RcvrsIntrmy2Dtls")]
    public PartyIdentificationAndAccount222? ReceiversIntermediary2Details { get; init; }

    /// <summary>
    /// Receiving Agent Details.
    /// </summary>
    [DisplayName("Receiving Agent Details")]
    [IsoXmlTag("RcvgAgtDtls")]
    public required PartyIdentificationAndAccount222 ReceivingAgentDetails { get; init; }
}
