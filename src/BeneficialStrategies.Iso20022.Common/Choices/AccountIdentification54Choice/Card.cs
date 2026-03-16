// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification54Choice
{
    /// <summary>
    /// PAN of the card identifying the account.
    /// </summary>
    [IsoId("_5q1FoVHSEey4xOoMoOPSJQ")]
    [DisplayName("Card")]
    public record Card : AccountIdentification54Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a numeric string with a minimum length of 8 digits, and a maximum length of 28 digits.
        /// </summary>
        [IsoXmlTag("Card")]
        [IsoSimpleType(IsoSimpleType.Min8Max28NumericText)]
        public required IsoMin8Max28NumericText Value { get; init; }
    }
}
