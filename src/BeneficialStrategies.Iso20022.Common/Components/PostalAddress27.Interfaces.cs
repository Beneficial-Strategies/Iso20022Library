// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PostalAddress27 : IPostalAddress27
{
    IAddressType3Choice? IPostalAddress27.AddressType => AddressType;
    IEnumerable<Max70Text> IPostalAddress27.AddressLine => AddressLine;
}
