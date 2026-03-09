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
/// This record is an implementation of the tsin.010.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The message PartyRegistrationAndGuaranteeStatus is either sent by a factoring service to a financing client to indicate the status of a factoring service agreement or from a guarantee issuer to a factoring client or a factoring service to indicate the guarantee covering a requested factoring service agreement. The message can also be sent to an interested party.
/// The factoring service or guarantee issuer may include references to a corresponding PartyRegistrationAndGuaranteeRequest message or other related messages and may include referenced data.
/// The message contains information about other parties to be notified about the financial service agreement or the guarantee and whether these parties are required to acknowledge the agreement.
/// The message contains information returned by the financial institution indicating acceptance or rejection of the trade partner; a positive response is necessary before being able to assign financial items concerning the trade party.
/// This message contains identifications of cash accounts to enable payer and payee to treat the transferred payment obligations.
/// The message can carry digital signatures if required by context.
/// </summary>
[Description(@"The message PartyRegistrationAndGuaranteeStatus is either sent by a factoring service to a financing client to indicate the status of a factoring service agreement or from a guarantee issuer to a factoring client or a factoring service to indicate the guarantee covering a requested factoring service agreement. The message can also be sent to an interested party.|The factoring service or guarantee issuer may include references to a corresponding PartyRegistrationAndGuaranteeRequest message or other related messages and may include referenced data.|The message contains information about other parties to be notified about the financial service agreement or the guarantee and whether these parties are required to acknowledge the agreement.|The message contains information returned by the financial institution indicating acceptance or rejection of the trade partner; a positive response is necessary before being able to assign financial items concerning the trade party.|This message contains identifications of cash accounts to enable payer and payee to treat the transferred payment obligations.|The message can carry digital signatures if required by context.")]
[IsoId("_OTgzNDcw-AOSNFX-8224506")]
[DisplayName("Party Registration And Guarantee Status V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyRegistrationAndGuaranteeStatusV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsin.010.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PtyRegnAndGrntSts";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.010.001.01";
    
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
    /// Constructs a PartyRegistrationAndGuaranteeStatusV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyRegistrationAndGuaranteeStatusV01( BusinessLetter1 reqHeader,FinancingAgreementList1 reqAgreementList )
    {
        Header = reqHeader;
        AgreementList = reqAgreementList;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics that unambiguously identify the status, common parameters, documents and identifications.
    /// </summary>
    [IsoId("_OTgzNDcx-AOSNFX-8224506")]
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
    [IsoId("_OTgzNDcy-AOSNFX-8224506")]
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
    [IsoId("_OTgzNDcz-AOSNFX-8224506")]
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
    [IsoId("_OTgzNDc0-AOSNFX-8224506")]
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
    [IsoId("_OTgzNDc1-AOSNFX-8224506")]
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
    [IsoId("_OTgzNDc2-AOSNFX-8224506")]
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


// Since PartyRegistrationAndGuaranteeStatusV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PartyRegistrationAndGuaranteeStatusV01.

