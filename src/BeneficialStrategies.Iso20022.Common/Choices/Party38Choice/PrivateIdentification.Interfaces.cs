// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Party38Choice;

public partial record PrivateIdentification : IPrivateIdentification
{
    IDateAndPlaceOfBirth1? IPrivateIdentification.DateAndPlaceOfBirth => DateAndPlaceOfBirth;
    IEnumerable<IGenericPersonIdentification1> IPrivateIdentification.Other => Other;
}
