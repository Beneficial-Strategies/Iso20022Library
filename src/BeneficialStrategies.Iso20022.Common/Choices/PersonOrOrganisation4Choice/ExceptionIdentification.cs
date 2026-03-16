// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PersonOrOrganisation4Choice
{
    /// <summary>
    /// Exception Identification.
    /// </summary>
    [DisplayName("Exception Identification")]
    public record ExceptionIdentification : PersonOrOrganisation4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("XcptnId")]
        public required PartyExceptionType1Code Value { get; init; }
    }
}
