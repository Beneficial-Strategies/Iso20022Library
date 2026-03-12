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
    
    #nullable enable
    
    /// <summary>
    /// Set of characteristics that unambiguously identify the status, common parameters, documents and identifications.
    /// </summary>
    [IsoId("_OTgzNDcx-AOSNFX-8224506")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required BusinessLetter1 Header { get; init; } 
    
    /// <summary>
    /// List of agreements.
    /// </summary>
    [IsoId("_OTgzNDcy-AOSNFX-8224506")]
    [DisplayName("Agreement List")]
    [IsoXmlTag("AgrmtList")]
    public required FinancingAgreementList1 AgreementList { get; init; } 
    
    /// <summary>
    /// Number of agreement lists as control value.
    /// </summary>
    [IsoId("_OTgzNDcz-AOSNFX-8224506")]
    [DisplayName("Agreement Count")]
    [IsoXmlTag("AgrmtCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? AgreementCount { get; init; } 
    
    /// <summary>
    /// Total number of individual items in all lists.
    /// </summary>
    [IsoId("_OTgzNDc0-AOSNFX-8224506")]
    [DisplayName("Item Count")]
    [IsoXmlTag("ItmCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? ItemCount { get; init; } 
    
    /// <summary>
    /// Total of all individual amounts included in all lists, irrespective of currencies or direction.
    /// </summary>
    [IsoId("_OTgzNDc1-AOSNFX-8224506")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; } 
    
    /// <summary>
    /// Referenced or related business message.
    /// </summary>
    [IsoId("_OTgzNDc2-AOSNFX-8224506")]
    [DisplayName("Attached Message")]
    [IsoXmlTag("AttchdMsg")]
    public EncapsulatedBusinessMessage1? AttachedMessage { get; init; } 
    
    
    #nullable disable
    
}


// Since PartyRegistrationAndGuaranteeStatusV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PartyRegistrationAndGuaranteeStatusV01.

