// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MandateSetupReason1Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_iQq8NT2OEeS6DKIV6SF6gw")]
    [DisplayName("Code")]
    public partial record Code : MandateSetupReason1Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ExternalMandateSetupReason1Code Value { get; init; }
    }
}
