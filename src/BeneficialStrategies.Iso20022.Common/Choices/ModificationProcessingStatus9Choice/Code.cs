// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus9Choice
{
    /// <summary>
    /// Provides the status of a modification request.
    /// </summary>
    [IsoId("_xFphgeF8EeWCAvUNsZ5u6g")]
    [DisplayName("Code")]
    public record Code : ModificationProcessingStatus9Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of a cancellation request.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ModificationProcessingStatus1Code Value { get; init; }
    }
}
