// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.pain;

public partial record MandateAcceptanceReportV08 : IMandateAcceptanceReportV08
{
    IGroupHeader110 IMandateAcceptanceReportV08.GroupHeader => GroupHeader;
    IEnumerable<ISupplementaryData1> IMandateAcceptanceReportV08.SupplementaryData => SupplementaryData;
    IEnumerable<IMandateAcceptance8> IMandateAcceptanceReportV08.UnderlyingAcceptanceDetails => UnderlyingAcceptanceDetails;
}
