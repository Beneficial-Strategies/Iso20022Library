// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AmountOrRate1Choice
{
    /// <inheritdoc cref="IRate"/>
    [IsoId("_Q-Unctp-Ed-ak6NoX_4Aeg_827689641")]
    [DisplayName("Rate")]
    public partial record Rate : AmountOrRate1Choice_
    {
        /// <inheritdoc cref="IRate.Value"/>
        [IsoXmlTag("Rate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public required IsoPercentageRate Value { get; init; }
    }
}
