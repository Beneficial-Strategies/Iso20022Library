// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingType1Choice
{
    /// <summary>
    /// Type of processing restrictions, in a coded form.
    /// </summary>
    [IsoId("_705FQ6MgEeCJ6YNENx4h-w_-423447016")]
    [DisplayName("Code")]
    public record Code : ProcessingType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of processing restrictions the central system must apply.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ProcessingType1Code Value { get; init; }
    }
}
