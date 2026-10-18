// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateAcceptanceReportV01 : IMandateAcceptanceReportV01
{
    IGroupHeader31 IMandateAcceptanceReportV01.GroupHeader => GroupHeader;
    IMandateAcceptance1 IMandateAcceptanceReportV01.UnderlyingAcceptanceDetails => UnderlyingAcceptanceDetails;
}
