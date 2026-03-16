// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification3Choice
{
    /// <summary>
    /// Identifier for Dutch securities.
    /// </summary>
    [IsoId("_Qd1wkNp-Ed-ak6NoX_4Aeg_-722284843")]
    [DisplayName("Dutch")]
    public record Dutch : SecurityIdentification3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Identifier for Dutch securities.
        /// </summary>
        [IsoXmlTag("Dtch")]
        [IsoSimpleType(IsoSimpleType.DutchIdentifier)]
        public required IsoDutchIdentifier Value { get; init; }
    }
}
