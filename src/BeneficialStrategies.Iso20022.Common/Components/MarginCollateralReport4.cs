// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of margin collateral agreement between counterparties.
/// </summary>
[IsoId("_1w_vQVosEe23K4GXSpBSeg")]
[DisplayName("Margin Collateral Report")]
public partial record MarginCollateralReport4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the unique code assigned by the reporting counterparty to the portfolio if the collateral is posted on a portfolio basis.
    /// Usage:
    /// NoCode is reported if the collateralisation was performed on a transaction level basis, or if there is no collateral agreement or if no collateral is posted or received.
    /// </summary>
    [IsoId("_1ywp0VosEe23K4GXSpBSeg")]
    [DisplayName("Collateral Portfolio Code")]
    [IsoXmlTag("CollPrtflCd")]
    public required CollateralPortfolioCode5Choice_ CollateralPortfolioCode { get; init; } 
    
    /// <summary>
    /// Indicates the type of collateral agreement existing between the counterparties.
    /// </summary>
    [IsoId("_1ywp01osEe23K4GXSpBSeg")]
    [DisplayName("Collateralisation Category")]
    [IsoXmlTag("CollstnCtgy")]
    public required CollateralisationType3Code CollateralisationCategory { get; init; } 
    
    /// <summary>
    /// Indicates the date and time of the last collateral amount determination or calculation.
    /// </summary>
    [IsoId("_1ywp1VosEe23K4GXSpBSeg")]
    [DisplayName("Time Stamp")]
    [IsoXmlTag("TmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TimeStamp { get; init; } 
    
    
    #nullable disable
    
}
