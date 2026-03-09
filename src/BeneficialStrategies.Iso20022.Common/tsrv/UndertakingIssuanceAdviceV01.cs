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


namespace BeneficialStrategies.Iso20022.tsrv;

/// <summary>
/// This record is an implementation of the tsrv.002.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The UndertakingIssuanceAdvice message is sent by an advising party to the beneficiary, either directly or via one or more other advising parties in the transaction chain, to advise the issuance of an undertaking. Other interested parties may also be informed of the advice. The undertaking advised could be a demand guarantee, standby letter of credit, or counter-undertaking (counter-guarantee or counter-standby). In addition to providing details on the applicable rules, expiry date, the amount, required documents, and terms and conditions of the undertaking, the advice may provide information from the sender such as confirmation details.
/// </summary>
[Description(@"The UndertakingIssuanceAdvice message is sent by an advising party to the beneficiary, either directly or via one or more other advising parties in the transaction chain, to advise the issuance of an undertaking. Other interested parties may also be informed of the advice. The undertaking advised could be a demand guarantee, standby letter of credit, or counter-undertaking (counter-guarantee or counter-standby). In addition to providing details on the applicable rules, expiry date, the amount, required documents, and terms and conditions of the undertaking, the advice may provide information from the sender such as confirmation details.")]
[IsoId("_9fkHg3ltEeG7BsjMvd1mEw_-135389308")]
[DisplayName("Undertaking Issuance Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UndertakingIssuanceAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.002.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgIssncAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.002.001.01";
    
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
    /// Constructs a UndertakingIssuanceAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UndertakingIssuanceAdviceV01( PartyIdentification43 reqAdvisingParty,DateAndDateTimeChoice_ reqDateOfAdvice,UndertakingAdvice1 reqUndertakingIssuanceAdviceDetails )
    {
        AdvisingParty = reqAdvisingParty;
        DateOfAdvice = reqDateOfAdvice;
        UndertakingIssuanceAdviceDetails = reqUndertakingIssuanceAdviceDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party advising the undertaking to the beneficiary or to another party.
    /// </summary>
    [IsoId("_HtBI0z1UEeKvwJ48Wu13ug")]
    [DisplayName("Advising Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdvsgPty")]
    #endif
    [IsoXmlTag("AdvsgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification43 AdvisingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification43 AdvisingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43 AdvisingParty { get; init; } 
    #else
    public PartyIdentification43 AdvisingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Additional party that advises the undertaking.
    /// </summary>
    [IsoId("_WPnPkz1UEeKvwJ48Wu13ug")]
    [DisplayName("Second Advising Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndAdvsgPty")]
    #endif
    [IsoXmlTag("ScndAdvsgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? SecondAdvisingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? SecondAdvisingParty { get; init; } 
    #else
    public PartyIdentification43? SecondAdvisingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the undertaking is advised.
    /// </summary>
    [IsoId("_bOgLdT1UEeKvwJ48Wu13ug")]
    [DisplayName("Date Of Advice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtOfAdvc")]
    #endif
    [IsoXmlTag("DtOfAdvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ DateOfAdvice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTimeChoice_ DateOfAdvice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ DateOfAdvice { get; init; } 
    #else
    public DateAndDateTimeChoice_ DateOfAdvice { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the advice of the issued undertaking.
    /// </summary>
    [IsoId("_9fkHhHltEeG7BsjMvd1mEw_-1882715655")]
    [DisplayName("Undertaking Issuance Advice Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgIssncAdvcDtls")]
    #endif
    [IsoXmlTag("UdrtkgIssncAdvcDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingAdvice1 UndertakingIssuanceAdviceDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UndertakingAdvice1 UndertakingIssuanceAdviceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingAdvice1 UndertakingIssuanceAdviceDetails { get; init; } 
    #else
    public UndertakingAdvice1 UndertakingIssuanceAdviceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information specific to the bank-to-bank communication.
    /// </summary>
    [IsoId("_pgGLlRWxEeKtPMeuz5Qhfw")]
    [DisplayName("Bank To Bank Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkToBkInf")]
    #endif
    [IsoXmlTag("BkToBkInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    public SimpleValueList<System.String> BankToBankInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    /// <summary>
    /// Digital signature of the undertaking advice.
    /// </summary>
    [IsoId("_9fkHhXltEeG7BsjMvd1mEw_1405552400")]
    [DisplayName("Digital Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgtlSgntr")]
    #endif
    [IsoXmlTag("DgtlSgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyAndSignature2? DigitalSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyAndSignature2? DigitalSignature { get; init; } 
    #else
    public PartyAndSignature2? DigitalSignature { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since UndertakingIssuanceAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to UndertakingIssuanceAdviceV01.

