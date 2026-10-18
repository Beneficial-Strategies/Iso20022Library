// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OrganisationIdentificationSchemeName1Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_QACaQ9p-Ed-ak6NoX_4Aeg_362604423")]
    [DisplayName("Code")]
    public partial record Code : OrganisationIdentificationSchemeName1Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ExternalOrganisationIdentification1Code Value { get; init; }
    }
}
