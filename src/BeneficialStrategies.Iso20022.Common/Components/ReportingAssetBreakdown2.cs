// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reporting Asset Breakdown2.
/// </summary>
[IsoId("_gDSccU2HEe-TXNruDFfwPA")]
[DisplayName("Reporting Asset Breakdown2")]
public record ReportingAssetBreakdown2
{
    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Debt Issuer Type.
    /// </summary>
    [DisplayName("Debt Issuer Type")]
    [IsoXmlTag("DebtIssrTp")]
    public DebtIssuerType1Code? DebtIssuerType { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax350Text? Identification { get; init; }

    /// <summary>
    /// Reporting Asset Type.
    /// </summary>
    [DisplayName("Reporting Asset Type")]
    [IsoXmlTag("RptgAsstTp")]
    public required ProductType6Code ReportingAssetType { get; init; }
}
