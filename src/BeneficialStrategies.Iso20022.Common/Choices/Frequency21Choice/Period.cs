// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Frequency21Choice
{
    /// <inheritdoc cref="IPeriod"/>
    [IsoId("_6GkgCR7yEeSxevWRRWxNAg")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public partial record Period : Frequency21Choice_
    {
        /// <inheritdoc cref="IPeriod.Type"/>
        [IsoId("_1bz5sB71EeSxevWRRWxNAg")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required Frequency6Code Type { get; init; }

        /// <inheritdoc cref="IPeriod.CountPerPeriod"/>
        [IsoId("_OPlVUB72EeSxevWRRWxNAg")]
        [DisplayName("Count Per Period")]
        [IsoXmlTag("CntPerPrd")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber CountPerPeriod { get; init; }
    }
}
