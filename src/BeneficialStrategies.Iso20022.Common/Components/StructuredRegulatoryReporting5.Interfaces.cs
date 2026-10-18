// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record StructuredRegulatoryReporting5 : IStructuredRegulatoryReporting5
{
    IRegulatoryReportingType1Choice? IStructuredRegulatoryReporting5.Type => Type;
    IEnumerable<Max35Text> IStructuredRegulatoryReporting5.Information => Information;
}
