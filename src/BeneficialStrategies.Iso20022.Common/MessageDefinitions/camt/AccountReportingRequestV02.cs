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
/// This record is an implementation of the camt.060.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AccountReportingRequest message is sent by the account owner, either directly or through a forwarding agent, to one of its account servicing institutions. It is used to ask the account servicing institution to send a report on the account owner&apos;s account in a BankToCustomerAccountReport (camt.052.001.02), a BankToCustomerStatement (camt.053.001.02) or a BankToCustomerDebitCreditNotification (camt.054.001.02).
/// Usage
/// The AccountReportingRequest message is used to advise the account servicing institution of funds that the account owner expects to have credited to its account. The message can be used in either a direct or a relay scenario.
/// </summary>
[Description(@"Scope|The AccountReportingRequest message is sent by the account owner, either directly or through a forwarding agent, to one of its account servicing institutions. It is used to ask the account servicing institution to send a report on the account owner's account in a BankToCustomerAccountReport (camt.052.001.02), a BankToCustomerStatement (camt.053.001.02) or a BankToCustomerDebitCreditNotification (camt.054.001.02).|Usage|The AccountReportingRequest message is used to advise the account servicing institution of funds that the account owner expects to have credited to its account. The message can be used in either a direct or a relay scenario.")]
[IsoId("_sd2raGtdEeCY4-KZ9JEyUQ_1430848689")]
[DisplayName("Account Reporting Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountReportingRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.060.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctRptgReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.060.001.02";
    
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
    /// Constructs a AccountReportingRequestV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountReportingRequestV02( GroupHeader43 reqGroupHeader,ReportingRequest2 reqReportingRequest )
    {
        GroupHeader = reqGroupHeader;
        ReportingRequest = reqReportingRequest;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide further details on the message.
    /// </summary>
    [IsoId("_sd2raWtdEeCY4-KZ9JEyUQ_1191907994")]
    [DisplayName("Group Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpHdr")]
    #endif
    [IsoXmlTag("GrpHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader43 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GroupHeader43 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader43 GroupHeader { get; init; } 
    #else
    public GroupHeader43 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide further details on the reporting request.
    /// </summary>
    [IsoId("_seAcYGtdEeCY4-KZ9JEyUQ_308674707")]
    [DisplayName("Reporting Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgReq")]
    #endif
    [IsoXmlTag("RptgReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportingRequest2 ReportingRequest { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportingRequest2 ReportingRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportingRequest2 ReportingRequest { get; init; } 
    #else
    public ReportingRequest2 ReportingRequest { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AccountReportingRequestV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountReportingRequestV02.

