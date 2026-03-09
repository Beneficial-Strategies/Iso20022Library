// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the status of a trade.
/// </summary>
[IsoId("_SvM2CgEcEeCQm6a_G2yO_w_-1369738530")]
[DisplayName("Trade Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeData4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeData4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeData4( Status5Choice_ reqCurrentStatus,System.DateTime reqCurrentStatusDateTime )
    {
        CurrentStatus = reqCurrentStatus;
        CurrentStatusDateTime = reqCurrentStatusDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that assigned the status to the foreign exchange trade.
    /// </summary>
    [IsoId("_SvM2CwEcEeCQm6a_G2yO_w_1814317347")]
    [DisplayName("Status Originator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsOrgtr")]
    #endif
    [IsoXmlTag("StsOrgtr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? StatusOriginator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StatusOriginator { get; init; } 
    #else
    public System.String? StatusOriginator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the new status of the trade.
    /// </summary>
    [IsoId("_SvM2DAEcEeCQm6a_G2yO_w_817244994")]
    [DisplayName("Current Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurSts")]
    #endif
    [IsoXmlTag("CurSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Status5Choice_ CurrentStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Status5Choice_ CurrentStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Status5Choice_ CurrentStatus { get; init; } 
    #else
    public Status5Choice_ CurrentStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the current status of the trade.
    /// </summary>
    [IsoId("_SvM2DQEcEeCQm6a_G2yO_w_-179827359")]
    [DisplayName("Current Status Sub Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurStsSubTp")]
    #endif
    [IsoXmlTag("CurStsSubTp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? CurrentStatusSubType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CurrentStatusSubType { get; init; } 
    #else
    public System.String? CurrentStatusSubType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date and time at which the current status was assigned to all the trades, unless overwritten by a date and time assigned to an individual trade.
    /// </summary>
    [IsoId("_SvM2DgEcEeCQm6a_G2yO_w_-1176899712")]
    [DisplayName("Current Status Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurStsDtTm")]
    #endif
    [IsoXmlTag("CurStsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CurrentStatusDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime CurrentStatusDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CurrentStatusDateTime { get; init; } 
    #else
    public System.DateTime CurrentStatusDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the previous status of a trade.
    /// </summary>
    [IsoId("_SvM2DwEcEeCQm6a_G2yO_w_2120995231")]
    [DisplayName("Previous Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsSts")]
    #endif
    [IsoXmlTag("PrvsSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Status5Choice_? PreviousStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Status5Choice_? PreviousStatus { get; init; } 
    #else
    public Status5Choice_? PreviousStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information on the previous status of a trade in a central system.
    /// </summary>
    [IsoId("_SvV_8AEcEeCQm6a_G2yO_w_-513235469")]
    [DisplayName("Previous Status Sub Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsStsSubTp")]
    #endif
    [IsoXmlTag("PrvsStsSubTp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? PreviousStatusSubType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PreviousStatusSubType { get; init; } 
    #else
    public System.String? PreviousStatusSubType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the product for which the status of the confirmation is reported, unless overwritten by a product type assigned to an individual trade.
    /// </summary>
    [IsoId("_SvV_8QEcEeCQm6a_G2yO_w_126850525")]
    [DisplayName("Product Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctTp")]
    #endif
    [IsoXmlTag("PdctTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProductType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductType { get; init; } 
    #else
    public System.String? ProductType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
