// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TimeToMaturity1Choice
{
    /// <summary>
    /// Provides the time to maturity when no period is provide.
    /// </summary>
    [IsoId("_9Q_E4MVaEeiYpLQka876sg")]
    [DisplayName("Special")]
    public record Special : TimeToMaturity1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies blank or not available codes.
        /// </summary>
        [IsoXmlTag("Spcl")]
        public required SpecialPurpose2Code Value { get; init; }
    }
}
