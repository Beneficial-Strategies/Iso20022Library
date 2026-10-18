// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pacs;

public partial record MultilateralSettlementRequestV01 : IMultilateralSettlementRequestV01
{
    IGroupHeader104 IMultilateralSettlementRequestV01.GroupHeader => GroupHeader;
    IMultilateralSettlementRequest2 IMultilateralSettlementRequestV01.SettlementRequest => SettlementRequest;
    ISupplementaryData1? IMultilateralSettlementRequestV01.SupplementaryData => SupplementaryData;
}
