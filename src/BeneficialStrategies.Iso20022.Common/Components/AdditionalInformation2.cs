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
/// Additional information about a request (e.g. financing request).
/// </summary>
[IsoId("_Rhyg6Np-Ed-ak6NoX_4Aeg_1542618603")]
[DisplayName("Additional Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalInformation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason for the waiver.
    /// </summary>
    [IsoId("_Rhyg6dp-Ed-ak6NoX_4Aeg_828459095")]
    [DisplayName("Order Waiver Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrWvrRsn")]
    #endif
    [IsoXmlTag("OrdrWvrRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrderWaiverReason1Choice_? OrderWaiverReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrderWaiverReason1Choice_? OrderWaiverReason { get; init; } 
    #else
    public OrderWaiverReason1Choice_? OrderWaiverReason { get; set; } 
    #endif
    
    /// <summary>
    /// Contents of the additional information.
    /// </summary>
    [IsoId("_Rh7q0Np-Ed-ak6NoX_4Aeg_1542618912")]
    [DisplayName("Information Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InfVal")]
    #endif
    [IsoXmlTag("InfVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? InformationValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InformationValue { get; init; } 
    #else
    public System.String? InformationValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
