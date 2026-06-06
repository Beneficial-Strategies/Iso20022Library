// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of a switch order.
/// </summary>
[IsoId("33efad92-9020-40eb-8350-871593f70002")]
[DisplayName("Switch Order Status And Reason3")]
public record SwitchOrderStatusAndReason3
{
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("33efad92-mstr-0001-0001-871593f70002")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
    /// </summary>
    [IsoId("33efad92-ordr-0001-0002-871593f70002")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor's identification of the order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("33efad92-clnt-0001-0003-871593f70002")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the order execution, as assigned by the confirming party.
    /// </summary>
    [IsoId("33efad92-deal-0001-0004-871593f70002")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    public IsoMax35Text? DealReference { get; init; }

    /// <summary>
    /// Unambiguous identification of a random or semi-random number used once (NONCE) generated in the frame of a cryptographic communication.
    /// </summary>
    [IsoId("33efad92-nonc-0001-0005-871593f70002")]
    [DisplayName("Nonce Identification")]
    [IsoXmlTag("NonceId")]
    public IsoMax35Text? NonceIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the order cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("33efad92-cxlr-0001-0006-871593f70002")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    public IsoMax35Text? CancellationReference { get; init; }

    /// <summary>
    /// Status of the switch order.
    /// </summary>
    [IsoId("33efad92-orst-0001-0007-871593f70002")]
    [DisplayName("Order Status")]
    [IsoXmlTag("OrdrSts")]
    public required OrderStatus7Choice_ OrderStatus { get; init; }

    /// <summary>
    /// Information about a switch leg that is rejected or repaired.
    /// </summary>
    [IsoId("33efad92-legi-0001-0008-871593f70002")]
    [DisplayName("Leg Information")]
    [IsoXmlTag("LegInf")]
    public ValueList<SwitchLegReferences3> LegInformation { get; init; } = [];

    /// <summary>
    /// Party that initiates the status of the order.
    /// </summary>
    [IsoId("33efad92-stit-0001-0009-871593f70002")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification139? StatusInitiator { get; init; }

    /// <summary>
    /// Order data.
    /// </summary>
    [IsoId("33efad92-ordt-0001-0010-871593f70002")]
    [DisplayName("Order Data")]
    [IsoXmlTag("OrdrData")]
    public FundOrderData6? OrderData { get; init; }

    /// <summary>
    /// Expected execution information.
    /// </summary>
    [IsoId("33efad92-newd-0001-0011-871593f70002")]
    [DisplayName("New Details")]
    [IsoXmlTag("NewDtls")]
    public ExpectedExecution6? NewDetails { get; init; }
}
