// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateAcceptanceReportV06 : IMandateAcceptanceReportV06
{
    IGroupHeader80 IMandateAcceptanceReportV06.GroupHeader => GroupHeader;
    IMandateAcceptance6 IMandateAcceptanceReportV06.UnderlyingAcceptanceDetails => UnderlyingAcceptanceDetails;
    ISupplementaryData1? IMandateAcceptanceReportV06.SupplementaryData => SupplementaryData;
}
