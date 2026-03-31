// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat29Choice
{
    /// <summary>
    /// Specifies the type of date.
    /// </summary>
    [IsoId("_n6yXblt_EeSmO6RkXg92Lg")]
    [DisplayName("Date Code")]
    public record DateCode : DateFormat29Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies when date is unknown.
        /// </summary>
        [IsoXmlTag("DtCd")]
        public required DateType1Code Value { get; init; }
    }
}
