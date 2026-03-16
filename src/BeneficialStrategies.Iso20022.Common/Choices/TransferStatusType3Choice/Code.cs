// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferStatusType3Choice
{
    /// <summary>
    /// Type of event expressed as a code.
    /// </summary>
    [IsoId("_SoQd0dydEeqzDbuoooxhdw")]
    [DisplayName("Code")]
    public record Code : TransferStatusType3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of transfer status or transfer event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TransferStatusType2Code Value { get; init; }
    }
}
