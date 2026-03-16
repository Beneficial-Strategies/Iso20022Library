// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the cash option.
/// </summary>
[IsoId("_fwtL-tseEeqmdMJWobugpw")]
[DisplayName("Cash Option")]
public record CashOption76
{
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    [IsoId("_fwtMCNseEeqmdMJWobugpw")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Identification of the account in which cash is maintained.
    /// </summary>
    [IsoId("_fwtMAtseEeqmdMJWobugpw")]
    [DisplayName("Cash Account Identification")]
    [IsoXmlTag("CshAcctId")]
    public CashAccountIdentification5Choice_? CashAccountIdentification { get; init; }

    /// <summary>
    /// Amount of money before any deductions and allowances have been made.
    /// </summary>
    [IsoId("_4QetbNseEeqmdMJWobugpw")]
    [DisplayName("Gross Cash Amount")]
    [IsoXmlTag("GrssCshAmt")]
    public ActiveCurrencyAndAmount? GrossCashAmount { get; init; }

    /// <summary>
    /// Amount of money after deductions and allowances have been made, if any, that is, the total amount +/- charges/fees.
    /// </summary>
    [IsoId("_4QetbdseEeqmdMJWobugpw")]
    [DisplayName("Net Cash Amount")]
    [IsoXmlTag("NetCshAmt")]
    public ActiveCurrencyAndAmount? NetCashAmount { get; init; }

    /// <summary>
    /// Cash amount based on the terms of the corporate action event and balance of underlying securities, entitled to/from account owner (which may be positive or negative).
    /// </summary>
    [IsoId("_4QetbtseEeqmdMJWobugpw")]
    [DisplayName("Entitled Amount")]
    [IsoXmlTag("EntitldAmt")]
    public ActiveCurrencyAndAmount? EntitledAmount { get; init; }

    /// <summary>
    /// Percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_ypu2UdvZEeqmdMJWobugpw")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public RateAndAmountFormat40Choice_? WithholdingTaxRate { get; init; }

    /// <summary>
    /// Amount of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_58kx1NvZEeqmdMJWobugpw")]
    [DisplayName("Withholding Tax Amount")]
    [IsoXmlTag("WhldgTaxAmt")]
    public ActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; }

    /// <summary>
    /// Date/time on which a payment can be made, for example, if the payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_dbTURNvaEeqmdMJWobugpw")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateAndDateTime2Choice_? EarliestPaymentDate { get; init; }

    /// <summary>
    /// Date/time on which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_CkbpdNsfEeqmdMJWobugpw")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public required DateFormat43Choice_ PaymentDate { get; init; }
}
