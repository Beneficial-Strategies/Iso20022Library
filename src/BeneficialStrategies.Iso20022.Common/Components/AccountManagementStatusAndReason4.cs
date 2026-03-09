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
[IsoId("_pxVPYSGaEeWKAaDJcYGKLw")]
[DisplayName("Account Management Status And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountManagementStatusAndReason4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountManagementStatusAndReason4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountManagementStatusAndReason4( Status20Choice_ reqStatus )
    {
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Status of the account opening instruction or account modification instruction.
    /// </summary>
    [IsoId("_qOyAYSGaEeWKAaDJcYGKLw")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Status20Choice_ Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Status20Choice_ Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Status20Choice_ Status { get; init; } 
    #else
    public Status20Choice_ Status { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of the account opening or modification instruction at application level.
    /// </summary>
    [IsoId("_qOyAYyGaEeWKAaDJcYGKLw")]
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
    [IsoId("_koqw0VxQEeW8MLuBzR10cg")]
    [DisplayName("Existing Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExstgAcctId")]
    #endif
    [IsoXmlTag("ExstgAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ExistingAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExistingAccountIdentification { get; init; } 
    #else
    public System.String? ExistingAccountIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
