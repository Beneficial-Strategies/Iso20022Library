// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MailType1Choice
{
    /// <summary>
    /// Mail type expressed as a code.
    /// </summary>
    [IsoId("_zx9lgCCXEeWJd9HF2tO7BA")]
    [DisplayName("Code")]
    public record Code : MailType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of mail service.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MailType1Code Value { get; init; }
    }
}
