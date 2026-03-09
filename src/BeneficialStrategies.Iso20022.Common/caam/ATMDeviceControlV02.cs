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


namespace BeneficialStrategies.Iso20022.caam;

/// <summary>
/// This record is an implementation of the caam.002.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMDeviceControl message is sent by a maintenance host to an ATM in response to an ATMDeviceReport message. The message contains a sequence of maintenance commands the ATM must perform.
/// </summary>
[Description(@"The ATMDeviceControl message is sent by a maintenance host to an ATM in response to an ATMDeviceReport message. The message contains a sequence of maintenance commands the ATM must perform.")]
[IsoId("_caM7Qa45EeWRfYPBaeOY8w")]
[DisplayName("ATM Device Control V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMDeviceControlV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caam.002.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMDvcCtrl";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.002.001.02";
    
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
    /// Constructs a ATMDeviceControlV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMDeviceControlV02( Header31 reqHeader )
    {
        Header = reqHeader;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_caM7Q645EeWRfYPBaeOY8w")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header31 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header31 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header31 Header { get; init; } 
    #else
    public Header31 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_caM7Ra45EeWRfYPBaeOY8w")]
    [DisplayName("Protected ATM Device Control")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdATMDvcCtrl")]
    #endif
    [IsoXmlTag("PrtctdATMDvcCtrl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType10? ProtectedATMDeviceControl { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType10? ProtectedATMDeviceControl { get; init; } 
    #else
    public ContentInformationType10? ProtectedATMDeviceControl { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the control of an ATM device.
    /// </summary>
    [IsoId("_caM7R645EeWRfYPBaeOY8w")]
    [DisplayName("ATM Device Control")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMDvcCtrl")]
    #endif
    [IsoXmlTag("ATMDvcCtrl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMDeviceControl1? ATMDeviceControl { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMDeviceControl1? ATMDeviceControl { get; init; } 
    #else
    public ATMDeviceControl1? ATMDeviceControl { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_caM7Sa45EeWRfYPBaeOY8w")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType13? SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType13? SecurityTrailer { get; init; } 
    #else
    public ContentInformationType13? SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ATMDeviceControlV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMDeviceControlV02.

