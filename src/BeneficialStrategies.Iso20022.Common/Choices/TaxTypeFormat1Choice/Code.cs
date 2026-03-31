// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TaxTypeFormat1Choice
{
    /// <summary>
    /// Standard code to specify the type of taxes.
    /// </summary>
    [IsoId("_SumZEwEcEeCQm6a_G2yO_w_931213658")]
    [DisplayName("Code")]
    public record Code : TaxTypeFormat1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of tax.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TaxType15Code Value { get; init; }
    }
}
