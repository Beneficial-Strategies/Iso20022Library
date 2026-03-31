// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PercentageRange1Choice
{
    /// <summary>
    /// Range of valid percentage rates.
    /// </summary>
    [IsoId("_7_LCoKMgEeCJ6YNENx4h-w_-1139827354")]
    [DisplayName("From To")]
    [IsoXmlTag("FrTo")]
    public record FromTo : PercentageRange1Choice_
    {
        /// <summary>
        /// Lower boundary of a range of percentage rates.
        /// </summary>
        [IsoId("_7_BRpqMgEeCJ6YNENx4h-w_-455806218")]
        [DisplayName("From")]
        [IsoXmlTag("Fr")]
        public required PercentageRangeBoundary1 From { get; init; }

        /// <summary>
        /// Upper boundary of a range of percentage rates.
        /// </summary>
        [IsoId("_7_BRp6MgEeCJ6YNENx4h-w_898182717")]
        [DisplayName("To")]
        [IsoXmlTag("To")]
        public required PercentageRangeBoundary1 To { get; init; }
    }
}
