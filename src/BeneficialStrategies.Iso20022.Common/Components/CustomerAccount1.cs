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
[IsoId("_SN5Y99p-Ed-ak6NoX_4Aeg_-1328700496")]
[DisplayName("Customer Account")]
public record CustomerAccount1
{
    /// <summary>
    /// Identification of the account.
    /// </summary>
    [IsoId("_SOCi4Np-Ed-ak6NoX_4Aeg_-366390676")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification4Choice_ Identification { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_SOCi4dp-Ed-ak6NoX_4Aeg_920076371")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Specifies the current state of an account, eg, enabled or deleted.
    /// </summary>
    [IsoId("_SOCi4tp-Ed-ak6NoX_4Aeg_1282094215")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public AccountStatus3Code? Status { get; init; }

    /// <summary>
    /// Type of the account.
    /// </summary>
    [IsoId("_SOCi49p-Ed-ak6NoX_4Aeg_-1326458544")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CashAccountType2? Type { get; init; }

    /// <summary>
    /// Medium of exchange of value.
    /// </summary>
    [IsoId("_SOCi5Np-Ed-ak6NoX_4Aeg_-208999236")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveCurrencyCode Currency { get; init; }

    /// <summary>
    /// Monthly average of the payment amounts (that is, payments going out) over a year.
    /// </summary>
    [IsoId("_SOCi5dp-Ed-ak6NoX_4Aeg_1019281789")]
    [DisplayName("Monthly Payment Value")]
    [IsoXmlTag("MnthlyPmtVal")]
    public ImpliedCurrencyAndAmount? MonthlyPaymentValue { get; init; }

    /// <summary>
    /// Monthly average of the received amounts over a year (that is, payments coming in).
    /// </summary>
    [IsoId("_SOCi5tp-Ed-ak6NoX_4Aeg_2114328915")]
    [DisplayName("Monthly Received Value")]
    [IsoXmlTag("MnthlyRcvdVal")]
    public ImpliedCurrencyAndAmount? MonthlyReceivedValue { get; init; }

    /// <summary>
    /// Monthly average of the number of payments (coming in and going out) over a year.
    /// </summary>
    [IsoId("_SOCi59p-Ed-ak6NoX_4Aeg_1908632472")]
    [DisplayName("Monthly Transaction Number")]
    [IsoXmlTag("MnthlyTxNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? MonthlyTransactionNumber { get; init; }

    /// <summary>
    /// Sum of the end of day balances over a month divided by the number of business days in the month.
    /// </summary>
    [IsoId("_SOCi6Np-Ed-ak6NoX_4Aeg_-161243707")]
    [DisplayName("Average Balance")]
    [IsoXmlTag("AvrgBal")]
    public ImpliedCurrencyAndAmount? AverageBalance { get; init; }

    /// <summary>
    /// Specifies the purpose of the account.
    /// </summary>
    [IsoId("_SOCi6dp-Ed-ak6NoX_4Aeg_-508141557")]
    [DisplayName("Account Purpose")]
    [IsoXmlTag("AcctPurp")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? AccountPurpose { get; init; }

    /// <summary>
    /// Specifies the value of the balance under which a notification will be sent to the account owner.
    /// </summary>
    [IsoId("_SOMT4Np-Ed-ak6NoX_4Aeg_-1030613327")]
    [DisplayName("Floor Notification Amount")]
    [IsoXmlTag("FlrNtfctnAmt")]
    public ImpliedCurrencyAndAmount? FloorNotificationAmount { get; init; }

    /// <summary>
    /// Specifies the value of the balance above which a notification will be sent to the account owner.
    /// </summary>
    [IsoId("_SOMT4dp-Ed-ak6NoX_4Aeg_-317591359")]
    [DisplayName("Ceiling Notification Amount")]
    [IsoXmlTag("ClngNtfctnAmt")]
    public ImpliedCurrencyAndAmount? CeilingNotificationAmount { get; init; }

    /// <summary>
    /// Specifies how often statements (for audit purposes) will be sent.
    /// </summary>
    [IsoId("_SOMT4tp-Ed-ak6NoX_4Aeg_-401791891")]
    [DisplayName("Statement Cycle")]
    [IsoXmlTag("StmtCycl")]
    public Frequency3Code? StatementCycle { get; init; }

    /// <summary>
    /// Date when the account will be or was closed.
    /// </summary>
    [IsoId("_SOMT49p-Ed-ak6NoX_4Aeg_-1192136833")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ClosingDate { get; init; }

    /// <summary>
    /// Restriction on capability or operations allowed.
    /// </summary>
    [IsoId("_SOMT5Np-Ed-ak6NoX_4Aeg_-693438831")]
    [DisplayName("Restriction")]
    [IsoXmlTag("Rstrctn")]
    public ValueList<Restriction1> Restriction { get; init; } = [];
}
