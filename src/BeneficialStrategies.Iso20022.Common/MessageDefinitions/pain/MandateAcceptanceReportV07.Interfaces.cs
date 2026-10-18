// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateAcceptanceReportV07 : IMandateAcceptanceReportV07
{
    IGroupHeader80 IMandateAcceptanceReportV07.GroupHeader => GroupHeader;
    IMandateAcceptance7 IMandateAcceptanceReportV07.UnderlyingAcceptanceDetails => UnderlyingAcceptanceDetails;
    ISupplementaryData1? IMandateAcceptanceReportV07.SupplementaryData => SupplementaryData;
}
