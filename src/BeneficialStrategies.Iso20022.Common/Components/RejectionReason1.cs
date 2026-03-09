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
/// Reason to reject the message.
/// </summary>
[IsoId("_U3LIX9p-Ed-ak6NoX_4Aeg_-2025393824")]
[DisplayName("Rejection Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RejectionReason1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RejectionReason1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RejectionReason1( MessageRejectedReason1Code reqReason )
    {
        Reason = reqReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason to reject the message.
    /// </summary>
    [IsoId("_U3USQNp-Ed-ak6NoX_4Aeg_-282709820")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageRejectedReason1Code Reason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageRejectedReason1Code Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageRejectedReason1Code Reason { get; init; } 
    #else
    public MessageRejectedReason1Code Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the rejection reason.
    /// </summary>
    [IsoId("_U3USQdp-Ed-ak6NoX_4Aeg_-282709803")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Linked previous reference that is invalid or unrecognised, of the message being rejected.
    /// </summary>
    [IsoId("_U3USQtp-Ed-ak6NoX_4Aeg_-425856419")]
    [DisplayName("Linked Message Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkdMsgPrvsRef")]
    #endif
    [IsoXmlTag("LkdMsgPrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference2? LinkedMessagePreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference2? LinkedMessagePreviousReference { get; init; } 
    #else
    public AdditionalReference2? LinkedMessagePreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Linked other reference that is invalid or unrecognised, of the message being rejected.
    /// </summary>
    [IsoId("_U3USQ9p-Ed-ak6NoX_4Aeg_-71222051")]
    [DisplayName("Linked Message Other Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkdMsgOthrRef")]
    #endif
    [IsoXmlTag("LkdMsgOthrRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference2? LinkedMessageOtherReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference2? LinkedMessageOtherReference { get; init; } 
    #else
    public AdditionalReference2? LinkedMessageOtherReference { get; set; } 
    #endif
    
    /// <summary>
    /// Linked related reference that is invalid or unrecognised, of the message being rejected.
    /// </summary>
    [IsoId("_U3USRNp-Ed-ak6NoX_4Aeg_1139278303")]
    [DisplayName("Linked Message Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkdMsgRltdRef")]
    #endif
    [IsoXmlTag("LkdMsgRltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference2? LinkedMessageRelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference2? LinkedMessageRelatedReference { get; init; } 
    #else
    public AdditionalReference2? LinkedMessageRelatedReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
