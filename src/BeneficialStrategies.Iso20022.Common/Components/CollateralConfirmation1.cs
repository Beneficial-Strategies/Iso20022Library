// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the status details about the collateral substitution.
/// </summary>
[IsoId("_UnrTxNp-Ed-ak6NoX_4Aeg_-2119738374")]
[DisplayName("Collateral Confirmation")]
public record CollateralConfirmation1
{
    /// <summary>
    /// Reference to the collateral substitution request identification.
    /// </summary>
    [IsoId("_UnrTxdp-Ed-ak6NoX_4Aeg_-2130532228")]
    [DisplayName("Collateral Substitution Request Identification")]
    [IsoXmlTag("CollSbstitnReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CollateralSubstitutionRequestIdentification { get; init; }

    /// <summary>
    /// Reference to the collateral substitution response identification.
    /// </summary>
    [IsoId("_UnrTxtp-Ed-ak6NoX_4Aeg_2051423832")]
    [DisplayName("Collateral Substitution Response Identification")]
    [IsoXmlTag("CollSbstitnRspnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CollateralSubstitutionResponseIdentification { get; init; }

    /// <summary>
    /// Provides details about the status of the collateral substitution, either released or returned.
    /// </summary>
    [IsoId("_UnrTx9p-Ed-ak6NoX_4Aeg_-785691192")]
    [DisplayName("Confirmation Type")]
    [IsoXmlTag("ConfTp")]
    public required CollateralSubstitutionConfirmation1Code ConfirmationType { get; init; }

    /// <summary>
    /// Allows to provides additional comments on the collateral substitution status.
    /// </summary>
    [IsoId("_UnrTyNp-Ed-ak6NoX_4Aeg_1518492847")]
    [DisplayName("Comment")]
    [IsoXmlTag("Cmnt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Comment { get; init; }
}
