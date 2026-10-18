// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IBranchAndFinancialInstitutionIdentification5"/>
[IsoId("_TFB1Qdp-Ed-ak6NoX_4Aeg_1367253312")]
[DisplayName("Branch And Financial Institution Identification")]
public partial record BranchAndFinancialInstitutionIdentification5
{
    /// <inheritdoc cref="IBranchAndFinancialInstitutionIdentification5.FinancialInstitutionIdentification"/>
    [IsoId("_TFB1Qtp-Ed-ak6NoX_4Aeg_1304823831")]
    [DisplayName("Financial Institution Identification")]
    [IsoXmlTag("FinInstnId")]
    public required FinancialInstitutionIdentification8 FinancialInstitutionIdentification { get; init; }

    /// <inheritdoc cref="IBranchAndFinancialInstitutionIdentification5.BranchIdentification"/>
    [IsoId("_TFB1Q9p-Ed-ak6NoX_4Aeg_-1458035858")]
    [DisplayName("Branch Identification")]
    [IsoXmlTag("BrnchId")]
    public BranchData2? BranchIdentification { get; init; }
}
