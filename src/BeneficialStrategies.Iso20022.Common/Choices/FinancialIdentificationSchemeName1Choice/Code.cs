// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialIdentificationSchemeName1Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_QALkMdp-Ed-ak6NoX_4Aeg_-2021925430")]
    [DisplayName("Code")]
    public partial record Code : FinancialIdentificationSchemeName1Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ExternalFinancialInstitutionIdentification1Code Value { get; init; }
    }
}
