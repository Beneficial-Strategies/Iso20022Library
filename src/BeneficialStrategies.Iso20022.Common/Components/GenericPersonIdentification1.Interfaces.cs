// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GenericPersonIdentification1 : IGenericPersonIdentification1
{
    IPersonIdentificationSchemeName1Choice? IGenericPersonIdentification1.SchemeName => SchemeName;
}
