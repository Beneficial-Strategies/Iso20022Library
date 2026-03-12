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
/// This record is an implementation of the auth.076.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// This FinancialSupervisedPartyIdentityReport message is sent by the competent institution to report parties used for the purpose of the local regulation.
/// 
/// </summary>
[Description(@"This FinancialSupervisedPartyIdentityReport message is sent by the competent institution to report parties used for the purpose of the local regulation.|")]
[IsoId("_EUnq8PH0Eeaz_YGUGLjP6A")]
[DisplayName("Financial Supervised Party Identity Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialSupervisedPartyIdentityReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.076.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinSprvsdPtyIdntyRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.076.001.01";
    
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
    /// Constructs a FinancialSupervisedPartyIdentityReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialSupervisedPartyIdentityReportV01( PartyReport1Choice_ reqPartyData )
    {
        PartyData = reqPartyData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides appropriate instructions to update or cancel information about a party in the scope of the local regulation.
    /// </summary>
    [IsoId("_DehT8fH1Eeaz_YGUGLjP6A")]
    [DisplayName("Party Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyData")]
    #endif
    [IsoXmlTag("PtyData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyReport1Choice_ PartyData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyReport1Choice_ PartyData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyReport1Choice_ PartyData { get; init; } 
    #else
    public PartyReport1Choice_ PartyData { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_nAykQTbuEeeYhaZ6bvG1Xg")]
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


// Since FinancialSupervisedPartyIdentityReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FinancialSupervisedPartyIdentityReportV01.

