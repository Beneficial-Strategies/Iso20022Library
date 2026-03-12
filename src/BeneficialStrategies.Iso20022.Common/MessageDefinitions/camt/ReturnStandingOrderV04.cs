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


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.070.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|The ReturnStandingOrder message is sent by a transaction administrator to a member.|It is used to provide information on the details of one or more standing orders, based on specific request and return criteria.|in response to a request a on information on standing and predefined orders.|Usage|The ReturnStandingOrder message lists the standing order based on the following possible return criteria: |- Generic standing order details,|- Details of a specific predefined or standing liquidity transfer orders,|- Details on the set to which the standing order belongs to,|- List of all predefined and standing liquidity transfer standing orders and/or per set,|- Total amount of predefined and standing liquidity transfer orders defined in the system.
/// </summary>
[Description(@"Scope|The ReturnStandingOrder message is sent by a transaction administrator to a member.|It is used to provide information on the details of one or more standing orders, based on specific request and return criteria.|in response to a request a on information on standing and predefined orders.|Usage|The ReturnStandingOrder message lists the standing order based on the following possible return criteria: |- Generic standing order details,|- Details of a specific predefined or standing liquidity transfer orders,|- Details on the set to which the standing order belongs to,|- List of all predefined and standing liquidity transfer standing orders and/or per set,|- Total amount of predefined and standing liquidity transfer orders defined in the system.")]
[IsoId("_jwlcMRbvEeiyVv5j1vf1VQ")]
[DisplayName("Return Standing Order V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReturnStandingOrderV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.070.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RtrStgOrdr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.070.001.04";
    
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
    /// Constructs a ReturnStandingOrderV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReturnStandingOrderV04( MessageHeader6 reqMessageHeader,StandingOrderOrError5Choice_ reqReportOrError )
    {
        MessageHeader = reqMessageHeader;
        ReportOrError = reqReportOrError;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlcMxbvEeiyVv5j1vf1VQ")]
    [DisplayName("Message Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgHdr")]
    #endif
    [IsoXmlTag("MsgHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageHeader6 MessageHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageHeader6 MessageHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageHeader6 MessageHeader { get; init; } 
    #else
    public MessageHeader6 MessageHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Reports on standing orders.
    /// </summary>
    [IsoId("_jwlcNRbvEeiyVv5j1vf1VQ")]
    [DisplayName("Report Or Error")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptOrErr")]
    #endif
    [IsoXmlTag("RptOrErr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StandingOrderOrError5Choice_ ReportOrError { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StandingOrderOrError5Choice_ ReportOrError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StandingOrderOrError5Choice_ ReportOrError { get; init; } 
    #else
    public StandingOrderOrError5Choice_ ReportOrError { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlcNxbvEeiyVv5j1vf1VQ")]
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


// Since ReturnStandingOrderV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ReturnStandingOrderV04.

