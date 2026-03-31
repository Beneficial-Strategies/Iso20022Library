// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UpdateLogPartyRecord1Choice
{
    /// <summary>
    /// Specifies the type of residence where the party has its permanent home or principal establishment.
    /// </summary>
    [IsoId("_xPtUfmjNEeiRg5NzP0jkQg")]
    [DisplayName("Residence Type")]
    [IsoXmlTag("ResTp")]
    public record ResidenceType : UpdateLogPartyRecord1Choice_
    {
        /// <summary>
        /// Old value before the update.
        /// </summary>
        [IsoId("_hgYlxWjWEeiRg5NzP0jkQg")]
        [DisplayName("Old")]
        [IsoXmlTag("Od")]
        public required ResidenceType1Code Old { get; init; }

        /// <summary>
        /// New value after the update.
        /// </summary>
        [IsoId("_hgYlxGjWEeiRg5NzP0jkQg")]
        [DisplayName("New")]
        [IsoXmlTag("New")]
        public required ResidenceType1Code New { get; init; }
    }
}
