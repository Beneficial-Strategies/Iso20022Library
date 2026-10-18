// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DiscountAmountType1Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_tlra8FkyEeGeoaLUQk__nA_1847720881")]
    [DisplayName("Code")]
    public partial record Code : DiscountAmountType1Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ExternalDiscountAmountType1Code Value { get; init; }
    }
}
