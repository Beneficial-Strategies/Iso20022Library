// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party50Choice
{
    /// <inheritdoc cref="IAgent"/>
    [DisplayName("Agent")]
    public partial record Agent : Party50Choice_
    {
        /// <inheritdoc cref="IAgent.Value"/>
        [IsoXmlTag("Agt")]
        public required BranchAndFinancialInstitutionIdentification8 Value { get; init; }
    }
}
