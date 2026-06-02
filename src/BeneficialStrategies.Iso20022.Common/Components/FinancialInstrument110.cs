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
[IsoId("5f293067-925e-4dbc-ae42-ab01fabd043b")]
[DisplayName("Financial Instrument110")]
public record FinancialInstrument110
{
    /// <summary>
    /// Identification of the line of holding in the portfolio.
    /// </summary>
    [IsoId("adf62743-17b9-42a7-99bc-d02b317a3f7b")]
    [DisplayName("Line Identification")]
    [IsoXmlTag("LineId")]
    public IsoMax35Text? LineIdentification { get; init; }

    /// <summary>
    /// Identification of the asset.
    /// </summary>
    [IsoId("19b951e9-1943-40a3-96f4-7685bd704538")]
    [DisplayName("Instrument")]
    [IsoXmlTag("Instrm")]
    public required FinancialInstrument102Choice Instrument { get; init; }

    /// <summary>
    /// Specifies the quantity of assets to be transferred in units or in a percentage rate.
    /// </summary>
    [IsoId("5a8df44d-a247-45a0-96c5-dcfde5d606d9")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public Quantity53? Quantity { get; init; }

    /// <summary>
    /// Breakdown of units.
    /// </summary>
    [IsoId("dcc72cb5-b5e7-4a46-9f82-a008d708badc")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public ValueList<Unit14> UnitsDetails { get; init; } = [];

    /// <summary>
    /// Unique and unambiguous investor's identification of the transfer.
    /// </summary>
    [IsoId("1abe0727-5b32-4501-90e2-d9f175a24840")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("f6216b31-64fa-4953-8b43-3eab4c6dd319")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference10? CounterpartyReference { get; init; }

    /// <summary>
    /// Business process in which the actors are involved.
    /// </summary>
    [IsoId("2f8f842b-5a56-4bd8-b59f-52b55f78f2c5")]
    [DisplayName("Business Flow Type")]
    [IsoXmlTag("BizFlowTp")]
    public BusinessFlowType1Code? BusinessFlowType { get; init; }

    /// <summary>
    /// Average cost per share of the security, including all fees.
    /// </summary>
    [IsoId("8c62f5e0-eb0f-4f2b-b6b7-b9046580af3a")]
    [DisplayName("Average Acquisition Price")]
    [IsoXmlTag("AvrgAcqstnPric")]
    public ActiveOrHistoricCurrencyAndAmount? AverageAcquisitionPrice { get; init; }

    /// <summary>
    /// Currency to be used to transfer the holdings.
    /// </summary>
    [IsoId("86a6cc1b-c8ef-4f8e-b69c-9808cf33d792")]
    [DisplayName("Transfer Currency")]
    [IsoXmlTag("TrfCcy")]
    public ActiveOrHistoricCurrencyCode? TransferCurrency { get; init; }

    /// <summary>
    /// Net asset on the balance sheet, the total portfolio value minus or plus the unrealised gain or loss.
    /// </summary>
    [IsoId("65b26dc5-9fc8-4f13-9932-e472517ab91b")]
    [DisplayName("Total Book Value")]
    [IsoXmlTag("TtlBookVal")]
    public DateAndAmount2? TotalBookValue { get; init; }

    /// <summary>
    /// Date and market value of the asset.
    /// </summary>
    [IsoId("b5b204b2-2f13-4e9e-b20c-719aada48ab1")]
    [DisplayName("Latest Valuation")]
    [IsoXmlTag("LatstValtn")]
    public DateAndAmount2? LatestValuation { get; init; }

    /// <summary>
    /// Original amount paid for the asset at the point of purchase.
    /// </summary>
    [IsoId("24d91d65-9595-4665-b866-a6c47c22981a")]
    [DisplayName("Original Cost")]
    [IsoXmlTag("OrgnlCost")]
    public ActiveCurrencyAnd13DecimalAmount? OriginalCost { get; init; }

    /// <summary>
    /// Account held in the name of the party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("9efa5f3d-18b4-4526-9db6-907243153e68")]
    [DisplayName("Transferee Account")]
    [IsoXmlTag("TrfeeAcct")]
    public Account37? TransfereeAccount { get; init; }

    /// <summary>
    /// Party and account from which the transferor delivers the financial instrument to the transferee.
    /// </summary>
    [IsoId("8ade3a26-f8b3-4fb5-a3ab-489bb5d7aafb")]
    [DisplayName("Transferor")]
    [IsoXmlTag("Trfr")]
    public ValueList<Account37> Transferor { get; init; } = [];

    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("2166f3e5-23b3-44d8-b9ce-d4d22af5e1d0")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public ValueList<Intermediary43> IntermediaryInformation { get; init; } = [];

    /// <summary>
    /// Number of units that have been received (crystallised) or not yet received (uncrystallised) from the fund.
    /// </summary>
    [IsoId("5b8fd0a7-9193-47b7-82bf-aee3b0761d60")]
    [DisplayName("Crystallisation Details")]
    [IsoXmlTag("CrstllstnDtls")]
    public ValueList<Crystallisation2> CrystallisationDetails { get; init; } = [];

    /// <summary>
    /// Date or tax quarter used for the calculation of tax on the asset.
    /// </summary>
    [IsoId("54fcae6a-76f3-41f4-a01b-1531d5644c14")]
    [DisplayName("Tax Valuation Point")]
    [IsoXmlTag("TaxValtnPt")]
    public Tax36? TaxValuationPoint { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("aa74b197-ef2f-4467-87b7-d432d1f32094")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public ValueList<FundSettlementParameters24> SettlementPartiesDetails { get; init; } = [];

    /// <summary>
    /// Indicates whether the assets are held in an individual's own name.
    /// </summary>
    [IsoId("b6faab0b-3f90-43ff-83cc-e6abb35b642e")]
    [DisplayName("Assets Held In Own Name")]
    [IsoXmlTag("AsstsHeldInOwnNm")]
    public IsoYesNoIndicator? AssetsHeldInOwnName { get; init; }

    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    [IsoId("2d4d6f3c-3a1b-4358-8562-fb778db5e341")]
    [DisplayName("Transfer Results In Change Of Beneficial Owner")]
    [IsoXmlTag("TrfRsltsInChngOfBnfclOwnr")]
    public IsoYesNoIndicator? TransferResultsInChangeOfBeneficialOwner { get; init; }

    /// <summary>
    /// Additional information about the financial instrument.
    /// </summary>
    [IsoId("9cd8d181-460b-49ba-a519-a3bd1e7c7a7c")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
