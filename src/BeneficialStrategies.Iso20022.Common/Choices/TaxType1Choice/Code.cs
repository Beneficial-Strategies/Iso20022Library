// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TaxType1Choice
{
    /// <summary>
    /// Type of tax expressed as a code.
    /// </summary>
    [IsoId("_4SMDcBuHEeOqSdXzJ0oydA")]
    [DisplayName("Code")]
    public record Code : TaxType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of tax.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TaxType16Code Value { get; init; }
    }
}
