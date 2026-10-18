// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record TrackerRecord1 : ITrackerRecord1
{
    IBranchAndFinancialInstitutionIdentification6 ITrackerRecord1.Agent => Agent;
    ICurrencyExchange13? ITrackerRecord1.ExchangeRateData => ExchangeRateData;
}
