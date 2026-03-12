// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security transfer.
/// </summary>
[IsoId("_QVfs5tp-Ed-ak6NoX_4Aeg_-686973332")]
[DisplayName("Receiving Parties And Account")]
public partial record ReceivingPartiesAndAccount3
{
    #nullable enable
    
    /// <summary>
    /// Party that acts on behalf of the buyer of securities when the buyer does not have a direct relationship with the receiving agent.
    /// </summary>
    [IsoId("_QVfs59p-Ed-ak6NoX_4Aeg_-686973288")]
    [DisplayName("Receivers Custodian Details")]
    [IsoXmlTag("RcvrsCtdnDtls")]
    public PartyIdentificationAndAccount3? ReceiversCustodianDetails { get; init; } 
    
    /// <summary>
    /// Party that the Receiver&apos;s custodian uses to effect the receipt of a security, when the Receiver&apos;s custodian does not have a direct relationship with the Receiver agent.
    /// </summary>
    [IsoId("_QVfs6Np-Ed-ak6NoX_4Aeg_-686973254")]
    [DisplayName("Receivers Intermediary Details")]
    [IsoXmlTag("RcvrsIntrmyDtls")]
    public PartyIdentificationAndAccount3? ReceiversIntermediaryDetails { get; init; } 
    
    /// <summary>
    /// Party that receives securities from the delivering agent at the place of settlement, eg, central securities depository.
    /// </summary>
    [IsoId("_QVfs6dp-Ed-ak6NoX_4Aeg_-686973236")]
    [DisplayName("Receiving Agent Details")]
    [IsoXmlTag("RcvgAgtDtls")]
    public required PartyIdentificationAndAccount3 ReceivingAgentDetails { get; init; } 
    
    
    #nullable disable
    
}
