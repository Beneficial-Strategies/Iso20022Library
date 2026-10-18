// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party35Choice
{
    /// <inheritdoc cref="IAgent"/>
    [IsoId("_mm7Z1bTREeeyuKckOGlwuA")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public partial record Agent : Party35Choice_
    {
        /// <inheritdoc cref="IAgent.FinancialInstitutionIdentification"/>
        [IsoId("_TFB1Qtp-Ed-ak6NoX_4Aeg_1304823831")]
        [DisplayName("Financial Institution Identification")]
        [IsoXmlTag("FinInstnId")]
        public required FinancialInstitutionIdentification8 FinancialInstitutionIdentification { get; init; }

        /// <inheritdoc cref="IAgent.BranchIdentification"/>
        [IsoId("_TFB1Q9p-Ed-ak6NoX_4Aeg_-1458035858")]
        [DisplayName("Branch Identification")]
        [IsoXmlTag("BrnchId")]
        public BranchData2? BranchIdentification { get; init; }
    }
}
