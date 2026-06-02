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
[IsoId("9a000949-ebff-4c34-b739-60976197b1fb")]
[DisplayName("Financial Instrument112")]
public record FinancialInstrument112
{
    /// <summary>
    /// Identification of the line of holding in the portfolio.
    /// </summary>
    [IsoId("734dc235-97bd-4938-b9db-6bbcd03a2a2a")]
    [DisplayName("Line Identification")]
    [IsoXmlTag("LineId")]
    public IsoMax35Text? LineIdentification { get; init; }

    /// <summary>
    /// Identification of the asset.
    /// </summary>
    [IsoId("393d0124-7bc2-4c67-9a2a-727cd1bf9fd5")]
    [DisplayName("Instrument")]
    [IsoXmlTag("Instrm")]
    public required FinancialInstrument103Choice Instrument { get; init; }

    /// <summary>
    /// Quantity of asset transferred.
    /// </summary>
    [IsoId("20dc87be-0c5d-483d-87ca-b8eba3146043")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public Quantity54? Quantity { get; init; }

    /// <summary>
    /// Indicates that the quantity of asset transferred is a partially instructed quantity.
    /// </summary>
    [IsoId("636d7feb-82d5-4bc8-b04e-9f416ccbfb31")]
    [DisplayName("Partial Instructed Quantity")]
    [IsoXmlTag("PrtlInstdQty")]
    public IsoYesNoIndicator? PartialInstructedQuantity { get; init; }

    /// <summary>
    /// Percentage rate of assets transferred, as originally instructed.
    /// </summary>
    [IsoId("742bb955-3e7a-459a-be77-3cde75cea160")]
    [DisplayName("Original Percentage Instructed")]
    [IsoXmlTag("OrgnlPctgInstd")]
    public IsoPercentageRate? OriginalPercentageInstructed { get; init; }

    /// <summary>
    /// Specifies how the financial instrument were transferred.
    /// </summary>
    [IsoId("95b21781-5699-41f8-abba-38a19eb706cc")]
    [DisplayName("Transfer Type")]
    [IsoXmlTag("TrfTp")]
    public required TransferType2Choice TransferType { get; init; }

    /// <summary>
    /// Indicates the asset is a new asset, not previously identified by the transferor party in the account holding discovery process.
    /// </summary>
    [IsoId("e0bbbd22-35e7-4cd6-b5f9-1a1397aeafa1")]
    [DisplayName("Additional Asset")]
    [IsoXmlTag("AddtlAsst")]
    public IsoYesNoIndicator? AdditionalAsset { get; init; }

    /// <summary>
    /// Indicates the asset is no longer available at the transferor party.
    /// </summary>
    [IsoId("e2a430c8-d7cc-4fb8-b42d-1b3d550b7bb1")]
    [DisplayName("Not Available")]
    [IsoXmlTag("NotAvlbl")]
    public IsoYesNoIndicator? NotAvailable { get; init; }

    /// <summary>
    /// Security was converted from another security before transfer.
    /// </summary>
    [IsoId("c594dcd9-af3a-4666-9f53-d3fccea15738")]
    [DisplayName("Conversion")]
    [IsoXmlTag("Convs")]
    public Conversion6? Conversion { get; init; }

    /// <summary>
    /// Breakdown of units.
    /// </summary>
    [IsoId("dce79f07-c851-44e6-ad02-1da687102e43")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public ValueList<Unit14> UnitsDetails { get; init; } = [];

    /// <summary>
    /// Unique and unambiguous investor's identification of the transfer.
    /// </summary>
    [IsoId("9ff0155f-955e-4366-9e2b-90f4a62e553d")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("219bb31b-6839-481b-9d65-b78eefbbbe6b")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference10? CounterpartyReference { get; init; }

    /// <summary>
    /// Business process in which the actors are involved.
    /// </summary>
    [IsoId("9fe3111b-5337-4330-9e79-55308da54a3f")]
    [DisplayName("Business Flow Type")]
    [IsoXmlTag("BizFlowTp")]
    public BusinessFlowType1Code? BusinessFlowType { get; init; }

    /// <summary>
    /// Average cost per share of the security, including all fees.
    /// </summary>
    [IsoId("2fb8ba8a-8b53-4472-b1dc-c2898019ee6d")]
    [DisplayName("Average Acquisition Price")]
    [IsoXmlTag("AvrgAcqstnPric")]
    public ActiveCurrencyAndAmount? AverageAcquisitionPrice { get; init; }

    /// <summary>
    /// Currency to be used to transfer the holdings.
    /// </summary>
    [IsoId("f4308f6a-2926-4804-94ce-9934d347613f")]
    [DisplayName("Transfer Currency")]
    [IsoXmlTag("TrfCcy")]
    public ActiveOrHistoricCurrencyCode? TransferCurrency { get; init; }

    /// <summary>
    /// Net asset on the balance sheet, the total portfolio value minus or plus the unrealised gain or loss.
    /// </summary>
    [IsoId("e7f614d3-e4a6-4279-bd4c-a5569e4a5583")]
    [DisplayName("Total Book Value")]
    [IsoXmlTag("TtlBookVal")]
    public DateAndAmount2? TotalBookValue { get; init; }

    /// <summary>
    /// Original amount paid for the asset at the point of purchase.
    /// </summary>
    [IsoId("07dc1480-14f5-489f-ab3d-b7c9fc91f5d9")]
    [DisplayName("Original Cost")]
    [IsoXmlTag("OrgnlCost")]
    public ActiveCurrencyAnd13DecimalAmount? OriginalCost { get; init; }

    /// <summary>
    /// Date and market value of the asset.
    /// </summary>
    [IsoId("40f2f137-62fe-479d-b796-d568aab623f7")]
    [DisplayName("Latest Valuation")]
    [IsoXmlTag("LatstValtn")]
    public DateAndAmount2? LatestValuation { get; init; }

    /// <summary>
    /// Account held in the name of the party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("644bc90a-aec0-436e-87e2-4f13444dc0de")]
    [DisplayName("Transferee Account")]
    [IsoXmlTag("TrfeeAcct")]
    public Account37? TransfereeAccount { get; init; }

    /// <summary>
    /// Party and account from which the transferor delivered the financial instrument to the transferee.
    /// </summary>
    [IsoId("c3e485ec-9dc7-461e-9ed4-b99b01e63426")]
    [DisplayName("Transferor")]
    [IsoXmlTag("Trfr")]
    public Account37? Transferor { get; init; }

    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("212d4bed-0605-48d0-99bd-367268a60195")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public ValueList<Intermediary43> IntermediaryInformation { get; init; } = [];

    /// <summary>
    /// Date that was requested as the trade date when securities are settled through an ICSD or CSD.
    /// </summary>
    [IsoId("51781afb-300c-4955-9a2e-55ac9632a374")]
    [DisplayName("Requested Trade Date")]
    [IsoXmlTag("ReqdTradDt")]
    public IsoISODate? RequestedTradeDate { get; init; }

    /// <summary>
    /// Date on which the securities were to be exchanged at the ICSD or CSD.
    /// </summary>
    [IsoId("88e8beab-0588-4907-9265-f3f901078926")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    public IsoISODate? RequestedSettlementDate { get; init; }

    /// <summary>
    /// Date and time at which the transfer was executed.
    /// </summary>
    [IsoId("6f40f3e4-a6fe-4ead-8096-9658ca57bc39")]
    [DisplayName("Effective Transfer Date")]
    [IsoXmlTag("FctvTrfDt")]
    public DateAndDateTime2Choice? EffectiveTransferDate { get; init; }

    /// <summary>
    /// Date and time at which the securities were exchanged at the ICSD or CSD.
    /// </summary>
    [IsoId("48ab88ad-3ced-47f8-b9a8-77cd1464759a")]
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public DateAndDateTime2Choice? EffectiveSettlementDate { get; init; }

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("e0b0b17a-612b-4e61-b974-06bd1d062c21")]
    [DisplayName("Payment Details")]
    [IsoXmlTag("PmtDtls")]
    public PaymentInstrument21? PaymentDetails { get; init; }

    /// <summary>
    /// Number of units that have been received (crystallised) or not yet received (uncrystallised) from the fund.
    /// </summary>
    [IsoId("f47b49e5-8447-460b-99af-56de12e8e0ad")]
    [DisplayName("Crystallisation Details")]
    [IsoXmlTag("CrstllstnDtls")]
    public ValueList<Crystallisation2> CrystallisationDetails { get; init; } = [];

    /// <summary>
    /// Date or tax quarter used for the calculation of tax on the asset.
    /// </summary>
    [IsoId("2ef2764e-1af6-410c-87cb-a6896d097841")]
    [DisplayName("Tax Valuation Point")]
    [IsoXmlTag("TaxValtnPt")]
    public Tax36? TaxValuationPoint { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("f7ad8b78-ebba-407b-9e2e-f0a10eef05c1")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public FundSettlementParameters24? SettlementPartiesDetails { get; init; }

    /// <summary>
    /// Indicates whether the assets are held in an individual's own name.
    /// </summary>
    [IsoId("86101889-6a6f-4d0b-806b-ccae9165809a")]
    [DisplayName("Assets Held In Own Name")]
    [IsoXmlTag("AsstsHeldInOwnNm")]
    public IsoYesNoIndicator? AssetsHeldInOwnName { get; init; }

    /// <summary>
    /// Indicates whether the transfer resulted in a change of beneficial owner.
    /// </summary>
    [IsoId("409ecf13-f136-4608-a832-6368e395cd4c")]
    [DisplayName("Transfer Results In Change Of Beneficial Owner")]
    [IsoXmlTag("TrfRsltsInChngOfBnfclOwnr")]
    public IsoYesNoIndicator? TransferResultsInChangeOfBeneficialOwner { get; init; }

    /// <summary>
    /// Additional information about the financial instrument.
    /// </summary>
    [IsoId("716b39e5-e5e7-458f-b3b7-2a83728e03d2")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
