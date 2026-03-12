// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides for each collateral account the report summary and the valuation of each piece of collateral.
/// </summary>
[IsoId("_otPoFAF1EeutW5-TpeYJhA")]
[DisplayName("Collateral")]
public partial record Collateral43
{
    #nullable enable
    
    /// <summary>
    /// Provides information about the collateral account, that is the identification, the type and optionally the name.
    /// </summary>
    [IsoId("_otPoFgF1EeutW5-TpeYJhA")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required CollateralAccount3 AccountIdentification { get; init; } 
    
    /// <summary>
    /// Summary of the collateral valuation.
    /// </summary>
    [IsoId("_otPoFwF1EeutW5-TpeYJhA")]
    [DisplayName("Report Summary")]
    [IsoXmlTag("RptSummry")]
    public required Summary2 ReportSummary { get; init; } 
    
    /// <summary>
    /// Additional information about the collateral valuation that has been posted.
    /// </summary>
    [IsoId("_otPoFQF1EeutW5-TpeYJhA")]
    [DisplayName("Collateral Valuation")]
    [IsoXmlTag("CollValtn")]
    public CollateralValuation12? CollateralValuation { get; init; } 
    
    
    #nullable disable
    
}
