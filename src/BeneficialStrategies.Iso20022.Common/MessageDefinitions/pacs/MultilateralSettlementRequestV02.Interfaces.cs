// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record MultilateralSettlementRequestV02 : IMultilateralSettlementRequestV02
{
    IGroupHeader104 IMultilateralSettlementRequestV02.GroupHeader => GroupHeader;
    IEnumerable<IMultilateralSettlementRequest3> IMultilateralSettlementRequestV02.SettlementRequest => SettlementRequest;
    ISupplementaryData1? IMultilateralSettlementRequestV02.SupplementaryData => SupplementaryData;
}
