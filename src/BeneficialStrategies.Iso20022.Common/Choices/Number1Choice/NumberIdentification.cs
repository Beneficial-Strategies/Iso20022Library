// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Number1Choice
{
    /// <summary>
    /// Number of maximum 3 numeric text.
    /// </summary>
    [IsoId("_RdKflNp-Ed-ak6NoX_4Aeg_-2117497176")]
    [DisplayName("Number Identification")]
    public record NumberIdentification : Number1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a numeric string with a maximum length of 3 digits.
        /// </summary>
        [IsoXmlTag("NbId")]
        [IsoSimpleType(IsoSimpleType.Max3NumericText)]
        public required IsoMax3NumericText Value { get; init; }
    }
}
