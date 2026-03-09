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
/// Status is suspended.
/// </summary>
[IsoId("_RGqrINp-Ed-ak6NoX_4Aeg_1793071793")]
[DisplayName("Suspended Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SuspendedStatus2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SuspendedStatus2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SuspendedStatus2( NoReasonCode reqNoSpecifiedReason )
    {
        NoSpecifiedReason = reqNoSpecifiedReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_RGqrIdp-Ed-ak6NoX_4Aeg_1793071810")]
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
    
    /// <summary>
    /// Reason for the suspended status.
    /// </summary>
    [IsoId("_RGqrItp-Ed-ak6NoX_4Aeg_-550374008")]
    [DisplayName("Reason Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsnDtls")]
    #endif
    [IsoXmlTag("RsnDtls")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<SuspendedStatusReason2> ReasonDetails { get; init; } = new ValueList<SuspendedStatusReason2>(){};
    
    
    #nullable disable
    
}
