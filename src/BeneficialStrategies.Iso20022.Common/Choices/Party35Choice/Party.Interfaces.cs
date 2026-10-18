// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Party35Choice;

public partial record Party : IParty
{
    IPostalAddress6? IParty.PostalAddress => PostalAddress;
    IParty34Choice? IParty.Identification => Identification;
    IContactDetails2? IParty.ContactDetails => ContactDetails;
}
