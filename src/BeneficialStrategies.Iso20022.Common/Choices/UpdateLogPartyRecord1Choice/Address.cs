// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UpdateLogPartyRecord1Choice
{
    /// <summary>
    /// Information that locates and identifies a specific address.
    /// </summary>
    [IsoId("_xPt7gGjNEeiRg5NzP0jkQg")]
    [DisplayName("Address")]
    public record Address : UpdateLogPartyRecord1Choice_
    {
        /// <summary>
        /// Old value before change
        /// </summary>
        [IsoId("_U5BZcGjSEeiRg5NzP0jkQg")]
        [DisplayName("Old")]
        [IsoXmlTag("Od")]
        public required PostalAddress25 Old { get; init; }

        /// <summary>
        /// New value after change
        /// </summary>
        [IsoId("_SjDnoGjSEeiRg5NzP0jkQg")]
        [DisplayName("New")]
        [IsoXmlTag("New")]
        public required PostalAddress25 New { get; init; }
    }
}
