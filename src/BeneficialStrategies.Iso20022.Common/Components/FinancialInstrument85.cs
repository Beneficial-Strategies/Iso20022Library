// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security or other asset.
/// </summary>
[IsoId("_npD8Z5NBEemQB_8XA98K0Q")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument85
{
    /// <summary>
    /// Identification of the line of holding in the portfolio.
    /// </summary>
    [IsoId("_n_OZmZNBEemQB_8XA98K0Q")]
    [DisplayName("Line Identification")]
    [IsoXmlTag("LineId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LineIdentification { get; init; }

    /// <summary>
    /// Identification of the asset.
    /// </summary>
    [IsoId("_n_OZm5NBEemQB_8XA98K0Q")]
    [DisplayName("Instrument")]
    [IsoXmlTag("Instrm")]
    public required FinancialInstrument62Choice_ Instrument { get; init; }

    /// <summary>
    /// Specifies the quantity of assets to be transferred in units or in a percentage rate.
    /// </summary>
    [IsoId("_n_OZnZNBEemQB_8XA98K0Q")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public Quantity47? Quantity { get; init; }

    /// <summary>
    /// Breakdown of units.
    /// </summary>
    [IsoId("_n_OZn5NBEemQB_8XA98K0Q")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public Unit11? UnitsDetails { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_n_OZoZNBEemQB_8XA98K0Q")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_n_OZo5NBEemQB_8XA98K0Q")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference10? CounterpartyReference { get; init; }

    /// <summary>
    /// Business process in which the actors are involved. This will facilitate the right business process to be triggered, according to the market business model, which may require matching instructions (double leg process) or not (single leg process).
    /// </summary>
    [IsoId("_n_OZpZNBEemQB_8XA98K0Q")]
    [DisplayName("Business Flow Type")]
    [IsoXmlTag("BizFlowTp")]
    public BusinessFlowType1Code? BusinessFlowType { get; init; }

    /// <summary>
    /// Average cost per share of the security, including all fees.
    /// </summary>
    [IsoId("_n_OZp5NBEemQB_8XA98K0Q")]
    [DisplayName("Average Acquisition Price")]
    [IsoXmlTag("AvrgAcqstnPric")]
    public ActiveOrHistoricCurrencyAndAmount? AverageAcquisitionPrice { get; init; }

    /// <summary>
    /// Net asset on the balance sheet, the total portfolio value minus or plus the unrealised gain or loss.
    /// </summary>
    [IsoId("_n_OZqZNBEemQB_8XA98K0Q")]
    [DisplayName("Total Book Value")]
    [IsoXmlTag("TtlBookVal")]
    public DateAndAmount2? TotalBookValue { get; init; }

    /// <summary>
    /// Date and market value of the asset.
    /// </summary>
    [IsoId("_n_OZq5NBEemQB_8XA98K0Q")]
    [DisplayName("Latest Valuation")]
    [IsoXmlTag("LatstValtn")]
    public DateAndAmount2? LatestValuation { get; init; }

    /// <summary>
    /// Account held in the name of the party that is not the name of the beneficial owner of the shares.
    /// (Party and account into which the transferee receives the financial instrument from the transferor.)
    /// </summary>
    [IsoId("_n_OZrZNBEemQB_8XA98K0Q")]
    [DisplayName("Transferee Account")]
    [IsoXmlTag("TrfeeAcct")]
    public Account28? TransfereeAccount { get; init; }

    /// <summary>
    /// Party and account from which the transferor delivers the financial instrument to the transferee.
    /// </summary>
    [IsoId("_n_OZr5NBEemQB_8XA98K0Q")]
    [DisplayName("Transferor")]
    [IsoXmlTag("Trfr")]
    public Account28? Transferor { get; init; }

    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("__UugwaIxEem3ELMJcnCmxA")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public Intermediary43? IntermediaryInformation { get; init; }

    /// <summary>
    /// Number of units that have been received (crystallised) or not yet received (uncrystallised) from the fund. This is typically relevant to a pension fund.
    /// </summary>
    [IsoId("_n_OZsZNBEemQB_8XA98K0Q")]
    [DisplayName("Crystallisation Details")]
    [IsoXmlTag("CrstllstnDtls")]
    public Crystallisation2? CrystallisationDetails { get; init; }

    /// <summary>
    /// Date or tax quarter used for the calculation of tax on the asset.
    /// </summary>
    [IsoId("_n_OZs5NBEemQB_8XA98K0Q")]
    [DisplayName("Tax Valuation Point")]
    [IsoXmlTag("TaxValtnPt")]
    public Tax36? TaxValuationPoint { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("_n_OZtZNBEemQB_8XA98K0Q")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public FundSettlementParameters17? SettlementPartiesDetails { get; init; }

    /// <summary>
    /// Additional information about the financial instrument.
    /// </summary>
    [IsoId("_n_OZt5NBEemQB_8XA98K0Q")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
