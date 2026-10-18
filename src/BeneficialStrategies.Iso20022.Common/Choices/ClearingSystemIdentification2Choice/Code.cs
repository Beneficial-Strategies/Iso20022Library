// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemIdentification2Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_TMoSEdp-Ed-ak6NoX_4Aeg_-1410917191")]
    [DisplayName("Code")]
    public partial record Code : ClearingSystemIdentification2Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ExternalClearingSystemIdentification1Code Value { get; init; }
    }
}
