// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Branch And Financial Institution Identification8.
/// </summary>
[IsoId("_vxnQ0TEyEe6g-ffJsqGiSA")]
[DisplayName("Branch And Financial Institution Identification8")]
public record BranchAndFinancialInstitutionIdentification8
{
    /// <summary>
    /// Branch Identification.
    /// </summary>
    [DisplayName("Branch Identification")]
    [IsoXmlTag("BrnchId")]
    public BranchData5? BranchIdentification { get; init; }

    /// <summary>
    /// Financial Institution Identification.
    /// </summary>
    [DisplayName("Financial Institution Identification")]
    [IsoXmlTag("FinInstnId")]
    public required FinancialInstitutionIdentification23 FinancialInstitutionIdentification { get; init; }
}
