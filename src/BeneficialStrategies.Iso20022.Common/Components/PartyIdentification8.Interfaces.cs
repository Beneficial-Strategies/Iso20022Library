// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PartyIdentification8 : IPartyIdentification8
{
    IPostalAddress1? IPartyIdentification8.PostalAddress => PostalAddress;
    IParty2Choice? IPartyIdentification8.Identification => Identification;
}
