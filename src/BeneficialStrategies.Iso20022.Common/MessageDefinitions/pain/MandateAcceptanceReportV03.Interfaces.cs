// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateAcceptanceReportV03 : IMandateAcceptanceReportV03
{
    IGroupHeader47 IMandateAcceptanceReportV03.GroupHeader => GroupHeader;
    IMandateAcceptance3 IMandateAcceptanceReportV03.UnderlyingAcceptanceDetails => UnderlyingAcceptanceDetails;
    ISupplementaryData1? IMandateAcceptanceReportV03.SupplementaryData => SupplementaryData;
}
