// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status26Choice
{
    /// <summary>
    /// Status report details of one or more individual orders from a bulk or multiple or switch order cancellation request.
    /// </summary>
    [IsoId("_n7iik0grEeaD2L_hzZaE0w")]
    [DisplayName("Individual Cancellation Status Report")]
    public record IndividualCancellationStatusReport : Status26Choice_
    {
        /// <summary>
        /// Reference assigned to a set of orders or trades in order to link them together.
        /// </summary>
        [IsoId("_KFFh8zbtEead9bDRE_1DAQ")]
        [DisplayName("Master Reference")]
        [IsoXmlTag("MstrRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MasterReference { get; init; }

        /// <summary>
        /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
        /// </summary>
        [IsoId("_KFFh9TbtEead9bDRE_1DAQ")]
        [DisplayName("Order Reference")]
        [IsoXmlTag("OrdrRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text OrderReference { get; init; }

        /// <summary>
        /// Unique and unambiguous investor&apos;s identification of the order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
        /// </summary>
        [IsoId("_KFFh9zbtEead9bDRE_1DAQ")]
        [DisplayName("Client Reference")]
        [IsoXmlTag("ClntRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? ClientReference { get; init; }

        /// <summary>
        /// Unique and unambiguous identifier for the order cancellation, as assigned by the instructing party.
        /// </summary>
        [IsoId("_KFFh-TbtEead9bDRE_1DAQ")]
        [DisplayName("Cancellation Reference")]
        [IsoXmlTag("CxlRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? CancellationReference { get; init; }

        /// <summary>
        /// Cancellation status of the order cancellation.
        /// </summary>
        [IsoId("_CpBKcUgvEeazC43Xuh-e6w")]
        [DisplayName("Cancellation Status")]
        [IsoXmlTag("CxlSts")]
        public required CancellationStatus22Choice_ CancellationStatus { get; init; }

        /// <summary>
        /// Party that initiates the status of the individual order cancellation.
        /// </summary>
        [IsoId("_KFFh_zbtEead9bDRE_1DAQ")]
        [DisplayName("Status Initiator")]
        [IsoXmlTag("StsInitr")]
        public PartyIdentification113? StatusInitiator { get; init; }

        /// <summary>
        /// Account information of the individual order cancellation for which the status is given.
        /// </summary>
        [IsoId("_KFFiATbtEead9bDRE_1DAQ")]
        [DisplayName("Investment Account Details")]
        [IsoXmlTag("InvstmtAcctDtls")]
        public InvestmentAccount58? InvestmentAccountDetails { get; init; }

        /// <summary>
        /// Financial instrument information of the individual order cancellation for which the status is given.
        /// </summary>
        [IsoId("_KFFiAzbtEead9bDRE_1DAQ")]
        [DisplayName("Financial Instrument Details")]
        [IsoXmlTag("FinInstrmDtls")]
        public FinancialInstrument57? FinancialInstrumentDetails { get; init; }
    }
}
