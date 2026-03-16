// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatisticsPerCounterparty16Choice
{
    /// <summary>
    /// Detailed information on statistics per combination of counterparties.
    /// </summary>
    [IsoId("_rpsLQ1owEe23K4GXSpBSeg")]
    [DisplayName("Report")]
    [IsoXmlTag("Rpt")]
    public record Report : StatisticsPerCounterparty16Choice_
    {
        /// <summary>
        /// Reference date for statistics collection.
        /// </summary>
        [IsoId("_rqy-gVowEe23K4GXSpBSeg")]
        [DisplayName("Reference Date")]
        [IsoXmlTag("RefDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate ReferenceDate { get; init; }

        /// <summary>
        /// Detailed information of outstanding derivatives for which the valuation was not reported or the valuation reported is more than fourteen calendar days earlier than the date for which the report was generated shall be included in the report of missing valuations at the end of the day.
        /// </summary>
        [IsoId("_rqy-g1owEe23K4GXSpBSeg")]
        [DisplayName("Missing Valuation")]
        [IsoXmlTag("MssngValtn")]
        public required DetailedMissingValuationsStatistics4Choice_ MissingValuation { get; init; }

        /// <summary>
        /// Detailed information of the outstanding derivatives for which no margin information has been reported, or the margin information that was reported is dated more than fourteen calendar days earlier than the day.
        /// </summary>
        [IsoId("_rqy-hVowEe23K4GXSpBSeg")]
        [DisplayName("Missing Margin Information")]
        [IsoXmlTag("MssngMrgnInf")]
        public required DetailedMissingMarginInformationStatistics4Choice_ MissingMarginInformation { get; init; }

        /// <summary>
        /// Detailed information of the derivatives that were received on the day of generation of the report with action type ‘New’, ‘Position component’, ‘Modification’ or ‘Correction’ whose notional amount is greater than a threshold for that class of derivatives.
        /// </summary>
        [IsoId("_rqy-h1owEe23K4GXSpBSeg")]
        [DisplayName("Abnormal Values")]
        [IsoXmlTag("AbnrmlVals")]
        public required DetailedAbnormalValuesStatistics4Choice_ AbnormalValues { get; init; }
    }
}
