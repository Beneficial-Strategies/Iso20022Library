// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PersonOrOrganisation1Choice
{
    /// <summary>
    /// Identifies internal party.
    /// </summary>
    [IsoId("_W53_AgkhEeWGouz230Xp5Q")]
    [DisplayName("Internal")]
    public record Internal : PersonOrOrganisation1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the role as an internal party in the transaction.
        /// </summary>
        [IsoXmlTag("Intl")]
        public required InternalPartyRole1Code Value { get; init; }
    }
}
