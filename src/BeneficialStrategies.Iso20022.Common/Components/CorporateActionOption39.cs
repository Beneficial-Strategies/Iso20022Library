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
[IsoId("_gsrpQfo9EeCdeaSQAR2tKw")]
[DisplayName("Corporate Action Option")]
public record CorporateActionOption39
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_gsrpR_o9EeCdeaSQAR2tKw")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_gsrpUfo9EeCdeaSQAR2tKw")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption11Choice_ OptionType { get; init; }

    /// <summary>
    /// Provides information about the securities movement linked to the corporate action option.
    /// </summary>
    [IsoId("_gsrpW_o9EeCdeaSQAR2tKw")]
    [DisplayName("Securities Movement Details")]
    [IsoXmlTag("SctiesMvmntDtls")]
    public ValueList<SecuritiesOption27> SecuritiesMovementDetails { get; init; } = [];

    /// <summary>
    /// Provides information about the cash movement related to a corporate action option.
    /// </summary>
    [IsoId("_gsrpZfo9EeCdeaSQAR2tKw")]
    [DisplayName("Cash Movement Details")]
    [IsoXmlTag("CshMvmntDtls")]
    public ValueList<CashOption19> CashMovementDetails { get; init; } = [];
}
