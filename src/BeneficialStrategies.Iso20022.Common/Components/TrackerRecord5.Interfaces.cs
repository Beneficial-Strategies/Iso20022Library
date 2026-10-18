// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record TrackerRecord5 : ITrackerRecord5
{
    IBranchAndFinancialInstitutionIdentification8 ITrackerRecord5.Agent => Agent;
    ICurrencyExchange13? ITrackerRecord5.ExchangeRateData => ExchangeRateData;
}
