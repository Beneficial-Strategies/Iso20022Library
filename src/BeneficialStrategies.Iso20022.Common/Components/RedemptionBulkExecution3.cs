// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a redemption order.
/// </summary>
[IsoId("_R2Dgudp-Ed-ak6NoX_4Aeg_-675591954")]
[DisplayName("Redemption Bulk Execution")]
public record RedemptionBulkExecution3
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    [IsoId("_R2Dgutp-Ed-ak6NoX_4Aeg_1336707129")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("_R2MqoNp-Ed-ak6NoX_4Aeg_-675591928")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification1Choice_? PlaceOfTrade { get; init; }

    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    [IsoId("_R2Mqodp-Ed-ak6NoX_4Aeg_-675591876")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OrderDateTime { get; init; }

    /// <summary>
    /// Future date at which the investor requests the order to be executed.|The specification of a requested future trade date is not allowed in some markets. The date must be a date in the future.
    /// </summary>
    [IsoId("_R2Mqotp-Ed-ak6NoX_4Aeg_231134451")]
    [DisplayName("Requested Future Trade Date")]
    [IsoXmlTag("ReqdFutrTradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedFutureTradeDate { get; init; }

    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_R2Mqo9p-Ed-ak6NoX_4Aeg_-675591599")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1Code? CancellationRight { get; init; }

    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_R2MqpNp-Ed-ak6NoX_4Aeg_1556036711")]
    [DisplayName("Extended Cancellation Right")]
    [IsoXmlTag("XtndedCxlRght")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoExtended350Code? ExtendedCancellationRight { get; init; }

    /// <summary>
    /// Investment fund class to which an investment fund order execution is related.
    /// </summary>
    [IsoId("_R2Mqpdp-Ed-ak6NoX_4Aeg_-675591075")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument10 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Execution of a redemption order.
    /// </summary>
    [IsoId("_R2Mqptp-Ed-ak6NoX_4Aeg_-675591477")]
    [DisplayName("Individual Execution Details")]
    [IsoXmlTag("IndvExctnDtls")]
    public ValueList<RedemptionExecution5> IndividualExecutionDetails { get; init; } = [];

    // ID for the above is _R2Mqptp-Ed-ak6NoX_4Aeg_-675591477

    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_R2Mqp9p-Ed-ak6NoX_4Aeg_-675591564")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_R2MqqNp-Ed-ak6NoX_4Aeg_-675591522")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the multiple order.
    /// </summary>
    [IsoId("_R2Mqqdp-Ed-ak6NoX_4Aeg_906795552")]
    [DisplayName("Total Settlement Amount")]
    [IsoXmlTag("TtlSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalSettlementAmount { get; init; }

    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_R2WboNp-Ed-ak6NoX_4Aeg_906795623")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CashSettlementDate { get; init; }

    /// <summary>
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_R2Wbodp-Ed-ak6NoX_4Aeg_1785629760")]
    [DisplayName("Bulk Cash Settlement Details")]
    [IsoXmlTag("BlkCshSttlmDtls")]
    public PaymentTransaction22? BulkCashSettlementDetails { get; init; }
}
