// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Purpose2Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_P6qyH9p-Ed-ak6NoX_4Aeg_-1283223370")]
    [DisplayName("Code")]
    public partial record Code : Purpose2Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ExternalPurpose1Code Value { get; init; }
    }
}
