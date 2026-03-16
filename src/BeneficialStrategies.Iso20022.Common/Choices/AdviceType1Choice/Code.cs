// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AdviceType1Choice
{
    /// <summary>
    /// Advice type, in a coded form.
    /// </summary>
    [IsoId("_u3TXxNomEembTrt_WixjyQ")]
    [DisplayName("Code")]
    public record Code : AdviceType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of advice to provide back in the report.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AdviceType1Code Value { get; init; }
    }
}
