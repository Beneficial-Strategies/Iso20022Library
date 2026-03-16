// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReferenceType1Choice
{
    /// <summary>
    /// Code identifying the type of reference.
    /// </summary>
    [IsoId("_uD80wMeUEeysUoBKYz1Ytw")]
    [DisplayName("Code")]
    public record Code : ReferenceType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 4 characters.
        /// </summary>
        [IsoXmlTag("Cd")]
        [IsoSimpleType(IsoSimpleType.Max4Text)]
        [StringLength(maximumLength: 4, MinimumLength = 1)]
        public required IsoMax4Text Value { get; init; }
    }
}
