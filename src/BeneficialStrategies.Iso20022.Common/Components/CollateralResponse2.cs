// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information on the collateral proposal(s), that is either in cash, securities or other types.
/// </summary>
[IsoId("_s62bx4pDEeaNTaanBSMWmg")]
[DisplayName("Collateral Response")]
public record CollateralResponse2
{
    /// <summary>
    /// Provides details on the securities collateral proposal.
    /// </summary>
    [IsoId("_tKLRM4pDEeaNTaanBSMWmg")]
    [DisplayName("Securities Collateral Response")]
    [IsoXmlTag("SctiesCollRspn")]
    public ValueList<SecuritiesCollateralResponse1> SecuritiesCollateralResponse { get; init; } =
        [];

    /// <summary>
    /// Provides details on the cash collateral proposal.
    /// </summary>
    [IsoId("_tKLRNYpDEeaNTaanBSMWmg")]
    [DisplayName("Cash Collateral Response")]
    [IsoXmlTag("CshCollRspn")]
    public ValueList<CashCollateralResponse2> CashCollateralResponse { get; init; } = [];

    /// <summary>
    /// Provides details on other collateral proposal.
    /// </summary>
    [IsoId("_tKLRN4pDEeaNTaanBSMWmg")]
    [DisplayName("Other Collateral Response")]
    [IsoXmlTag("OthrCollRspn")]
    public ValueList<OtherCollateralResponse2> OtherCollateralResponse { get; init; } = [];
}
