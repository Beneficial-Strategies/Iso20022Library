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
/// Information about the message reference of the account management instruction message for which the status is requested.
/// </summary>
[IsoId("_KUjOwQgvEeSy_NqeitQG4Q")]
[DisplayName("Account Management Message Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountManagementMessageReference2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountManagementMessageReference2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountManagementMessageReference2( AccountManagementType1Code reqStatusRequestType )
    {
        StatusRequestType = reqStatusRequestType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to a linked message.
    /// </summary>
    [IsoId("_wu2KcQgvEeSy_NqeitQG4Q")]
    [DisplayName("Linked Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkdRef")]
    #endif
    [IsoXmlTag("LkdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LinkedMessage2Choice_? LinkedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LinkedMessage2Choice_? LinkedReference { get; init; } 
    #else
    public LinkedMessage2Choice_? LinkedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the status request refers to an earlier account opening or modification instruction message.
    /// </summary>
    [IsoId("_KvVGTwgvEeSy_NqeitQG4Q")]
    [DisplayName("Status Request Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsReqTp")]
    #endif
    [IsoXmlTag("StsReqTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountManagementType1Code StatusRequestType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountManagementType1Code StatusRequestType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountManagementType1Code StatusRequestType { get; init; } 
    #else
    public AccountManagementType1Code StatusRequestType { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of the account opening or account modification instruction at application level.
    /// </summary>
    [IsoId("_KvVGUQgvEeSy_NqeitQG4Q")]
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
    /// Account information for which the status of an account management instruction is requested.
    /// </summary>
    [IsoId("_KvVGUwgvEeSy_NqeitQG4Q")]
    [DisplayName("Investment Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcct")]
    #endif
    [IsoXmlTag("InvstmtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccount45? InvestmentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount45? InvestmentAccount { get; init; } 
    #else
    public InvestmentAccount45? InvestmentAccount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
