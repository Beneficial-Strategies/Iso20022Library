// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountSchemeName1Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_P_4pQdp-Ed-ak6NoX_4Aeg_191053818")]
    [DisplayName("Code")]
    public partial record Code : AccountSchemeName1Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ExternalAccountIdentification1Code Value { get; init; }
    }
}
