// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status report of the individual orders of a bulk or multiple order that was previously received.
/// </summary>
[IsoId("055610e9-ff4b-463d-8554-c1d66b741e0b")]
[DisplayName("Individual Order Status And Reason9")]
public record IndividualOrderStatusAndReason9
{
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("f26e937d-b642-4797-a0c4-31b4a1fea318")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
    /// </summary>
    [IsoId("2c67f625-12ec-4d2d-9668-d574f149659c")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor's identification of the order.
    /// </summary>
    [IsoId("28eba764-f0e3-410a-8fc5-d68dc2cf0135")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the order execution, as assigned by the confirming party.
    /// </summary>
    [IsoId("765bc59c-a26e-47ba-8fbe-66831f070379")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    public IsoMax35Text? DealReference { get; init; }

    /// <summary>
    /// Unambiguous identification of a random or semi-random number used once (NONCE) generated in the frame of a cryptographic communication.
    /// </summary>
    [IsoId("48ccadfc-6f50-4327-9deb-e3b1f2b92a18")]
    [DisplayName("Nonce Identification")]
    [IsoXmlTag("NonceId")]
    public IsoMax35Text? NonceIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the order cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("7aab3876-d5c2-42be-8fc9-7963122d9d86")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    public IsoMax35Text? CancellationReference { get; init; }

    /// <summary>
    /// Status of the individual order.
    /// </summary>
    [IsoId("f01cb2db-743d-4044-b6fb-cbff6e1dd959")]
    [DisplayName("Order Status")]
    [IsoXmlTag("OrdrSts")]
    public required OrderStatus6Choice OrderStatus { get; init; }

    /// <summary>
    /// Elements from the original individual order that have been repaired so that the order can be accepted.
    /// </summary>
    [IsoId("eb5bb99c-f2fd-4db1-89b8-16e81ff54ac7")]
    [DisplayName("Repaired Fee")]
    [IsoXmlTag("RprdFee")]
    public ValueList<Fee12> RepairedFee { get; init; } = [];

    /// <summary>
    /// Party that initiates the status of the order.
    /// </summary>
    [IsoId("3379e5c0-84c7-4fb4-a045-115edda5d81a")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification139? StatusInitiator { get; init; }

    /// <summary>
    /// Order data.
    /// </summary>
    [IsoId("1bf2c192-5c02-4302-84bf-7d35485cd47a")]
    [DisplayName("Order Data")]
    [IsoXmlTag("OrdrData")]
    public FundOrderData7? OrderData { get; init; }

    /// <summary>
    /// Expected execution information.
    /// </summary>
    [IsoId("f905791a-2dc8-4a4f-b2d1-195aefff6fde")]
    [DisplayName("New Details")]
    [IsoXmlTag("NewDtls")]
    public ExpectedExecutionDetails5? NewDetails { get; init; }

    /// <summary>
    /// Information about gating and hold back of redemption proceeds.
    /// </summary>
    [IsoId("a18c4315-c82d-43b5-96ab-a6d05a02e935")]
    [DisplayName("Gating Or Hold Back Details")]
    [IsoXmlTag("GtgOrHldBckDtls")]
    public HoldBackInformation4? GatingOrHoldBackDetails { get; init; }
}
