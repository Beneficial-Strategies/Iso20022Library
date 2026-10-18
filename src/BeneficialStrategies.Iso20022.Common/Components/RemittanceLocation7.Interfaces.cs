// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record RemittanceLocation7 : IRemittanceLocation7
{
    IEnumerable<IRemittanceLocationData1> IRemittanceLocation7.RemittanceLocationDetails => RemittanceLocationDetails;
}
