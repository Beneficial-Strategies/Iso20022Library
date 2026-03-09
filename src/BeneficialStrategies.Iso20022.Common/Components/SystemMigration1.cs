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
/// Data about participant migration to new payment system process.
/// </summary>
[IsoId("_g8InkCG3EeaZx5-Tw7BKeQ")]
[DisplayName("System Migration")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SystemMigration1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the participant is a member of a new payment system.
    /// </summary>
    [IsoId("_TqHo0CHAEeaZx5-Tw7BKeQ")]
    [DisplayName("NPS Participant Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NPSPtcptInd")]
    #endif
    [IsoXmlTag("NPSPtcptInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? NPSParticipantIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NPSParticipantIndicator { get; init; } 
    #else
    public System.String? NPSParticipantIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Planned migration date.
    /// </summary>
    [IsoId("_Z_SbICHAEeaZx5-Tw7BKeQ")]
    [DisplayName("Planned Migration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlandMgrtnDt")]
    #endif
    [IsoXmlTag("PlandMgrtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? PlannedMigrationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? PlannedMigrationDate { get; init; } 
    #else
    public System.DateTime? PlannedMigrationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the balance was received.
    /// </summary>
    [IsoId("_WYk3UCG5EeaZx5-Tw7BKeQ")]
    [DisplayName("Balance Received Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalRcvdInd")]
    #endif
    [IsoXmlTag("BalRcvdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? BalanceReceivedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BalanceReceivedIndicator { get; init; } 
    #else
    public System.String? BalanceReceivedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the participant was migrated.
    /// </summary>
    [IsoId("_ruxDsCG3EeaZx5-Tw7BKeQ")]
    [DisplayName("Migrated")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mgrtd")]
    #endif
    [IsoXmlTag("Mgrtd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? Migrated { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Migrated { get; init; } 
    #else
    public System.String? Migrated { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the latest RABIS service.
    /// </summary>
    [IsoId("_ze70YCG3EeaZx5-Tw7BKeQ")]
    [DisplayName("Last Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastDt")]
    #endif
    [IsoXmlTag("LastDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? LastDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? LastDate { get; init; } 
    #else
    public System.DateTime? LastDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
