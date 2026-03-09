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


namespace BeneficialStrategies.Iso20022.caam;

/// <summary>
/// This record is an implementation of the caam.010.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMReconciliationAcknowledgement message is sent by an acquirer or its agent to an ATM to acknowledge the receipt of an ATMReconciliationAdvice message.
/// </summary>
[Description(@"The ATMReconciliationAcknowledgement message is sent by an acquirer or its agent to an ATM to acknowledge the receipt of an ATMReconciliationAdvice message.")]
[IsoId("_RIcLwa48EeWRfYPBaeOY8w")]
[DisplayName("ATM Reconciliation Acknowledgement V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMReconciliationAcknowledgementV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caam.010.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMRcncltnAck";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.010.001.02";
    
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
    /// Constructs a ATMReconciliationAcknowledgementV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMReconciliationAcknowledgementV02( Header32 reqHeader )
    {
        Header = reqHeader;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_RIcLw648EeWRfYPBaeOY8w")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header32 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header32 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header32 Header { get; init; } 
    #else
    public Header32 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_RIcLxa48EeWRfYPBaeOY8w")]
    [DisplayName("Protected ATM Reconciliation Acknowledgement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdATMRcncltnAck")]
    #endif
    [IsoXmlTag("PrtctdATMRcncltnAck")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType10? ProtectedATMReconciliationAcknowledgement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType10? ProtectedATMReconciliationAcknowledgement { get; init; } 
    #else
    public ContentInformationType10? ProtectedATMReconciliationAcknowledgement { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the acknowledgement of an ATM reconciliation from the ATM manager.
    /// </summary>
    [IsoId("_RIcLx648EeWRfYPBaeOY8w")]
    [DisplayName("ATM Reconciliation Acknowledgement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMRcncltnAck")]
    #endif
    [IsoXmlTag("ATMRcncltnAck")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMReconciliationAcknowledgement2? ATMReconciliationAcknowledgement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMReconciliationAcknowledgement2? ATMReconciliationAcknowledgement { get; init; } 
    #else
    public ATMReconciliationAcknowledgement2? ATMReconciliationAcknowledgement { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_RIcLya48EeWRfYPBaeOY8w")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType15? SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType15? SecurityTrailer { get; init; } 
    #else
    public ContentInformationType15? SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ATMReconciliationAcknowledgementV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMReconciliationAcknowledgementV02.

