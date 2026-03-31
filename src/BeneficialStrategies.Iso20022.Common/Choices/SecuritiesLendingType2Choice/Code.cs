// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesLendingType2Choice
{
    /// <summary>
    /// Securities lending type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_KrIw85EkEeakHoV5BVecAQ")]
    [DisplayName("Code")]
    public record Code : SecuritiesLendingType2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Type of securities lending contract.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesLendingType1Code Value { get; init; }
    }
}
