// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// This record is an implementation of the supl.006.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCACNSD1 message extends ISO corporate action cancellation advise (CACN) message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Description(@"The DTCCCACNSD1 message extends ISO corporate action cancellation advise (CACN) message with DTCC corporate action elements not covered in the standard message.")]
[IsoId("_1OTt4zL3EeKU9IrkkToqcw_-1610896925")]
[DisplayName("DTCCCACNSD 1 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DTCCCACNSD1V02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.006.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCACNSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.006.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Information to be extended as supplementary data to cancellation advice.
    /// </summary>
    [IsoId("_1OTt5DL3EeKU9IrkkToqcw_-1238632619")]
    [DisplayName("Notification Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnXtnsn")]
    #endif
    [IsoXmlTag("NtfctnXtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionNotificationSD1? NotificationExtension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNotificationSD1? NotificationExtension { get; init; } 
    #else
    public CorporateActionNotificationSD1? NotificationExtension { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to cancellation advice general information.
    /// </summary>
    [IsoId("_1OTt5TL3EeKU9IrkkToqcw_-2042507692")]
    [DisplayName("General Information Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GnlInfXtnsn")]
    #endif
    [IsoXmlTag("GnlInfXtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionGeneralInformationSD2? GeneralInformationExtension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformationSD2? GeneralInformationExtension { get; init; } 
    #else
    public CorporateActionGeneralInformationSD2? GeneralInformationExtension { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as events linkage supplementary data to events to cancellation advice.
    /// </summary>
    [IsoId("_1OTt5jL3EeKU9IrkkToqcw_-1867503343")]
    [DisplayName("Events Linkage Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtsLkgXtnsn")]
    #endif
    [IsoXmlTag("EvtsLkgXtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionCancellationSD1? EventsLinkageExtension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionCancellationSD1? EventsLinkageExtension { get; init; } 
    #else
    public CorporateActionCancellationSD1? EventsLinkageExtension { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as external comments to cancellation advice.
    /// </summary>
    [IsoId("_1OTt5zL3EeKU9IrkkToqcw_-551563388")]
    [DisplayName("External Comments Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCmntsXtnsn")]
    #endif
    [IsoXmlTag("XtrnlCmntsXtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionCancellationSD2? ExternalCommentsExtension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionCancellationSD2? ExternalCommentsExtension { get; init; } 
    #else
    public CorporateActionCancellationSD2? ExternalCommentsExtension { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since DTCCCACNSD1V02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCACNSD1V02.

