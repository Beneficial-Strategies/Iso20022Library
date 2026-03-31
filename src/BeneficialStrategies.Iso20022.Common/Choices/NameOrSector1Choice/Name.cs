// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NameOrSector1Choice
{
    /// <summary>
    /// Internal name of the counterparty of the reporting agent used by the reporting agent.
    /// </summary>
    [IsoId("_D_ZxYYIoEeWA9fc11zJf1Q")]
    [DisplayName("Name")]
    public record Name : NameOrSector1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 70characters.
        /// </summary>
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70, MinimumLength = 1)]
        public required IsoMax70Text Value { get; init; }
    }
}
