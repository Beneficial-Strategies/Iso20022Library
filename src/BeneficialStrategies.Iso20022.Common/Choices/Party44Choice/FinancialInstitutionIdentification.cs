// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party44Choice
{
    /// <summary>
    /// Identification of a financial institution.
    /// </summary>
    [IsoId("_98TyY249EeiU9cctagi5ow")]
    [DisplayName("Financial Institution Identification")]
    public record FinancialInstitutionIdentification : Party44Choice_
    {
        /// <summary>
        /// Unique and unambiguous identification of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
        /// </summary>
        [IsoXmlTag("FinInstnId")]
        public required FinancialInstitutionIdentification18 Value { get; init; }

        /// <summary>
        /// Identifies a specific branch of a financial institution.||Usage: This component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
        /// </summary>
        [IsoId("_8xXCM249EeiU9cctagi5ow")]
        [DisplayName("Branch Identification")]
        [IsoXmlTag("BrnchId")]
        public BranchData3? BranchIdentification { get; init; }
    }
}
