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


namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.019.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SecuritiesAccountQuery message sent by an instructing party to the executing party to request the details related to the securities account.
/// </summary>
[Description(@"The SecuritiesAccountQuery message sent by an instructing party to the executing party to request the details related to the securities account.")]
[IsoId("_KAu-wZ2fEem_Be8NuxvF7Q")]
[DisplayName("Securities Account Query V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesAccountQueryV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.019.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesAcctQry";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.019.001.01";
    
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
    /// Constructs a SecuritiesAccountQueryV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesAccountQueryV01( SecuritiesAccountSearchCriteria2 reqSearchCriteria )
    {
        SearchCriteria = reqSearchCriteria;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Point to point reference elements, as assigned by the instructing party, to unambiguously identify the query message.
    /// </summary>
    [IsoId("_KAu-yZ2fEem_Be8NuxvF7Q")]
    [DisplayName("Message Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgHdr")]
    #endif
    [IsoXmlTag("MsgHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageHeader2? MessageHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageHeader2? MessageHeader { get; init; } 
    #else
    public MessageHeader2? MessageHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the criteria to be used to query the securities account reference data by the executing system.
    /// </summary>
    [IsoId("_KAu-z52fEem_Be8NuxvF7Q")]
    [DisplayName("Search Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SchCrit")]
    #endif
    [IsoXmlTag("SchCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccountSearchCriteria2 SearchCriteria { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccountSearchCriteria2 SearchCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccountSearchCriteria2 SearchCriteria { get; init; } 
    #else
    public SecuritiesAccountSearchCriteria2 SearchCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the expected securities account reference data to be returned.
    /// </summary>
    [IsoId("_KAu-0Z2fEem_Be8NuxvF7Q")]
    [DisplayName("Return Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrCrit")]
    #endif
    [IsoXmlTag("RtrCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccountReturnCriteria1? ReturnCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccountReturnCriteria1? ReturnCriteria { get; init; } 
    #else
    public SecuritiesAccountReturnCriteria1? ReturnCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_KAu-052fEem_Be8NuxvF7Q")]
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


// Since SecuritiesAccountQueryV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesAccountQueryV01.

