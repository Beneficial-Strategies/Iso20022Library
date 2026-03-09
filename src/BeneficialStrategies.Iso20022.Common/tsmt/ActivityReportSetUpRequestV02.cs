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


namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// This record is an implementation of the tsmt.004.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ActivityReportSetUpRequest message is sent by any party involved in a transaction to the matching application.
/// The ActivityReportSetUpRequest message can be sent to request the reset of the pre-determined time at which the daily production of the activity report should take place.
/// Usage
/// This message is sent to the matching application by a bank, in order to set the UTC offset specifying the hour when the matching application will generate every day an activity report covering the last 24 hours and send it. By default, this offset is equal to 0.
/// </summary>
[Description(@"Scope|The ActivityReportSetUpRequest message is sent by any party involved in a transaction to the matching application.|The ActivityReportSetUpRequest message can be sent to request the reset of the pre-determined time at which the daily production of the activity report should take place.|Usage|This message is sent to the matching application by a bank, in order to set the UTC offset specifying the hour when the matching application will generate every day an activity report covering the last 24 hours and send it. By default, this offset is equal to 0.")]
[IsoId("_ihSN2NE8Ed-BzquC8wXy7w_-1378853261")]
[DisplayName("Activity Report Set Up Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ActivityReportSetUpRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.004.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ActvtyRptSetUpReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.004.001.02";
    
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
    /// Constructs a ActivityReportSetUpRequestV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ActivityReportSetUpRequestV02( MessageIdentification1 reqRequestIdentification,UTCOffset1 reqUTCOffset )
    {
        RequestIdentification = reqRequestIdentification;
        UTCOffset = reqUTCOffset;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the request message.
    /// </summary>
    [IsoId("_ihSN2dE8Ed-BzquC8wXy7w_-1378853229")]
    [DisplayName("Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqId")]
    #endif
    [IsoXmlTag("ReqId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 RequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 RequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 RequestIdentification { get; init; } 
    #else
    public MessageIdentification1 RequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the parameters to calculate the local reporting time.
    /// </summary>
    [IsoId("_ihSN2tE8Ed-BzquC8wXy7w_-1378852898")]
    [DisplayName("UTC Offset")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UTCOffset")]
    #endif
    [IsoXmlTag("UTCOffset")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UTCOffset1 UTCOffset { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UTCOffset1 UTCOffset { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UTCOffset1 UTCOffset { get; init; } 
    #else
    public UTCOffset1 UTCOffset { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ActivityReportSetUpRequestV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ActivityReportSetUpRequestV02.

