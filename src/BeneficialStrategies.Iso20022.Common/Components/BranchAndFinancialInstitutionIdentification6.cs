// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IBranchAndFinancialInstitutionIdentification6"/>
[IsoId("_8nO10W49EeiU9cctagi5ow")]
[DisplayName("Branch And Financial Institution Identification")]
public partial record BranchAndFinancialInstitutionIdentification6
{
    /// <inheritdoc cref="IBranchAndFinancialInstitutionIdentification6.FinancialInstitutionIdentification"/>
    [IsoId("_8xXCMW49EeiU9cctagi5ow")]
    [DisplayName("Financial Institution Identification")]
    [IsoXmlTag("FinInstnId")]
    public required FinancialInstitutionIdentification18 FinancialInstitutionIdentification { get; init; }

    /// <inheritdoc cref="IBranchAndFinancialInstitutionIdentification6.BranchIdentification"/>
    [IsoId("_8xXCM249EeiU9cctagi5ow")]
    [DisplayName("Branch Identification")]
    [IsoXmlTag("BrnchId")]
    public BranchData3? BranchIdentification { get; init; }
}
