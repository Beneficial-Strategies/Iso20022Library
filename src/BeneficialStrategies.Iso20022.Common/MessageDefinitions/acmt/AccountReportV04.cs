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


namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// This record is an implementation of the acmt.014.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountReport message is sent from a financial institution to an organisation for reporting purposes. It can be sent unsolicited as part of opening, maintenance, or closing process, or it can be sent as response to an AccountReportRequest message.
/// </summary>
[Description(@"The AccountReport message is sent from a financial institution to an organisation for reporting purposes. It can be sent unsolicited as part of opening, maintenance, or closing process, or it can be sent as response to an AccountReportRequest message.")]
[IsoId("_1EOMu9cAEeq_l4BJLVUF2Q")]
[DisplayName("Account Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountReportV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.014.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.014.001.04";
    
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
    /// Constructs a AccountReportV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountReportV04( References5 reqReferences,BranchAndFinancialInstitutionIdentification6 reqAccountServicerIdentification,Organisation33 reqOrganisation )
    {
        References = reqReferences;
        AccountServicerIdentification = reqAccountServicerIdentification;
        Organisation = reqOrganisation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements for the identification of the message and related references.
    /// </summary>
    [IsoId("_1EOMwdcAEeq_l4BJLVUF2Q")]
    [DisplayName("References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Refs")]
    #endif
    [IsoXmlTag("Refs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required References5 References { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required References5 References { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public References5 References { get; init; } 
    #else
    public References5 References { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the business sender of the message, if it is not the account owner or account servicing financial institution.
    /// </summary>
    [IsoId("_1EOMw9cAEeq_l4BJLVUF2Q")]
    [DisplayName("From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fr")]
    #endif
    [IsoXmlTag("Fr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification29? From { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification29? From { get; init; } 
    #else
    public OrganisationIdentification29? From { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_1EOMxdcAEeq_l4BJLVUF2Q")]
    [DisplayName("Account Servicer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcrId")]
    #endif
    [IsoXmlTag("AcctSvcrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification6 AccountServicerIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification6 AccountServicerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6 AccountServicerIdentification { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6 AccountServicerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_1EOMx9cAEeq_l4BJLVUF2Q")]
    [DisplayName("Organisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Org")]
    #endif
    [IsoXmlTag("Org")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Organisation33 Organisation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Organisation33 Organisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation33 Organisation { get; init; } 
    #else
    public Organisation33 Organisation { get; set; } 
    #endif
    
    /// <summary>
    /// Account report.
    /// </summary>
    [IsoId("_1EOMydcAEeq_l4BJLVUF2Q")]
    [DisplayName("Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rpt")]
    #endif
    [IsoXmlTag("Rpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountReport28? Report { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountReport28? Report { get; init; } 
    #else
    public AccountReport28? Report { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_1EOMy9cAEeq_l4BJLVUF2Q")]
    [DisplayName("Digital Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgtlSgntr")]
    #endif
    [IsoXmlTag("DgtlSgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyAndSignature3? DigitalSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyAndSignature3? DigitalSignature { get; init; } 
    #else
    public PartyAndSignature3? DigitalSignature { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_1EOMzdcAEeq_l4BJLVUF2Q")]
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


// Since AccountReportV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountReportV04.

