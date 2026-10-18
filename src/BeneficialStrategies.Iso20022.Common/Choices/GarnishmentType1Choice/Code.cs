// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GarnishmentType1Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_lG0rQ4nnEeOORMXOfBk1Bw")]
    [DisplayName("Code")]
    public partial record Code : GarnishmentType1Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ExternalGarnishmentType1Code Value { get; init; }
    }
}
