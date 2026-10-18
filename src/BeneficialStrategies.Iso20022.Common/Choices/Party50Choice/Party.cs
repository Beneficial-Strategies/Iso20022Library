// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party50Choice
{
    /// <inheritdoc cref="IParty"/>
    [DisplayName("Party")]
    public partial record Party : Party50Choice_
    {
        /// <inheritdoc cref="IParty.Value"/>
        [IsoXmlTag("Pty")]
        public required PartyIdentification272 Value { get; init; }
    }
}
