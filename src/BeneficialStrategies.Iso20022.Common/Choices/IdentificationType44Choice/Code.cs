// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationType44Choice
{
    /// <summary>
    /// Type of identification is defined using a code.
    /// </summary>
    [IsoId("_chc_C5KQEeWHWpTQn1FFVg")]
    [DisplayName("Code")]
    public record Code : IdentificationType44Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of alternate identification which can be used to give an alternate identification of the party identified.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TypeOfIdentification1Code Value { get; init; }
    }
}
