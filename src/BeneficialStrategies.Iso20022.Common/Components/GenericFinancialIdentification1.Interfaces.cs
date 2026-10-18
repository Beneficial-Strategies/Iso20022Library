// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GenericFinancialIdentification1 : IGenericFinancialIdentification1
{
    IFinancialIdentificationSchemeName1Choice? IGenericFinancialIdentification1.SchemeName => SchemeName;
}
