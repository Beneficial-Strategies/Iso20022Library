// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CategoryPurpose1Choice
{
    /// <summary>
    /// Category purpose, as published in an external category purpose code list.
    /// </summary>
    [IsoId("_THaa5dp-Ed-ak6NoX_4Aeg_1223014481")]
    [DisplayName("Code")]
    public record Code : CategoryPurpose1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the category purpose, as published in an external category purpose code list.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalCategoryPurpose1Code Value { get; init; }
    }
}
