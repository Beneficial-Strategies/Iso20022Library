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
/// This record is an implementation of the pain.010.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MandateAmendmentRequest message is sent by the initiator of the request to his agent and/or counterparty. The initiator can both be the debtor or the creditor (or where appropriate the debtor agent).
/// The MandateAmendmentRequest message is forwarded by the agent of the initiator to the agent of the counterparty.
/// A MandateAmendmentRequest message is used to request the amendment of specific information in an existing mandate. The MandateAmendmentRequest message must reflect the new data of the element(s) to be amended and at a minimum a unique reference to the existing mandate. If accepted, this MandateAmendmentRequest message together with the MandateAcceptanceReport message confirming the acceptance will be considered as a valid amendment on an existing mandate, agreed upon by all parties. The amended mandate will from then on be considered the valid mandate.
/// Usage
/// The MandateAmendmentRequest message can contain one or more request(s) to amend a specific mandate.
/// The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.
/// The message can also be used by an initiating party that has authority to send the message on behalf of the creditor or debtor.
/// The MandateAmendmentRequest message can be used in domestic and cross-border scenarios.
/// If all elements in the existing Mandate need to be amended or the underlying contract is different, then the MandateAmendmentRequest message should not be used. The existing Mandate has to be cancelled and a new Mandate has to be initiated.
/// </summary>
[Description(@"Scope|The MandateAmendmentRequest message is sent by the initiator of the request to his agent and/or counterparty. The initiator can both be the debtor or the creditor (or where appropriate the debtor agent).|The MandateAmendmentRequest message is forwarded by the agent of the initiator to the agent of the counterparty.|A MandateAmendmentRequest message is used to request the amendment of specific information in an existing mandate. The MandateAmendmentRequest message must reflect the new data of the element(s) to be amended and at a minimum a unique reference to the existing mandate. If accepted, this MandateAmendmentRequest message together with the MandateAcceptanceReport message confirming the acceptance will be considered as a valid amendment on an existing mandate, agreed upon by all parties. The amended mandate will from then on be considered the valid mandate.|Usage|The MandateAmendmentRequest message can contain one or more request(s) to amend a specific mandate.|The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.|The message can also be used by an initiating party that has authority to send the message on behalf of the creditor or debtor.|The MandateAmendmentRequest message can be used in domestic and cross-border scenarios.|If all elements in the existing Mandate need to be amended or the underlying contract is different, then the MandateAmendmentRequest message should not be used. The existing Mandate has to be cancelled and a new Mandate has to be initiated.")]
[IsoId("_Ie2ISxPeEeSVo-TFVwFHvA")]
[DisplayName("Mandate Amendment Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MandateAmendmentRequestV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.010.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MndtAmdmntReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.010.001.04";
    
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
    /// Constructs a MandateAmendmentRequestV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MandateAmendmentRequestV04( GroupHeader47 reqGroupHeader,MandateAmendment4 reqUnderlyingAmendmentDetails )
    {
        GroupHeader = reqGroupHeader;
        UnderlyingAmendmentDetails = reqUnderlyingAmendmentDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the amendment of the mandate, but which are not part of the mandate.
    /// </summary>
    [IsoId("_Ie2ITxPeEeSVo-TFVwFHvA")]
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
    /// Set of elements used to provide details on the amendment request.
    /// </summary>
    [IsoId("_Ie2IURPeEeSVo-TFVwFHvA")]
    [DisplayName("Underlying Amendment Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygAmdmntDtls")]
    #endif
    [IsoXmlTag("UndrlygAmdmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MandateAmendment4 UnderlyingAmendmentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MandateAmendment4 UnderlyingAmendmentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MandateAmendment4 UnderlyingAmendmentDetails { get; init; } 
    #else
    public MandateAmendment4 UnderlyingAmendmentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Ie2IUxPeEeSVo-TFVwFHvA")]
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


// Since MandateAmendmentRequestV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MandateAmendmentRequestV04.

