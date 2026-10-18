// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ServiceLevel8Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_QJa_zdp-Ed-ak6NoX_4Aeg_1912716972")]
    [DisplayName("Code")]
    public partial record Code : ServiceLevel8Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ExternalServiceLevel1Code Value { get; init; }
    }
}
