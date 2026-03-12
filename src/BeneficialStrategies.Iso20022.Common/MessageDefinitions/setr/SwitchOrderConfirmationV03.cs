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



namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// This record is an implementation of the setr.015.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a transfer agent, sends the SwitchOrderConfirmation message to the instructing party, for example, an investment manager or its authorised representative to confirm the details of the execution of a previously received SwitchOrder instruction.
/// Usage
/// The SwitchOrderConfirmation message is used to confirm that all the legs of the previously instructed switch order have been executed. The reference of the switch order confirmation is identified in DealReference.
/// The reference of the original switch order is specified in OrderReference. The message identification of the SwitchOrder message in which the switch order was conveyed may also be quoted in RelatedReference.
/// If the SwitchOrderConfirmation Details sequence is present more than once, then the redemption leg details and subscription leg details sequences may only be present once.
/// If Switch Confirmation Order Details\Investment Account is used, then the Investment Account Details sequences in Subscription Leg Details and Redemption Leg Details are not allowed.|If the SwitchOrderConfirmation Details sequence is present more than once, then the redemption leg details and subscription leg details sequences may only be present once.|If SwitchOrderConfirmationDetails\InvestmentAccount is used, then the InvestmentAccountDetails sequences in SubscriptionLegDetails and RedemptionLegDetails are not allowed. This functionality is to be used by institutions that set up two accounts per investor, rather than one investment account.|.
/// </summary>
[Description(@"Scope|An executing party, for example, a transfer agent, sends the SwitchOrderConfirmation message to the instructing party, for example, an investment manager or its authorised representative to confirm the details of the execution of a previously received SwitchOrder instruction.|Usage|The SwitchOrderConfirmation message is used to confirm that all the legs of the previously instructed switch order have been executed. The reference of the switch order confirmation is identified in DealReference.|The reference of the original switch order is specified in OrderReference. The message identification of the SwitchOrder message in which the switch order was conveyed may also be quoted in RelatedReference.|If the SwitchOrderConfirmation Details sequence is present more than once, then the redemption leg details and subscription leg details sequences may only be present once.|If Switch Confirmation Order Details\Investment Account is used, then the Investment Account Details sequences in Subscription Leg Details and Redemption Leg Details are not allowed.|If the SwitchOrderConfirmation Details sequence is present more than once, then the redemption leg details and subscription leg details sequences may only be present once.|If SwitchOrderConfirmationDetails\InvestmentAccount is used, then the InvestmentAccountDetails sequences in SubscriptionLegDetails and RedemptionLegDetails are not allowed. This functionality is to be used by institutions that set up two accounts per investor, rather than one investment account.|.")]
[IsoId("_7t2ZYNE7Ed-BzquC8wXy7w_190731874")]
[DisplayName("Switch Order Confirmation V")]
public partial record SwitchOrderConfirmationV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.015.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SwtchOrdrConfV03";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.015.001.03";
    
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
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_7t2ZYdE7Ed-BzquC8wXy7w_602996789")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_7t2ZYtE7Ed-BzquC8wXy7w_1151194773")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_7t2ZY9E7Ed-BzquC8wXy7w_1364526959")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_7t2ZZNE7Ed-BzquC8wXy7w_1366376495")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; } 
    
    /// <summary>
    /// Information related to a switch execution.
    /// </summary>
    [IsoId("_7t2ZZdE7Ed-BzquC8wXy7w_-1882952026")]
    [DisplayName("Switch Execution Details")]
    [IsoXmlTag("SwtchExctnDtls")]
    public required SwitchExecution4 SwitchExecutionDetails { get; init; } 
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_7uAKYNE7Ed-BzquC8wXy7w_738593095")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_7uAKYdE7Ed-BzquC8wXy7w_746903959")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}


// Since SwitchOrderConfirmationV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SwitchOrderConfirmationV03.

