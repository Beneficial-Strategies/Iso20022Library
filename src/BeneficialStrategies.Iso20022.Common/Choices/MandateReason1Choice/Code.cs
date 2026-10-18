// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MandateReason1Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_TOt8xtp-Ed-ak6NoX_4Aeg_193514894")]
    [DisplayName("Code")]
    public partial record Code : MandateReason1Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ExternalMandateReason1Code Value { get; init; }
    }
}
