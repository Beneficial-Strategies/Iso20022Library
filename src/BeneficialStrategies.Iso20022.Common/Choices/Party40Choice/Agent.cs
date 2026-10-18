// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party40Choice
{
    /// <inheritdoc cref="IAgent"/>
    [IsoId("_8U6MNW48EeiU9cctagi5ow")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public partial record Agent : Party40Choice_
    {
        /// <inheritdoc cref="IAgent.FinancialInstitutionIdentification"/>
        [IsoId("_8xXCMW49EeiU9cctagi5ow")]
        [DisplayName("Financial Institution Identification")]
        [IsoXmlTag("FinInstnId")]
        public required FinancialInstitutionIdentification18 FinancialInstitutionIdentification { get; init; }

        /// <inheritdoc cref="IAgent.BranchIdentification"/>
        [IsoId("_8xXCM249EeiU9cctagi5ow")]
        [DisplayName("Branch Identification")]
        [IsoXmlTag("BrnchId")]
        public BranchData3? BranchIdentification { get; init; }
    }
}
