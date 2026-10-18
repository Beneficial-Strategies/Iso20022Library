// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record TrackerData1 : ITrackerData1
{
    IDateAndDateTime2Choice ITrackerData1.ConfirmedDate => ConfirmedDate;
    IEnumerable<ITrackerRecord1> ITrackerData1.TrackerRecord => TrackerRecord;
}
