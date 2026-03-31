// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PensionSchemeType1Choice
{
    /// <summary>
    /// Type of pension policy, plan or scheme expressed as a code.
    /// </summary>
    [IsoId("_JZwpYE4OEeiQHa-q1Uephw")]
    [DisplayName("Code")]
    public record Code : PensionSchemeType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of pension scheme.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PensionSchemeType1Code Value { get; init; }
    }
}
