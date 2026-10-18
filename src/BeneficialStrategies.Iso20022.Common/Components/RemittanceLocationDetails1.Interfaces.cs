// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record RemittanceLocationDetails1 : IRemittanceLocationDetails1
{
    INameAndAddress10? IRemittanceLocationDetails1.PostalAddress => PostalAddress;
}
