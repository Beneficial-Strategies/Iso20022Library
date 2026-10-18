// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CategoryPurpose1Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_THaa5dp-Ed-ak6NoX_4Aeg_1223014481")]
    [DisplayName("Code")]
    public partial record Code : CategoryPurpose1Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ExternalCategoryPurpose1Code Value { get; init; }
    }
}
