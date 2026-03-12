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
[IsoId("_67TXk2A4EeSMf75YyPqG7w")]
[DisplayName("Collateral")]
public partial record Collateral9
{
    #nullable enable
    
    /// <summary>
    /// Provides information about the collateral account, that is the identification, the type and optionally the name.
    /// </summary>
    [IsoId("_7ZNbkWA4EeSMf75YyPqG7w")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required CollateralAccount1 AccountIdentification { get; init; } 
    
    /// <summary>
    /// Provides the summary of the collateral valuation report.
    /// </summary>
    [IsoId("_7ZNbk2A4EeSMf75YyPqG7w")]
    [DisplayName("Report Summary")]
    [IsoXmlTag("RptSummry")]
    public required Summary1 ReportSummary { get; init; } 
    
    /// <summary>
    /// Provides additionnal information about the collateral valuation that has been posted.
    /// </summary>
    [IsoId("_7ZNblWA4EeSMf75YyPqG7w")]
    [DisplayName("Collateral Valuation")]
    [IsoXmlTag("CollValtn")]
    public CollateralValuation2? CollateralValuation { get; init; } 
    
    
    #nullable disable
    
}
