// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party12Choice
{
    /// <summary>
    /// Identification of a financial institution.
    /// </summary>
    [IsoId("_4O9pIdFmEd-Lq65KLayVeg")]
    [DisplayName("Agent")]
    public record Agent : Party12Choice_
    {
        /// <summary>
        /// Unique and unambiguous identification of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
        /// </summary>
        [IsoId("_TFB1Qtp-Ed-ak6NoX_4Aeg_1304823831")]
        [DisplayName("Financial Institution Identification")]
        [IsoXmlTag("FinInstnId")]
        public required FinancialInstitutionIdentification8 FinancialInstitutionIdentification { get; init; }

        /// <summary>
        /// Identifies a specific branch of a financial institution.||Usage: This component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
        /// </summary>
        [IsoId("_TFB1Q9p-Ed-ak6NoX_4Aeg_-1458035858")]
        [DisplayName("Branch Identification")]
        [IsoXmlTag("BrnchId")]
        public BranchData2? BranchIdentification { get; init; }
    }
}
