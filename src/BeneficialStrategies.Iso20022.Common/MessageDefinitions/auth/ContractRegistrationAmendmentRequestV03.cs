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
/// This record is an implementation of the auth.021.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ContractRegistrationAmendmentRequest message is sent by the reporting party to the registration agent to amend the registered contract subject to currency control.
/// </summary>
[Description(@"The ContractRegistrationAmendmentRequest message is sent by the reporting party to the registration agent to amend the registered contract subject to currency control.")]
[IsoId("_Nz8agR3pEeuiRvbpCaJe6A")]
[DisplayName("Contract Registration Amendment Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContractRegistrationAmendmentRequestV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.021.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CtrctRegnAmdmntReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.021.001.03";
    
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
    /// Constructs a ContractRegistrationAmendmentRequestV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ContractRegistrationAmendmentRequestV03( CurrencyControlHeader4 reqGroupHeader,RegisteredContract13 reqContractRegistrationAmendment )
    {
        GroupHeader = reqGroupHeader;
        ContractRegistrationAmendment = reqContractRegistrationAmendment;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Characteristics shared by all individual items included in the message.
    /// </summary>
    [IsoId("_Nz8agx3pEeuiRvbpCaJe6A")]
    [DisplayName("Group Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpHdr")]
    #endif
    [IsoXmlTag("GrpHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyControlHeader4 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyControlHeader4 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyControlHeader4 GroupHeader { get; init; } 
    #else
    public CurrencyControlHeader4 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Details on the amendment of the registered contract.
    /// </summary>
    [IsoId("_Nz8ahR3pEeuiRvbpCaJe6A")]
    [DisplayName("Contract Registration Amendment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctRegnAmdmnt")]
    #endif
    [IsoXmlTag("CtrctRegnAmdmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RegisteredContract13 ContractRegistrationAmendment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RegisteredContract13 ContractRegistrationAmendment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegisteredContract13 ContractRegistrationAmendment { get; init; } 
    #else
    public RegisteredContract13 ContractRegistrationAmendment { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Nz8ahx3pEeuiRvbpCaJe6A")]
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


// Since ContractRegistrationAmendmentRequestV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ContractRegistrationAmendmentRequestV03.

