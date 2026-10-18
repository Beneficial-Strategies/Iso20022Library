// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateAndDateTimeChoice
{
    /// <inheritdoc cref="IDateTime"/>
    [IsoId("_T6OX6dp-Ed-ak6NoX_4Aeg_1215657156")]
    [DisplayName("Date Time")]
    public partial record DateTime : DateAndDateTimeChoice_
    {
        /// <inheritdoc cref="IDateTime.Value"/>
        [IsoXmlTag("DtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public required IsoISODateTime Value { get; init; }
    }
}
