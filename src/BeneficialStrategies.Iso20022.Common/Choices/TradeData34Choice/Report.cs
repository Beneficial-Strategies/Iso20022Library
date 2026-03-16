// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeData34Choice
{
    /// <summary>
    /// Information concerning the reporting at transaction level.
    /// </summary>
    [IsoId("_ArgEc8K3EeuFNp8LZAnorg")]
    [DisplayName("Report")]
    [IsoXmlTag("Rpt")]
    public record Report : TradeData34Choice_
    {
        /// <summary>
        /// Status of the required transactions reconciliation or pairing.
        /// </summary>
        [IsoId("_AtBHYcK3EeuFNp8LZAnorg")]
        [DisplayName("Pairing Reconciliation Status")]
        [IsoXmlTag("PairgRcncltnSts")]
        public NumberOfReportsPerStatus4? PairingReconciliationStatus { get; init; }

        /// <summary>
        /// Data on transaction requiring reconciliation or pairing.
        /// </summary>
        [IsoId("_AtBHY8K3EeuFNp8LZAnorg")]
        [DisplayName("Reconciliation Report")]
        [IsoXmlTag("RcncltnRpt")]
        public ValueList<ReconciliationReport8> ReconciliationReport { get; init; } = [];

        // ID for the above is _AtBHY8K3EeuFNp8LZAnorg

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_AtBHZcK3EeuFNp8LZAnorg")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
