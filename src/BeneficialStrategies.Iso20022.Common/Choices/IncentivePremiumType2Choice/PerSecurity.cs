// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IncentivePremiumType2Choice
{
    /// <summary>
    /// Number of securities giving right to a premium.
    /// </summary>
    [IsoId("_vMYu8fNBEeqRfth943bvEA")]
    [DisplayName("Per Security")]
    public record PerSecurity : IncentivePremiumType2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as an integer.
        /// </summary>
        [IsoXmlTag("PerScty")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber Value { get; init; }
    }
}
