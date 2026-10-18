// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PartyIdentification135 : IPartyIdentification135
{
    IPostalAddress24? IPartyIdentification135.PostalAddress => PostalAddress;
    IParty38Choice? IPartyIdentification135.Identification => Identification;
    IContact4? IPartyIdentification135.ContactDetails => ContactDetails;
}
