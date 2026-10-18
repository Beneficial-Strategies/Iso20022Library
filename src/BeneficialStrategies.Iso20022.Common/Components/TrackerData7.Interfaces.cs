// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record TrackerData7 : ITrackerData7
{
    IDateAndDateTime2Choice ITrackerData7.ConfirmedDate => ConfirmedDate;
    IEnumerable<ITrackerRecord5> ITrackerData7.TrackerRecord => TrackerRecord;
}
