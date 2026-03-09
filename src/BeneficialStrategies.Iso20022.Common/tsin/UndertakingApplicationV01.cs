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
/// This record is an implementation of the tsin.005.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The UndertakingApplication message is sent by the party requesting issuance of the undertaking (applicant or obligor) to the party issuing the undertaking. It is used to request the issuance of an undertaking (demand guarantee or standby letter of credit or suretyship) or counter-undertaking (counter-guarantee or counter-standby or suretyship), and provides details on the applicable rules, terms, conditions and content of the undertaking to be issued.
/// </summary>
[Description(@"The UndertakingApplication message is sent by the party requesting issuance of the undertaking (applicant or obligor) to the party issuing the undertaking. It is used to request the issuance of an undertaking (demand guarantee or standby letter of credit or suretyship) or counter-undertaking (counter-guarantee or counter-standby or suretyship), and provides details on the applicable rules, terms, conditions and content of the undertaking to be issued.")]
[IsoId("_9fRMkHltEeG7BsjMvd1mEw_980511566")]
[DisplayName("Undertaking Application V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UndertakingApplicationV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsin.005.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgAppl";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.005.001.01";
    
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
    /// Constructs a UndertakingApplicationV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UndertakingApplicationV01( Undertaking1 reqUndertakingApplicationDetails )
    {
        UndertakingApplicationDetails = reqUndertakingApplicationDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Details of the application for an independent undertaking, such as a demand guarantee or standby letter of credit, that provides financial assurance, to be collected on the presentation of documents that comply with its terms and conditions.
    /// </summary>
    [IsoId("_9fRMkXltEeG7BsjMvd1mEw_-1409870883")]
    [DisplayName("Undertaking Application Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgApplDtls")]
    #endif
    [IsoXmlTag("UdrtkgApplDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Undertaking1 UndertakingApplicationDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Undertaking1 UndertakingApplicationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Undertaking1 UndertakingApplicationDetails { get; init; } 
    #else
    public Undertaking1 UndertakingApplicationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Instructions specific to the bank receiving the message.
    /// </summary>
    [IsoId("__KBlo3_5EeGOn4dfTT_QdQ")]
    [DisplayName("Instructions To Bank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrsToBk")]
    #endif
    [IsoXmlTag("InstrsToBk")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    public SimpleValueList<System.String> InstructionsToBank { get; init; } = new SimpleValueList<System.String>(){};
    
    /// <summary>
    /// Digital signature of the undertaking application.
    /// </summary>
    [IsoId("_9fRMknltEeG7BsjMvd1mEw_-448392239")]
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


// Since UndertakingApplicationV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to UndertakingApplicationV01.

