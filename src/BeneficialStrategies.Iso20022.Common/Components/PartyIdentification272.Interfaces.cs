// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PartyIdentification272 : IPartyIdentification272
{
    IPostalAddress27? IPartyIdentification272.PostalAddress => PostalAddress;
    IParty52Choice? IPartyIdentification272.Identification => Identification;
    IContact13? IPartyIdentification272.ContactDetails => ContactDetails;
}
