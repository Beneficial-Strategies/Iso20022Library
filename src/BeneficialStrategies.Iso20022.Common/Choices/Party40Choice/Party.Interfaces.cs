// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Party40Choice;

public partial record Party : IParty
{
    IPostalAddress24? IParty.PostalAddress => PostalAddress;
    IParty38Choice? IParty.Identification => Identification;
    IContact4? IParty.ContactDetails => ContactDetails;
}
