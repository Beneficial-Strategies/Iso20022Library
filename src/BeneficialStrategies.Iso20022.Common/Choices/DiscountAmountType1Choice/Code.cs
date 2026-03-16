// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DiscountAmountType1Choice
{
    /// <summary>
    /// Specifies the amount type, in a coded form.
    /// </summary>
    [IsoId("_tlra8FkyEeGeoaLUQk__nA_1847720881")]
    [DisplayName("Code")]
    public record Code : DiscountAmountType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature, or use, of the amount in the format of character string with a maximum length of 4 characters.
        /// The list of valid codes is an external code list published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalDiscountAmountType1Code Value { get; init; }
    }
}
