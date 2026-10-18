// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IBranchAndFinancialInstitutionIdentification3"/>
[IsoId("_TFUwNdp-Ed-ak6NoX_4Aeg_-107465569")]
[DisplayName("Branch And Financial Institution Identification")]
public partial record BranchAndFinancialInstitutionIdentification3
{
    /// <inheritdoc cref="IBranchAndFinancialInstitutionIdentification3.FinancialInstitutionIdentification"/>
    [IsoId("_TFUwNtp-Ed-ak6NoX_4Aeg_-105617941")]
    [DisplayName("Financial Institution Identification")]
    [IsoXmlTag("FinInstnId")]
    public required FinancialInstitutionIdentification5Choice_ FinancialInstitutionIdentification { get; init; }

    /// <inheritdoc cref="IBranchAndFinancialInstitutionIdentification3.BranchIdentification"/>
    [IsoId("_TFUwN9p-Ed-ak6NoX_4Aeg_-105616105")]
    [DisplayName("Branch Identification")]
    [IsoXmlTag("BrnchId")]
    public BranchData? BranchIdentification { get; init; }
}
