// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Non-extension information.
/// </summary>
[IsoId("_95ylZXltEeG7BsjMvd1mEw_856781964")]
[DisplayName("Non Extension")]
public partial record NonExtension1
{
    #nullable enable
    
    /// <summary>
    /// Minimum number of days prior to the then current expiry date by which notice of non-extension must be sent.
    /// </summary>
    [IsoId("_95ylZnltEeG7BsjMvd1mEw_1991021937")]
    [DisplayName("Notification Period")]
    [IsoXmlTag("NtfctnPrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NotificationPeriod { get; init; } 
    
    /// <summary>
    /// Method by which the notice of non-extension is intended to be delivered.
    /// </summary>
    [IsoId("_958WYHltEeG7BsjMvd1mEw_3398820")]
    [DisplayName("Notification Method")]
    [IsoXmlTag("NtfctnMtd")]
    public CommunicationMethod1Choice_? NotificationMethod { get; init; } 
    
    /// <summary>
    /// Type of party to whom the notice of non-extension is intended to be delivered.
    /// </summary>
    [IsoId("_958WYXltEeG7BsjMvd1mEw_-431096325")]
    [DisplayName("Notification Recipient Type")]
    [IsoXmlTag("NtfctnRcptTp")]
    public PartyType1Choice_? NotificationRecipientType { get; init; } 
    
    /// <summary>
    /// Name of party to whom the notice of non-extension is intended to be delivered.
    /// </summary>
    [IsoId("_958WYnltEeG7BsjMvd1mEw_829191387")]
    [DisplayName("Notification Recipient Name")]
    [IsoXmlTag("NtfctnRcptNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? NotificationRecipientName { get; init; } 
    
    /// <summary>
    /// Address of party to whom the notice of non-extension is intended to be delivered.
    /// </summary>
    [IsoId("_958WY3ltEeG7BsjMvd1mEw_-1651018057")]
    [DisplayName("Notification Recipient Address")]
    [IsoXmlTag("NtfctnRcptAdr")]
    public PostalAddress6? NotificationRecipientAddress { get; init; } 
    
    
    #nullable disable
    
}
