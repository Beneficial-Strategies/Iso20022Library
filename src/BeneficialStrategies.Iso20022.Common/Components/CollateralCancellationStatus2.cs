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
/// Provides details on the status (that is accept or reject) of the CollateralManagementCancellationRequest message.
/// </summary>
[IsoId("_mgp44StIEeyOa655cLd-DQ")]
[DisplayName("Collateral Cancellation Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralCancellationStatus2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralCancellationStatus2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralCancellationStatus2( Status4Code reqCollateralStatusCode )
    {
        CollateralStatusCode = reqCollateralStatusCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Allows to provide a cancellation status using a code or a proprietary status.
    /// </summary>
    [IsoId("_m7VCsytIEeyOa655cLd-DQ")]
    [DisplayName("Collateral Status Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollStsCd")]
    #endif
    [IsoXmlTag("CollStsCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Status4Code CollateralStatusCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Status4Code CollateralStatusCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Status4Code CollateralStatusCode { get; init; } 
    #else
    public Status4Code CollateralStatusCode { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information on the status of the CollateralManagementCancellationRequest message.
    /// </summary>
    [IsoId("_m7VCtStIEeyOa655cLd-DQ")]
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
    
    /// <summary>
    /// Provides rejection reason and optionaly additional information.
    /// </summary>
    [IsoId("_m7VCtytIEeyOa655cLd-DQ")]
    [DisplayName("Rejection Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctnDtls")]
    #endif
    [IsoXmlTag("RjctnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RejectionStatus3? RejectionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectionStatus3? RejectionDetails { get; init; } 
    #else
    public RejectionStatus3? RejectionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
