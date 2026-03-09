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


namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// This record is an implementation of the supl.027.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// This extends the message InformationRequestResponse.
/// </summary>
[Description(@"This extends the message InformationRequestResponse.")]
[IsoId("_8nOCwC_7EeOKib24wnHaFg")]
[DisplayName("Information Response SD 1 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InformationResponseSD1V01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.027.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InfRspnSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.027.001.01";
    
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
    /// Constructs a InformationResponseSD1V01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InformationResponseSD1V01( System.String reqInvestigationIdentification,System.DateTime reqCreationDateTime,BranchAndFinancialInstitutionIdentification4 reqAccountServicerIdentification,AccountAndParties2 reqAccountAndParties )
    {
        InvestigationIdentification = reqInvestigationIdentification;
        CreationDateTime = reqCreationDateTime;
        AccountServicerIdentification = reqAccountServicerIdentification;
        AccountAndParties = reqAccountAndParties;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information used to identify the request.
    /// </summary>
    [IsoId("_hWzaoJirEeO4o528ngEXuw")]
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
    /// Date and time of creation of the extension.
    /// </summary>
    [IsoId("_pfuCgJirEeO4o528ngEXuw")]
    [DisplayName("Creation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CreDtTm")]
    #endif
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CreationDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime CreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CreationDateTime { get; init; } 
    #else
    public System.DateTime CreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the account servicing institution.
    /// </summary>
    [IsoId("_oUIuoC_8EeOKib24wnHaFg")]
    [DisplayName("Account Servicer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcrId")]
    #endif
    [IsoXmlTag("AcctSvcrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Requested account and its owners.
    /// </summary>
    [IsoId("_jqrv4C__EeOKib24wnHaFg")]
    [DisplayName("Account And Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctAndPties")]
    #endif
    [IsoXmlTag("AcctAndPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountAndParties2 AccountAndParties { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountAndParties2 AccountAndParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountAndParties2 AccountAndParties { get; init; } 
    #else
    public AccountAndParties2 AccountAndParties { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since InformationResponseSD1V01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InformationResponseSD1V01.

