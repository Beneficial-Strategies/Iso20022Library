// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UpdateLogPartyRecord1Choice
{
    /// <summary>
    /// Additional attributes defined by a central security depositary for a party.
    /// </summary>
    [IsoId("_xPt7hWjNEeiRg5NzP0jkQg")]
    [DisplayName("Market Specific Attribute")]
    [IsoXmlTag("MktSpcfcAttr")]
    public record MarketSpecificAttribute : UpdateLogPartyRecord1Choice_
    {
        /// <summary>
        /// Old value before the update.
        /// </summary>
        [IsoId("_8g_pMWjSEeiRg5NzP0jkQg")]
        [DisplayName("Old")]
        [IsoXmlTag("Od")]
        public required MarketSpecificAttribute1 Old { get; init; }

        /// <summary>
        /// New value after the update.
        /// </summary>
        [IsoId("_8g_pMGjSEeiRg5NzP0jkQg")]
        [DisplayName("New")]
        [IsoXmlTag("New")]
        public required MarketSpecificAttribute1 New { get; init; }
    }
}
