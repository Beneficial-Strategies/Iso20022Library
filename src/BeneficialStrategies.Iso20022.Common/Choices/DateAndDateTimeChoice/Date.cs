// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateAndDateTimeChoice
{
    /// <inheritdoc cref="IDate"/>
    [IsoId("_T6OX6Np-Ed-ak6NoX_4Aeg_1215657155")]
    [DisplayName("Date")]
    public partial record Date : DateAndDateTimeChoice_
    {
        /// <inheritdoc cref="IDate.Value"/>
        [IsoXmlTag("Dt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate Value { get; init; }
    }
}
