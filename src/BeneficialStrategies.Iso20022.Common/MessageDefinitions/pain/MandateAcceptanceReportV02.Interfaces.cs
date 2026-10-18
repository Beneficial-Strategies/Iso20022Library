// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateAcceptanceReportV02 : IMandateAcceptanceReportV02
{
    IGroupHeader47 IMandateAcceptanceReportV02.GroupHeader => GroupHeader;
    IMandateAcceptance2 IMandateAcceptanceReportV02.UnderlyingAcceptanceDetails => UnderlyingAcceptanceDetails;
    ISupplementaryData1? IMandateAcceptanceReportV02.SupplementaryData => SupplementaryData;
}
