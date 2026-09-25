// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account owned by a customer.
/// </summary>
[IsoId("_INRP8TFKEe651u5xu3f5iw")]
[DisplayName("Customer Account10")]
public record CustomerAccount10
{
    /// <summary>
    /// Identification of the account.
    /// </summary>
    [IsoId("_IQXAMTFKEe651u5xu3f5iw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public AccountIdentification4Choice_? Identification { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_IQXAMzFKEe651u5xu3f5iw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Specifies the current state of an account, eg, enabled or deleted.
    /// </summary>
    [IsoId("_IQXANTFKEe651u5xu3f5iw")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public AccountStatus3Code? Status { get; init; }

    /// <summary>
    /// Type of the account.
    /// </summary>
    [IsoId("_IQXANzFKEe651u5xu3f5iw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CashAccountType2Choice_? Type { get; init; }

    /// <summary>
    /// Medium of exchange of value.
    /// </summary>
    [IsoId("_IQXAOTFKEe651u5xu3f5iw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Specifies an alternate assumed name for the identification of the account.
    /// </summary>
    [IsoId("_IQXAOzFKEe651u5xu3f5iw")]
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    public ProxyAccountIdentification1? Proxy { get; init; }

    /// <summary>
    /// Minimum monthly average of the payment amounts (that is, payments going out) over a year.
    /// </summary>
    [IsoId("_IQXAPTFKEe651u5xu3f5iw")]
    [DisplayName("Minimum Monthly Payment Value")]
    [IsoXmlTag("MinMnthlyPmtVal")]
    public ImpliedCurrencyAndAmount? MinimumMonthlyPaymentValue { get; init; }

    /// <summary>
    /// Maximum monthly average of the payment amounts (that is, payments going out) over a year.
    /// </summary>
    [IsoId("_IQXAPzFKEe651u5xu3f5iw")]
    [DisplayName("Maximum Monthly Payment Value")]
    [IsoXmlTag("MaxMnthlyPmtVal")]
    public ImpliedCurrencyAndAmount? MaximumMonthlyPaymentValue { get; init; }

    /// <summary>
    /// Minimum monthly average of the received amounts over a year (that is, payments coming in).
    /// </summary>
    [IsoId("_IQXAQTFKEe651u5xu3f5iw")]
    [DisplayName("Minimum Monthly Received Value")]
    [IsoXmlTag("MinMnthlyRcvdVal")]
    public ImpliedCurrencyAndAmount? MinimumMonthlyReceivedValue { get; init; }

    /// <summary>
    /// Maximum monthly average of the received amounts over a year (that is, payments coming in).
    /// </summary>
    [IsoId("_IQXAQzFKEe651u5xu3f5iw")]
    [DisplayName("Maximum Monthly Received Value")]
    [IsoXmlTag("MaxMnthlyRcvdVal")]
    public ImpliedCurrencyAndAmount? MaximumMonthlyReceivedValue { get; init; }

    /// <summary>
    /// Minimum monthly average of the number of payments (coming in and going out) over a year.
    /// </summary>
    [IsoId("_IQXARTFKEe651u5xu3f5iw")]
    [DisplayName("Minimum Monthly Transaction Number")]
    [IsoXmlTag("MinMnthlyTxNb")]
    public IsoMax5NumericText? MinimumMonthlyTransactionNumber { get; init; }

    /// <summary>
    /// Maximum monthly average of the number of payments (coming in and going out) over a year.
    /// </summary>
    [IsoId("_IQXARzFKEe651u5xu3f5iw")]
    [DisplayName("Maximum Monthly Transaction Number")]
    [IsoXmlTag("MaxMnthlyTxNb")]
    public IsoMax5NumericText? MaximumMonthlyTransactionNumber { get; init; }

    /// <summary>
    /// Minimum average balance, that is, sum of the end of day balances over a month divided by the number of business days in the month.
    /// </summary>
    [IsoId("_IQXASTFKEe651u5xu3f5iw")]
    [DisplayName("Minimum Average Balance")]
    [IsoXmlTag("MinAvrgBal")]
    public ImpliedCurrencyAndAmount? MinimumAverageBalance { get; init; }

    /// <summary>
    /// Maximum average balance, that is, sum of the end of day balances over a month divided by the number of business days in the month.
    /// </summary>
    [IsoId("_IQXASzFKEe651u5xu3f5iw")]
    [DisplayName("Maximum Average Balance")]
    [IsoXmlTag("MaxAvrgBal")]
    public ImpliedCurrencyAndAmount? MaximumAverageBalance { get; init; }

    /// <summary>
    /// Specifies the purpose of the account.
    /// </summary>
    [IsoId("_IQXATTFKEe651u5xu3f5iw")]
    [DisplayName("Account Purpose")]
    [IsoXmlTag("AcctPurp")]
    public IsoMax140Text? AccountPurpose { get; init; }

    /// <summary>
    /// Minimum floor notification amount, that is, the value of the balance under which a notification will be sent to the account owner.
    /// </summary>
    [IsoId("_IQXATzFKEe651u5xu3f5iw")]
    [DisplayName("Minimum Floor Notification Amount")]
    [IsoXmlTag("MinFlrNtfctnAmt")]
    public ImpliedCurrencyAndAmount? MinimumFloorNotificationAmount { get; init; }

    /// <summary>
    /// Maximum floor notification amount, that is, the value of the balance under which a notification will be sent to the account owner.
    /// </summary>
    [IsoId("_IQXAUTFKEe651u5xu3f5iw")]
    [DisplayName("Maximum Floor Notification Amount")]
    [IsoXmlTag("MaxFlrNtfctnAmt")]
    public ImpliedCurrencyAndAmount? MaximumFloorNotificationAmount { get; init; }

    /// <summary>
    /// Minimum ceiling notification amount, that is, the value of the balance above which a notification will be sent to the account owner.
    /// </summary>
    [IsoId("_IQXAUzFKEe651u5xu3f5iw")]
    [DisplayName("Minimum Ceiling Notification Amount")]
    [IsoXmlTag("MinClngNtfctnAmt")]
    public ImpliedCurrencyAndAmount? MinimumCeilingNotificationAmount { get; init; }

    /// <summary>
    /// Maximum ceiling notification amount, that is, the value of the balance above which a notification will be sent to the account owner.
    /// </summary>
    [IsoId("_IQXAVTFKEe651u5xu3f5iw")]
    [DisplayName("Maximum Ceiling Notification Amount")]
    [IsoXmlTag("MaxClngNtfctnAmt")]
    public ImpliedCurrencyAndAmount? MaximumCeilingNotificationAmount { get; init; }

    /// <summary>
    /// Specifies how often statements (for audit purposes) will be sent, in which format, to which address.
    /// </summary>
    [IsoId("_IQXAVzFKEe651u5xu3f5iw")]
    [DisplayName("Statement Frequency And Format")]
    [IsoXmlTag("StmtFrqcyAndFrmt")]
    public ValueList<StatementFrequencyAndForm1> StatementFrequencyAndFormat { get; init; } = [];

    /// <summary>
    /// Restriction on capability or operations allowed.
    /// </summary>
    [IsoId("_IQXAWTFKEe651u5xu3f5iw")]
    [DisplayName("Restriction")]
    [IsoXmlTag("Rstrctn")]
    public ValueList<Restriction1> Restriction { get; init; } = [];

    /// <summary>
    /// Date when the account will be or was closed.
    /// </summary>
    [IsoId("_IQXAWzFKEe651u5xu3f5iw")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    public DatePeriodSearch1Choice_? ClosingDate { get; init; }

    /// <summary>
    /// Date when the account was opened.
    /// </summary>
    [IsoId("_IQXAXTFKEe651u5xu3f5iw")]
    [DisplayName("Opening Date")]
    [IsoXmlTag("OpngDt")]
    public DatePeriodSearch1Choice_? OpeningDate { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the account used as a reference for the opening of another account.
    /// </summary>
    [IsoId("_IQXAXzFKEe651u5xu3f5iw")]
    [DisplayName("Reference Account Identification")]
    [IsoXmlTag("RefAcctId")]
    public AccountIdentification4Choice_? ReferenceAccountIdentification { get; init; }

    /// <summary>
    /// Proprietary characteristics of the account.
    /// </summary>
    [IsoId("_IQXAYTFKEe651u5xu3f5iw")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ValueList<GenericIdentification1> Proprietary { get; init; } = [];

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_IQXAYzFKEe651u5xu3f5iw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public OrganisationIdentification39? AccountOwner { get; init; }
}
