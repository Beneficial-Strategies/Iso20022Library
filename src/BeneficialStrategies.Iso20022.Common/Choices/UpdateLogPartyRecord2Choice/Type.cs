// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UpdateLogPartyRecord2Choice
{
    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    public record Type : UpdateLogPartyRecord2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Tp")]
        public required UpdateLogSystemPartyType1 Value { get; init; }
    }
}
