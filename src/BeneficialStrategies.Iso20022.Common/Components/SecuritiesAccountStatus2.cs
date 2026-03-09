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
/// Status of the securities account processed in the system.
/// </summary>
[IsoId("_102h8eGEEeWCAvUNsZ5u6g")]
[DisplayName("Securities Account Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesAccountStatus2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesAccountStatus2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesAccountStatus2( Status6Code reqStatus )
    {
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the securities account referenced by a request.
    /// </summary>
    [IsoId("_2DI1leGEEeWCAvUNsZ5u6g")]
    [DisplayName("Related Securities Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdSctiesAcct")]
    #endif
    [IsoXmlTag("RltdSctiesAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount19? RelatedSecuritiesAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19? RelatedSecuritiesAccount { get; init; } 
    #else
    public SecuritiesAccount19? RelatedSecuritiesAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the securities account maintenance instruction.
    /// </summary>
    [IsoId("_2DI1l-GEEeWCAvUNsZ5u6g")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Status6Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Status6Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Status6Code Status { get; init; } 
    #else
    public Status6Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for the status of a securities account maintenance instruction.
    /// </summary>
    [IsoId("_2DI1meGEEeWCAvUNsZ5u6g")]
    [DisplayName("Status Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRsn")]
    #endif
    [IsoXmlTag("StsRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatusReasonInformation10? StatusReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusReasonInformation10? StatusReason { get; init; } 
    #else
    public StatusReasonInformation10? StatusReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
