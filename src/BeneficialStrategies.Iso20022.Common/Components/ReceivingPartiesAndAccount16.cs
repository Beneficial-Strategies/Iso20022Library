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
[IsoId("_1gjt9TbsEead9bDRE_1DAQ")]
[DisplayName("Receiving Parties And Account")]
public record ReceivingPartiesAndAccount16
{
    /// <summary>
    /// Party that acts on behalf of the buyer of securities when the buyer does not have a direct relationship with the receiving agent.
    /// </summary>
    [IsoId("_14z14zbsEead9bDRE_1DAQ")]
    [DisplayName("Receivers Custodian Details")]
    [IsoXmlTag("RcvrsCtdnDtls")]
    public PartyIdentificationAndAccount147? ReceiversCustodianDetails { get; init; }

    /// <summary>
    /// Party that the receiver&apos;s custodian uses to effect the receipt of a security, when the receiver&apos;s custodian does not have a direct relationship with the receiving agent.
    /// </summary>
    [IsoId("_14z15TbsEead9bDRE_1DAQ")]
    [DisplayName("Receivers Intermediary 1 Details")]
    [IsoXmlTag("RcvrsIntrmy1Dtls")]
    public PartyIdentificationAndAccount147? ReceiversIntermediary1Details { get; init; }

    /// <summary>
    /// Party that interacts with the receiver’s intermediary 1.
    /// </summary>
    [IsoId("_SXUugThZEeaRwdGFv45qTQ")]
    [DisplayName("Receivers Intermediary 2 Details")]
    [IsoXmlTag("RcvrsIntrmy2Dtls")]
    public PartyIdentificationAndAccount147? ReceiversIntermediary2Details { get; init; }

    /// <summary>
    /// Party that receives securities from the delivering agent at the place of settlement, for example, central securities depository.
    /// </summary>
    [IsoId("_14z15zbsEead9bDRE_1DAQ")]
    [DisplayName("Receiving Agent Details")]
    [IsoXmlTag("RcvgAgtDtls")]
    public required PartyIdentificationAndAccount147 ReceivingAgentDetails { get; init; }
}
