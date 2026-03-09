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
/// This record is an implementation of the auth.008.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A reporting institution, eg, an investment bank, sends the RegulatoryTransactionReport to a regulator or an intermediary (eg a reporting agent), to report the transaction details of a trade that has been executed on or off-exchange.
/// Usage
/// The message definition can be used to report more than one transaction. The message definition can also be used to specify, on a trade by trade basis, to which authorities the transaction report(s) need to be sent using the TransactionReportMarker.
/// </summary>
[Description(@"Scope|A reporting institution, eg, an investment bank, sends the RegulatoryTransactionReport to a regulator or an intermediary (eg a reporting agent), to report the transaction details of a trade that has been executed on or off-exchange.|Usage|The message definition can be used to report more than one transaction. The message definition can also be used to specify, on a trade by trade basis, to which authorities the transaction report(s) need to be sent using the TransactionReportMarker.")]
[IsoId("_gKH798IFEeGllrOKQRUTYA_1289680586")]
[DisplayName("Regulatory Transaction Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RegulatoryTransactionReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.008.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RgltryTxRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.008.001.02";
    
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
    /// Constructs a RegulatoryTransactionReportV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RegulatoryTransactionReportV02( DocumentIdentification8 reqIdentification,TransactionDetails3 reqTransactionDetails,PartyIdentification23Choice_ reqReportingInstitution )
    {
        Identification = reqIdentification;
        TransactionDetails = reqTransactionDetails;
        ReportingInstitution = reqReportingInstitution;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the RegulatoryTransactionReport.
    /// </summary>
    [IsoId("_gKH7-MIFEeGllrOKQRUTYA_1289680640")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 Identification { get; init; } 
    #else
    public DocumentIdentification8 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details of the trade for which the transaction report is being sent.
    /// </summary>
    [IsoId("_gKRs8MIFEeGllrOKQRUTYA_1289680605")]
    [DisplayName("Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDtls")]
    #endif
    [IsoXmlTag("TxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionDetails3 TransactionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionDetails3 TransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionDetails3 TransactionDetails { get; init; } 
    #else
    public TransactionDetails3 TransactionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the firm that is legally responsible for sending the transaction report.|.
    /// </summary>
    [IsoId("_gKRs8cIFEeGllrOKQRUTYA_1289680665")]
    [DisplayName("Reporting Institution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgInstn")]
    #endif
    [IsoXmlTag("RptgInstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification23Choice_ ReportingInstitution { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification23Choice_ ReportingInstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification23Choice_ ReportingInstitution { get; init; } 
    #else
    public PartyIdentification23Choice_ ReportingInstitution { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the intermediary which is reporting on behalf on the ReportingInstitution. If there is a reporting chain, then the last party should override the previous one.
    /// </summary>
    [IsoId("_gKRs8sIFEeGllrOKQRUTYA_1289680990")]
    [DisplayName("Reporting Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgAgt")]
    #endif
    [IsoXmlTag("RptgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification24Choice_? ReportingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification24Choice_? ReportingAgent { get; init; } 
    #else
    public PartyIdentification24Choice_? ReportingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_gKRs88IFEeGllrOKQRUTYA_1289680973")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension1? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension1? Extension { get; init; } 
    #else
    public Extension1? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since RegulatoryTransactionReportV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RegulatoryTransactionReportV02.

