// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UpdateLogPartyRecord1Choice
{
    /// <summary>
    /// Specifies whether the party is locked or not, and the reason for this status, when required.
    /// </summary>
    [IsoId("_xPt7iWjNEeiRg5NzP0jkQg")]
    [DisplayName("Lock Status")]
    [IsoXmlTag("LckSts")]
    public record LockStatus : UpdateLogPartyRecord1Choice_
    {
        /// <summary>
        /// Old value before the update.
        /// </summary>
        [IsoId("_mm5wdGjSEeiRg5NzP0jkQg")]
        [DisplayName("Old")]
        [IsoXmlTag("Od")]
        public required PartyLockStatus1 Old { get; init; }

        /// <summary>
        /// New value after the update.
        /// </summary>
        [IsoId("_mm5wdWjSEeiRg5NzP0jkQg")]
        [DisplayName("New")]
        [IsoXmlTag("New")]
        public required PartyLockStatus1 New { get; init; }
    }
}
