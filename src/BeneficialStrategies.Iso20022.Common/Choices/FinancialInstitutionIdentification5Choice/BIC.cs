// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstitutionIdentification5Choice
{
    /// <summary>
    /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_TFehN9p-Ed-ak6NoX_4Aeg_1156630060")]
    [DisplayName("BIC")]
    public record BIC : FinancialInstitutionIdentification5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
        /// </summary>
        [IsoXmlTag("BIC")]
        [IsoSimpleType(IsoSimpleType.BICIdentifier)]
        public required IsoBICIdentifier Value { get; init; }
    }
}
