// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PartyIdentification125 : IPartyIdentification125
{
    IPostalAddress6? IPartyIdentification125.PostalAddress => PostalAddress;
    IParty34Choice? IPartyIdentification125.Identification => Identification;
    IContactDetails2? IPartyIdentification125.ContactDetails => ContactDetails;
}
