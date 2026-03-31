// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction from an investor to sell investment fund units back to the fund.
/// </summary>
[IsoId("_SE84Utp-Ed-ak6NoX_4Aeg_-1277150734")]
[DisplayName("Redemption Bulk Order")]
public record RedemptionBulkOrder4
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    [IsoId("_SE84U9p-Ed-ak6NoX_4Aeg_-1277150708")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("_SE84VNp-Ed-ak6NoX_4Aeg_-1277150692")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification1Choice_? PlaceOfTrade { get; init; }

    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    [IsoId("_SE84Vdp-Ed-ak6NoX_4Aeg_-1277150674")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OrderDateTime { get; init; }

    /// <summary>
    /// Date on which the order expires.
    /// </summary>
    [IsoId("_SE84Vtp-Ed-ak6NoX_4Aeg_-1277150401")]
    [DisplayName("Expiry Date Time")]
    [IsoXmlTag("XpryDtTm")]
    public DateAndDateTimeChoice_? ExpiryDateTime { get; init; }

    /// <summary>
    /// Future date at which the investor requests the order to be executed.|The specification of a requested future trade date is not allowed in some markets. The date must be a date in the future.
    /// </summary>
    [IsoId("_SE84V9p-Ed-ak6NoX_4Aeg_-111492755")]
    [DisplayName("Requested Future Trade Date")]
    [IsoXmlTag("ReqdFutrTradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedFutureTradeDate { get; init; }

    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_SE84WNp-Ed-ak6NoX_4Aeg_-1277150384")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1Code? CancellationRight { get; init; }

    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_SE84Wdp-Ed-ak6NoX_4Aeg_-1277150366")]
    [DisplayName("Extended Cancellation Right")]
    [IsoXmlTag("XtndedCxlRght")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoExtended350Code? ExtendedCancellationRight { get; init; }

    /// <summary>
    /// Investment fund class related to an order.
    /// </summary>
    [IsoId("_SE84Wtp-Ed-ak6NoX_4Aeg_-1277150245")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument10 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Instruction from an investor to sell investment fund units back to the fund.
    /// </summary>
    [IsoId("_SE84W9p-Ed-ak6NoX_4Aeg_-1277150269")]
    [DisplayName("Individual Order Details")]
    [IsoXmlTag("IndvOrdrDtls")]
    public ValueList<RedemptionOrder7> IndividualOrderDetails { get; init; } = [];

    // ID for the above is _SE84W9p-Ed-ak6NoX_4Aeg_-1277150269

    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_SFGpUNp-Ed-ak6NoX_4Aeg_-1277150349")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_SFGpUdp-Ed-ak6NoX_4Aeg_-1277150306")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the multiple order.
    /// </summary>
    [IsoId("_SFGpUtp-Ed-ak6NoX_4Aeg_1069920397")]
    [DisplayName("Total Settlement Amount")]
    [IsoXmlTag("TtlSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalSettlementAmount { get; init; }

    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_SFGpU9p-Ed-ak6NoX_4Aeg_1069920474")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CashSettlementDate { get; init; }

    /// <summary>
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_SFGpVNp-Ed-ak6NoX_4Aeg_-1277150210")]
    [DisplayName("Bulk Cash Settlement Details")]
    [IsoXmlTag("BlkCshSttlmDtls")]
    public PaymentTransaction21? BulkCashSettlementDetails { get; init; }
}
