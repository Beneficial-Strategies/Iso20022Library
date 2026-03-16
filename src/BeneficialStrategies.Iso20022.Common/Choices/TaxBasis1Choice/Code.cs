// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TaxBasis1Choice
{
    /// <summary>
    /// Tax basis expressed as a code.
    /// </summary>
    [IsoId("_kri-kBuIEeOqSdXzJ0oydA")]
    [DisplayName("Code")]
    public record Code : TaxBasis1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the tax basis.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TaxationBasis2Code Value { get; init; }
    }
}
