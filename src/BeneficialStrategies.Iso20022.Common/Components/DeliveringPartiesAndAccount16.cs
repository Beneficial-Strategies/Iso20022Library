// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security transfer.
/// </summary>
[IsoId("_0ubGbTbsEead9bDRE_1DAQ")]
[DisplayName("Delivering Parties And Account")]
public record DeliveringPartiesAndAccount16
{
    /// <summary>
    /// Party that acts on behalf of the seller of securities when the seller does not have a direct relationship with the delivering agent.
    /// </summary>
    [IsoId("_1Hj_IzbsEead9bDRE_1DAQ")]
    [DisplayName("Deliverers Custodian Details")]
    [IsoXmlTag("DlvrrsCtdnDtls")]
    public PartyIdentificationAndAccount147? DeliverersCustodianDetails { get; init; }

    /// <summary>
    /// Party that the deliverer&apos;s custodian uses to effect the delivery of a security, when the deliverer&apos;s custodian does not have a direct relationship with the delivering agent.
    /// </summary>
    [IsoId("_1Hj_JTbsEead9bDRE_1DAQ")]
    [DisplayName("Deliverers Intermediary 1 Details")]
    [IsoXmlTag("DlvrrsIntrmy1Dtls")]
    public PartyIdentificationAndAccount147? DeliverersIntermediary1Details { get; init; }

    /// <summary>
    /// Party that interacts with the deliverer&apos;s intermediary 1.
    /// </summary>
    [IsoId("_mGRlYThZEeaRwdGFv45qTQ")]
    [DisplayName("Deliverers Intermediary 2 Details")]
    [IsoXmlTag("DlvrrsIntrmy2Dtls")]
    public PartyIdentificationAndAccount147? DeliverersIntermediary2Details { get; init; }

    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, for example, central securities depository.
    /// </summary>
    [IsoId("_1Hj_JzbsEead9bDRE_1DAQ")]
    [DisplayName("Delivering Agent Details")]
    [IsoXmlTag("DlvrgAgtDtls")]
    public required PartyIdentificationAndAccount147 DeliveringAgentDetails { get; init; }
}
