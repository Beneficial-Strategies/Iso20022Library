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
/// This record is an implementation of the tsrv.005.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The UndertakingAmendment message is sent (and is thus issued) by the party that issued the undertaking. The message may be sent either directly to the beneficiary or via an advising party. The proposed undertaking amendment could be to a demand guarantee, standby letter of credit, or counter-undertaking (counter-guarantee or counter-standby). The message provides details on proposed changes to the undertaking, for example, to the expiry date, the amount, and terms and conditions of the undertaking. It may also be used to propose the termination or cancellation of the undertaking. Under practice and law, this communication binds the party issuing it. The message constitutes an operative financial instrument.
/// </summary>
[Description(@"The UndertakingAmendment message is sent (and is thus issued) by the party that issued the undertaking. The message may be sent either directly to the beneficiary or via an advising party. The proposed undertaking amendment could be to a demand guarantee, standby letter of credit, or counter-undertaking (counter-guarantee or counter-standby). The message provides details on proposed changes to the undertaking, for example, to the expiry date, the amount, and terms and conditions of the undertaking. It may also be used to propose the termination or cancellation of the undertaking. Under practice and law, this communication binds the party issuing it. The message constitutes an operative financial instrument.")]
[IsoId("_9gAzdnltEeG7BsjMvd1mEw_-1766556993")]
[DisplayName("Undertaking Amendment V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UndertakingAmendmentV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.005.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgAmdmnt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.005.001.01";
    
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
    /// Constructs a UndertakingAmendmentV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UndertakingAmendmentV01( Amendment1 reqUndertakingAmendmentDetails )
    {
        UndertakingAmendmentDetails = reqUndertakingAmendmentDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Details related to the proposed undertaking amendment.
    /// </summary>
    [IsoId("_9gAzd3ltEeG7BsjMvd1mEw_-531936320")]
    [DisplayName("Undertaking Amendment Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgAmdmntDtls")]
    #endif
    [IsoXmlTag("UdrtkgAmdmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amendment1 UndertakingAmendmentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amendment1 UndertakingAmendmentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amendment1 UndertakingAmendmentDetails { get; init; } 
    #else
    public Amendment1 UndertakingAmendmentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information specific to the bank-to-bank communication.
    /// </summary>
    [IsoId("_825P83_6EeGOn4dfTT_QdQ")]
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
    /// Digital signature of the proposed undertaking amendment.
    /// </summary>
    [IsoId("_9gAzeHltEeG7BsjMvd1mEw_1718202663")]
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


// Since UndertakingAmendmentV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to UndertakingAmendmentV01.

