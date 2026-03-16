// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Delivering Parties And Account20.
/// </summary>
[IsoId("_3cod5RwMEe6O0NdiBuX__w")]
[DisplayName("Delivering Parties And Account20")]
public record DeliveringPartiesAndAccount20
{
    /// <summary>
    /// Deliverers Custodian Details.
    /// </summary>
    [DisplayName("Deliverers Custodian Details")]
    [IsoXmlTag("DlvrrsCtdnDtls")]
    public PartyIdentificationAndAccount222? DeliverersCustodianDetails { get; init; }

    /// <summary>
    /// Deliverers Intermediary1Details.
    /// </summary>
    [DisplayName("Deliverers Intermediary1Details")]
    [IsoXmlTag("DlvrrsIntrmy1Dtls")]
    public PartyIdentificationAndAccount222? DeliverersIntermediary1Details { get; init; }

    /// <summary>
    /// Deliverers Intermediary2Details.
    /// </summary>
    [DisplayName("Deliverers Intermediary2Details")]
    [IsoXmlTag("DlvrrsIntrmy2Dtls")]
    public PartyIdentificationAndAccount222? DeliverersIntermediary2Details { get; init; }

    /// <summary>
    /// Delivering Agent Details.
    /// </summary>
    [DisplayName("Delivering Agent Details")]
    [IsoXmlTag("DlvrgAgtDtls")]
    public required PartyIdentificationAndAccount222 DeliveringAgentDetails { get; init; }
}
