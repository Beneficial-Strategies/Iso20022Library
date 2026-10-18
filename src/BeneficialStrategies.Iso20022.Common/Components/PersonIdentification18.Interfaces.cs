// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PersonIdentification18 : IPersonIdentification18
{
    IDateAndPlaceOfBirth1? IPersonIdentification18.DateAndPlaceOfBirth => DateAndPlaceOfBirth;
    IEnumerable<IGenericPersonIdentification2> IPersonIdentification18.Other => Other;
}
