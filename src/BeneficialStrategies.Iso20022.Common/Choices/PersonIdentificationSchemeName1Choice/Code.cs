// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PersonIdentificationSchemeName1Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_P_4pRNp-Ed-ak6NoX_4Aeg_2056543161")]
    [DisplayName("Code")]
    public partial record Code : PersonIdentificationSchemeName1Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ExternalPersonIdentification1Code Value { get; init; }
    }
}
