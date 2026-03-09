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
/// This record is an implementation of the reda.071.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The RequestToPayDebtorActivationAmendmentRequest message is sent by the debtor RTP (Request To Pay) provider to the creditor RTP provider and optionally from the debtor to its RTP provider and from the creditor RTP provider to the creditor to request for the amendment of the debtor activation of the RTP service with that specific creditor.
/// </summary>
[Description(@"The RequestToPayDebtorActivationAmendmentRequest message is sent by the debtor RTP (Request To Pay) provider to the creditor RTP provider and optionally from the debtor to its RTP provider and from the creditor RTP provider to the creditor to request for the amendment of the debtor activation of the RTP service with that specific creditor.")]
[IsoId("_rNNBueHzEeqbls7Gk4-ckA")]
[DisplayName("Request To Pay Debtor Activation Amendment Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequestToPayDebtorActivationAmendmentRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.071.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqToPayDbtrActvtnAmdmntReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.071.001.01";
    
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
    /// Constructs a RequestToPayDebtorActivationAmendmentRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequestToPayDebtorActivationAmendmentRequestV01( ActivationHeader2 reqHeader,DebtorActivationAmendment3 reqAmendmentData )
    {
        Header = reqHeader;
        AmendmentData = reqAmendmentData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the amendment of the mandate, but which are not part of the mandate.
    /// </summary>
    [IsoId("_rNNBveHzEeqbls7Gk4-ckA")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActivationHeader2 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActivationHeader2 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActivationHeader2 Header { get; init; } 
    #else
    public ActivationHeader2 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the amendment of a debtor activation request.
    /// </summary>
    [IsoId("_rNNBv-HzEeqbls7Gk4-ckA")]
    [DisplayName("Amendment Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmdmntData")]
    #endif
    [IsoXmlTag("AmdmntData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DebtorActivationAmendment3 AmendmentData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DebtorActivationAmendment3 AmendmentData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DebtorActivationAmendment3 AmendmentData { get; init; } 
    #else
    public DebtorActivationAmendment3 AmendmentData { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rNNBweHzEeqbls7Gk4-ckA")]
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


// Since RequestToPayDebtorActivationAmendmentRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RequestToPayDebtorActivationAmendmentRequestV01.

