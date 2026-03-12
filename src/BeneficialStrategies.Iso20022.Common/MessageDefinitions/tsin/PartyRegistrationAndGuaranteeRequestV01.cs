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


namespace BeneficialStrategies.Iso20022.tsin;

/// <summary>
/// This record is an implementation of the tsin.009.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The message PartyRegistrationAndGuaranteeRequest is sent by a factoring client either to a financial service or a guarantee issuer. The message can also be sent from a financial service to a guarantee issuer. Furthermore, the message can be sent to an interested party for example a fiscal authority. When the message is sent to a guarantee issuer, the factoring client or financial service provider requests a guarantee for the factoring agreement concerning the indicated trade party. When the message is sent to a financial service, the financial client requests an agreement to execute assignments of financial items. The financial client may request the guarantee amount to be obtained in case of insolvency of the trade partner for a corresponding account receivable directly from the financial service. Alternatively and depending on the contractual and product definition, the financial client may be required to include a copy of a guarantee status received from a guarantee issuer.
/// The message can carry digital signatures if required by context.
/// </summary>
[Description(@"The message PartyRegistrationAndGuaranteeRequest is sent by a factoring client either to a financial service or a guarantee issuer. The message can also be sent from a financial service to a guarantee issuer. Furthermore, the message can be sent to an interested party for example a fiscal authority. When the message is sent to a guarantee issuer, the factoring client or financial service provider requests a guarantee for the factoring agreement concerning the indicated trade party. When the message is sent to a financial service, the financial client requests an agreement to execute assignments of financial items. The financial client may request the guarantee amount to be obtained in case of insolvency of the trade partner for a corresponding account receivable directly from the financial service. Alternatively and depending on the contractual and product definition, the financial client may be required to include a copy of a guarantee status received from a guarantee issuer.|The message can carry digital signatures if required by context.")]
[IsoId("_OTgzNDYz-AOSNFX-8224506")]
[DisplayName("Party Registration And Guarantee Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyRegistrationAndGuaranteeRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsin.009.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PtyRegnAndGrntReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.009.001.01";
    
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
    /// Constructs a PartyRegistrationAndGuaranteeRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyRegistrationAndGuaranteeRequestV01( BusinessLetter1 reqHeader,FinancingAgreementList1 reqAgreementList )
    {
        Header = reqHeader;
        AgreementList = reqAgreementList;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics that unambiguously identify the request, common parameters, documents and identifications.
    /// </summary>
    [IsoId("_OTgzNDY0-AOSNFX-8224506")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BusinessLetter1 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BusinessLetter1 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BusinessLetter1 Header { get; init; } 
    #else
    public BusinessLetter1 Header { get; set; } 
    #endif
    
    /// <summary>
    /// List of agreements.
    /// </summary>
    [IsoId("_OTgzNDY1-AOSNFX-8224506")]
    [DisplayName("Agreement List")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgrmtList")]
    #endif
    [IsoXmlTag("AgrmtList")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancingAgreementList1 AgreementList { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancingAgreementList1 AgreementList { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancingAgreementList1 AgreementList { get; init; } 
    #else
    public FinancingAgreementList1 AgreementList { get; set; } 
    #endif
    
    /// <summary>
    /// Number of agreement lists as control value.
    /// </summary>
    [IsoId("_OTgzNDY2-AOSNFX-8224506")]
    [DisplayName("Agreement Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgrmtCnt")]
    #endif
    [IsoXmlTag("AgrmtCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? AgreementCount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AgreementCount { get; init; } 
    #else
    public System.String? AgreementCount { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of individual items in all lists.
    /// </summary>
    [IsoId("_OTgzNDY3-AOSNFX-8224506")]
    [DisplayName("Item Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ItmCnt")]
    #endif
    [IsoXmlTag("ItmCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? ItemCount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ItemCount { get; init; } 
    #else
    public System.String? ItemCount { get; set; } 
    #endif
    
    /// <summary>
    /// Total of all individual amounts included in all lists, irrespective of currencies or direction.
    /// </summary>
    [IsoId("_OTgzNDY4-AOSNFX-8224506")]
    [DisplayName("Control Sum")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrlSum")]
    #endif
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? ControlSum { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ControlSum { get; init; } 
    #else
    public System.UInt64? ControlSum { get; set; } 
    #endif
    
    /// <summary>
    /// Referenced or related business message.
    /// </summary>
    [IsoId("_OTgzNDY5-AOSNFX-8224506")]
    [DisplayName("Attached Message")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttchdMsg")]
    #endif
    [IsoXmlTag("AttchdMsg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EncapsulatedBusinessMessage1? AttachedMessage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EncapsulatedBusinessMessage1? AttachedMessage { get; init; } 
    #else
    public EncapsulatedBusinessMessage1? AttachedMessage { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since PartyRegistrationAndGuaranteeRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PartyRegistrationAndGuaranteeRequestV01.

