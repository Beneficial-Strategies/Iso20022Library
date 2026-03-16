// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Number21Choice
{
    /// <summary>
    /// Number of maximum 4 numeric text.
    /// </summary>
    [IsoId("_AeehNNokEeC60axPepSq7g_249465515")]
    [DisplayName("Number Identification")]
    public record NumberIdentification : Number21Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a numeric string with a maximum length of 4 digits.
        /// </summary>
        [IsoXmlTag("NbId")]
        [IsoSimpleType(IsoSimpleType.Max4NumericText)]
        public required IsoMax4NumericText Value { get; init; }
    }
}
