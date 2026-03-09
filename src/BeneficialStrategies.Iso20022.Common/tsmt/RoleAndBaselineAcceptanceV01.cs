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


namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// This record is an implementation of the tsmt.049.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RoleAndBaselineAcceptance message is sent by a secondary bank to the matching application if it accepts to join the transaction based on the baseline and the role that it is expected to play.
/// Usage
/// The RoleAndBaselineAcceptance message is sent in response to a message that is a direct request to join a transaction.
/// </summary>
[Description(@"Scope|The RoleAndBaselineAcceptance message is sent by a secondary bank to the matching application if it accepts to join the transaction based on the baseline and the role that it is expected to play.|Usage|The RoleAndBaselineAcceptance message is sent in response to a message that is a direct request to join a transaction.")]
[IsoId("_tSUHeNE8Ed-BzquC8wXy7w_1282098535")]
[DisplayName("Role And Baseline Acceptance V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RoleAndBaselineAcceptanceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.049.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RoleAndBaselnAccptnc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.049.001.01";
    
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
    /// Constructs a RoleAndBaselineAcceptanceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RoleAndBaselineAcceptanceV01( MessageIdentification1 reqAcceptanceIdentification,MessageIdentification1 reqRelatedMessageReference,SimpleIdentificationInformation reqTransactionIdentification )
    {
        AcceptanceIdentification = reqAcceptanceIdentification;
        RelatedMessageReference = reqRelatedMessageReference;
        TransactionIdentification = reqTransactionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the acceptance message.
    /// </summary>
    [IsoId("_tSdRYNE8Ed-BzquC8wXy7w_1282098561")]
    [DisplayName("Acceptance Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptncId")]
    #endif
    [IsoXmlTag("AccptncId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 AcceptanceIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 AcceptanceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 AcceptanceIdentification { get; init; } 
    #else
    public MessageIdentification1 AcceptanceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the message that contained the baseline and is accepted.
    /// </summary>
    [IsoId("_tSdRYdE8Ed-BzquC8wXy7w_1662420594")]
    [DisplayName("Related Message Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdMsgRef")]
    #endif
    [IsoXmlTag("RltdMsgRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 RelatedMessageReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 RelatedMessageReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 RelatedMessageReference { get; init; } 
    #else
    public MessageIdentification1 RelatedMessageReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_tSdRYtE8Ed-BzquC8wXy7w_1282098638")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SimpleIdentificationInformation TransactionIdentification { get; init; } 
    #else
    public SimpleIdentificationInformation TransactionIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since RoleAndBaselineAcceptanceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RoleAndBaselineAcceptanceV01.

