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
[IsoId("_QVMK5tp-Ed-ak6NoX_4Aeg_349216301")]
[DisplayName("Delivering Parties And Account")]
public record DeliveringPartiesAndAccount3
{
    /// <summary>
    /// Party that acts on behalf of the seller of securities when the seller does not have a direct relationship with the delivering agent.
    /// </summary>
    [IsoId("_QVMK59p-Ed-ak6NoX_4Aeg_349216345")]
    [DisplayName("Deliverers Custodian Details")]
    [IsoXmlTag("DlvrrsCtdnDtls")]
    public PartyIdentificationAndAccount3? DeliverersCustodianDetails { get; init; }

    /// <summary>
    /// Party that the deliverer&apos;s custodian uses to effect the delivery of a security, when the deliverer&apos;s custodian does not have a direct relationship with the delivering agent.
    /// </summary>
    [IsoId("_QVMK6Np-Ed-ak6NoX_4Aeg_349216362")]
    [DisplayName("Deliverers Intermediary Details")]
    [IsoXmlTag("DlvrrsIntrmyDtls")]
    public PartyIdentificationAndAccount3? DeliverersIntermediaryDetails { get; init; }

    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, eg, central securities depository.
    /// </summary>
    [IsoId("_QVMK6dp-Ed-ak6NoX_4Aeg_349216397")]
    [DisplayName("Delivering Agent Details")]
    [IsoXmlTag("DlvrgAgtDtls")]
    public required PartyIdentificationAndAccount3 DeliveringAgentDetails { get; init; }
}
