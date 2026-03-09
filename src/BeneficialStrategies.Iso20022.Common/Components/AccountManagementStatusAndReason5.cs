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
/// Status information.
/// </summary>
[IsoId("_8vNzgUQSEealVdmlTDXWkw")]
[DisplayName("Account Management Status And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountManagementStatusAndReason5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountManagementStatusAndReason5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountManagementStatusAndReason5( Status25Choice_ reqStatus )
    {
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Status of the account management instruction that was previously received.
    /// </summary>
    [IsoId("_9H6nYUQSEealVdmlTDXWkw")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Status25Choice_ Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Status25Choice_ Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Status25Choice_ Status { get; init; } 
    #else
    public Status25Choice_ Status { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for the status of the account management instruction.
    /// </summary>
    [IsoId("_cPlMMGBdEeaR1OOiVxm3Gg")]
    [DisplayName("Status Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRsn")]
    #endif
    [IsoXmlTag("StsRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AcceptedStatusReason1Choice_? StatusReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcceptedStatusReason1Choice_? StatusReason { get; init; } 
    #else
    public AcceptedStatusReason1Choice_? StatusReason { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of the account opening or modification instruction at application level.
    /// </summary>
    [IsoId("_9H6nY0QSEealVdmlTDXWkw")]
    [DisplayName("Account Application Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctApplId")]
    #endif
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountApplicationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountApplicationIdentification { get; init; } 
    #else
    public System.String? AccountApplicationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Account to which the account opening is related.
    /// </summary>
    [IsoId("_9H6nZUQSEealVdmlTDXWkw")]
    [DisplayName("Existing Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExstgAcctId")]
    #endif
    [IsoXmlTag("ExstgAcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Account23? ExistingAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account23? ExistingAccountIdentification { get; init; } 
    #else
    public Account23? ExistingAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_CTz6oEy9EeafiMTDrtSnyw")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountIdentification { get; init; } 
    #else
    public System.String? AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the account.
    /// </summary>
    [IsoId("_EJC98Ey9EeafiMTDrtSnyw")]
    [DisplayName("Account Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSts")]
    #endif
    [IsoXmlTag("AcctSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountStatus2? AccountStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountStatus2? AccountStatus { get; init; } 
    #else
    public AccountStatus2? AccountStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the account is blocked and other factors for the blocked account.
    /// </summary>
    [IsoId("_2AZVkV1BEeagR5I1rq5oaw")]
    [DisplayName("Blocked Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckdSts")]
    #endif
    [IsoXmlTag("BlckdSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BlockedStatusReason2Choice_? BlockedStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BlockedStatusReason2Choice_? BlockedStatus { get; init; } 
    #else
    public BlockedStatusReason2Choice_? BlockedStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Date provided by the account owner to inform the account servicer of the date on which the holdings must be reported before the account is subsequently closed.
    /// </summary>
    [IsoId("_tfSXcWBzEeaHEJD5P6-ccw")]
    [DisplayName("FATCA Reporting Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FATCARptgDt")]
    #endif
    [IsoXmlTag("FATCARptgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? FATCAReportingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? FATCAReportingDate { get; init; } 
    #else
    public System.DateOnly? FATCAReportingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date provided by the account owner to inform the account servicer of the date on which the holdings must be reported before the account is subsequently closed.
    /// </summary>
    [IsoId("_VrHMUXXXEeaH0fB6yD0LBA")]
    [DisplayName("CRS Reporting Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CRSRptgDt")]
    #endif
    [IsoXmlTag("CRSRptgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? CRSReportingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? CRSReportingDate { get; init; } 
    #else
    public System.DateOnly? CRSReportingDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
