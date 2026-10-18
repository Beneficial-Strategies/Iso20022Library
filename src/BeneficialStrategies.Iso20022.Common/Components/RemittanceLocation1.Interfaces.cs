// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record RemittanceLocation1 : IRemittanceLocation1
{
    INameAndAddress3? IRemittanceLocation1.RemittanceLocationPostalAddress => RemittanceLocationPostalAddress;
}
