// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous identifier of a financial institution or a branch of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
/// </summary>
[IsoId("_TFUwNdp-Ed-ak6NoX_4Aeg_-107465569")]
public interface IBranchAndFinancialInstitutionIdentification3 : IIsoComponent
{
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_TFUwNtp-Ed-ak6NoX_4Aeg_-105617941")]
    [DisplayName("Financial Institution Identification")]
    [IsoXmlTag("FinInstnId")]
    IFinancialInstitutionIdentification5Choice FinancialInstitutionIdentification { get; }

    /// <summary>
    /// Information identifying a specific branch of a financial institution.||Usage: this component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
    /// </summary>
    [IsoId("_TFUwN9p-Ed-ak6NoX_4Aeg_-105616105")]
    [DisplayName("Branch Identification")]
    [IsoXmlTag("BrnchId")]
    IBranchData? BranchIdentification { get; }
}
