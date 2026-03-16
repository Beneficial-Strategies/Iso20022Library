// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentificationChoice
{
    /// <summary>
    /// Portuguese National Clearing Code - identifies Portuguese financial institutions on the Portuguese national clearing system.
    /// </summary>
    [IsoId("_TDY2hdp-Ed-ak6NoX_4Aeg_-896562591")]
    [DisplayName("Portuguese NCC Identification")]
    public record PortugueseNCCIdentification : ClearingSystemMemberIdentificationChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Portuguese National Clearing Code. Identifies Portuguese financial institutions on the Portuguese national clearing system.
        /// </summary>
        [IsoXmlTag("PTNCC")]
        [IsoSimpleType(IsoSimpleType.PortugueseNCCIdentifier)]
        public required IsoPortugueseNCCIdentifier Value { get; init; }
    }
}
