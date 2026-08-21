// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DocumentAmountType1Choice
{
    /// <summary>
    /// Specifies the amount type, as published in an external referred amount code set.
    /// </summary>
    [DisplayName("Code")]
    public record Code : DocumentAmountType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the amount type, as published in an external referred amount code set.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalDocumentAmountType1Code Value { get; init; }
    }
}
