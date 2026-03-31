// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
/// </summary>
[IsoId("_2SSjYSSsEeWEdM0tuoNJdg")]
[DisplayName("Delivering Parties And Account")]
public record DeliveringPartiesAndAccount14
{
    /// <summary>
    /// Party that acts on behalf of the seller of securities when the seller does not have a direct relationship with the delivering agent.
    /// </summary>
    [IsoId("_2vdAhySsEeWEdM0tuoNJdg")]
    [DisplayName("Deliverers Custodian Details")]
    [IsoXmlTag("DlvrrsCtdnDtls")]
    public PartyIdentificationAndAccount124? DeliverersCustodianDetails { get; init; }

    /// <summary>
    /// Party that the deliverer&apos;s custodian uses to effect the delivery of a security, when the deliverer&apos;s custodian does not have a direct relationship with the delivering agent.
    /// </summary>
    [IsoId("_2vdAiSSsEeWEdM0tuoNJdg")]
    [DisplayName("Deliverers Intermediary 1 Details")]
    [IsoXmlTag("DlvrrsIntrmy1Dtls")]
    public PartyIdentificationAndAccount124? DeliverersIntermediary1Details { get; init; }

    /// <summary>
    /// Party that interacts with the deliverer&apos;s intermediary.
    /// </summary>
    [IsoId("_2vdAiySsEeWEdM0tuoNJdg")]
    [DisplayName("Deliverers Intermediary 2 Details")]
    [IsoXmlTag("DlvrrsIntrmy2Dtls")]
    public PartyIdentificationAndAccount124? DeliverersIntermediary2Details { get; init; }

    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, for example, central securities depository.
    /// </summary>
    [IsoId("_2vdAjSSsEeWEdM0tuoNJdg")]
    [DisplayName("Delivering Agent Details")]
    [IsoXmlTag("DlvrgAgtDtls")]
    public required PartyIdentificationAndAccount124 DeliveringAgentDetails { get; init; }

    /// <summary>
    /// Identifies the securities settlement system to be used.
    /// </summary>
    [IsoId("_2vdAjySsEeWEdM0tuoNJdg")]
    [DisplayName("Securities Settlement System")]
    [IsoXmlTag("SctiesSttlmSys")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SecuritiesSettlementSystem { get; init; }

    /// <summary>
    /// Place where settlement of the securities takes place.
    /// </summary>
    [IsoId("_2vdAkSSsEeWEdM0tuoNJdg")]
    [DisplayName("Place Of Settlement Details")]
    [IsoXmlTag("PlcOfSttlmDtls")]
    public PartyIdentification97? PlaceOfSettlementDetails { get; init; }
}
