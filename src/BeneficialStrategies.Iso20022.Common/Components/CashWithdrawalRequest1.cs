// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of a cash withdrawal request.
/// </summary>
[IsoId("_VCI-cOR9Ee-NFYIkYc90gw")]
[DisplayName("Cash Withdrawal Request1")]
public record CashWithdrawalRequest1
{
    /// <summary>
    /// Unique identification for the order.
    /// </summary>
    [IsoId("_m99YAVDfEfCRhs5qxCujTw")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public required IsoUUIDv4Identifier OrderReference { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the cash receiver for the cash withdrawal.
    /// </summary>
    [IsoId("_e0TcGeR9Ee-NFYIkYc90gw")]
    [DisplayName("Cash Receiver Reference")]
    [IsoXmlTag("CshRcvrRef")]
    public required IsoMax35Text CashReceiverReference { get; init; }

    /// <summary>
    /// Indicates whether this message is amending an earlier request message.
    /// Where the value Yes is indicated the OrderReference and CashReceiverReference must remain the same as the original message.
    /// Where this element is not used the message is not considered an amendment.
    /// </summary>
    [IsoId("_MxRV8KtmEfC6tbn8zOl_iw")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    public IsoYesNoIndicator? AmendmentIndicator { get; init; }

    /// <summary>
    /// Date on which the cash receiver requests the cash to be withdrawn from the account.
    /// </summary>
    [IsoId("_e0TcGuR9Ee-NFYIkYc90gw")]
    [DisplayName("Requested Value Date")]
    [IsoXmlTag("ReqdValDt")]
    public required IsoISODate RequestedValueDate { get; init; }

    /// <summary>
    /// Unambiguous identification of the account to which cash will be withdrawn.
    /// </summary>
    [IsoId("_e0TcG-R9Ee-NFYIkYc90gw")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount43 Account { get; init; }

    /// <summary>
    /// Provides the details of a cash withdrawal for an amount of money in cash notes and/or coins.
    /// </summary>
    [IsoId("_e0TcHOR9Ee-NFYIkYc90gw")]
    [DisplayName("Cash Withdrawal")]
    [IsoXmlTag("CshWdrwl")]
    public required CashBreakdown1 CashWithdrawal { get; init; }

    /// <summary>
    /// Specifies the delivery method for the cash withdrawal.
    /// </summary>
    [IsoId("_e0TcHeR9Ee-NFYIkYc90gw")]
    [DisplayName("Delivery Method")]
    [IsoXmlTag("DlvryMtd")]
    public CashDeliveryMethod1Choice_? DeliveryMethod { get; init; }

    /// <summary>
    /// Specifies the address to which the cash withdrawal is delivered to.
    /// </summary>
    [IsoId("_nilv8OR_Ee-NFYIkYc90gw")]
    [DisplayName("Delivery Address")]
    [IsoXmlTag("DlvryAdr")]
    public PostalAddress27? DeliveryAddress { get; init; }

    /// <summary>
    /// Party that is collecting the withdrawn cash.
    /// </summary>
    [IsoId("_5qUmsEBbEfCGo6pGJ7j7Eg")]
    [DisplayName("Withdrawal Contact")]
    [IsoXmlTag("WdrwlCtct")]
    public Contact13? WithdrawalContact { get; init; }

    /// <summary>
    /// Identification of the secure carrier.
    /// </summary>
    [IsoId("_e0TcHuR9Ee-NFYIkYc90gw")]
    [DisplayName("Secure Carrier Name")]
    [IsoXmlTag("ScrCrrierNm")]
    public IsoMax70Text? SecureCarrierName { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the secure carrier for the withdrawal.
    /// </summary>
    [IsoId("_e0TcH-R9Ee-NFYIkYc90gw")]
    [DisplayName("Secure Carrier Reference")]
    [IsoXmlTag("ScrCrrierRef")]
    public IsoMax35Text? SecureCarrierReference { get; init; }

    /// <summary>
    /// Indicates whether the withdrawal in transit is insured.
    /// Where this element is not used the withdrawal is not insured.
    /// </summary>
    [IsoId("_e0TcIOR9Ee-NFYIkYc90gw")]
    [DisplayName("Insurance Indicator")]
    [IsoXmlTag("InsrncInd")]
    public IsoYesNoIndicator? InsuranceIndicator { get; init; }

    /// <summary>
    /// Specifies the address where the cash withdrawal is sent from.
    /// </summary>
    [IsoId("_IsCu4EBbEfCGo6pGJ7j7Eg")]
    [DisplayName("Withdrawal Address")]
    [IsoXmlTag("WdrwlAdr")]
    public PostalAddress27? WithdrawalAddress { get; init; }

    /// <summary>
    /// Further details of the cash withdrawal.
    /// </summary>
    [IsoId("_e0TcIeR9Ee-NFYIkYc90gw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public IsoMax500Text? AdditionalInformation { get; init; }
}
