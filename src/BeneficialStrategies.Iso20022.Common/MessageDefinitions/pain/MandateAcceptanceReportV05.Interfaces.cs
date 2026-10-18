// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateAcceptanceReportV05 : IMandateAcceptanceReportV05
{
    IGroupHeader47 IMandateAcceptanceReportV05.GroupHeader => GroupHeader;
    IMandateAcceptance5 IMandateAcceptanceReportV05.UnderlyingAcceptanceDetails => UnderlyingAcceptanceDetails;
    ISupplementaryData1? IMandateAcceptanceReportV05.SupplementaryData => SupplementaryData;
}
