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
/// This record is an implementation of the auth.029.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DerivativesTradeReportQuery message is sent by the supervisory authority system to the trade repositories, to query data based on the search criteria for the trade transaction as defined by the system user.
/// </summary>
[Description(@"The DerivativesTradeReportQuery message is sent by the supervisory authority system to the trade repositories, to query data based on the search criteria for the trade transaction as defined by the system user.")]
[IsoId("_pVWWkWmFEe2DRvVJM2Qy-g")]
[DisplayName("Derivatives Trade Report Query V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DerivativesTradeReportQueryV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.029.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DerivsTradRptQry";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.029.001.03";
    
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
    /// Constructs a DerivativesTradeReportQueryV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DerivativesTradeReportQueryV03( PartyIdentification121Choice_ reqRequestingAuthority,TradeReportQuery16Choice_ reqTradeQueryData )
    {
        RequestingAuthority = reqRequestingAuthority;
        TradeQueryData = reqTradeQueryData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the authority that requests the query report.
    /// </summary>
    [IsoId("_pVWWk2mFEe2DRvVJM2Qy-g")]
    [DisplayName("Requesting Authority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RqstngAuthrty")]
    #endif
    [IsoXmlTag("RqstngAuthrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification121Choice_ RequestingAuthority { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification121Choice_ RequestingAuthority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification121Choice_ RequestingAuthority { get; init; } 
    #else
    public PartyIdentification121Choice_ RequestingAuthority { get; set; } 
    #endif
    
    /// <summary>
    /// Criteria for defining recurrent and ad-hoc queries.
    /// </summary>
    [IsoId("_pVWWlWmFEe2DRvVJM2Qy-g")]
    [DisplayName("Trade Query Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradQryData")]
    #endif
    [IsoXmlTag("TradQryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeReportQuery16Choice_ TradeQueryData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeReportQuery16Choice_ TradeQueryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeReportQuery16Choice_ TradeQueryData { get; init; } 
    #else
    public TradeReportQuery16Choice_ TradeQueryData { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_pVWWl2mFEe2DRvVJM2Qy-g")]
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


// Since DerivativesTradeReportQueryV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DerivativesTradeReportQueryV03.

