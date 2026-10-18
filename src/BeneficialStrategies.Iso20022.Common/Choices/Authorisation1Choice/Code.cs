// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Authorisation1Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_RD1Zl9p-Ed-ak6NoX_4Aeg_-955120142")]
    [DisplayName("Code")]
    public partial record Code : Authorisation1Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required Authorisation1Code Value { get; init; }
    }
}
