// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatisticsPerCounterparty2Choice
{
    /// <summary>
    /// Detailed statistics per counterparty.
    /// </summary>
    [IsoId("_85s8lEwWEeqwfMIOLcNxbw")]
    [DisplayName("Report")]
    [IsoXmlTag("Rpt")]
    public record Report : StatisticsPerCounterparty2Choice_
    {
        /// <summary>
        /// Reference period for statistics collection.
        /// </summary>
        [IsoId("_MweAYVfdEeqZr5K1Woax-g")]
        [DisplayName("Reporting Period")]
        [IsoXmlTag("RptgPrd")]
        public required Period2 ReportingPeriod { get; init; }

        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_MweAY1fdEeqZr5K1Woax-g")]
        [DisplayName("Counterparty Identification")]
        [IsoXmlTag("CtrPtyId")]
        public required CounterpartyData36 CounterpartyIdentification { get; init; }

        /// <summary>
        /// Detailed information on rejections for derivatives submitted to trade repositories and failed to pass validations.
        /// </summary>
        [IsoId("_MweAZVfdEeqZr5K1Woax-g")]
        [DisplayName("Rejection Statistics")]
        [IsoXmlTag("RjctnSttstcs")]
        public required RejectionStatistics3 RejectionStatistics { get; init; }

        /// <summary>
        /// Identification of the competent authority which supervises the reporting counterparty.
        /// </summary>
        [IsoId("_MweAZ1fdEeqZr5K1Woax-g")]
        [DisplayName("Competent Authority")]
        [IsoXmlTag("CmptntAuthrty")]
        public CompetentAuthority1? CompetentAuthority { get; init; }
    }
}
