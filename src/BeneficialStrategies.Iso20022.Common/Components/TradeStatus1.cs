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
/// Specifies the status of a trade in a central settlement system.
/// </summary>
[IsoId("_Q7Ma8dp-Ed-ak6NoX_4Aeg_-931990425")]
[DisplayName("Trade Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeStatus1( System.String reqMatchingSystemUniqueReference )
    {
        MatchingSystemUniqueReference = reqMatchingSystemUniqueReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether a trade is alleged or not.
    /// </summary>
    [IsoId("_Q7Ma8tp-Ed-ak6NoX_4Aeg_2061891848")]
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
    /// Reference to the unique identification assigned to a trade by a central matching system.
    /// </summary>
    [IsoId("_Q7Ma89p-Ed-ak6NoX_4Aeg_2043342151")]
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
    /// Specifies the status of a trade.
    /// </summary>
    [IsoId("_Q7Ma9Np-Ed-ak6NoX_4Aeg_809836093")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeStatus1Code? Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeStatus1Code? Status { get; init; } 
    #else
    public TradeStatus1Code? Status { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the status of a trade when no coded form is available.
    /// </summary>
    [IsoId("_Q7Ma9dp-Ed-ak6NoX_4Aeg_1685557048")]
    [DisplayName("Extended Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedSts")]
    #endif
    [IsoXmlTag("XtndedSts")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExtended350Code? ExtendedStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExtendedStatus { get; init; } 
    #else
    public System.String? ExtendedStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information on the status of a trade in a central system.
    /// </summary>
    [IsoId("_Q7Ma9tp-Ed-ak6NoX_4Aeg_824610615")]
    [DisplayName("Status Sub Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsSubTp")]
    #endif
    [IsoXmlTag("StsSubTp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? StatusSubType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StatusSubType { get; init; } 
    #else
    public System.String? StatusSubType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the time at which a status was assigned.
    /// </summary>
    [IsoId("_Q7Ma99p-Ed-ak6NoX_4Aeg_1765636507")]
    [DisplayName("Status Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsTm")]
    #endif
    [IsoXmlTag("StsTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? StatusTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? StatusTime { get; init; } 
    #else
    public System.DateTime? StatusTime { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the party which assigned a status to a treasury trade.
    /// </summary>
    [IsoId("_Q7Ma-Np-Ed-ak6NoX_4Aeg_1712995906")]
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
    
    
    #nullable disable
    
}
