// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record StatusReasonInformation1 : IStatusReasonInformation1
{
    IPartyIdentification8? IStatusReasonInformation1.StatusOriginator => StatusOriginator;
    IStatusReason1Choice? IStatusReasonInformation1.StatusReason => StatusReason;
    IEnumerable<Max105Text> IStatusReasonInformation1.AdditionalStatusReasonInformation => AdditionalStatusReasonInformation;
}
