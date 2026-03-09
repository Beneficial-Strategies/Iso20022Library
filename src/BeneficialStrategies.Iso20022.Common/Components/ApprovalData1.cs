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
/// Data pertaining to the approval of the transaction.
/// </summary>
[IsoId("_7fkbkEVSEeea-M6VZkEPUw")]
[DisplayName("Approval Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ApprovalData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Entity that has delivered or declined the card payment authorisation (the party may be unidentified).
    /// </summary>
    [IsoId("_QLClEEVTEeea-M6VZkEPUw")]
    [DisplayName("Approval Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApprvlNtty")]
    #endif
    [IsoXmlTag("ApprvlNtty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ApprovalEntity1? ApprovalEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ApprovalEntity1? ApprovalEntity { get; init; } 
    #else
    public ApprovalEntity1? ApprovalEntity { get; set; } 
    #endif
    
    /// <summary>
    /// Value assigned by the approval entity indicating approval.
    /// ISO 8583:93/2003 bit 38
    /// </summary>
    [IsoId("_cvMpMEVTEeea-M6VZkEPUw")]
    [DisplayName("Approval Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApprvlCd")]
    #endif
    [IsoXmlTag("ApprvlCd")]
    [IsoSimpleType(IsoSimpleType.Exact6AlphaNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact6AlphaNumericText? ApprovalCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ApprovalCode { get; init; } 
    #else
    public System.String? ApprovalCode { get; set; } 
    #endif
    
    
    #nullable disable
    
}
