// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TaxType3Choice
{
    /// <summary>
    /// Type of tax expressed as a code.
    /// </summary>
    [IsoId("_NCW8gjh7EeaH-93K5JKmzw")]
    [DisplayName("Code")]
    public record Code : TaxType3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of tax.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TaxType17Code Value { get; init; }
    }
}
