// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatisticsPerCounterparty1Choice
{
    /// <summary>
    /// Detailed statistics per counterparty.
    /// </summary>
    [IsoId("_98o1t0wVEeqwfMIOLcNxbw")]
    [DisplayName("Report")]
    public record Report : StatisticsPerCounterparty1Choice_
    {
        /// <summary>
        /// Reference date for statistics collection.
        /// </summary>
        [IsoId("_5fuIcVfcEeqZr5K1Woax-g")]
        [DisplayName("Reference Date")]
        [IsoXmlTag("RefDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate ReferenceDate { get; init; }

        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_5fuIc1fcEeqZr5K1Woax-g")]
        [DisplayName("Counterparty Identification")]
        [IsoXmlTag("CtrPtyId")]
        public required TradeCounterpartyReport9 CounterpartyIdentification { get; init; }

        /// <summary>
        /// Detailed information on derivatives submitted for reconciliation.
        /// </summary>
        [IsoId("_5fuIdVfcEeqZr5K1Woax-g")]
        [DisplayName("Reconciliation Statistics")]
        [IsoXmlTag("RcncltnSttstcs")]
        public required ReconciliationStatisticsPerDerivativeContractGroup3 ReconciliationStatistics { get; init; }

        /// <summary>
        /// Identification of the competent authority which supervises the reporting counterparty.
        /// </summary>
        [IsoId("_5fuId1fcEeqZr5K1Woax-g")]
        [DisplayName("Competent Authority")]
        [IsoXmlTag("CmptntAuthrty")]
        public CompetentAuthority1? CompetentAuthority { get; init; }
    }
}
