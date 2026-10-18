// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Party2Choice;

public partial record PrivateIdentification : IPrivateIdentification
{
    IDateAndPlaceOfBirth IPrivateIdentification.DateAndPlaceOfBirth => DateAndPlaceOfBirth;
    IGenericIdentification4 IPrivateIdentification.OtherIdentification => OtherIdentification;
}
