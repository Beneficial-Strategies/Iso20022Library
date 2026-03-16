// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeData14Choice
{
    /// <summary>
    /// Information concerning the reporting at transaction level.
    /// </summary>
    [IsoId("_CpO6Y__oEemm3skPVSMJQg")]
    [DisplayName("Report")]
    [IsoXmlTag("Rpt")]
    public record Report : TradeData14Choice_
    {
        /// <summary>
        /// Status of the required transactions reconciliation or pairing.
        /// </summary>
        [IsoId("_CtHU0f_oEemm3skPVSMJQg")]
        [DisplayName("Pairing Reconciliation Status")]
        [IsoXmlTag("PairgRcncltnSts")]
        public NumberOfReportsPerStatus2? PairingReconciliationStatus { get; init; }

        /// <summary>
        /// Data on transaction requiring reconciliation or pairing.
        /// </summary>
        [IsoId("_CtHU0__oEemm3skPVSMJQg")]
        [DisplayName("Reconciliation Report")]
        [IsoXmlTag("RcncltnRpt")]
        public ValueList<ReconciliationReport5> ReconciliationReport { get; init; } = [];

        // ID for the above is _CtHU0__oEemm3skPVSMJQg

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_CtHU1f_oEemm3skPVSMJQg")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
