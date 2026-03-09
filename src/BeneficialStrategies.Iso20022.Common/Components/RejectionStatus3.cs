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
/// Provides a rejection reason and additional information.
/// </summary>
[IsoId("_m7VCuStIEeyOa655cLd-DQ")]
[DisplayName("Rejection Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RejectionStatus3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RejectionStatus3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RejectionStatus3( RejectionReason68Code reqRejectedReason )
    {
        RejectedReason = reqRejectedReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the rejection reason using a code.
    /// </summary>
    [IsoId("_nXDVYStIEeyOa655cLd-DQ")]
    [DisplayName("Rejected Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctdRsn")]
    #endif
    [IsoXmlTag("RjctdRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RejectionReason68Code RejectedReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RejectionReason68Code RejectedReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectionReason68Code RejectedReason { get; init; } 
    #else
    public RejectionReason68Code RejectedReason { get; set; } 
    #endif
    
    /// <summary>
    /// Allows to provides additional information to the rejection reason code.
    /// </summary>
    [IsoId("_nXDVYytIEeyOa655cLd-DQ")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
