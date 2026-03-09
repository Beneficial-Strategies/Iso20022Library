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


namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.004.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ReversalOfTransferOutConfirmation message is sent by an executing party to the instructing party or the instructing party&apos;s designated agent. This message is used to reverse a TransferOutConfirmation that was previously sent by the instructing party.
/// Usage
/// The ReversalOfTransferOutConfirmation message is sent by an executing party to reverse a previously sent TransferOutConfirmation.
/// This message must contain the reference of the message to be reversed. The message may also contain all the details of the reversed message, but this is not recommended.
/// </summary>
[Description(@"Scope|The ReversalOfTransferOutConfirmation message is sent by an executing party to the instructing party or the instructing party's designated agent. This message is used to reverse a TransferOutConfirmation that was previously sent by the instructing party.|Usage|The ReversalOfTransferOutConfirmation message is sent by an executing party to reverse a previously sent TransferOutConfirmation.|This message must contain the reference of the message to be reversed. The message may also contain all the details of the reversed message, but this is not recommended.")]
[IsoId("_pokg9tE5Ed-BzquC8wXy7w_938886633")]
[DisplayName("Reversal Of Transfer Out Confirmation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReversalOfTransferOutConfirmation : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.004.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "sese.004.001.01";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.004.001.01";
    
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
    /// Constructs a ReversalOfTransferOutConfirmation instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReversalOfTransferOutConfirmation( AdditionalReference2 reqPreviousReference )
    {
        PreviousReference = reqPreviousReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_pokg99E5Ed-BzquC8wXy7w_-910378416")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdditionalReference2 PreviousReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AdditionalReference2 PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference2 PreviousReference { get; init; } 
    #else
    public AdditionalReference2 PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_pokg-NE5Ed-BzquC8wXy7w_233612787")]
    [DisplayName("Pool Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PoolRef")]
    #endif
    [IsoXmlTag("PoolRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference2? PoolReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference2? PoolReference { get; init; } 
    #else
    public AdditionalReference2? PoolReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_pokg-dE5Ed-BzquC8wXy7w_-541223381")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference2? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference2? RelatedReference { get; init; } 
    #else
    public AdditionalReference2? RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Copy of the transfer out confirmation to reverse.
    /// </summary>
    [IsoId("_pokg-tE5Ed-BzquC8wXy7w_1772260838")]
    [DisplayName("Transfer Out Confirmation To Be Reversed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfOutConfToBeRvsd")]
    #endif
    [IsoXmlTag("TrfOutConfToBeRvsd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransferOut1? TransferOutConfirmationToBeReversed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferOut1? TransferOutConfirmationToBeReversed { get; init; } 
    #else
    public TransferOut1? TransferOutConfirmationToBeReversed { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ReversalOfTransferOutConfirmationDocument is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ReversalOfTransferOutConfirmation.

