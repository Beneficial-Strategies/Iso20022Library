// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Period7Choice
{
    /// <summary>
    /// Time span defined by a start date and time, and an end date and time.
    /// </summary>
    [IsoId("_VQk9WTwGEemGDJYTly2NCA")]
    [DisplayName("From Date To Date")]
    [IsoXmlTag("FrDtToDt")]
    public record FromDateToDate : Period7Choice_
    {
        /// <summary>
        /// Date and time at which the range starts.
        /// </summary>
        [IsoId("_T5oiAdp-Ed-ak6NoX_4Aeg_1497161242")]
        [DisplayName("From Date")]
        [IsoXmlTag("FrDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate FromDate { get; init; }

        /// <summary>
        /// Date and time at which the range ends.
        /// </summary>
        [IsoId("_T5oiAtp-Ed-ak6NoX_4Aeg_1497161560")]
        [DisplayName("To Date")]
        [IsoXmlTag("ToDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate ToDate { get; init; }
    }
}
