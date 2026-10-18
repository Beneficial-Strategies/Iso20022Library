// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous identification of a financial institution or a branch of a financial institution.
/// </summary>
[IsoId("_8nO10W49EeiU9cctagi5ow")]
public interface IBranchAndFinancialInstitutionIdentification6 : IIsoComponent
{
    /// <summary>
    /// Unique and unambiguous identification of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_8xXCMW49EeiU9cctagi5ow")]
    [DisplayName("Financial Institution Identification")]
    [IsoXmlTag("FinInstnId")]
    IFinancialInstitutionIdentification18 FinancialInstitutionIdentification { get; }

    /// <summary>
    /// Identifies a specific branch of a financial institution.||Usage: This component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
    /// </summary>
    [IsoId("_8xXCM249EeiU9cctagi5ow")]
    [DisplayName("Branch Identification")]
    [IsoXmlTag("BrnchId")]
    IBranchData3? BranchIdentification { get; }
}
