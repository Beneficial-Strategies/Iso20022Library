// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionChangeTypeFormat6Choice
{
    /// <summary>
    /// Standard code to specify the type of changes.
    /// </summary>
    [IsoId("_42kR4UGTEeWqy4niLuXETA")]
    [DisplayName("Code")]
    public record Code : CorporateActionChangeTypeFormat6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of changes.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionChangeType2Code Value { get; init; }
    }
}
