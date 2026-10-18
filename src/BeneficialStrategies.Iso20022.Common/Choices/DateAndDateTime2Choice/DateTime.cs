// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice
{
    /// <inheritdoc cref="IDateTime"/>
    [IsoId("_fPH6g5lhEeeE1Ya-LgRsuQ")]
    [DisplayName("Date Time")]
    public partial record DateTime : DateAndDateTime2Choice_
    {
        /// <inheritdoc cref="IDateTime.Value"/>
        [IsoXmlTag("DtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public required IsoISODateTime Value { get; init; }
    }
}
