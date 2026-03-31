// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action option.
/// </summary>
[IsoId("_c30QMZKQEeWHWpTQn1FFVg")]
[DisplayName("Corporate Action Option")]
public record CorporateActionOption126
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_c30QM5KQEeWHWpTQn1FFVg")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_c30QO5KQEeWHWpTQn1FFVg")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption26Choice_ OptionType { get; init; }

    /// <summary>
    /// Provides information about the securities movement linked to the corporate action option.
    /// </summary>
    [IsoId("_c30QQ5KQEeWHWpTQn1FFVg")]
    [DisplayName("Securities Movement Details")]
    [IsoXmlTag("SctiesMvmntDtls")]
    public ValueList<SecuritiesOption58> SecuritiesMovementDetails { get; init; } = [];

    /// <summary>
    /// Provides information about the cash movement related to a corporate action option.
    /// </summary>
    [IsoId("_c30QS5KQEeWHWpTQn1FFVg")]
    [DisplayName("Cash Movement Details")]
    [IsoXmlTag("CshMvmntDtls")]
    public ValueList<CashOption48> CashMovementDetails { get; init; } = [];
}
