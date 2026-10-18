// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record RegulatoryReporting2 : IRegulatoryReporting2
{
    IRegulatoryAuthority? IRegulatoryReporting2.Authority => Authority;
    IStructuredRegulatoryReporting2? IRegulatoryReporting2.RegulatoryDetails => RegulatoryDetails;
}
