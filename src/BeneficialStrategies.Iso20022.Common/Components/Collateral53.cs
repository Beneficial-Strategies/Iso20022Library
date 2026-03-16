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
[IsoId("_zoKi8SgtEeyB747fKu7_rw")]
[DisplayName("Collateral")]
public record Collateral53
{
    /// <summary>
    /// Provides information about the collateral account, that is the identification, the type and optionally the name.
    /// </summary>
    [IsoId("_0AdHISgtEeyB747fKu7_rw")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public CollateralAccount3? AccountIdentification { get; init; }

    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of collateral account for digital assets.
    /// </summary>
    [IsoId("_21OOcyqWEeyR9JrVGfaMKw")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet5? BlockChainAddressOrWallet { get; init; }

    /// <summary>
    /// Summary of the collateral valuation.
    /// </summary>
    [IsoId("_0AdHIygtEeyB747fKu7_rw")]
    [DisplayName("Report Summary")]
    [IsoXmlTag("RptSummry")]
    public required Summary3 ReportSummary { get; init; }

    /// <summary>
    /// Additional information about the collateral valuation that has been posted.
    /// </summary>
    [IsoId("_0AdHJSgtEeyB747fKu7_rw")]
    [DisplayName("Collateral Valuation")]
    [IsoXmlTag("CollValtn")]
    public CollateralValuation13? CollateralValuation { get; init; }
}
