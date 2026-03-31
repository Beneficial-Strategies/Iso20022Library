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
[IsoId("_r8lEoQ4oEeK3IMoVvcTkkg")]
[DisplayName("Customer Account Modification")]
public record CustomerAccountModification1
{
    /// <summary>
    /// Identification of the account.
    /// </summary>
    [IsoId("_sRvcVQ4oEeK3IMoVvcTkkg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public ValueList<AccountIdentification4Choice_> Identification { get; init; } = [];

    // ID for the above is _sRvcVQ4oEeK3IMoVvcTkkg

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_sRvcXA4oEeK3IMoVvcTkkg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public NameModification1? Name { get; init; }

    /// <summary>
    /// Specifies the current state of an account, eg, enabled or deleted.
    /// </summary>
    [IsoId("_sRvcYw4oEeK3IMoVvcTkkg")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public AccountStatusModification1? Status { get; init; }

    /// <summary>
    /// Type of the account.
    /// </summary>
    [IsoId("_sRvcag4oEeK3IMoVvcTkkg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TypeModification1? Type { get; init; }

    /// <summary>
    /// Medium of exchange of value.
    /// </summary>
    [IsoId("_sRvccQ4oEeK3IMoVvcTkkg")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveCurrencyCode Currency { get; init; }

    /// <summary>
    /// Monthly average of the payment amounts (that is, payments going out) over a year.
    /// </summary>
    [IsoId("_sRvceA4oEeK3IMoVvcTkkg")]
    [DisplayName("Monthly Payment Value")]
    [IsoXmlTag("MnthlyPmtVal")]
    public AmountModification1? MonthlyPaymentValue { get; init; }

    /// <summary>
    /// Monthly average of the received amounts over a year (that is, payments coming in).
    /// </summary>
    [IsoId("_sRvcfw4oEeK3IMoVvcTkkg")]
    [DisplayName("Monthly Received Value")]
    [IsoXmlTag("MnthlyRcvdVal")]
    public AmountModification1? MonthlyReceivedValue { get; init; }

    /// <summary>
    /// Monthly average of the number of payments (coming in and going out) over a year.
    /// </summary>
    [IsoId("_sRvchg4oEeK3IMoVvcTkkg")]
    [DisplayName("Monthly Transaction Number")]
    [IsoXmlTag("MnthlyTxNb")]
    public NumberModification1? MonthlyTransactionNumber { get; init; }

    /// <summary>
    /// Sum of the end of day balances over a month divided by the number of business days in the month.
    /// </summary>
    [IsoId("_sRvcjQ4oEeK3IMoVvcTkkg")]
    [DisplayName("Average Balance")]
    [IsoXmlTag("AvrgBal")]
    public AmountModification1? AverageBalance { get; init; }

    /// <summary>
    /// Specifies the purpose of the account.
    /// </summary>
    [IsoId("_sRvclA4oEeK3IMoVvcTkkg")]
    [DisplayName("Account Purpose")]
    [IsoXmlTag("AcctPurp")]
    public PurposeModification1? AccountPurpose { get; init; }

    /// <summary>
    /// Specifies the value of the balance under which a notification will be sent to the account owner.
    /// </summary>
    [IsoId("_sRvcmw4oEeK3IMoVvcTkkg")]
    [DisplayName("Floor Notification Amount")]
    [IsoXmlTag("FlrNtfctnAmt")]
    public AmountModification1? FloorNotificationAmount { get; init; }

    /// <summary>
    /// Specifies the value of the balance above which a notification will be sent to the account owner.
    /// </summary>
    [IsoId("_sRvcog4oEeK3IMoVvcTkkg")]
    [DisplayName("Ceiling Notification Amount")]
    [IsoXmlTag("ClngNtfctnAmt")]
    public AmountModification1? CeilingNotificationAmount { get; init; }

    /// <summary>
    /// Specifies how often statements (for audit purposes) will be sent, in which format, to which address.
    /// </summary>
    [IsoId("_sRvcqQ4oEeK3IMoVvcTkkg")]
    [DisplayName("Statement Frequency And Format")]
    [IsoXmlTag("StmtFrqcyAndFrmt")]
    public ValueList<StatementFrequencyAndFormModification1> StatementFrequencyAndFormat { get; init; } =
        [];

    /// <summary>
    /// Date when the account will be or was closed.
    /// </summary>
    [IsoId("_sRvcsA4oEeK3IMoVvcTkkg")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    public DateModification1? ClosingDate { get; init; }

    /// <summary>
    /// Restriction on capability or operations allowed.
    /// </summary>
    [IsoId("_sRvctw4oEeK3IMoVvcTkkg")]
    [DisplayName("Restriction")]
    [IsoXmlTag("Rstrctn")]
    public ValueList<RestrictionModification1> Restriction { get; init; } = [];
}
