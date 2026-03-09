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
[IsoId("_RPTpwNp-Ed-ak6NoX_4Aeg_1905550020")]
[DisplayName("Account Management Message Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountManagementMessageReference1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountManagementMessageReference1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountManagementMessageReference1( AccountManagementType1Code reqStatusRequestType )
    {
        StatusRequestType = reqStatusRequestType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to a linked message sent in a proprietary way or reference of a system.
    /// </summary>
    [IsoId("_RPTpwdp-Ed-ak6NoX_4Aeg_1905550359")]
    [DisplayName("Other Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrRef")]
    #endif
    [IsoXmlTag("OthrRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? OtherReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? OtherReference { get; init; } 
    #else
    public AdditionalReference3? OtherReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_RPTpwtp-Ed-ak6NoX_4Aeg_1905550317")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? PreviousReference { get; init; } 
    #else
    public AdditionalReference3? PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the status request refers to an earlier account opening or modification instruction message.
    /// </summary>
    [IsoId("_RPTpw9p-Ed-ak6NoX_4Aeg_1905550298")]
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
    [IsoId("_RPTpxNp-Ed-ak6NoX_4Aeg_1905550256")]
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
    [IsoId("_RPTpxdp-Ed-ak6NoX_4Aeg_1905550394")]
    [DisplayName("Investment Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcct")]
    #endif
    [IsoXmlTag("InvstmtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccount14? InvestmentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount14? InvestmentAccount { get; init; } 
    #else
    public InvestmentAccount14? InvestmentAccount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
