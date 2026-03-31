// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationProcessingStatus1Choice
{
    /// <summary>
    /// Provides the status of a cancellation request.
    /// </summary>
    [IsoId("_UX39M9p-Ed-ak6NoX_4Aeg_-1853143796")]
    [DisplayName("Code")]
    public record Code : CancellationProcessingStatus1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of a cancellation request.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CancellationProcessingStatus1Code Value { get; init; }
    }
}
