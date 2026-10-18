// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatusReason6Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_TRGiZ9p-Ed-ak6NoX_4Aeg_-1877638996")]
    [DisplayName("Code")]
    public partial record Code : StatusReason6Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ExternalStatusReason1Code Value { get; init; }
    }
}
