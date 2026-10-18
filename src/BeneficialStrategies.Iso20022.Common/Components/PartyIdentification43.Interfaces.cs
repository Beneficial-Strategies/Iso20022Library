// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PartyIdentification43 : IPartyIdentification43
{
    IPostalAddress6? IPartyIdentification43.PostalAddress => PostalAddress;
    IParty11Choice? IPartyIdentification43.Identification => Identification;
    IContactDetails2? IPartyIdentification43.ContactDetails => ContactDetails;
}
