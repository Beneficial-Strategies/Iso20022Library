// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CreditorReferenceType2Choice
{
    /// <inheritdoc cref="IProprietary"/>
    [DisplayName("Proprietary")]
    public partial record Proprietary : CreditorReferenceType2Choice_
    {
        /// <inheritdoc cref="IProprietary.Value"/>
        [IsoXmlTag("Prtry")]
        public required IsoMax35Text Value { get; init; }
    }
}
