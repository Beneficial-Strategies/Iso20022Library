// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PostalAddress24 : IPostalAddress24
{
    IAddressType3Choice? IPostalAddress24.AddressType => AddressType;
    IEnumerable<string> IPostalAddress24.AddressLine => AddressLine;
}
