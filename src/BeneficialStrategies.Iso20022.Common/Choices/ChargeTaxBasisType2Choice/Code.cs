// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ChargeTaxBasisType2Choice
{
    /// <summary>
    /// Securities transaction type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_VZBakZBhEeakHoV5BVecAQ")]
    [DisplayName("Code")]
    public record Code : ChargeTaxBasisType2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Define the Charges/tax basis for the trade being allocated.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ChargeTaxBasis1Code Value { get; init; }
    }
}
