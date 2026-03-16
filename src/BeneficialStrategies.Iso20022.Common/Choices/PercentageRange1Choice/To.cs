// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PercentageRange1Choice
{
    /// <summary>
    /// Upper boundary of a range of percentage rates.
    /// </summary>
    [IsoId("_7_BRqqMgEeCJ6YNENx4h-w_-1593914623")]
    [DisplayName("To")]
    [IsoXmlTag("To")]
    public record To : PercentageRange1Choice_
    {
        /// <summary>
        /// Percentage rate of the range limit.
        /// </summary>
        [IsoId("_8GekiKMgEeCJ6YNENx4h-w_1727044493")]
        [DisplayName("Boundary Rate")]
        [IsoXmlTag("BdryRate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public required IsoPercentageRate BoundaryRate { get; init; }

        /// <summary>
        /// Indicates whether the boundary percentage rate is included in the range of percentage rates.
        /// </summary>
        [IsoId("_8GekiaMgEeCJ6YNENx4h-w_-1807157650")]
        [DisplayName("Included")]
        [IsoXmlTag("Incl")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator Included { get; init; }
    }
}
