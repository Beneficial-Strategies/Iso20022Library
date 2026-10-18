// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Authorisation1Choice
{
    /// <inheritdoc cref="IProprietary"/>
    [IsoId("_RD_KkNp-Ed-ak6NoX_4Aeg_-955120080")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : Authorisation1Choice_
    {
        /// <inheritdoc cref="IProprietary.Value"/>
        [IsoXmlTag("Prtry")]
        [IsoSimpleType(IsoSimpleType.Max128Text)]
        [StringLength(maximumLength: 128, MinimumLength = 1)]
        public required IsoMax128Text Value { get; init; }
    }
}
