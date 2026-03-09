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
/// Specifies the reason for cancelling a meeting.
/// </summary>
[IsoId("_RCMa19p-Ed-ak6NoX_4Aeg_1000768570")]
[DisplayName("Meeting Cancellation Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingCancellationReason2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason for cancelling a meeting.
    /// </summary>
    [IsoId("_RCMa2Np-Ed-ak6NoX_4Aeg_1092600790")]
    [DisplayName("Cancellation Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRsnCd")]
    #endif
    [IsoXmlTag("CxlRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MeetingCancellationReason1Choice_? CancellationReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingCancellationReason1Choice_? CancellationReasonCode { get; init; } 
    #else
    public MeetingCancellationReason1Choice_? CancellationReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Provides more information on the reason for cancelling a meeting in free format form.
    /// </summary>
    [IsoId("_RCWL0Np-Ed-ak6NoX_4Aeg_1000768631")]
    [DisplayName("Cancellation Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRsn")]
    #endif
    [IsoXmlTag("CxlRsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? CancellationReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CancellationReason { get; init; } 
    #else
    public System.String? CancellationReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
