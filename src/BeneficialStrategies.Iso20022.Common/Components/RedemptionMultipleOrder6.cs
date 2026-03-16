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
[IsoId("_7RE7JTbsEead9bDRE_1DAQ")]
[DisplayName("Redemption Multiple Order")]
public record RedemptionMultipleOrder6
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    [IsoId("_7rQ8vTbsEead9bDRE_1DAQ")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("_7rQ8vzbsEead9bDRE_1DAQ")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification1Choice_? PlaceOfTrade { get; init; }

    /// <summary>
    /// Date and time the order is placed by the investor or its agent.
    /// </summary>
    [IsoId("_7rQ8wTbsEead9bDRE_1DAQ")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OrderDateTime { get; init; }

    /// <summary>
    /// Date on which the order expires.
    /// </summary>
    [IsoId("_7rQ8wzbsEead9bDRE_1DAQ")]
    [DisplayName("Expiry Date Time")]
    [IsoXmlTag("XpryDtTm")]
    public DateAndDateTimeChoice_? ExpiryDateTime { get; init; }

    /// <summary>
    /// Future date at which the investor requests the order to be executed.|The specification of a requested future trade date is not allowed in some markets. The date must be a date in the future.
    /// </summary>
    [IsoId("_7rQ8xTbsEead9bDRE_1DAQ")]
    [DisplayName("Requested Future Trade Date")]
    [IsoXmlTag("ReqdFutrTradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedFutureTradeDate { get; init; }

    /// <summary>
    /// Cancellation right of the investor with respect to the investment fund order.
    /// </summary>
    [IsoId("_7rQ8xzbsEead9bDRE_1DAQ")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1Choice_? CancellationRight { get; init; }

    /// <summary>
    /// Account impacted by the investment fund order.
    /// </summary>
    [IsoId("_7rQ8yzbsEead9bDRE_1DAQ")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount58 InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    [IsoId("_7rQ8zTbsEead9bDRE_1DAQ")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public ValueList<IndividualPerson32> BeneficiaryDetails { get; init; } = [];

    /// <summary>
    /// Instruction from an investor to sell investment fund units back to the fund.
    /// </summary>
    [IsoId("_7rQ8zzbsEead9bDRE_1DAQ")]
    [DisplayName("Individual Order Details")]
    [IsoXmlTag("IndvOrdrDtls")]
    public ValueList<RedemptionOrder14> IndividualOrderDetails { get; init; } = [];

    // ID for the above is _7rQ8zzbsEead9bDRE_1DAQ

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_7rQ80TbsEead9bDRE_1DAQ")]
    [DisplayName("Bulk Cash Settlement Details")]
    [IsoXmlTag("BlkCshSttlmDtls")]
    public PaymentTransaction72? BulkCashSettlementDetails { get; init; }

    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the multiple order.
    /// </summary>
    [IsoId("_7rQ80zbsEead9bDRE_1DAQ")]
    [DisplayName("Total Settlement Amount")]
    [IsoXmlTag("TtlSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalSettlementAmount { get; init; }
}
