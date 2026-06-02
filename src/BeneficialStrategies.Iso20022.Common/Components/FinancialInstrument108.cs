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
[IsoId("8a098069-297e-408e-9145-6bd64ae106a9")]
[DisplayName("Financial Instrument108")]
public record FinancialInstrument108
{
    /// <summary>
    /// Identification of the line of holding in the portfolio.
    /// </summary>
    [IsoId("d5ef4fd2-151b-47e1-bf36-555fd5fd1303")]
    [DisplayName("Line Identification")]
    [IsoXmlTag("LineId")]
    public IsoMax35Text? LineIdentification { get; init; }

    /// <summary>
    /// Identification of the asset.
    /// </summary>
    [IsoId("8ad0720c-49ab-408a-8c41-2a619e3b6736")]
    [DisplayName("Instrument")]
    [IsoXmlTag("Instrm")]
    public required FinancialInstrument101Choice Instrument { get; init; }

    /// <summary>
    /// Quantity of asset to be transferred.
    /// </summary>
    [IsoId("46f7fcfa-014b-4da9-a42f-eb3729acc675")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public Quantity53? Quantity { get; init; }

    /// <summary>
    /// Indicates that the quantity of asset to be transferred is a partially instructed quantity.
    /// </summary>
    [IsoId("fd718efc-6f8f-42ac-b7aa-1dd3c62f003a")]
    [DisplayName("Partial Instructed Quantity")]
    [IsoXmlTag("PrtlInstdQty")]
    public IsoYesNoIndicator? PartialInstructedQuantity { get; init; }

    /// <summary>
    /// Specifies how the financial instrument is transferred.
    /// </summary>
    [IsoId("7ebc921e-8415-4a46-916a-24ed6428221d")]
    [DisplayName("Transfer Type")]
    [IsoXmlTag("TrfTp")]
    public required TransferType2Choice TransferType { get; init; }

    /// <summary>
    /// Indicates the asset is a new asset, not previously identified by the transferor party in the account holding discovery process.
    /// </summary>
    [IsoId("7fdb3589-8f5b-4596-b5d7-3db816bf7924")]
    [DisplayName("Additional Asset")]
    [IsoXmlTag("AddtlAsst")]
    public IsoYesNoIndicator? AdditionalAsset { get; init; }

    /// <summary>
    /// Indicates the asset is no longer available at the transferor party.
    /// </summary>
    [IsoId("6d669113-bef0-43a1-9173-1eff8573aee1")]
    [DisplayName("Not Available")]
    [IsoXmlTag("NotAvlbl")]
    public IsoYesNoIndicator? NotAvailable { get; init; }

    /// <summary>
    /// Security is to be converted into another security before transfer.
    /// </summary>
    [IsoId("23c18428-42fa-4dcc-8679-5afd21d8ce13")]
    [DisplayName("Conversion")]
    [IsoXmlTag("Convs")]
    public Conversion5? Conversion { get; init; }

    /// <summary>
    /// Breakdown of units.
    /// </summary>
    [IsoId("233fca19-3cc1-48fc-8a6f-8548e65e5d44")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public ValueList<Unit14> UnitsDetails { get; init; } = [];

    /// <summary>
    /// Unique and unambiguous investor's identification of the transfer.
    /// </summary>
    [IsoId("a4831e1a-cc1b-49b1-ae7d-a3687db2b6a0")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("40ff5048-f9d9-4caf-a032-616fce2dd912")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference10? CounterpartyReference { get; init; }

    /// <summary>
    /// Business process in which the actors are involved.
    /// </summary>
    [IsoId("9cb64f0e-b97f-43d2-978b-648f3803f21a")]
    [DisplayName("Business Flow Type")]
    [IsoXmlTag("BizFlowTp")]
    public BusinessFlowType1Code? BusinessFlowType { get; init; }

    /// <summary>
    /// Average cost per share of the security, including all fees.
    /// </summary>
    [IsoId("d8f8ff87-eb1d-43eb-b152-f789dc153a6d")]
    [DisplayName("Average Acquisition Price")]
    [IsoXmlTag("AvrgAcqstnPric")]
    public ActiveOrHistoricCurrencyAndAmount? AverageAcquisitionPrice { get; init; }

    /// <summary>
    /// Currency to be used to transfer the holdings.
    /// </summary>
    [IsoId("30b69df0-1b29-487b-85e8-12ca06799587")]
    [DisplayName("Transfer Currency")]
    [IsoXmlTag("TrfCcy")]
    public ActiveOrHistoricCurrencyCode? TransferCurrency { get; init; }

    /// <summary>
    /// Net asset on the balance sheet, the total portfolio value minus or plus the unrealised gain or loss.
    /// </summary>
    [IsoId("d0da936b-a64a-4399-8dae-23ff4b1980c3")]
    [DisplayName("Total Book Value")]
    [IsoXmlTag("TtlBookVal")]
    public DateAndAmount2? TotalBookValue { get; init; }

    /// <summary>
    /// Account held in the name of the party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("84090362-b90b-4956-ac60-c62cc471fc03")]
    [DisplayName("Transferee Account")]
    [IsoXmlTag("TrfeeAcct")]
    public Account37? TransfereeAccount { get; init; }

    /// <summary>
    /// Party and account from which the transferor delivers the financial instrument to the transferee.
    /// </summary>
    [IsoId("112a62b0-ca99-46ba-8b8c-a75170c10734")]
    [DisplayName("Transferor")]
    [IsoXmlTag("Trfr")]
    public Account37? Transferor { get; init; }

    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("a33f19b5-9789-469d-8dc9-d5960bd1b52c")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public ValueList<Intermediary43> IntermediaryInformation { get; init; } = [];

    /// <summary>
    /// Date for which the instructing party requests the transfer.
    /// </summary>
    [IsoId("060082ef-f7af-47ab-a1b8-3481b8daf65b")]
    [DisplayName("Requested Transfer Date")]
    [IsoXmlTag("ReqdTrfDt")]
    public IsoISODate? RequestedTransferDate { get; init; }

    /// <summary>
    /// Date to be used as the trade date when securities are settled through an ICSD or CSD.
    /// </summary>
    [IsoId("4f02462b-d70a-4718-a581-3931d0eed4aa")]
    [DisplayName("Requested Trade Date")]
    [IsoXmlTag("ReqdTradDt")]
    public IsoISODate? RequestedTradeDate { get; init; }

    /// <summary>
    /// Date at which the securities are to be exchanged at the ICSD or CSD.
    /// </summary>
    [IsoId("1c5ab094-c3b7-4d57-be02-9b8d465be950")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    public IsoISODate? RequestedSettlementDate { get; init; }

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("feabb0c2-d548-4e64-bf1c-1661c01c5858")]
    [DisplayName("Payment Details")]
    [IsoXmlTag("PmtDtls")]
    public PaymentInstrument22? PaymentDetails { get; init; }

    /// <summary>
    /// Number of units that have been received (crystallised) or not yet received (uncrystallised) from the fund.
    /// </summary>
    [IsoId("c8f6ba70-73aa-40bf-b233-8a1204a111fd")]
    [DisplayName("Crystallisation Details")]
    [IsoXmlTag("CrstllstnDtls")]
    public ValueList<Crystallisation2> CrystallisationDetails { get; init; } = [];

    /// <summary>
    /// Date or tax quarter used for the calculation of tax on the asset.
    /// </summary>
    [IsoId("72768012-b6e4-439d-a1d2-edc6064430fa")]
    [DisplayName("Tax Valuation Point")]
    [IsoXmlTag("TaxValtnPt")]
    public Tax36? TaxValuationPoint { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("5c0f29e0-7a1d-44d3-a1f5-470eca33fc9e")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public FundSettlementParameters24? SettlementPartiesDetails { get; init; }

    /// <summary>
    /// Indicates whether the assets are held in an individual's own name.
    /// </summary>
    [IsoId("76d9f23e-e874-4b8f-9979-b618b895c879")]
    [DisplayName("Assets Held In Own Name")]
    [IsoXmlTag("AsstsHeldInOwnNm")]
    public IsoYesNoIndicator? AssetsHeldInOwnName { get; init; }

    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    [IsoId("494cd4ec-288a-43bc-945f-c29da23bf4e8")]
    [DisplayName("Transfer Results In Change Of Beneficial Owner")]
    [IsoXmlTag("TrfRsltsInChngOfBnfclOwnr")]
    public IsoYesNoIndicator? TransferResultsInChangeOfBeneficialOwner { get; init; }

    /// <summary>
    /// Additional information about the financial instrument.
    /// </summary>
    [IsoId("04f61f55-18f6-46c7-bafb-a6c15611cf24")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
