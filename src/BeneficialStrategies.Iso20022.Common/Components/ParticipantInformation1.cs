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
/// Participant profile participant information.
/// </summary>
[IsoId("_5On4EB9nEeapDZRA0Hb6ow")]
[DisplayName("Participant Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ParticipantInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ParticipantInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ParticipantInformation1( SystemMigration1 reqMigration )
    {
        Migration = reqMigration;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date the profile was deleted.
    /// </summary>
    [IsoId("_Q1cYYB9oEeapDZRA0Hb6ow")]
    [DisplayName("Profile Deletion Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrflDeltnDt")]
    #endif
    [IsoXmlTag("PrflDeltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ProfileDeletionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ProfileDeletionDate { get; init; } 
    #else
    public System.DateTime? ProfileDeletionDate { get; set; } 
    #endif
    
    /// <summary>
    /// National BIC identifiers for authorised and central branches.
    /// </summary>
    [IsoId("_oJLIIB9pEeapDZRA0Hb6ow")]
    [DisplayName("Bank Branch")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkBrnch")]
    #endif
    [IsoXmlTag("BkBrnch")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CentralisedAndAuthorisedBranchIdentification1Choice_? BankBranch { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CentralisedAndAuthorisedBranchIdentification1Choice_? BankBranch { get; init; } 
    #else
    public CentralisedAndAuthorisedBranchIdentification1Choice_? BankBranch { get; set; } 
    #endif
    
    /// <summary>
    /// CBRF identification of the terminal.
    /// </summary>
    [IsoId("_Dx0NMB9sEeapDZRA0Hb6ow")]
    [DisplayName("Terminal Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermnlId")]
    #endif
    [IsoXmlTag("TermnlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TerminalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TerminalIdentification { get; init; } 
    #else
    public System.String? TerminalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Intraday restrictions details.
    /// </summary>
    [IsoId("_WauMkB9tEeapDZRA0Hb6ow")]
    [DisplayName("Restrictions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rstrctns")]
    #endif
    [IsoXmlTag("Rstrctns")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Restrictions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Restrictions { get; init; } 
    #else
    public System.String? Restrictions { get; set; } 
    #endif
    
    /// <summary>
    /// External payment system details.
    /// </summary>
    [IsoId("_XFengB9yEeapDZRA0Hb6ow")]
    [DisplayName("External Payment System Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlPmtSysInf")]
    #endif
    [IsoXmlTag("XtrnlPmtSysInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternalPaymentSystemDetails1? ExternalPaymentSystemInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPaymentSystemDetails1? ExternalPaymentSystemInformation { get; init; } 
    #else
    public ExternalPaymentSystemDetails1? ExternalPaymentSystemInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information related for participant migration process.
    /// </summary>
    [IsoId("_gEt3YCG3EeaZx5-Tw7BKeQ")]
    [DisplayName("Migration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mgrtn")]
    #endif
    [IsoXmlTag("Mgrtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemMigration1 Migration { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SystemMigration1 Migration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemMigration1 Migration { get; init; } 
    #else
    public SystemMigration1 Migration { get; set; } 
    #endif
    
    
    #nullable disable
    
}
