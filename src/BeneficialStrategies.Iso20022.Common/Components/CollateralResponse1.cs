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
[IsoId("_-IboQWTVEeSSTJlMfOKFsA")]
[DisplayName("Collateral Response")]
public record CollateralResponse1
{
    /// <summary>
    /// Provides details on the securities collateral proposal.
    /// </summary>
    [IsoId("_UI6AYGTXEeSSTJlMfOKFsA")]
    [DisplayName("Securities Collateral Response")]
    [IsoXmlTag("SctiesCollRspn")]
    public ValueList<SecuritiesCollateralResponse1> SecuritiesCollateralResponse { get; init; } =
        [];

    /// <summary>
    /// Provides details on the cash collateral proposal.
    /// </summary>
    [IsoId("_Py1_EGTXEeSSTJlMfOKFsA")]
    [DisplayName("Cash Collateral Response")]
    [IsoXmlTag("CshCollRspn")]
    public ValueList<CashCollateralResponse1> CashCollateralResponse { get; init; } = [];

    /// <summary>
    /// Provides details on other collateral proposal.
    /// </summary>
    [IsoId("_fsWOYGTXEeSSTJlMfOKFsA")]
    [DisplayName("Other Collateral Response")]
    [IsoXmlTag("OthrCollRspn")]
    public ValueList<OtherCollateralResponse1> OtherCollateralResponse { get; init; } = [];
}
