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
/// Non-extension information.
/// </summary>
[IsoId("_95ylZXltEeG7BsjMvd1mEw_856781964")]
[DisplayName("Non Extension")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NonExtension1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Minimum number of days prior to the then current expiry date by which notice of non-extension must be sent.
    /// </summary>
    [IsoId("_95ylZnltEeG7BsjMvd1mEw_1991021937")]
    [DisplayName("Notification Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnPrd")]
    #endif
    [IsoXmlTag("NtfctnPrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NotificationPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NotificationPeriod { get; init; } 
    #else
    public System.UInt64? NotificationPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Method by which the notice of non-extension is intended to be delivered.
    /// </summary>
    [IsoId("_958WYHltEeG7BsjMvd1mEw_3398820")]
    [DisplayName("Notification Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnMtd")]
    #endif
    [IsoXmlTag("NtfctnMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationMethod1Choice_? NotificationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationMethod1Choice_? NotificationMethod { get; init; } 
    #else
    public CommunicationMethod1Choice_? NotificationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Type of party to whom the notice of non-extension is intended to be delivered.
    /// </summary>
    [IsoId("_958WYXltEeG7BsjMvd1mEw_-431096325")]
    [DisplayName("Notification Recipient Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnRcptTp")]
    #endif
    [IsoXmlTag("NtfctnRcptTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyType1Choice_? NotificationRecipientType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyType1Choice_? NotificationRecipientType { get; init; } 
    #else
    public PartyType1Choice_? NotificationRecipientType { get; set; } 
    #endif
    
    /// <summary>
    /// Name of party to whom the notice of non-extension is intended to be delivered.
    /// </summary>
    [IsoId("_958WYnltEeG7BsjMvd1mEw_829191387")]
    [DisplayName("Notification Recipient Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnRcptNm")]
    #endif
    [IsoXmlTag("NtfctnRcptNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? NotificationRecipientName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NotificationRecipientName { get; init; } 
    #else
    public System.String? NotificationRecipientName { get; set; } 
    #endif
    
    /// <summary>
    /// Address of party to whom the notice of non-extension is intended to be delivered.
    /// </summary>
    [IsoId("_958WY3ltEeG7BsjMvd1mEw_-1651018057")]
    [DisplayName("Notification Recipient Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnRcptAdr")]
    #endif
    [IsoXmlTag("NtfctnRcptAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress6? NotificationRecipientAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress6? NotificationRecipientAddress { get; init; } 
    #else
    public PostalAddress6? NotificationRecipientAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
