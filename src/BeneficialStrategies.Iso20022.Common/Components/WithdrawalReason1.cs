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
/// Specifies the withdrawal reason code and optionally a withdrawal reason sub code.
/// </summary>
[IsoId("_t1jau4xnEeKdxfnzD2sqyA")]
[DisplayName("Withdrawal Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record WithdrawalReason1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a WithdrawalReason1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public WithdrawalReason1( WithdrawalReason1Code reqWithdrawalReasonCode )
    {
        WithdrawalReasonCode = reqWithdrawalReasonCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Withdrawal reason expressed as a code.
    /// </summary>
    [IsoId("_t1jaxYxnEeKdxfnzD2sqyA")]
    [DisplayName("Withdrawal Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WdrwlRsnCd")]
    #endif
    [IsoXmlTag("WdrwlRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required WithdrawalReason1Code WithdrawalReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required WithdrawalReason1Code WithdrawalReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public WithdrawalReason1Code WithdrawalReasonCode { get; init; } 
    #else
    public WithdrawalReason1Code WithdrawalReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Further withdrawal reason information expressed as a code.
    /// </summary>
    [IsoId("_t1javoxnEeKdxfnzD2sqyA")]
    [DisplayName("Withdrawal Reason Sub Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WdrwlRsnSubCd")]
    #endif
    [IsoXmlTag("WdrwlRsnSubCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4Text? WithdrawalReasonSubCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? WithdrawalReasonSubCode { get; init; } 
    #else
    public System.String? WithdrawalReasonSubCode { get; set; } 
    #endif
    
    
    #nullable disable
    
}
