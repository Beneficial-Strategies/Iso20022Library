// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstitutionIdentification5Choice
{
    /// <inheritdoc cref="IBIC"/>
    [IsoId("_TFehN9p-Ed-ak6NoX_4Aeg_1156630060")]
    [DisplayName("BIC")]
    public partial record BIC : FinancialInstitutionIdentification5Choice_
    {
        /// <inheritdoc cref="IBIC.Value"/>
        [IsoXmlTag("BIC")]
        [IsoSimpleType(IsoSimpleType.BICIdentifier)]
        public required IsoBICIdentifier Value { get; init; }
    }
}
