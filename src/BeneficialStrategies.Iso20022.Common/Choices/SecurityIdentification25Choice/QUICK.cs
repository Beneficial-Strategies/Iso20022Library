// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification25Choice
{
    /// <summary>
    /// Identifier of a security assigned by the Japanese QUICK identification scheme for financial instruments.
    /// </summary>
    [IsoId("_cH1L8TnxEeabspMEjqY5TQ")]
    [DisplayName("QUICK")]
    public record QUICK : SecurityIdentification25Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Identifier of a security assigned by the Japanese QUICK identification scheme for financial instruments.
        /// </summary>
        [IsoXmlTag("QUICK")]
        [IsoSimpleType(IsoSimpleType.QUICKIdentifier)]
        public required IsoQUICKIdentifier Value { get; init; }
    }
}
