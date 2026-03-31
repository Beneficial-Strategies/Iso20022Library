// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SystemPartyModification3Choice
{
    /// <summary>
    /// Party Name.
    /// </summary>
    [DisplayName("Party Name")]
    public record PartyName : SystemPartyModification3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("PtyNm")]
        public required PartyName3 Value { get; init; }
    }
}
