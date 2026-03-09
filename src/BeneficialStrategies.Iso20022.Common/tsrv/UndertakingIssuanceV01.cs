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
/// This record is an implementation of the tsrv.001.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The UndertakingIssuance message is sent (and is thus issued) by the party issuing the undertaking to the beneficiary. The message may be sent either to the beneficiary directly or via an advising party. The undertaking could be a demand guarantee, standby letter of credit, or counter-undertaking (counter-guarantee or counter-standby). It contains details on the applicable rules, expiry date, the amount, required documents, and terms and conditions of the undertaking. The message constitutes an operative financial instrument.
/// Under the United Nations Convention on Independent Guarantees and Stand-by Letters of Credit (http://www.uncitral.org), 1996, Article 2, &quot;an undertaking is an independent commitment, known in international practice as an independent guarantee or as a standby letter of credit, given by a bank or other institution or person (&apos;guarantor/issuer&apos;) to pay to the beneficiary a certain or determinable amount upon simple demand or upon demand accompanied by other documents, in conformity with the terms and any documentary conditions of the undertaking, indicating, or from which it is to be inferred, that payment is due because of a default in the performance of an obligation, or because of another contingency, or for money borrowed or advanced, or on account of any mature indebtedness undertaken by the principal/applicant or another person&quot;.
/// </summary>
[Description(@"The UndertakingIssuance message is sent (and is thus issued) by the party issuing the undertaking to the beneficiary. The message may be sent either to the beneficiary directly or via an advising party. The undertaking could be a demand guarantee, standby letter of credit, or counter-undertaking (counter-guarantee or counter-standby). It contains details on the applicable rules, expiry date, the amount, required documents, and terms and conditions of the undertaking. The message constitutes an operative financial instrument.|Under the United Nations Convention on Independent Guarantees and Stand-by Letters of Credit (http://www.uncitral.org), 1996, Article 2, ""an undertaking is an independent commitment, known in international practice as an independent guarantee or as a standby letter of credit, given by a bank or other institution or person ('guarantor/issuer') to pay to the beneficiary a certain or determinable amount upon simple demand or upon demand accompanied by other documents, in conformity with the terms and any documentary conditions of the undertaking, indicating, or from which it is to be inferred, that payment is due because of a default in the performance of an obligation, or because of another contingency, or for money borrowed or advanced, or on account of any mature indebtedness undertaken by the principal/applicant or another person"".")]
[IsoId("_9faWgnltEeG7BsjMvd1mEw_256886753")]
[DisplayName("Undertaking Issuance V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UndertakingIssuanceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.001.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgIssnc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.001.001.01";
    
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
    /// Constructs a UndertakingIssuanceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UndertakingIssuanceV01( Undertaking3 reqUndertakingIssuanceDetails )
    {
        UndertakingIssuanceDetails = reqUndertakingIssuanceDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Independent undertaking, such as a demand guarantee or standby letter of credit, that provides financial assurance, to be collected on the presentation of documents that comply with its terms and conditions.
    /// </summary>
    [IsoId("_9faWg3ltEeG7BsjMvd1mEw_-1948679398")]
    [DisplayName("Undertaking Issuance Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgIssncDtls")]
    #endif
    [IsoXmlTag("UdrtkgIssncDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Undertaking3 UndertakingIssuanceDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Undertaking3 UndertakingIssuanceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Undertaking3 UndertakingIssuanceDetails { get; init; } 
    #else
    public Undertaking3 UndertakingIssuanceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information specific to the bank-to-beneficiary communication.
    /// </summary>
    [IsoId("_izALUBHpEeKdLJc0LFyn4w")]
    [DisplayName("Bank To Beneficiary Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkToBnfcryInf")]
    #endif
    [IsoXmlTag("BkToBnfcryInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    public SimpleValueList<System.String> BankToBeneficiaryInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    /// <summary>
    /// Additional information specific to the bank-to-bank communication.
    /// </summary>
    [IsoId("_yNRl43_6EeGOn4dfTT_QdQ")]
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
    /// Digital signature of the undertaking.
    /// </summary>
    [IsoId("_9faWhHltEeG7BsjMvd1mEw_-2129518569")]
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


// Since UndertakingIssuanceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to UndertakingIssuanceV01.

