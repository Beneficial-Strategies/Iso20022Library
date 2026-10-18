// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GenericPersonIdentification2 : IGenericPersonIdentification2
{
    IPersonIdentificationSchemeName1Choice? IGenericPersonIdentification2.SchemeName => SchemeName;
}
