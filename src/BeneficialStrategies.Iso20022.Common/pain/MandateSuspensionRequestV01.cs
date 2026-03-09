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


namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.018.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MandateSuspensionRequest message is sent by the initiator of the request to its agent. The initiator can either be the debtor, debtor agent, creditor or creditor agent.
/// A MandateSuspensionRequest message is used to request the suspension of an existing mandate until the suspension is lifted. 
/// Usage
/// The MandateSuspensionRequest message can contain one or more suspension requests.
/// The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.
/// The MandateSuspensionRequest message can be used in domestic and cross-border scenarios.
/// 
/// </summary>
[Description(@"Scope|The MandateSuspensionRequest message is sent by the initiator of the request to its agent. The initiator can either be the debtor, debtor agent, creditor or creditor agent.|A MandateSuspensionRequest message is used to request the suspension of an existing mandate until the suspension is lifted. |Usage|The MandateSuspensionRequest message can contain one or more suspension requests.|The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.|The MandateSuspensionRequest message can be used in domestic and cross-border scenarios.|")]
[IsoId("_0HNCMH5lEea7cqFPsAF3tQ")]
[DisplayName("Mandate Suspension Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MandateSuspensionRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.018.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MndtSspnsnReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.018.001.01";
    
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
    /// Constructs a MandateSuspensionRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MandateSuspensionRequestV01( GroupHeader47 reqGroupHeader,MandateSuspension1 reqUnderlyingSuspensionDetails )
    {
        GroupHeader = reqGroupHeader;
        UnderlyingSuspensionDetails = reqUnderlyingSuspensionDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the mandate suspension request, but which are not part of the mandate.
    /// </summary>
    [IsoId("_SNAisH5nEea7cqFPsAF3tQ")]
    [DisplayName("Group Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpHdr")]
    #endif
    [IsoXmlTag("GrpHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader47 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GroupHeader47 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader47 GroupHeader { get; init; } 
    #else
    public GroupHeader47 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide information on the suspension request of the mandate.
    /// </summary>
    [IsoId("_ka8SwH5nEea7cqFPsAF3tQ")]
    [DisplayName("Underlying Suspension Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygSspnsnDtls")]
    #endif
    [IsoXmlTag("UndrlygSspnsnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MandateSuspension1 UnderlyingSuspensionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MandateSuspension1 UnderlyingSuspensionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MandateSuspension1 UnderlyingSuspensionDetails { get; init; } 
    #else
    public MandateSuspension1 UnderlyingSuspensionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_yoO34H5nEea7cqFPsAF3tQ")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since MandateSuspensionRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MandateSuspensionRequestV01.

