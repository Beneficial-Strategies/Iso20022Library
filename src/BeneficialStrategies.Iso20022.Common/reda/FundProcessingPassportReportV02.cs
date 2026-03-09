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
/// This record is an implementation of the reda.004.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A report provider, for example, a fund promoter, fund management company, transfer agent, or market data provider, sends the FundProcessingPassportReport message to the report recipient, for, a professional investor, investment fund distributor, market data provider, regulator or other interested party to provide the key reference data for financial instruments to facilitate trading.
/// Usage
/// A unique FundProcessingPassportReport should be prepared for each class of unit/share (for which an individual ISIN should have been allocated), in respect of its &quot;home&quot; market.
/// The FundProcessingPassportReport may be used in various models or environments:
/// - stand alone environment, for example, initiated by the Report Provider (fund promoter, fund manager and / or reference data vendors) sent on a regular frequency, or when changes are needed.
/// - in a request / response environment, with the InvestmentFundReportRequest, for example, initiated by report users (data vendors, professional investors, regulators or investment fund distributors) in enabling the user to control the flow and updates of information.
/// - in a reference data vendor environment, for example, market infrastructure and reference data providers may collate and store all fund processing passport information centrally for access via database or regular distribution information. A reference data vendor may assume the role of both report provider and report user.
/// </summary>
[Description(@"Scope|A report provider, for example, a fund promoter, fund management company, transfer agent, or market data provider, sends the FundProcessingPassportReport message to the report recipient, for, a professional investor, investment fund distributor, market data provider, regulator or other interested party to provide the key reference data for financial instruments to facilitate trading.|Usage|A unique FundProcessingPassportReport should be prepared for each class of unit/share (for which an individual ISIN should have been allocated), in respect of its ""home"" market.|The FundProcessingPassportReport may be used in various models or environments:|- stand alone environment, for example, initiated by the Report Provider (fund promoter, fund manager and / or reference data vendors) sent on a regular frequency, or when changes are needed.|- in a request / response environment, with the InvestmentFundReportRequest, for example, initiated by report users (data vendors, professional investors, regulators or investment fund distributors) in enabling the user to control the flow and updates of information.|- in a reference data vendor environment, for example, market infrastructure and reference data providers may collate and store all fund processing passport information centrally for access via database or regular distribution information. A reference data vendor may assume the role of both report provider and report user.")]
[IsoId("_ZsRA2NEvEd-BzquC8wXy7w_2012426718")]
[DisplayName("Fund Processing Passport Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundProcessingPassportReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.004.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FndPrcgPsptRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.004.001.02";
    
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
    /// Constructs a FundProcessingPassportReportV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FundProcessingPassportReportV02( MessageIdentification1 reqMessageIdentification,FundProcessingPassport1 reqFundProcessingPassport )
    {
        MessageIdentification = reqMessageIdentification;
        FundProcessingPassport = reqFundProcessingPassport;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_ZsRA2dEvEd-BzquC8wXy7w_1111943337")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageIdentification { get; init; } 
    #else
    public MessageIdentification1 MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    ///  Fund Processing Passsport (FPP) is a fully harmonised document with all key operational information that fund promoters
    ///  should provide on their investment funds in order to facilitate their trading.
    /// </summary>
    [IsoId("_ZsRA2tEvEd-BzquC8wXy7w_-23910655")]
    [DisplayName("Fund Processing Passport")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FPP")]
    #endif
    [IsoXmlTag("FPP")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FundProcessingPassport1 FundProcessingPassport { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FundProcessingPassport1 FundProcessingPassport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundProcessingPassport1 FundProcessingPassport { get; init; } 
    #else
    public FundProcessingPassport1 FundProcessingPassport { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since FundProcessingPassportReportV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FundProcessingPassportReportV02.

