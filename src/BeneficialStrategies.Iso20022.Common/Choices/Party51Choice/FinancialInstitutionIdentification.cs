// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party51Choice
{
    /// <summary>
    /// Financial Institution Identification.
    /// </summary>
    [DisplayName("Financial Institution Identification")]
    public record FinancialInstitutionIdentification : Party51Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("FIId")]
        public required BranchAndFinancialInstitutionIdentification8 Value { get; init; }
    }
}
