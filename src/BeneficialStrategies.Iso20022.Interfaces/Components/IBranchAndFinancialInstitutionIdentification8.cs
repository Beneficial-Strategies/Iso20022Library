// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Branch And Financial Institution Identification8.
/// </summary>
[IsoId("_vxnQ0TEyEe6g-ffJsqGiSA")]
public interface IBranchAndFinancialInstitutionIdentification8 : IIsoComponent
{
    /// <summary>
    /// Branch Identification.
    /// </summary>
    [DisplayName("Branch Identification")]
    [IsoXmlTag("BrnchId")]
    IBranchData5? BranchIdentification { get; }

    /// <summary>
    /// Financial Institution Identification.
    /// </summary>
    [DisplayName("Financial Institution Identification")]
    [IsoXmlTag("FinInstnId")]
    IFinancialInstitutionIdentification23 FinancialInstitutionIdentification { get; }
}
