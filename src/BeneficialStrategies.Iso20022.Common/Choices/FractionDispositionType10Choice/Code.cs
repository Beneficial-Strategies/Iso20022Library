// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FractionDispositionType10Choice
{
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_XZY5U-HEEd-1Ktb5rVaajw")]
    [DisplayName("Code")]
    public record Code : FractionDispositionType10Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FractionDispositionType6Code Value { get; init; }
    }
}
