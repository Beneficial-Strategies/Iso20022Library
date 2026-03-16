// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InformationType1Choice
{
    /// <summary>
    /// Type of additional information in a coded form.
    /// </summary>
    [IsoId("_RYGZYNp-Ed-ak6NoX_4Aeg_598842184")]
    [DisplayName("Code")]
    public record Code : InformationType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the coded type of additional information provided.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InformationType1Code Value { get; init; }
    }
}
