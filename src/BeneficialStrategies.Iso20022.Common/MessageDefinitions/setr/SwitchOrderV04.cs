// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// This record is an implementation of the setr.013.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The SwitchOrder message is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to instruct a switch transaction from a financial instrument or multiple financial instruments to a different specified financial instrument or instruments for a specified amount/quantity.
/// Usage
/// The SwitchOrder message is used to either:
/// - instruct one switch transaction comprising one or more redemption legs and one or more subscription legs, that is, a single switch transaction that can be a one to one, many to one, many to many or one to many switch transaction, or,
/// - instruct one or many switch transactions each comprising one redemption leg and one subscription leg, that is, multiple simple switch transactions.
/// The SwitchOrder message may be used to either:
/// - instruct a switch transaction for one investment account, or,
/// - instruct a switch transaction for separate accounts at the redemption and subscription leg levels.
/// The message caters for a switch from one financial instrument to another financial instrument (within the same fund family), many to one, many to many and one to many.
/// The message caters for switch transactions that result in an additional cash payment from the investor or a transaction that results in a net payment to the investor. Not all institutions or funds permit this type of switch and acceptance is therefore not automatic.
/// There is no limitation on the number of switch legs in a switch message. The number allowed is defined by the fund prospectus or by the service level agreement (SLA) in place between the two parties. However, if the SwitchOrderDetails sequence is present more than once, then the RedemptionLegDetails and SubscriptionLegDetails sequences may only be present once.
/// If SwitchOrderDetails\InvestmentAccount is used, then the InvestmentAccountDetails sequences in SubscriptionLegDetails and RedemptionLegDetails are not allowed. This functionality is to be used by institutions that set up two accounts per investor, rather than one investment account.
/// There is no switch driver type in the message to indicate whether the switch is buy or sell driven. A driver is not needed since it is possible to indicate the total subscription amount or the total redemption amount. Only one of these two amounts should be used.
/// The subscription quantity can be expressed in one of the following ways:
/// - Amount: the monetary value (either GROSS or NET) of the financial instrument to be subscribed to, for example, the subscription of EUR 1,000 of financial instrument ISIN LU1234567890 or
/// - Unit: the number of units of the financial instrument to be subscribed to, for example, the subscription of 10 units of financial instrument ISIN LU1234567890 or
/// - Percentage of the total redemption amount: when the switch transaction is redemption driven, it is the part of the redemption amount that must be switched to a specific financial instrument, for example, the subscription quantity of financial instrument ISIN LU1234567890 represents 50% of the redemption amount of the financial instrument ISIN LU4444444444.
/// The redemption quantity can be expressed in one of the following ways:
/// - Amount: the monetary value (either GROSS or NET) of the financial instrument to be redeemed, for example, the redemption of EUR 1,000 of financial instrument ISIN LU1234567890, or
/// - Unit: the number of units of financial instrument to be redeemed, for example, the redemption of 10 units of financial instrument ISIN LU1234567890, or
/// - Rate: the part of the portfolio to be redeemed, for example, the redemption of 10% of the holdings in financial instrument ISIN LU1234567890, or
/// - Percentage of the total subscription amount: when the switch transaction is subscription driven, it is the part of the subscription amount that must be the result of the redemption of a specific financial instrument, for example, the redemption quantity in financial instrument ABC represents 50% of the subscription amount of the financial instrument ISIN LU4444444444.
/// </summary>
[Description(
    @"Scope|The SwitchOrder message is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to instruct a switch transaction from a financial instrument or multiple financial instruments to a different specified financial instrument or instruments for a specified amount/quantity.|Usage|The SwitchOrder message is used to either:|- instruct one switch transaction comprising one or more redemption legs and one or more subscription legs, that is, a single switch transaction that can be a one to one, many to one, many to many or one to many switch transaction, or,|- instruct one or many switch transactions each comprising one redemption leg and one subscription leg, that is, multiple simple switch transactions.|The SwitchOrder message may be used to either:|- instruct a switch transaction for one investment account, or,|- instruct a switch transaction for separate accounts at the redemption and subscription leg levels.|The message caters for a switch from one financial instrument to another financial instrument (within the same fund family), many to one, many to many and one to many.|The message caters for switch transactions that result in an additional cash payment from the investor or a transaction that results in a net payment to the investor. Not all institutions or funds permit this type of switch and acceptance is therefore not automatic. |There is no limitation on the number of switch legs in a switch message. The number allowed is defined by the fund prospectus or by the service level agreement (SLA) in place between the two parties. However, if the SwitchOrderDetails sequence is present more than once, then the RedemptionLegDetails and SubscriptionLegDetails sequences may only be present once.|If SwitchOrderDetails\InvestmentAccount is used, then the InvestmentAccountDetails sequences in SubscriptionLegDetails and RedemptionLegDetails are not allowed. This functionality is to be used by institutions that set up two accounts per investor, rather than one investment account.|There is no switch driver type in the message to indicate whether the switch is buy or sell driven. A driver is not needed since it is possible to indicate the total subscription amount or the total redemption amount. Only one of these two amounts should be used. |The subscription quantity can be expressed in one of the following ways:|- Amount: the monetary value (either GROSS or NET) of the financial instrument to be subscribed to, for example, the subscription of EUR 1,000 of financial instrument ISIN LU1234567890 or |- Unit: the number of units of the financial instrument to be subscribed to, for example, the subscription of 10 units of financial instrument ISIN LU1234567890 or |- Percentage of the total redemption amount: when the switch transaction is redemption driven, it is the part of the redemption amount that must be switched to a specific financial instrument, for example, the subscription quantity of financial instrument ISIN LU1234567890 represents 50% of the redemption amount of the financial instrument ISIN LU4444444444.|The redemption quantity can be expressed in one of the following ways:|- Amount: the monetary value (either GROSS or NET) of the financial instrument to be redeemed, for example, the redemption of EUR 1,000 of financial instrument ISIN LU1234567890, or |- Unit: the number of units of financial instrument to be redeemed, for example, the redemption of 10 units of financial instrument ISIN LU1234567890, or|- Rate: the part of the portfolio to be redeemed, for example, the redemption of 10% of the holdings in financial instrument ISIN LU1234567890, or|- Percentage of the total subscription amount: when the switch transaction is subscription driven, it is the part of the subscription amount that must be the result of the redemption of a specific financial instrument, for example, the redemption quantity in financial instrument ABC represents 50% of the subscription amount of the financial instrument ISIN LU4444444444."
)]
[IsoId("_Aab64TbLEead9bDRE_1DAQ")]
[DisplayName("Switch Order V")]
public record SwitchOrderV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.013.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SwtchOrdr";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.013.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_Aab66zbLEead9bDRE_1DAQ")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_Aab67TbLEead9bDRE_1DAQ")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference9? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_Aab67zbLEead9bDRE_1DAQ")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference8? PreviousReference { get; init; }

    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_Aab68TbLEead9bDRE_1DAQ")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public Pagination? MessagePagination { get; init; }

    /// <summary>
    /// Information related to the switch order.
    /// </summary>
    [IsoId("_Aab68zbLEead9bDRE_1DAQ")]
    [DisplayName("Switch Order Details")]
    [IsoXmlTag("SwtchOrdrDtls")]
    public required SwitchOrder7 SwitchOrderDetails { get; init; }

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_Aab69TbLEead9bDRE_1DAQ")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation4? CopyDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Aab69zbLEead9bDRE_1DAQ")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since SwitchOrderV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SwitchOrderV04.
