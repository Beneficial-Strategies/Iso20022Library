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
[IsoId("_aR0KoWbcEembdtOObkYAHQ")]
[DisplayName("Customer Account8")]
public record CustomerAccount8
{
    /// <summary>
    /// Identification of the account.
    /// </summary>
    [IsoId("_afv48WbcEembdtOObkYAHQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public AccountIdentification4Choice_? Identification { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_afv482bcEembdtOObkYAHQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Specifies the current state of an account, eg, enabled or deleted.
    /// </summary>
    [IsoId("_afv49WbcEembdtOObkYAHQ")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public AccountStatus3Code? Status { get; init; }

    /// <summary>
    /// Type of the account.
    /// </summary>
    [IsoId("_afv492bcEembdtOObkYAHQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CashAccountType2Choice_? Type { get; init; }

    /// <summary>
    /// Medium of exchange of value.
    /// </summary>
    [IsoId("_afv4-WbcEembdtOObkYAHQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveCurrencyCode Currency { get; init; }

    /// <summary>
    /// Specifies an alternate assumed name for the identification of the account.
    /// </summary>
    [IsoId("_c5ohcWbcEembdtOObkYAHQ")]
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    public ProxyAccountIdentification1? Proxy { get; init; }

    /// <summary>
    /// Monthly average of the payment amounts (that is, payments going out) over a year.
    /// </summary>
    [IsoId("_afv4-2bcEembdtOObkYAHQ")]
    [DisplayName("Monthly Payment Value")]
    [IsoXmlTag("MnthlyPmtVal")]
    public ImpliedCurrencyAndAmount? MonthlyPaymentValue { get; init; }

    /// <summary>
    /// Monthly average of the received amounts over a year (that is, payments coming in).
    /// </summary>
    [IsoId("_afv4_WbcEembdtOObkYAHQ")]
    [DisplayName("Monthly Received Value")]
    [IsoXmlTag("MnthlyRcvdVal")]
    public ImpliedCurrencyAndAmount? MonthlyReceivedValue { get; init; }

    /// <summary>
    /// Monthly average of the number of payments (coming in and going out) over a year.
    /// </summary>
    [IsoId("_afv4_2bcEembdtOObkYAHQ")]
    [DisplayName("Monthly Transaction Number")]
    [IsoXmlTag("MnthlyTxNb")]
    public IsoMax5NumericText? MonthlyTransactionNumber { get; init; }

    /// <summary>
    /// Sum of the end of day balances over a month divided by the number of business days in the month.
    /// </summary>
    [IsoId("_afv5AWbcEembdtOObkYAHQ")]
    [DisplayName("Average Balance")]
    [IsoXmlTag("AvrgBal")]
    public ImpliedCurrencyAndAmount? AverageBalance { get; init; }

    /// <summary>
    /// Specifies the purpose of the account.
    /// </summary>
    [IsoId("_afv5A2bcEembdtOObkYAHQ")]
    [DisplayName("Account Purpose")]
    [IsoXmlTag("AcctPurp")]
    public IsoMax140Text? AccountPurpose { get; init; }

    /// <summary>
    /// Specifies the value of the balance under which a notification will be sent to the account owner.
    /// </summary>
    [IsoId("_afv5BWbcEembdtOObkYAHQ")]
    [DisplayName("Floor Notification Amount")]
    [IsoXmlTag("FlrNtfctnAmt")]
    public ImpliedCurrencyAndAmount? FloorNotificationAmount { get; init; }

    /// <summary>
    /// Specifies the value of the balance above which a notification will be sent to the account owner.
    /// </summary>
    [IsoId("_afv5B2bcEembdtOObkYAHQ")]
    [DisplayName("Ceiling Notification Amount")]
    [IsoXmlTag("ClngNtfctnAmt")]
    public ImpliedCurrencyAndAmount? CeilingNotificationAmount { get; init; }

    /// <summary>
    /// Specifies how often statements (for audit purposes) will be sent, in which format, to which address.
    /// </summary>
    [IsoId("_afv5CWbcEembdtOObkYAHQ")]
    [DisplayName("Statement Frequency And Format")]
    [IsoXmlTag("StmtFrqcyAndFrmt")]
    public ValueList<StatementFrequencyAndForm1> StatementFrequencyAndFormat { get; init; } = [];

    /// <summary>
    /// Date when the account will be or was closed.
    /// </summary>
    [IsoId("_afv5C2bcEembdtOObkYAHQ")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    public IsoISODate? ClosingDate { get; init; }

    /// <summary>
    /// Restriction on capability or operations allowed.
    /// </summary>
    [IsoId("_afv5DWbcEembdtOObkYAHQ")]
    [DisplayName("Restriction")]
    [IsoXmlTag("Rstrctn")]
    public ValueList<Restriction1> Restriction { get; init; } = [];

    /// <summary>
    /// Date when the account was opened.
    /// </summary>
    [IsoId("_afv5D2bcEembdtOObkYAHQ")]
    [DisplayName("Opening Date")]
    [IsoXmlTag("OpngDt")]
    public IsoISODate? OpeningDate { get; init; }
}
