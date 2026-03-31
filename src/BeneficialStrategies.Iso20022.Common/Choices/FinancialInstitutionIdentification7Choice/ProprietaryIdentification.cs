// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstitutionIdentification7Choice
{
    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
    /// </summary>
    [IsoId("_Tet_ZyGOEeW7gKYhAMEFCw")]
    [DisplayName("Proprietary Identification")]
    public record ProprietaryIdentification : FinancialInstitutionIdentification7Choice_
    {
        /// <summary>
        /// Name or number assigned by an entity to enable recognition of that entity, for example, account identifier.
        /// </summary>
        [IsoId("_n2FZYSxxEeKgiYs1KJCQUg")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; }
    }
}
