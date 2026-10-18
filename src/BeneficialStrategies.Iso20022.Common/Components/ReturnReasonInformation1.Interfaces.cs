// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record ReturnReasonInformation1 : IReturnReasonInformation1
{
    IPartyIdentification8? IReturnReasonInformation1.ReturnOriginator => ReturnOriginator;
    IReturnReason1Choice? IReturnReasonInformation1.ReturnReason => ReturnReason;
    IEnumerable<Max105Text> IReturnReasonInformation1.AdditionalReturnReasonInformation => AdditionalReturnReasonInformation;
}
