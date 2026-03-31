// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Period1Choice
{
    /// <summary>
    /// Time span defined by a start date and time, and an end date and time.
    /// </summary>
    [IsoId("_T5oiB9p-Ed-ak6NoX_4Aeg_183629575")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public record Period : Period1Choice_
    {
        /// <summary>
        /// Date and time at which the range starts.
        /// </summary>
        [IsoId("_T5oiBNp-Ed-ak6NoX_4Aeg_1743067755")]
        [DisplayName("Start Date")]
        [IsoXmlTag("StartDt")]
        public required DateFormat12Choice_ StartDate { get; init; }

        /// <summary>
        /// Date and time at which the range ends.
        /// </summary>
        [IsoId("_T5oiBdp-Ed-ak6NoX_4Aeg_1743067910")]
        [DisplayName("End Date")]
        [IsoXmlTag("EndDt")]
        public required DateFormat12Choice_ EndDate { get; init; }
    }
}
