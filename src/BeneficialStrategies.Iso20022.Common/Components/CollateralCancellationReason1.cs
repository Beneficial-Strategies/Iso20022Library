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
/// Reason for which the collateral message has been cancelled.
/// </summary>
[IsoId("_UnhiwNp-Ed-ak6NoX_4Aeg_-540863751")]
[DisplayName("Collateral Cancellation Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralCancellationReason1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralCancellationReason1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralCancellationReason1( CollateralCancellationType1Choice_ reqCancellationReasonCode )
    {
        CancellationReasonCode = reqCancellationReasonCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Allows to provides additional information on the cancellation reason.
    /// </summary>
    [IsoId("_Unhiwdp-Ed-ak6NoX_4Aeg_-1001218572")]
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
    /// Allows to provide a cancellation reason using a code or proprietary reason.
    /// </summary>
    [IsoId("_Unhiwtp-Ed-ak6NoX_4Aeg_1328732613")]
    [DisplayName("Cancellation Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRsnCd")]
    #endif
    [IsoXmlTag("CxlRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralCancellationType1Choice_ CancellationReasonCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralCancellationType1Choice_ CancellationReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralCancellationType1Choice_ CancellationReasonCode { get; init; } 
    #else
    public CollateralCancellationType1Choice_ CancellationReasonCode { get; set; } 
    #endif
    
    
    #nullable disable
    
}
