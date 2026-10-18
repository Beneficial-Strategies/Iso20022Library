// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record AmendmentReasonInformation1 : IAmendmentReasonInformation1
{
    IPartyIdentification32? IAmendmentReasonInformation1.Originator => Originator;
    IMandateReason1Choice IAmendmentReasonInformation1.Reason => Reason;
    IEnumerable<IsoMax105Text> IAmendmentReasonInformation1.AdditionalInformation => AdditionalInformation;
}
