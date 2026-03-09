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
[IsoId("_UscfANp-Ed-ak6NoX_4Aeg_1902245509")]
[DisplayName("Trade Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeData1( System.String reqNotificationIdentification,System.String reqMatchingSystemUniqueReference,TradeStatus1Code reqCurrentStatus,System.String reqExtendedCurrentStatus )
    {
        NotificationIdentification = reqNotificationIdentification;
        MatchingSystemUniqueReference = reqMatchingSystemUniqueReference;
        CurrentStatus = reqCurrentStatus;
        ExtendedCurrentStatus = reqExtendedCurrentStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Refers to the identification of a notification.
    /// </summary>
    [IsoId("_UscfAdp-Ed-ak6NoX_4Aeg_1953965551")]
    [DisplayName("Notification Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnId")]
    #endif
    [IsoXmlTag("NtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text NotificationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String NotificationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String NotificationIdentification { get; init; } 
    #else
    public System.String NotificationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the unique identification assigned to a trade by a central matching system.
    /// </summary>
    [IsoId("_UscfAtp-Ed-ak6NoX_4Aeg_1954886301")]
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
    /// Identifies the party which assigned a status to a treasury trade.
    /// </summary>
    [IsoId("_UscfA9p-Ed-ak6NoX_4Aeg_502075221")]
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
    /// Specifies the new status of a trade.
    /// </summary>
    [IsoId("_UscfBNp-Ed-ak6NoX_4Aeg_1546701058")]
    [DisplayName("Current Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurSts")]
    #endif
    [IsoXmlTag("CurSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeStatus1Code CurrentStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeStatus1Code CurrentStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeStatus1Code CurrentStatus { get; init; } 
    #else
    public TradeStatus1Code CurrentStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the status of a trade when no coded form is available.
    /// </summary>
    [IsoId("_UscfBdp-Ed-ak6NoX_4Aeg_2119516029")]
    [DisplayName("Extended Current Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedCurSts")]
    #endif
    [IsoXmlTag("XtndedCurSts")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedCurrentStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExtendedCurrentStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedCurrentStatus { get; init; } 
    #else
    public System.String ExtendedCurrentStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information on the current status of a trade in a central system.
    /// </summary>
    [IsoId("_UscfBtp-Ed-ak6NoX_4Aeg_1103289655")]
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
    /// Specifies the time at which the current status was assigned.
    /// </summary>
    [IsoId("_UscfB9p-Ed-ak6NoX_4Aeg_1922452873")]
    [DisplayName("Current Status Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurStsTm")]
    #endif
    [IsoXmlTag("CurStsTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? CurrentStatusTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? CurrentStatusTime { get; init; } 
    #else
    public System.DateTime? CurrentStatusTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the previous status of a trade.
    /// </summary>
    [IsoId("_UscfCNp-Ed-ak6NoX_4Aeg_1145893613")]
    [DisplayName("Previous Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsSts")]
    #endif
    [IsoXmlTag("PrvsSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeStatus1Code? PreviousStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeStatus1Code? PreviousStatus { get; init; } 
    #else
    public TradeStatus1Code? PreviousStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the status of a trade when no coded form is available.
    /// </summary>
    [IsoId("_UscfCdp-Ed-ak6NoX_4Aeg_942747498")]
    [DisplayName("Extended Previous Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedPrvsSts")]
    #endif
    [IsoXmlTag("XtndedPrvsSts")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExtended350Code? ExtendedPreviousStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExtendedPreviousStatus { get; init; } 
    #else
    public System.String? ExtendedPreviousStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information on the previous status of a trade in a central system.
    /// </summary>
    [IsoId("_Uslo8Np-Ed-ak6NoX_4Aeg_-1628157965")]
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
    /// Specifies the time at which the previous status was assigned.
    /// </summary>
    [IsoId("_Uslo8dp-Ed-ak6NoX_4Aeg_-1473004903")]
    [DisplayName("Previous Status Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsStsTm")]
    #endif
    [IsoXmlTag("PrvsStsTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? PreviousStatusTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? PreviousStatusTime { get; init; } 
    #else
    public System.DateTime? PreviousStatusTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the product for which the status of the confirmation is reported.
    /// </summary>
    [IsoId("_Uslo8tp-Ed-ak6NoX_4Aeg_1820316906")]
    [DisplayName("Product Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctTp")]
    #endif
    [IsoXmlTag("PdctTp")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4AlphaNumericText? ProductType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductType { get; init; } 
    #else
    public System.String? ProductType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
