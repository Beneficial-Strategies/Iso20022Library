// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the breakdown of a reported amount that can be split across a range of assets: bonds, cash, equities, or another asset class.
/// </summary>
[IsoId("_J02CgDWzEemdWfjs3tykFQ")]
[DisplayName("Reporting Asset Breakdown")]
public partial record ReportingAssetBreakdown1
{
    #nullable enable
    
    /// <summary>
    /// Class of the asset which is a component of the breakdown.
    /// </summary>
    [IsoId("_f9yPkDWzEemdWfjs3tykFQ")]
    [DisplayName("Reporting Asset Type")]
    [IsoXmlTag("RptgAsstTp")]
    public required ProductType6Code ReportingAssetType { get; init; } 
    
    /// <summary>
    /// Identifies the reporting asset.
    /// </summary>
    [IsoId("_xu3rkDWzEemdWfjs3tykFQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? Identification { get; init; } 
    
    /// <summary>
    /// Value of the reporting asset.
    /// </summary>
    [IsoId("_9bzMwDWzEemdWfjs3tykFQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    
    #nullable disable
    
}
