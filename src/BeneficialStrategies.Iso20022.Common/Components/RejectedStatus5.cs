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
/// Status is rejected.
/// </summary>
[IsoId("_REuxdtp-Ed-ak6NoX_4Aeg_1075057449")]
[DisplayName("Rejected Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RejectedStatus5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RejectedStatus5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RejectedStatus5( RejectedStatusReason6Code reqReason,System.String reqExtendedReason )
    {
        Reason = reqReason;
        ExtendedReason = reqExtendedReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason for a rejected status.
    /// </summary>
    [IsoId("_REuxd9p-Ed-ak6NoX_4Aeg_1865326664")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RejectedStatusReason6Code Reason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RejectedStatusReason6Code Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectedStatusReason6Code Reason { get; init; } 
    #else
    public RejectedStatusReason6Code Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for a rejected status.
    /// </summary>
    [IsoId("_REuxeNp-Ed-ak6NoX_4Aeg_1878257837")]
    [DisplayName("Extended Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedRsn")]
    #endif
    [IsoXmlTag("XtndedRsn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExtendedReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedReason { get; init; } 
    #else
    public System.String ExtendedReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
