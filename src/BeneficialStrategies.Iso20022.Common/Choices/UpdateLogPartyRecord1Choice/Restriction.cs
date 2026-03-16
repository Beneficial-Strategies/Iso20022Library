// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UpdateLogPartyRecord1Choice
{
    /// <summary>
    /// Defines the specific processing characteristics for a party to ensure configurability of specific requirements, as prescribed by national legal and regulatory requirements and practices.
    /// </summary>
    [IsoId("_xPt7gmjNEeiRg5NzP0jkQg")]
    [DisplayName("Restriction")]
    [IsoXmlTag("Rstrctn")]
    public record Restriction : UpdateLogPartyRecord1Choice_
    {
        /// <summary>
        /// Old value before the update.
        /// </summary>
        [IsoId("_rhJndGjTEeiRg5NzP0jkQg")]
        [DisplayName("Old")]
        [IsoXmlTag("Od")]
        public required Restriction1 Old { get; init; }

        /// <summary>
        /// New value after the update.
        /// </summary>
        [IsoId("_rhJndWjTEeiRg5NzP0jkQg")]
        [DisplayName("New")]
        [IsoXmlTag("New")]
        public required Restriction1 New { get; init; }
    }
}
