// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateOrDateTimePeriodChoice
{
    /// <summary>
    /// Period expressed a dates and times.
    /// </summary>
    [IsoId("_T6Em7tp-Ed-ak6NoX_4Aeg_-1583487690")]
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    public record DateTime : DateOrDateTimePeriodChoice_
    {
        /// <summary>
        /// Date and time at which the range starts.
        /// </summary>
        [IsoId("_T5xr9dp-Ed-ak6NoX_4Aeg_330596092")]
        [DisplayName("From Date Time")]
        [IsoXmlTag("FrDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public required IsoISODateTime FromDateTime { get; init; }

        /// <summary>
        /// Date and time at which the range ends.
        /// </summary>
        [IsoId("_T5xr9tp-Ed-ak6NoX_4Aeg_330596093")]
        [DisplayName("To Date Time")]
        [IsoXmlTag("ToDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public required IsoISODateTime ToDateTime { get; init; }
    }
}
