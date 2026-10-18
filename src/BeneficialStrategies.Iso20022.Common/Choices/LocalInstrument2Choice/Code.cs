// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LocalInstrument2Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_TF7NI9p-Ed-ak6NoX_4Aeg_365018928")]
    [DisplayName("Code")]
    public partial record Code : LocalInstrument2Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ExternalLocalInstrument1Code Value { get; init; }
    }
}
