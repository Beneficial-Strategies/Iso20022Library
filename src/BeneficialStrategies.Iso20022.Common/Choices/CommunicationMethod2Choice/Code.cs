// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CommunicationMethod2Choice
{
    /// <summary>
    /// Unique and unambiguous identification of communication method using a code list.
    /// </summary>
    [IsoId("_29oJkA1fEeKGXqvMN6jpiw")]
    [DisplayName("Code")]
    public record Code : CommunicationMethod2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Communication method used for the transmission of documents.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CommunicationMethod2Code Value { get; init; }
    }
}
