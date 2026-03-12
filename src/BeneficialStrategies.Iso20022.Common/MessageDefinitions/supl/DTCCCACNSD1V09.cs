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
/// This record is an implementation of the supl.006.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCACNSD1 message extends ISO corporate action cancellation advise (CACN) message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Description(@"The DTCCCACNSD1 message extends ISO corporate action cancellation advise (CACN) message with DTCC corporate action elements not covered in the standard message.")]
[IsoId("_x6QR-QB6EeqouY-yI_q3qQ")]
[DisplayName("DTCCCACNSD 1 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DTCCCACNSD1V09 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.006.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCACNSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.006.001.09";
    
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
    /// Page number of the message and continuation indicator to indicate that the multi-parts confirmation is to continue or that the message is the last page of the multi-parts confirmation.
    /// </summary>
    [IsoId("_x6QR-wB6EeqouY-yI_q3qQ")]
    [DisplayName("Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pgntn")]
    #endif
    [IsoXmlTag("Pgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Pagination1? Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination1? Pagination { get; init; } 
    #else
    public Pagination1? Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to cancellation advice.
    /// </summary>
    [IsoId("_x6QR_QB6EeqouY-yI_q3qQ")]
    [DisplayName("Notification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ntfctn")]
    #endif
    [IsoXmlTag("Ntfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionNotificationSD10? Notification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNotificationSD10? Notification { get; init; } 
    #else
    public CorporateActionNotificationSD10? Notification { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as supplementary data to cancellation advice general information.
    /// </summary>
    [IsoId("_x6QR_wB6EeqouY-yI_q3qQ")]
    [DisplayName("General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GnlInf")]
    #endif
    [IsoXmlTag("GnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionGeneralInformationSD40? GeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformationSD40? GeneralInformation { get; init; } 
    #else
    public CorporateActionGeneralInformationSD40? GeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as events linkage supplementary data to events to cancellation advice.
    /// </summary>
    [IsoId("_x6QSAQB6EeqouY-yI_q3qQ")]
    [DisplayName("Events Linkage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtsLkg")]
    #endif
    [IsoXmlTag("EvtsLkg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionCancellationSD3? EventsLinkage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionCancellationSD3? EventsLinkage { get; init; } 
    #else
    public CorporateActionCancellationSD3? EventsLinkage { get; set; } 
    #endif
    
    /// <summary>
    /// Information to be extended as external comments to cancellation advice.
    /// </summary>
    [IsoId("_x6QSAwB6EeqouY-yI_q3qQ")]
    [DisplayName("External Comments")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlCmnts")]
    #endif
    [IsoXmlTag("XtrnlCmnts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionCancellationSD4? ExternalComments { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionCancellationSD4? ExternalComments { get; init; } 
    #else
    public CorporateActionCancellationSD4? ExternalComments { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since DTCCCACNSD1V09Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCACNSD1V09.

