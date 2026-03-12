// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the status of a trade.
/// </summary>
[IsoId("_SvM2CgEcEeCQm6a_G2yO_w_-1369738530")]
[DisplayName("Trade Data")]
public partial record TradeData4
{
    #nullable enable
    
    /// <summary>
    /// Party that assigned the status to the foreign exchange trade.
    /// </summary>
    [IsoId("_SvM2CwEcEeCQm6a_G2yO_w_1814317347")]
    [DisplayName("Status Originator")]
    [IsoXmlTag("StsOrgtr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? StatusOriginator { get; init; } 
    
    /// <summary>
    /// Specifies the new status of the trade.
    /// </summary>
    [IsoId("_SvM2DAEcEeCQm6a_G2yO_w_817244994")]
    [DisplayName("Current Status")]
    [IsoXmlTag("CurSts")]
    public required Status5Choice_ CurrentStatus { get; init; } 
    
    /// <summary>
    /// Additional information about the current status of the trade.
    /// </summary>
    [IsoId("_SvM2DQEcEeCQm6a_G2yO_w_-179827359")]
    [DisplayName("Current Status Sub Type")]
    [IsoXmlTag("CurStsSubTp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? CurrentStatusSubType { get; init; } 
    
    /// <summary>
    /// Specifies the date and time at which the current status was assigned to all the trades, unless overwritten by a date and time assigned to an individual trade.
    /// </summary>
    [IsoId("_SvM2DgEcEeCQm6a_G2yO_w_-1176899712")]
    [DisplayName("Current Status Date Time")]
    [IsoXmlTag("CurStsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CurrentStatusDateTime { get; init; } 
    
    /// <summary>
    /// Specifies the previous status of a trade.
    /// </summary>
    [IsoId("_SvM2DwEcEeCQm6a_G2yO_w_2120995231")]
    [DisplayName("Previous Status")]
    [IsoXmlTag("PrvsSts")]
    public Status5Choice_? PreviousStatus { get; init; } 
    
    /// <summary>
    /// Additional information on the previous status of a trade in a central system.
    /// </summary>
    [IsoId("_SvV_8AEcEeCQm6a_G2yO_w_-513235469")]
    [DisplayName("Previous Status Sub Type")]
    [IsoXmlTag("PrvsStsSubTp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? PreviousStatusSubType { get; init; } 
    
    /// <summary>
    /// Specifies the product for which the status of the confirmation is reported, unless overwritten by a product type assigned to an individual trade.
    /// </summary>
    [IsoId("_SvV_8QEcEeCQm6a_G2yO_w_126850525")]
    [DisplayName("Product Type")]
    [IsoXmlTag("PdctTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProductType { get; init; } 
    
    
    #nullable disable
    
}
