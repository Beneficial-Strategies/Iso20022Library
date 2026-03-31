// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status24Choice
{
    /// <summary>
    /// Status report details of a switch order.
    /// </summary>
    [IsoId("_bpQwZUHPEeazV4RAqPV71g")]
    [DisplayName("Switch Order Details Report")]
    [IsoXmlTag("SwtchOrdrDtlsRpt")]
    public record SwitchOrderDetailsReport : Status24Choice_
    {
        /// <summary>
        /// Reference assigned to a set of orders or trades in order to link them together.
        /// </summary>
        [IsoId("_Fx2LJTbtEead9bDRE_1DAQ")]
        [DisplayName("Master Reference")]
        [IsoXmlTag("MstrRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MasterReference { get; init; }

        /// <summary>
        /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
        /// </summary>
        [IsoId("_Fx2LJzbtEead9bDRE_1DAQ")]
        [DisplayName("Order Reference")]
        [IsoXmlTag("OrdrRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text OrderReference { get; init; }

        /// <summary>
        /// Unique and unambiguous investor&apos;s identification of the order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
        /// </summary>
        [IsoId("_Fx2LKTbtEead9bDRE_1DAQ")]
        [DisplayName("Client Reference")]
        [IsoXmlTag("ClntRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? ClientReference { get; init; }

        /// <summary>
        /// Unique and unambiguous identifier for the order execution, as assigned by the confirming party.
        /// </summary>
        [IsoId("_Fx2LKzbtEead9bDRE_1DAQ")]
        [DisplayName("Deal Reference")]
        [IsoXmlTag("DealRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? DealReference { get; init; }

        /// <summary>
        /// Unique and unambiguous identifier for the order cancellation, as assigned by the instructing party.
        /// </summary>
        [IsoId("_Fx2LLTbtEead9bDRE_1DAQ")]
        [DisplayName("Cancellation Reference")]
        [IsoXmlTag("CxlRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? CancellationReference { get; init; }

        /// <summary>
        /// Status of the switch order.
        /// </summary>
        [IsoId("_10GMIEH8EeaV3ab_pHzFIQ")]
        [DisplayName("Order Status")]
        [IsoXmlTag("OrdrSts")]
        public required OrderStatus4Choice_ OrderStatus { get; init; }

        /// <summary>
        /// Information about a switch leg that is rejected or repaired.
        /// </summary>
        [IsoId("_Fx2LPTbtEead9bDRE_1DAQ")]
        [DisplayName("Leg Information")]
        [IsoXmlTag("LegInf")]
        public SwitchLegReferences2? LegInformation { get; init; }

        /// <summary>
        /// Party that initiates the status of the order.
        /// </summary>
        [IsoId("_Fx2LPzbtEead9bDRE_1DAQ")]
        [DisplayName("Status Initiator")]
        [IsoXmlTag("StsInitr")]
        public PartyIdentification113? StatusInitiator { get; init; }

        /// <summary>
        /// Order data.
        /// </summary>
        [IsoId("_Fx2LQTbtEead9bDRE_1DAQ")]
        [DisplayName("Order Data")]
        [IsoXmlTag("OrdrData")]
        public FundOrderData6? OrderData { get; init; }

        /// <summary>
        /// Expected execution information.
        /// </summary>
        [IsoId("_Fx2LQzbtEead9bDRE_1DAQ")]
        [DisplayName("New Details")]
        [IsoXmlTag("NewDtls")]
        public ExpectedExecutionDetails2? NewDetails { get; init; }
    }
}
