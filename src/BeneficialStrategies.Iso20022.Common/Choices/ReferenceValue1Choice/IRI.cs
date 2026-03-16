// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReferenceValue1Choice
{
    /// <summary>
    /// Internationalized Resource Identifier (IRI) address.
    /// </summary>
    [IsoId("_yqrhkMePEeysUoBKYz1Ytw")]
    [DisplayName("IRI")]
    public record IRI : ReferenceValue1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 2048 characters.
        /// </summary>
        [IsoXmlTag("IRI")]
        [IsoSimpleType(IsoSimpleType.Max2048Text)]
        [StringLength(maximumLength: 2048, MinimumLength = 1)]
        public required IsoMax2048Text Value { get; init; }
    }
}
