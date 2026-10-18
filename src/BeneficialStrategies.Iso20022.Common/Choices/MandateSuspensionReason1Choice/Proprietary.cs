// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MandateSuspensionReason1Choice
{
    /// <inheritdoc cref="IProprietary"/>
    [IsoId("_gW_7xIPDEeahmOIR_zFG6A")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : MandateSuspensionReason1Choice_
    {
        /// <inheritdoc cref="IProprietary.Value"/>
        [IsoXmlTag("Prtry")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}
