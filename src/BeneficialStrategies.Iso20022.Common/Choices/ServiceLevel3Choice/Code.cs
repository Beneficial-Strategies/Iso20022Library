// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ServiceLevel3Choice
{
    /// <summary>
    /// Identification of a pre-agreed level of service between the parties in a coded form.
    /// </summary>
    [IsoId("_QJkwxdp-Ed-ak6NoX_4Aeg_1187501371")]
    [DisplayName("Code")]
    public record Code : ServiceLevel3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the pre-agreed level of service between the parties.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ServiceLevel2Code Value { get; init; }
    }
}
