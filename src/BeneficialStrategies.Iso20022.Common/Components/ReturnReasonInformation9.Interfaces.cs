// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record ReturnReasonInformation9 : IReturnReasonInformation9
{
    IPartyIdentification32? IReturnReasonInformation9.Originator => Originator;
    IReturnReason5Choice? IReturnReasonInformation9.Reason => Reason;
    IEnumerable<Max105Text> IReturnReasonInformation9.AdditionalInformation => AdditionalInformation;
}
