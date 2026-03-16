// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides for each collateral account the report summary and the valuation of each piece of collateral.
/// </summary>
[IsoId("_z0NexYFvEeWtPe6Crjmeug")]
[DisplayName("Collateral")]
public record Collateral13
{
    /// <summary>
    /// Provides information about the collateral account, that is the identification, the type and optionally the name.
    /// </summary>
    [IsoId("_0KFBEYFvEeWtPe6Crjmeug")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required CollateralAccount2 AccountIdentification { get; init; }

    /// <summary>
    /// Provides the summary of the collateral valuation report.
    /// </summary>
    [IsoId("_0KFBE4FvEeWtPe6Crjmeug")]
    [DisplayName("Report Summary")]
    [IsoXmlTag("RptSummry")]
    public required Summary1 ReportSummary { get; init; }

    /// <summary>
    /// Provides additionnal information about the collateral valuation that has been posted.
    /// </summary>
    [IsoId("_0KFBFYFvEeWtPe6Crjmeug")]
    [DisplayName("Collateral Valuation")]
    [IsoXmlTag("CollValtn")]
    public CollateralValuation5? CollateralValuation { get; init; }
}
