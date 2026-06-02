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
[IsoId("5ba6817b-cbf7-47b3-a95b-26642c68ace3")]
[DisplayName("Financial Instrument109")]
public record FinancialInstrument109
{
    /// <summary>
    /// Identification of the line of holding in the portfolio.
    /// </summary>
    [IsoId("87dc2b87-a28b-4fb5-bf4b-69a2b6203b27")]
    [DisplayName("Line Identification")]
    [IsoXmlTag("LineId")]
    public IsoMax35Text? LineIdentification { get; init; }

    /// <summary>
    /// Identification of the asset.
    /// </summary>
    [IsoId("f926a2fb-aaca-4d37-9518-db4f3f48262d")]
    [DisplayName("Instrument")]
    [IsoXmlTag("Instrm")]
    public required FinancialInstrument101Choice Instrument { get; init; }

    /// <summary>
    /// Quantity of asset transferred or to be transferred.
    /// </summary>
    [IsoId("3eaf3c76-f61d-4852-902d-0d98f20e57b7")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public Quantity53? Quantity { get; init; }

    /// <summary>
    /// Indicates that the quantity of asset to be transferred is a partially instructed quantity.
    /// </summary>
    [IsoId("9454148c-89d9-4a52-b26e-e33e59a6867e")]
    [DisplayName("Partial Instructed Quantity")]
    [IsoXmlTag("PrtlInstdQty")]
    public IsoYesNoIndicator? PartialInstructedQuantity { get; init; }

    /// <summary>
    /// Percentage rate of assets to be transferred or transferred, as originally instructed.
    /// </summary>
    [IsoId("8f6d584c-7292-48eb-a047-c507596b305f")]
    [DisplayName("Original Percentage Instructed")]
    [IsoXmlTag("OrgnlPctgInstd")]
    public IsoPercentageRate? OriginalPercentageInstructed { get; init; }

    /// <summary>
    /// Specifies how the financial instrument is transferred.
    /// </summary>
    [IsoId("eac28858-9d22-42cc-bf8b-abbb80828479")]
    [DisplayName("Transfer Type")]
    [IsoXmlTag("TrfTp")]
    public required TransferType2Choice TransferType { get; init; }

    /// <summary>
    /// Indicates the asset is a new asset, not previously identified by the transferor party in the account holding discovery process.
    /// </summary>
    [IsoId("a173bc94-2a59-4794-a8e3-443ba114b022")]
    [DisplayName("Additional Asset")]
    [IsoXmlTag("AddtlAsst")]
    public IsoYesNoIndicator? AdditionalAsset { get; init; }

    /// <summary>
    /// Indicates the asset is no longer available at the transferor party.
    /// </summary>
    [IsoId("75a8794c-e198-42a0-b8d3-aadda2aa7cbf")]
    [DisplayName("Not Available")]
    [IsoXmlTag("NotAvlbl")]
    public IsoYesNoIndicator? NotAvailable { get; init; }

    /// <summary>
    /// Security is to be converted into another security before transfer.
    /// </summary>
    [IsoId("e66b4c65-a931-4baf-b370-29d9f50ebd71")]
    [DisplayName("Conversion")]
    [IsoXmlTag("Convs")]
    public Conversion5? Conversion { get; init; }

    /// <summary>
    /// Breakdown of units.
    /// </summary>
    [IsoId("cef011e8-ccfb-412b-92ed-432e6de6a6e9")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public ValueList<Unit14> UnitsDetails { get; init; } = [];

    /// <summary>
    /// Unique and unambiguous investor's identification of the transfer.
    /// </summary>
    [IsoId("2d795d34-0cff-49ba-b396-73c6b3611ee0")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("dfadc5d0-4de9-4748-8e36-395722da5847")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference10? CounterpartyReference { get; init; }

    /// <summary>
    /// Business process in which the actors are involved.
    /// </summary>
    [IsoId("e4d0733d-788f-4ca3-b7fd-b272498e75aa")]
    [DisplayName("Business Flow Type")]
    [IsoXmlTag("BizFlowTp")]
    public BusinessFlowType1Code? BusinessFlowType { get; init; }

    /// <summary>
    /// Average cost per share of the security, including all fees.
    /// </summary>
    [IsoId("b0e365b2-8ebc-4a4a-9765-3dc942ddb6af")]
    [DisplayName("Average Acquisition Price")]
    [IsoXmlTag("AvrgAcqstnPric")]
    public ActiveCurrencyAndAmount? AverageAcquisitionPrice { get; init; }

    /// <summary>
    /// Currency to be used to transfer the holdings.
    /// </summary>
    [IsoId("c51b4a45-d9a3-4e23-8479-27e3f6bf3d85")]
    [DisplayName("Transfer Currency")]
    [IsoXmlTag("TrfCcy")]
    public ActiveOrHistoricCurrencyCode? TransferCurrency { get; init; }

    /// <summary>
    /// Net asset on the balance sheet, the total portfolio value minus or plus the unrealised gain or loss.
    /// </summary>
    [IsoId("6d2179d5-52ff-4a3a-baf1-cd1f50212917")]
    [DisplayName("Total Book Value")]
    [IsoXmlTag("TtlBookVal")]
    public DateAndAmount2? TotalBookValue { get; init; }

    /// <summary>
    /// Original amount paid for the asset at the point of purchase.
    /// </summary>
    [IsoId("352d0573-72c9-4ec7-8152-fb5c571d7c14")]
    [DisplayName("Original Cost")]
    [IsoXmlTag("OrgnlCost")]
    public ActiveCurrencyAnd13DecimalAmount? OriginalCost { get; init; }

    /// <summary>
    /// Date and market value of the asset.
    /// </summary>
    [IsoId("51f20519-66da-418c-9b90-afc88b83bfe1")]
    [DisplayName("Latest Valuation")]
    [IsoXmlTag("LatstValtn")]
    public DateAndAmount2? LatestValuation { get; init; }

    /// <summary>
    /// Account held in the name of the party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("27ef1c7c-a412-4819-9d90-ee3139fdb977")]
    [DisplayName("Transferee Account")]
    [IsoXmlTag("TrfeeAcct")]
    public Account37? TransfereeAccount { get; init; }

    /// <summary>
    /// Party and account from which the transferor delivers the financial instrument to the transferee.
    /// </summary>
    [IsoId("42c9e204-3a78-4780-ac30-fcfb1312ea51")]
    [DisplayName("Transferor")]
    [IsoXmlTag("Trfr")]
    public Account37? Transferor { get; init; }

    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("fa416f06-8cc6-4a0a-ad4a-7dfeab1d8eb2")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public ValueList<Intermediary43> IntermediaryInformation { get; init; } = [];

    /// <summary>
    /// Date to be used as the trade date when securities are settled through an ICSD or CSD.
    /// </summary>
    [IsoId("f47405f9-7c88-48f1-ab01-6514e04f0fb3")]
    [DisplayName("Requested Trade Date")]
    [IsoXmlTag("ReqdTradDt")]
    public IsoISODate? RequestedTradeDate { get; init; }

    /// <summary>
    /// Date on which the securities are to be exchanged at the ICSD or CSD.
    /// </summary>
    [IsoId("7d073be3-af95-421b-8952-5d93473e13f0")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    public IsoISODate? RequestedSettlementDate { get; init; }

    /// <summary>
    /// Date and time at which the transfer was executed.
    /// </summary>
    [IsoId("575ab863-e90e-40e4-8c7b-92070d3b9205")]
    [DisplayName("Effective Transfer Date")]
    [IsoXmlTag("FctvTrfDt")]
    public DateAndDateTime2Choice? EffectiveTransferDate { get; init; }

    /// <summary>
    /// Date and time at which the securities were exchanged at the ICSD or CSD.
    /// </summary>
    [IsoId("f4def9dd-5c3d-43d4-be11-11e5ee9b8f5a")]
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public DateAndDateTime2Choice? EffectiveSettlementDate { get; init; }

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("b7bc77be-6fcf-4e75-b3d0-a81f5572112b")]
    [DisplayName("Payment Details")]
    [IsoXmlTag("PmtDtls")]
    public PaymentInstrument22? PaymentDetails { get; init; }

    /// <summary>
    /// Number of units that have been received (crystallised) or not yet received (uncrystallised) from the fund.
    /// </summary>
    [IsoId("bc38320c-6727-44fa-87c4-a3d8a162d762")]
    [DisplayName("Crystallisation Details")]
    [IsoXmlTag("CrstllstnDtls")]
    public ValueList<Crystallisation2> CrystallisationDetails { get; init; } = [];

    /// <summary>
    /// Date or tax quarter used for the calculation of tax on the asset.
    /// </summary>
    [IsoId("b9a39e0a-e1e5-41f4-8a02-c62bfb52439b")]
    [DisplayName("Tax Valuation Point")]
    [IsoXmlTag("TaxValtnPt")]
    public Tax36? TaxValuationPoint { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("8ea2a184-b289-445c-ae59-b11544ccff2d")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public FundSettlementParameters24? SettlementPartiesDetails { get; init; }

    /// <summary>
    /// Indicates whether the assets are held in an individual's own name.
    /// </summary>
    [IsoId("4a341c12-4cd7-4953-aff0-d13d7a6b706d")]
    [DisplayName("Assets Held In Own Name")]
    [IsoXmlTag("AsstsHeldInOwnNm")]
    public IsoYesNoIndicator? AssetsHeldInOwnName { get; init; }

    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    [IsoId("0abd7e2b-5298-4c9c-b048-9162fcd80288")]
    [DisplayName("Transfer Results In Change Of Beneficial Owner")]
    [IsoXmlTag("TrfRsltsInChngOfBnfclOwnr")]
    public IsoYesNoIndicator? TransferResultsInChangeOfBeneficialOwner { get; init; }

    /// <summary>
    /// Additional information about the financial instrument.
    /// </summary>
    [IsoId("c3f94bc0-a2fd-4eb4-ad9f-1c6e6e6d8f75")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
