// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record RegulatoryReporting3 : IRegulatoryReporting3
{
    IRegulatoryAuthority2? IRegulatoryReporting3.Authority => Authority;
    IEnumerable<IStructuredRegulatoryReporting3> IRegulatoryReporting3.Details => Details;
}
