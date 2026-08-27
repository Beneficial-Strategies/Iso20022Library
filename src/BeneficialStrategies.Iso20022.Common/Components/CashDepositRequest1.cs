// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of a cash deposit request.
/// </summary>
[IsoId("_VHpcgOOsEe-NFYIkYc90gw")]
[DisplayName("Cash Deposit Request1")]
public record CashDepositRequest1
{
    /// <summary>
    /// Unique identification for the order.
    /// </summary>
    [IsoId("_lCZqQVDfEfCRhs5qxCujTw")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public required IsoUUIDv4Identifier OrderReference { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the cash sender for the cash deposit.
    /// </summary>
    [IsoId("__6BSEOO0Ee-NFYIkYc90gw")]
    [DisplayName("Cash Sender Reference")]
    [IsoXmlTag("CshSndrRef")]
    public required IsoMax35Text CashSenderReference { get; init; }

    /// <summary>
    /// Indicates whether this message is amending an earlier request message.
    /// Usage: Where the value Yes is indicated the OrderReference and CashSenderReference must remain the same as the original message. Where this element is not used the message is not considered an amendment.
    /// </summary>
    [IsoId("_YtLHQatmEfC6tbn8zOl_iw")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    public IsoYesNoIndicator? AmendmentIndicator { get; init; }

    /// <summary>
    /// Date on which the cash sender expects the cash to arrive at the cash receiver and be credited to their account.
    /// </summary>
    [IsoId("_NjfqYeOzEe-NFYIkYc90gw")]
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    public required IsoISODate ExpectedValueDate { get; init; }

    /// <summary>
    /// Unambiguous identification of the account to which cash will be deposited.
    /// </summary>
    [IsoId("_2hG7kOOsEe-NFYIkYc90gw")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount43 Account { get; init; }

    /// <summary>
    /// Provides the details of a cash deposit for an amount of money in cash notes and/or coins.
    /// </summary>
    [IsoId("_ljtJ0OOtEe-NFYIkYc90gw")]
    [DisplayName("Cash Deposit")]
    [IsoXmlTag("CshDpst")]
    public required CashBreakdown1 CashDeposit { get; init; }

    /// <summary>
    /// Specifies the delivery method for the cash deposit.
    /// </summary>
    [IsoId("_KTUacOOwEe-NFYIkYc90gw")]
    [DisplayName("Delivery Method")]
    [IsoXmlTag("DlvryMtd")]
    public required CashDeliveryMethod1Choice_ DeliveryMethod { get; init; }

    /// <summary>
    /// Specifies the address to which the cash desposit is delivered to.
    /// </summary>
    [IsoId("_zC3NsUBfEfCGo6pGJ7j7Eg")]
    [DisplayName("Delivery Address")]
    [IsoXmlTag("DlvryAdr")]
    public PostalAddress27? DeliveryAddress { get; init; }

    /// <summary>
    /// Party that is bringing the cash to be deposited.
    /// </summary>
    [IsoId("_ggdlYUITEfCzH9mu34Pawg")]
    [DisplayName("Deposit Contact")]
    [IsoXmlTag("DpstCtct")]
    public ValueList<Contact13> DepositContact { get; init; } = [];

    /// <summary>
    /// Identification of the secure carrier.
    /// </summary>
    [IsoId("_t40oYOOyEe-NFYIkYc90gw")]
    [DisplayName("Secure Carrier Name")]
    [IsoXmlTag("ScrCrrierNm")]
    public IsoMax70Text? SecureCarrierName { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the secure carrier for the deposit.
    /// </summary>
    [IsoId("_Xj1RcOO0Ee-NFYIkYc90gw")]
    [DisplayName("Secure Carrier Reference")]
    [IsoXmlTag("ScrCrrierRef")]
    public IsoMax35Text? SecureCarrierReference { get; init; }

    /// <summary>
    /// Indicates whether the deposit in transit is insured.
    /// Usage: where this element is not used, the deposit is not insured.
    /// </summary>
    [IsoId("_8vR-8OO1Ee-NFYIkYc90gw")]
    [DisplayName("Insurance Indicator")]
    [IsoXmlTag("InsrncInd")]
    public IsoYesNoIndicator? InsuranceIndicator { get; init; }

    /// <summary>
    /// Further details of the cash deposit.
    /// </summary>
    [IsoId("_QEGekOO2Ee-NFYIkYc90gw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public IsoMax500Text? AdditionalInformation { get; init; }
}
