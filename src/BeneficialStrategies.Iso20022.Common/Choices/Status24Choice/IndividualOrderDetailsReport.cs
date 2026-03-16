// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status24Choice
{
    /// <summary>
    /// Status report details of an individual order.
    /// </summary>
    [IsoId("_bpQwZEHPEeazV4RAqPV71g")]
    [DisplayName("Individual Order Details Report")]
    public record IndividualOrderDetailsReport : Status24Choice_
    {
        /// <summary>
        /// Reference assigned to a set of orders or trades in order to link them together.
        /// </summary>
        [IsoId("_JSDihTbtEead9bDRE_1DAQ")]
        [DisplayName("Master Reference")]
        [IsoXmlTag("MstrRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MasterReference { get; init; }

        /// <summary>
        /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
        /// </summary>
        [IsoId("_JSDihzbtEead9bDRE_1DAQ")]
        [DisplayName("Order Reference")]
        [IsoXmlTag("OrdrRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text OrderReference { get; init; }

        /// <summary>
        /// Unique and unambiguous investor&apos;s identification of the order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
        /// </summary>
        [IsoId("_JSDiiTbtEead9bDRE_1DAQ")]
        [DisplayName("Client Reference")]
        [IsoXmlTag("ClntRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? ClientReference { get; init; }

        /// <summary>
        /// Unique and unambiguous identifier for the order execution, as assigned by the confirming party.
        /// </summary>
        [IsoId("_JSDiizbtEead9bDRE_1DAQ")]
        [DisplayName("Deal Reference")]
        [IsoXmlTag("DealRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? DealReference { get; init; }

        /// <summary>
        /// Unique and unambiguous identifier for the order cancellation, as assigned by the instructing party.
        /// </summary>
        [IsoId("_JSDijTbtEead9bDRE_1DAQ")]
        [DisplayName("Cancellation Reference")]
        [IsoXmlTag("CxlRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? CancellationReference { get; init; }

        /// <summary>
        /// Status of the individual order.
        /// </summary>
        [IsoId("_Sop2EEHQEeazV4RAqPV71g")]
        [DisplayName("Order Status")]
        [IsoXmlTag("OrdrSts")]
        public required OrderStatus5Choice_ OrderStatus { get; init; }

        /// <summary>
        /// Elements from the original individual order that have been repaired so that the order can be accepted.
        /// </summary>
        [IsoId("_zyjlwTk2EeapUO0vUIo9Xw")]
        [DisplayName("Repaired Fee")]
        [IsoXmlTag("RprdFee")]
        [MinLength(0)]
        [MaxLength(10)]
        public ValueList<Fee3> RepairedFee { get; init; } = [];

        /// <summary>
        /// Party that initiates the status of the order.
        /// </summary>
        [IsoId("_xvSL8UjYEeaUN5TdQqhvNQ")]
        [DisplayName("Status Initiator")]
        [IsoXmlTag("StsInitr")]
        public PartyIdentification113? StatusInitiator { get; init; }

        /// <summary>
        /// Order data.
        /// </summary>
        [IsoId("_JSDioTbtEead9bDRE_1DAQ")]
        [DisplayName("Order Data")]
        [IsoXmlTag("OrdrData")]
        public FundOrderData5? OrderData { get; init; }

        /// <summary>
        /// Expected execution information.
        /// </summary>
        [IsoId("_JSDiozbtEead9bDRE_1DAQ")]
        [DisplayName("New Details")]
        [IsoXmlTag("NewDtls")]
        public ExpectedExecutionDetails4? NewDetails { get; init; }

        /// <summary>
        /// Information about gating and hold back of redemption proceeds.
        /// </summary>
        [IsoId("_gd_YcUgWEea9YuSvQGoi-w")]
        [DisplayName("Gating Or Hold Back Details")]
        [IsoXmlTag("GtgOrHldBckDtls")]
        public HoldBackInformation3? GatingOrHoldBackDetails { get; init; }
    }
}
