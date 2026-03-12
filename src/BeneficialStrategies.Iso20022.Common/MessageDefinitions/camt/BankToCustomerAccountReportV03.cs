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
/// This record is an implementation of the camt.052.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The BankToCustomerAccountReport message is sent by the account servicer to an account owner or to a party authorised by the account owner to receive the message. It can be used to inform the account owner, or authorised party, of the entries reported to the account, and/or to provide the owner with balance information on the account at a given point in time.
/// Usage
/// The BankToCustomerAccountReport message can contain reports for more than one account. It provides information for cash management and/or reconciliation. It can be used to:
/// - report pending and booked items;
/// - provide balance information.
/// It can include underlying details of transactions that have been included in the entry.
/// It is possible that the receiver of the message is not the account owner, but a party entitled by the account owner to receive the account information (also known as recipient).
/// For a statement, the Bank-to-Customer Account Statement message should be used.
/// </summary>
[Description(@"Scope|The BankToCustomerAccountReport message is sent by the account servicer to an account owner or to a party authorised by the account owner to receive the message. It can be used to inform the account owner, or authorised party, of the entries reported to the account, and/or to provide the owner with balance information on the account at a given point in time.|Usage|The BankToCustomerAccountReport message can contain reports for more than one account. It provides information for cash management and/or reconciliation. It can be used to:|- report pending and booked items;|- provide balance information.|It can include underlying details of transactions that have been included in the entry.|It is possible that the receiver of the message is not the account owner, but a party entitled by the account owner to receive the account information (also known as recipient).|For a statement, the Bank-to-Customer Account Statement message should be used.")]
[IsoId("_rta40FkyEeGeoaLUQk__nA_560918446")]
[DisplayName("Bank To Customer Account Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BankToCustomerAccountReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.052.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BkToCstmrAcctRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.052.001.03";
    
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
    /// Constructs a BankToCustomerAccountReportV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BankToCustomerAccountReportV03( GroupHeader58 reqGroupHeader,AccountReport12 reqReport )
    {
        GroupHeader = reqGroupHeader;
        Report = reqReport;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common information for the message.
    /// </summary>
    [IsoId("_rt3kwFkyEeGeoaLUQk__nA_-604633741")]
    [DisplayName("Group Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpHdr")]
    #endif
    [IsoXmlTag("GrpHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader58 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GroupHeader58 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader58 GroupHeader { get; init; } 
    #else
    public GroupHeader58 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Reports on a cash account.
    /// </summary>
    [IsoId("_ruAusFkyEeGeoaLUQk__nA_-1487867028")]
    [DisplayName("Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rpt")]
    #endif
    [IsoXmlTag("Rpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountReport12 Report { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountReport12 Report { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountReport12 Report { get; init; } 
    #else
    public AccountReport12 Report { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_KdXHQp9YEeGBX4a4yy-WHg_-1985886168")]
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


// Since BankToCustomerAccountReportV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BankToCustomerAccountReportV03.

