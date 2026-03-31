// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UpdateLogPartyRecord1Choice
{
    /// <summary>
    /// Specifies the closing date of the party.
    /// </summary>
    [IsoId("_xPt7hmjNEeiRg5NzP0jkQg")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    public record ClosingDate : UpdateLogPartyRecord1Choice_
    {
        /// <summary>
        /// Old value before the update.
        /// </summary>
        [IsoId("_Zi5HlGjSEeiRg5NzP0jkQg")]
        [DisplayName("Old")]
        [IsoXmlTag("Od")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate Old { get; init; }

        /// <summary>
        /// New value after the update.
        /// </summary>
        [IsoId("_Zi5HlWjSEeiRg5NzP0jkQg")]
        [DisplayName("New")]
        [IsoXmlTag("New")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate New { get; init; }
    }
}
