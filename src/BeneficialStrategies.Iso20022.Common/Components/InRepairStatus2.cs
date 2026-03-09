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
/// Status is in repair.
/// </summary>
[IsoId("_RMeYNtp-Ed-ak6NoX_4Aeg_-329740653")]
[DisplayName("In Repair Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InRepairStatus2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InRepairStatus2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InRepairStatus2( InRepairStatusReason3 reqReasonDetails,NoReasonCode reqNoSpecifiedReason )
    {
        ReasonDetails = reqReasonDetails;
        NoSpecifiedReason = reqNoSpecifiedReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason for the in-repair status.
    /// </summary>
    [IsoId("_RMeYN9p-Ed-ak6NoX_4Aeg_-2034253428")]
    [DisplayName("Reason Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsnDtls")]
    #endif
    [IsoXmlTag("RsnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InRepairStatusReason3 ReasonDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InRepairStatusReason3 ReasonDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InRepairStatusReason3 ReasonDetails { get; init; } 
    #else
    public InRepairStatusReason3 ReasonDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_RMeYONp-Ed-ak6NoX_4Aeg_-329740627")]
    [DisplayName("No Specified Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NoSpcfdRsn")]
    #endif
    [IsoXmlTag("NoSpcfdRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NoReasonCode NoSpecifiedReason { get; init; } 
    #else
    public NoReasonCode NoSpecifiedReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
