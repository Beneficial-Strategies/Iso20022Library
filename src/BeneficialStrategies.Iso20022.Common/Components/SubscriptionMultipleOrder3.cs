// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Order to invest the investor&apos;s principal in an investment fund.
/// </summary>
[IsoId("_SI0rtdp-Ed-ak6NoX_4Aeg_-1657233942")]
[DisplayName("Subscription Multiple Order")]
public record SubscriptionMultipleOrder3
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    [IsoId("_SI0rttp-Ed-ak6NoX_4Aeg_-1640395419")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("_SI0rt9p-Ed-ak6NoX_4Aeg_-1657233924")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification1Choice_? PlaceOfTrade { get; init; }

    /// <summary>
    /// Date the investor places the order.
    /// </summary>
    [IsoId("_SI0ruNp-Ed-ak6NoX_4Aeg_-1657233907")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OrderDateTime { get; init; }

    /// <summary>
    /// Date on which the order expires.
    /// </summary>
    [IsoId("_SI0rudp-Ed-ak6NoX_4Aeg_-1657233227")]
    [DisplayName("Expiry Date Time")]
    [IsoXmlTag("XpryDtTm")]
    public DateAndDateTimeChoice_? ExpiryDateTime { get; init; }

    /// <summary>
    /// Future date at which the investor requests the order to be executed.|The specification of a requested future trade date is not allowed in some markets. The date must be a date in the future.
    /// </summary>
    [IsoId("_SI0rutp-Ed-ak6NoX_4Aeg_-1920669414")]
    [DisplayName("Requested Future Trade Date")]
    [IsoXmlTag("ReqdFutrTradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedFutureTradeDate { get; init; }

    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_SI0ru9p-Ed-ak6NoX_4Aeg_-1657233150")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1Code? CancellationRight { get; init; }

    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_SI0rvNp-Ed-ak6NoX_4Aeg_-835488278")]
    [DisplayName("Extended Cancellation Right")]
    [IsoXmlTag("XtndedCxlRght")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoExtended350Code? ExtendedCancellationRight { get; init; }

    /// <summary>
    /// Account impacted by an investment fund order.
    /// </summary>
    [IsoId("_SI-csNp-Ed-ak6NoX_4Aeg_-1378171299")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount21 InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Additional information about the beneficial owner.
    /// </summary>
    [IsoId("_SI-csdp-Ed-ak6NoX_4Aeg_1261538301")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public IndividualPerson9? BeneficiaryDetails { get; init; }

    /// <summary>
    /// Order to invest the investor&apos;s principal in an investment fund.
    /// </summary>
    [IsoId("_SI-cstp-Ed-ak6NoX_4Aeg_-1657232934")]
    [DisplayName("Individual Order Details")]
    [IsoXmlTag("IndvOrdrDtls")]
    public ValueList<SubscriptionOrder6> IndividualOrderDetails { get; init; } = [];

    // ID for the above is _SI-cstp-Ed-ak6NoX_4Aeg_-1657232934

    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the multiple order.
    /// </summary>
    [IsoId("_SI-cs9p-Ed-ak6NoX_4Aeg_117301260")]
    [DisplayName("Total Settlement Amount")]
    [IsoXmlTag("TtlSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalSettlementAmount { get; init; }

    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_SI-ctNp-Ed-ak6NoX_4Aeg_117301415")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CashSettlementDate { get; init; }

    /// <summary>
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_SI-ctdp-Ed-ak6NoX_4Aeg_324684110")]
    [DisplayName("Bulk Cash Settlement Details")]
    [IsoXmlTag("BlkCshSttlmDtls")]
    public PaymentTransaction23? BulkCashSettlementDetails { get; init; }
}
