// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FractionDispositionType27Choice
{
    /// <summary>
    /// Standard code to specify how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_7Ci64UGLEeWqy4niLuXETA")]
    [DisplayName("Code")]
    public record Code : FractionDispositionType27Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates that fractional value should be retained; no rounding.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FractionDispositionType11Code Value { get; init; }
    }
}
