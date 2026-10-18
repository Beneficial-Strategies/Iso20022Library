// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record AcceptanceResult6 : IAcceptanceResult6
{
    IMandateReason1Choice? IAcceptanceResult6.RejectReason => RejectReason;
    IEnumerable<IsoMax105Text> IAcceptanceResult6.AdditionalRejectReasonInformation => AdditionalRejectReasonInformation;
}
