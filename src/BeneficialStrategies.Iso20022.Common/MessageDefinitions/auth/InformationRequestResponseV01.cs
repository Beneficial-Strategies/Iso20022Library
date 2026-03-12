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
/// This record is an implementation of the auth.002.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// This message is sent by the financial institution to the authorities (police, customs, tax authorities, enforcement authorities) to provide a part or all of the requested information.
/// The financial institution previously received a request for financial information in the scope of a financial investigation.
/// 
/// Depending on whether the response can be provided STP within the authorities financial investigations messages, the requested information may be 
/// •	provided in part or in full within the response message itself, or 
/// •	only referred to in the response message.
/// </summary>
[Description(@"This message is sent by the financial institution to the authorities (police, customs, tax authorities, enforcement authorities) to provide a part or all of the requested information.|The financial institution previously received a request for financial information in the scope of a financial investigation.||Depending on whether the response can be provided STP within the authorities financial investigations messages, the requested information may be |•	provided in part or in full within the response message itself, or |•	only referred to in the response message.")]
[IsoId("_6iqtkDzdEeGl7N0Cd54dlw")]
[DisplayName("Information Request Response V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InformationRequestResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.002.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InfReqRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.002.001.01";
    
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
    /// Constructs a InformationRequestResponseV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InformationRequestResponseV01( System.String reqResponseIdentification,System.String reqInvestigationIdentification,StatusResponse1Code reqResponseStatus,SearchCriteria1Choice_ reqSearchCriteria,ReturnIndicator1 reqReturnIndicator )
    {
        ResponseIdentification = reqResponseIdentification;
        InvestigationIdentification = reqInvestigationIdentification;
        ResponseStatus = reqResponseStatus;
        SearchCriteria = reqSearchCriteria;
        ReturnIndicator = reqReturnIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification for the specific investigation as know by the responding party.
    /// </summary>
    [IsoId("_DSEUezzjEeGl7N0Cd54dlw")]
    [DisplayName("Response Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnId")]
    #endif
    [IsoXmlTag("RspnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ResponseIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ResponseIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ResponseIdentification { get; init; } 
    #else
    public System.String ResponseIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification for the specific investigation as known by the requesting party.
    /// </summary>
    [IsoId("_gF8WOzzoEeGl7N0Cd54dlw")]
    [DisplayName("Investigation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstgtnId")]
    #endif
    [IsoXmlTag("InvstgtnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text InvestigationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String InvestigationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InvestigationIdentification { get; init; } 
    #else
    public System.String InvestigationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status of the response.
    /// </summary>
    [IsoId("_t0ETGzzoEeGl7N0Cd54dlw")]
    [DisplayName("Response Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnSts")]
    #endif
    [IsoXmlTag("RspnSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatusResponse1Code ResponseStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatusResponse1Code ResponseStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusResponse1Code ResponseStatus { get; init; } 
    #else
    public StatusResponse1Code ResponseStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the the search criteria for the financial institution to perform the search on. The search criteria can be an account, a customer identification or a payment instrument type.
    /// </summary>
    [IsoId("_U4B7wV0zEeGwFY7pvwHH-g")]
    [DisplayName("Search Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SchCrit")]
    #endif
    [IsoXmlTag("SchCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SearchCriteria1Choice_ SearchCriteria { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SearchCriteria1Choice_ SearchCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SearchCriteria1Choice_ SearchCriteria { get; init; } 
    #else
    public SearchCriteria1Choice_ SearchCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the return indicators and the investigation result.
    /// </summary>
    [IsoId("_UbboITzuEeGl7N0Cd54dlw")]
    [DisplayName("Return Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrInd")]
    #endif
    [IsoXmlTag("RtrInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReturnIndicator1 ReturnIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReturnIndicator1 ReturnIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReturnIndicator1 ReturnIndicator { get; init; } 
    #else
    public ReturnIndicator1 ReturnIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_ICHsnzzvEeGl7N0Cd54dlw")]
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


// Since InformationRequestResponseV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InformationRequestResponseV01.

