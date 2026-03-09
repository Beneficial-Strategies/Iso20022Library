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
[IsoId("_SvV_8gEcEeCQm6a_G2yO_w_2088147903")]
[DisplayName("Trade Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeData3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeData3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeData3( System.String reqMatchingSystemUniqueReference,Status5Choice_ reqCurrentStatus )
    {
        MatchingSystemUniqueReference = reqMatchingSystemUniqueReference;
        CurrentStatus = reqCurrentStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to the unique system identification assigned to the trade by the central matching system.
    /// </summary>
    [IsoId("_SvV_8wEcEeCQm6a_G2yO_w_1091075550")]
    [DisplayName("Matching System Unique Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchgSysUnqRef")]
    #endif
    [IsoXmlTag("MtchgSysUnqRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MatchingSystemUniqueReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MatchingSystemUniqueReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MatchingSystemUniqueReference { get; init; } 
    #else
    public System.String MatchingSystemUniqueReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the unique matching identification assigned to the trade and to the matching trade from the counterparty by the central matching system.
    /// </summary>
    [IsoId("_SvV_9AEcEeCQm6a_G2yO_w_-206207174")]
    [DisplayName("Matching System Matching Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchgSysMtchgRef")]
    #endif
    [IsoXmlTag("MtchgSysMtchgRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MatchingSystemMatchingReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MatchingSystemMatchingReference { get; init; } 
    #else
    public System.String? MatchingSystemMatchingReference { get; set; } 
    #endif
    
    /// <summary>
    /// Party that assigned the status to the trade.
    /// </summary>
    [IsoId("_SvV_9QEcEeCQm6a_G2yO_w_977236484")]
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
    [IsoId("_SvV_9gEcEeCQm6a_G2yO_w_-499046731")]
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
    [IsoId("_SvV_9wEcEeCQm6a_G2yO_w_-1016908222")]
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
    /// Specifies the date and time at which the current status was assigned.
    /// </summary>
    [IsoId("_SvV_-AEcEeCQm6a_G2yO_w_-2013980575")]
    [DisplayName("Current Status Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurStsDtTm")]
    #endif
    [IsoXmlTag("CurStsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? CurrentStatusDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? CurrentStatusDateTime { get; init; } 
    #else
    public System.DateTime? CurrentStatusDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the previous status of the trade.
    /// </summary>
    [IsoId("_SvV_-QEcEeCQm6a_G2yO_w_-1473318800")]
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
    /// Specifies whether a trade is alleged or not.
    /// </summary>
    [IsoId("_SvV_-gEcEeCQm6a_G2yO_w_-633353166")]
    [DisplayName("Alleged Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllgdTrad")]
    #endif
    [IsoXmlTag("AllgdTrad")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AllegedTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AllegedTrade { get; init; } 
    #else
    public System.String? AllegedTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information on the previous status of a trade in a central system.
    /// </summary>
    [IsoId("_SvV_-wEcEeCQm6a_G2yO_w_-1846645819")]
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
    
    
    #nullable disable
    
}
