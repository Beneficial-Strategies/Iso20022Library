// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification30Choice
{
    /// <summary>
    /// Mobile Subscriber Integrated Service Digital Network (i.e. mobile phone number of the SIM card).
    /// </summary>
    [IsoId("_GGm1wHs9EeSTS7uHCe8FPQ")]
    [DisplayName("MSISDN")]
    public record MSISDN : AccountIdentification30Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 16 characters.
        /// </summary>
        [IsoXmlTag("MSISDN")]
        [IsoSimpleType(IsoSimpleType.Max16Text)]
        [StringLength(maximumLength: 16, MinimumLength = 1)]
        public required IsoMax16Text Value { get; init; }
    }
}
