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
[IsoId("_ZpT6delaEeu9cf4XM82AQQ")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument99
{
    /// <summary>
    /// Identification of the line of holding in the portfolio.
    /// </summary>
    [IsoId("_Z-ncB-laEeu9cf4XM82AQQ")]
    [DisplayName("Line Identification")]
    [IsoXmlTag("LineId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LineIdentification { get; init; }

    /// <summary>
    /// Identification of the asset.
    /// </summary>
    [IsoId("_Z-ncCelaEeu9cf4XM82AQQ")]
    [DisplayName("Instrument")]
    [IsoXmlTag("Instrm")]
    public required FinancialInstrument62Choice_ Instrument { get; init; }

    /// <summary>
    /// Specifies the quantity of assets to be transferred in units or in a percentage rate.
    /// </summary>
    [IsoId("_Z-ncC-laEeu9cf4XM82AQQ")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public Quantity47? Quantity { get; init; }

    /// <summary>
    /// Breakdown of units.
    /// </summary>
    [IsoId("_Z-ncDelaEeu9cf4XM82AQQ")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public ValueList<Unit11> UnitsDetails { get; init; } = [];

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_Z-ncD-laEeu9cf4XM82AQQ")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_Z-ncEelaEeu9cf4XM82AQQ")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference10? CounterpartyReference { get; init; }

    /// <summary>
    /// Business process in which the actors are involved. This will facilitate the right business process to be triggered, according to the market business model, which may require matching instructions (double leg process) or not (single leg process).
    /// </summary>
    [IsoId("_Z-ncE-laEeu9cf4XM82AQQ")]
    [DisplayName("Business Flow Type")]
    [IsoXmlTag("BizFlowTp")]
    public BusinessFlowType1Code? BusinessFlowType { get; init; }

    /// <summary>
    /// Average cost per share of the security, including all fees.
    /// </summary>
    [IsoId("_Z-ncFelaEeu9cf4XM82AQQ")]
    [DisplayName("Average Acquisition Price")]
    [IsoXmlTag("AvrgAcqstnPric")]
    public ActiveOrHistoricCurrencyAndAmount? AverageAcquisitionPrice { get; init; }

    /// <summary>
    /// Currency to be used to transfer the holdings. Some transfer agents register holdings grouped by currency in addition to using the ISIN for multi-currency fund shares.
    /// </summary>
    [IsoId("_D7S0IOltEeuvhrZwLF0fDg")]
    [DisplayName("Transfer Currency")]
    [IsoXmlTag("TrfCcy")]
    public ActiveOrHistoricCurrencyCode? TransferCurrency { get; init; }

    /// <summary>
    /// Net asset on the balance sheet, the total portfolio value minus or plus the unrealised gain or loss.
    /// </summary>
    [IsoId("_Z-ncF-laEeu9cf4XM82AQQ")]
    [DisplayName("Total Book Value")]
    [IsoXmlTag("TtlBookVal")]
    public DateAndAmount2? TotalBookValue { get; init; }

    /// <summary>
    /// Date and market value of the asset.
    /// </summary>
    [IsoId("_Z-ncGelaEeu9cf4XM82AQQ")]
    [DisplayName("Latest Valuation")]
    [IsoXmlTag("LatstValtn")]
    public DateAndAmount2? LatestValuation { get; init; }

    /// <summary>
    /// Original amount paid for the asset at the point of purchase. May also be known as the book cost.
    /// </summary>
    [IsoId("_biWDIOlbEeu9cf4XM82AQQ")]
    [DisplayName("Original Cost")]
    [IsoXmlTag("OrgnlCost")]
    public ActiveCurrencyAnd13DecimalAmount? OriginalCost { get; init; }

    /// <summary>
    /// Account held in the name of the party that is not the name of the beneficial owner of the shares.
    /// (Party and account into which the transferee receives the financial instrument from the transferor.)
    /// </summary>
    [IsoId("_Z-ncG-laEeu9cf4XM82AQQ")]
    [DisplayName("Transferee Account")]
    [IsoXmlTag("TrfeeAcct")]
    public Account28? TransfereeAccount { get; init; }

    /// <summary>
    /// Party and account from which the transferor delivers the financial instrument to the transferee.
    /// </summary>
    [IsoId("_Z-ncHelaEeu9cf4XM82AQQ")]
    [DisplayName("Transferor")]
    [IsoXmlTag("Trfr")]
    public ValueList<Account28> Transferor { get; init; } = [];

    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("_Z-ncH-laEeu9cf4XM82AQQ")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public ValueList<Intermediary43> IntermediaryInformation { get; init; } = [];

    /// <summary>
    /// Number of units that have been received (crystallised) or not yet received (uncrystallised) from the fund. This is typically relevant to a pension fund.
    /// </summary>
    [IsoId("_Z-ncIelaEeu9cf4XM82AQQ")]
    [DisplayName("Crystallisation Details")]
    [IsoXmlTag("CrstllstnDtls")]
    public ValueList<Crystallisation2> CrystallisationDetails { get; init; } = [];

    /// <summary>
    /// Date or tax quarter used for the calculation of tax on the asset.
    /// </summary>
    [IsoId("_Z-ncI-laEeu9cf4XM82AQQ")]
    [DisplayName("Tax Valuation Point")]
    [IsoXmlTag("TaxValtnPt")]
    public Tax36? TaxValuationPoint { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("_Z-ncJelaEeu9cf4XM82AQQ")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public ValueList<FundSettlementParameters17> SettlementPartiesDetails { get; init; } = [];

    /// <summary>
    /// Indicates whether the assets are held in an individual’s own name.
    /// </summary>
    [IsoId("_yEvXYOluEeuvhrZwLF0fDg")]
    [DisplayName("Assets Held In Own Name")]
    [IsoXmlTag("AsstsHeldInOwnNm")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AssetsHeldInOwnName { get; init; }

    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    [IsoId("_3AffsOluEeuvhrZwLF0fDg")]
    [DisplayName("Transfer Results In Change Of Beneficial Owner")]
    [IsoXmlTag("TrfRsltsInChngOfBnfclOwnr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TransferResultsInChangeOfBeneficialOwner { get; init; }

    /// <summary>
    /// Additional information about the financial instrument.
    /// </summary>
    [IsoId("_Z-ncJ-laEeu9cf4XM82AQQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
