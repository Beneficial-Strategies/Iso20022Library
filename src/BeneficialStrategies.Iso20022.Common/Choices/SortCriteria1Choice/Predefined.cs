// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SortCriteria1Choice
{
    /// <summary>
    /// Pre-defined way of indicating how the information is broken down.
    /// </summary>
    [IsoId("_U1-1hdp-Ed-ak6NoX_4Aeg_1036248630")]
    [DisplayName("Predefined")]
    public record Predefined : SortCriteria1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of criterion used to sort a report.
        /// </summary>
        [IsoXmlTag("Prdfnd")]
        public required ReportSortedType1Code Value { get; init; }
    }
}
