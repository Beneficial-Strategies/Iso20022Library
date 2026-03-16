// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ServiceLevel2Choice
{
    /// <summary>
    /// Identification of a pre-agreed level of service between the parties in a coded form.
    /// </summary>
    [IsoId("_QJkwwtp-Ed-ak6NoX_4Aeg_1773004320")]
    [DisplayName("Code")]
    public record Code : ServiceLevel2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the pre-agreed level of service between the parties.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ServiceLevel1Code Value { get; init; }
    }
}
