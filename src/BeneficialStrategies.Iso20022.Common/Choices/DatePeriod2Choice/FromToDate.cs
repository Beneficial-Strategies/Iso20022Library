// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DatePeriod2Choice
{
    /// <summary>
    /// Range of time between a start date and an end date.
    /// </summary>
    [IsoId("_jVCsNZlPEee-Zps0fZQaFQ")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public record FromToDate : DatePeriod2Choice_
    {
        /// <summary>
        /// Start date of the range.
        /// </summary>
        [IsoId("_lhvG0YaDEee8r9VKRbnJSg")]
        [DisplayName("From Date")]
        [IsoXmlTag("FrDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate FromDate { get; init; }

        /// <summary>
        /// End date of the range.
        /// </summary>
        [IsoId("_lhvG04aDEee8r9VKRbnJSg")]
        [DisplayName("To Date")]
        [IsoXmlTag("ToDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate ToDate { get; init; }
    }
}
