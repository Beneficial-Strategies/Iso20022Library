// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Purpose1Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_PrK9gdp-Ed-ak6NoX_4Aeg_-607853940")]
    [DisplayName("Code")]
    public partial record Code : Purpose1Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ExternalPurposeCode_Obsolete Value { get; init; }
    }
}
