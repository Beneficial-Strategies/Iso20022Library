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


namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// This record is an implementation of the cain.009.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The NetworkManagementInitiation message covers the range of activities to control the operating condition of the network and may be initiated by any party to an acquirer, an issuer or an agent.
/// </summary>
[Description(@"The NetworkManagementInitiation message covers the range of activities to control the operating condition of the network and may be initiated by any party to an acquirer, an issuer or an agent.")]
[IsoId("_C8o9QHvDEeSKFIcWw3l4Yw")]
[DisplayName("Network Management Initiation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NetworkManagementInitiation : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.009.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NtwkMgmtInitn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.009.001.01";
    
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
    /// Constructs a NetworkManagementInitiation instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NetworkManagementInitiation( Header17 reqHeader,AcquirerNetworkManagementInitiation1 reqNetworkManagementInitiationValue )
    {
        Header = reqHeader;
        NetworkManagementInitiationValue = reqNetworkManagementInitiationValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the protocol management.
    /// </summary>
    [IsoId("_OAJuAHvDEeSKFIcWw3l4Yw")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header17 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header17 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header17 Header { get; init; } 
    #else
    public Header17 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the network management.
    /// </summary>
    [IsoId("_WcxVAHvDEeSKFIcWw3l4Yw")]
    [DisplayName("Network Management Initiation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtwkMgmtInitn")]
    #endif
    [IsoXmlTag("NtwkMgmtInitn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcquirerNetworkManagementInitiation1 NetworkManagementInitiationValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AcquirerNetworkManagementInitiation1 NetworkManagementInitiationValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcquirerNetworkManagementInitiation1 NetworkManagementInitiationValue { get; init; } 
    #else
    public AcquirerNetworkManagementInitiation1 NetworkManagementInitiationValue { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_46J5wHvEEeSKFIcWw3l4Yw")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType15? SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType15? SecurityTrailer { get; init; } 
    #else
    public ContentInformationType15? SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since NetworkManagementInitiationDocument is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to NetworkManagementInitiation.

