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


namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.003.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// This message is sent by the authorities (police, customs, tax authorities, enforcement authorities) to a financial institution to inform the financial institution that the confidentiality status of the investigation has changed.
/// </summary>
[Description(@"This message is sent by the authorities (police, customs, tax authorities, enforcement authorities) to a financial institution to inform the financial institution that the confidentiality status of the investigation has changed.")]
[IsoId("_fQEyMzz1EeGl7N0Cd54dlw")]
[DisplayName("Information Request Status Change Notification V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InformationRequestStatusChangeNotificationV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.003.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InfReqStsChngNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.003.001.01";
    
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
    /// <summary>
    /// Constructs a InformationRequestStatusChangeNotificationV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InformationRequestStatusChangeNotificationV01( System.String reqOriginalBusinessQuery,System.String reqConfidentialityStatus )
    {
        OriginalBusinessQuery = reqOriginalBusinessQuery;
        ConfidentialityStatus = reqConfidentialityStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference of the information request opening message that this message is an update of.
    /// </summary>
    [IsoId("_tqPSWz2QEeGG64_ngBNdUg")]
    [DisplayName("Original Business Query")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlBizQry")]
    #endif
    [IsoXmlTag("OrgnlBizQry")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OriginalBusinessQuery { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OriginalBusinessQuery { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginalBusinessQuery { get; init; } 
    #else
    public System.String OriginalBusinessQuery { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the confidentiality status of the investigation.
    /// </summary>
    [IsoId("_0ikcBT2QEeGG64_ngBNdUg")]
    [DisplayName("Confidentiality Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CnfdtltySts")]
    #endif
    [IsoXmlTag("CnfdtltySts")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ConfidentialityStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ConfidentialityStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ConfidentialityStatus { get; init; } 
    #else
    public System.String ConfidentialityStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_2tmJOz2QEeGG64_ngBNdUg")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since InformationRequestStatusChangeNotificationV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InformationRequestStatusChangeNotificationV01.

