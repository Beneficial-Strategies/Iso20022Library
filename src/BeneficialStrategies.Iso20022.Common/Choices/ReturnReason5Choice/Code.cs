// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReturnReason5Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_TP6Pktp-Ed-ak6NoX_4Aeg_-1676326035")]
    [DisplayName("Code")]
    public partial record Code : ReturnReason5Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ExternalReturnReason1Code Value { get; init; }
    }
}
