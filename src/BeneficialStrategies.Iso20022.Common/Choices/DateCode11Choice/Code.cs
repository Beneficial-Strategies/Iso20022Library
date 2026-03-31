// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateCode11Choice
{
    /// <summary>
    /// Standard code to specify the type of date.
    /// </summary>
    [IsoId("_lH2aQfZFEd-2Jsl2KtUQCw")]
    [DisplayName("Code")]
    public record Code : DateCode11Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of dates.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DateType8Code Value { get; init; }
    }
}
