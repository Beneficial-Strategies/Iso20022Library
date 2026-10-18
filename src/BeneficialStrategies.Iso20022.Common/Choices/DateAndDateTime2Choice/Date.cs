// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice
{
    /// <inheritdoc cref="IDate"/>
    [IsoId("_fPH6gZlhEeeE1Ya-LgRsuQ")]
    [DisplayName("Date")]
    public partial record Date : DateAndDateTime2Choice_
    {
        /// <inheritdoc cref="IDate.Value"/>
        [IsoXmlTag("Dt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate Value { get; init; }
    }
}
