// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateAcceptanceReportV04 : IMandateAcceptanceReportV04
{
    IGroupHeader47 IMandateAcceptanceReportV04.GroupHeader => GroupHeader;
    IMandateAcceptance4 IMandateAcceptanceReportV04.UnderlyingAcceptanceDetails => UnderlyingAcceptanceDetails;
    ISupplementaryData1? IMandateAcceptanceReportV04.SupplementaryData => SupplementaryData;
}
