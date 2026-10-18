// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IBranchAndFinancialInstitutionIdentification4"/>
[IsoId("_TFB1RNp-Ed-ak6NoX_4Aeg_-736060150")]
[DisplayName("Branch And Financial Institution Identification")]
public partial record BranchAndFinancialInstitutionIdentification4
{
    /// <inheritdoc cref="IBranchAndFinancialInstitutionIdentification4.FinancialInstitutionIdentification"/>
    [IsoId("_TFB1Rdp-Ed-ak6NoX_4Aeg_-736059286")]
    [DisplayName("Financial Institution Identification")]
    [IsoXmlTag("FinInstnId")]
    public required FinancialInstitutionIdentification7 FinancialInstitutionIdentification { get; init; }

    /// <inheritdoc cref="IBranchAndFinancialInstitutionIdentification4.BranchIdentification"/>
    [IsoId("_TFB1Rtp-Ed-ak6NoX_4Aeg_-1911467512")]
    [DisplayName("Branch Identification")]
    [IsoXmlTag("BrnchId")]
    public BranchData2? BranchIdentification { get; init; }
}
