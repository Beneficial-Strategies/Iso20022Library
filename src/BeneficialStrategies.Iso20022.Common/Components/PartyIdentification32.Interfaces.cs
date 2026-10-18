// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PartyIdentification32 : IPartyIdentification32
{
    IPostalAddress6? IPartyIdentification32.PostalAddress => PostalAddress;
    IParty6Choice? IPartyIdentification32.Identification => Identification;
    IContactDetails2? IPartyIdentification32.ContactDetails => ContactDetails;
}
