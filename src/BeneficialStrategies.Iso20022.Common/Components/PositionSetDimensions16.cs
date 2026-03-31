// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Position Set Dimensions16.
/// </summary>
[IsoId("_jRx8FRTjEe61h9tfoUrWyw")]
[DisplayName("Position Set Dimensions16")]
public record PositionSetDimensions16
{
    /// <summary>
    /// Asset Class.
    /// </summary>
    [DisplayName("Asset Class")]
    [IsoXmlTag("AsstClss")]
    public ProductType4Code? AssetClass { get; init; }

    /// <summary>
    /// Cleared.
    /// </summary>
    [DisplayName("Cleared")]
    [IsoXmlTag("Clrd")]
    public IsoTrueFalseIndicator? Cleared { get; init; }

    /// <summary>
    /// Collateral.
    /// </summary>
    [DisplayName("Collateral")]
    [IsoXmlTag("Coll")]
    public MarginCollateralReport4? Collateral { get; init; }

    /// <summary>
    /// Commodity.
    /// </summary>
    [DisplayName("Commodity")]
    [IsoXmlTag("Cmmdty")]
    public AssetClassCommodity6Choice_? Commodity { get; init; }

    /// <summary>
    /// Contract Type.
    /// </summary>
    [DisplayName("Contract Type")]
    [IsoXmlTag("CtrctTp")]
    public FinancialInstrumentContractType2Code? ContractType { get; init; }

    /// <summary>
    /// Counterparty Identification.
    /// </summary>
    [DisplayName("Counterparty Identification")]
    [IsoXmlTag("CtrPtyId")]
    public TradeCounterpartyReport20? CounterpartyIdentification { get; init; }

    /// <summary>
    /// Credit.
    /// </summary>
    [DisplayName("Credit")]
    [IsoXmlTag("Cdt")]
    public CreditDerivative7? Credit { get; init; }

    /// <summary>
    /// Exchange Rate Basis.
    /// </summary>
    [DisplayName("Exchange Rate Basis")]
    [IsoXmlTag("XchgRateBsis")]
    public ExchangeRateBasis1Choice_? ExchangeRateBasis { get; init; }

    /// <summary>
    /// Intra Group.
    /// </summary>
    [DisplayName("Intra Group")]
    [IsoXmlTag("IntraGrp")]
    public IsoTrueFalseIndicator? IntraGroup { get; init; }

    /// <summary>
    /// IRS Type.
    /// </summary>
    [DisplayName("IRS Type")]
    [IsoXmlTag("IRSTp")]
    public IsoMax52Text? IRSType { get; init; }

    /// <summary>
    /// Master Agreement.
    /// </summary>
    [DisplayName("Master Agreement")]
    [IsoXmlTag("MstrAgrmt")]
    public MasterAgreement8? MasterAgreement { get; init; }

    /// <summary>
    /// Notional Currency.
    /// </summary>
    [DisplayName("Notional Currency")]
    [IsoXmlTag("NtnlCcy")]
    public ActiveOrHistoricCurrencyCode? NotionalCurrency { get; init; }

    /// <summary>
    /// Notional Currency Second Leg.
    /// </summary>
    [DisplayName("Notional Currency Second Leg")]
    [IsoXmlTag("NtnlCcyScndLeg")]
    public ActiveOrHistoricCurrencyCode? NotionalCurrencySecondLeg { get; init; }

    /// <summary>
    /// Option Type.
    /// </summary>
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public OptionType2Code? OptionType { get; init; }

    /// <summary>
    /// Other Payment.
    /// </summary>
    [DisplayName("Other Payment")]
    [IsoXmlTag("OthrPmt")]
    public OtherPayment6? OtherPayment { get; init; }

    /// <summary>
    /// Settlement Currency.
    /// </summary>
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public ActiveOrHistoricCurrencyCode? SettlementCurrency { get; init; }

    /// <summary>
    /// Settlement Currency Second Leg.
    /// </summary>
    [DisplayName("Settlement Currency Second Leg")]
    [IsoXmlTag("SttlmCcyScndLeg")]
    public ActiveOrHistoricCurrencyCode? SettlementCurrencySecondLeg { get; init; }

    /// <summary>
    /// Time To Maturity.
    /// </summary>
    [DisplayName("Time To Maturity")]
    [IsoXmlTag("TmToMtrty")]
    public TimeToMaturity1Choice_? TimeToMaturity { get; init; }

    /// <summary>
    /// Underlying Instrument.
    /// </summary>
    [DisplayName("Underlying Instrument")]
    [IsoXmlTag("UndrlygInstrm")]
    public SecurityIdentification41Choice_? UnderlyingInstrument { get; init; }

    /// <summary>
    /// Value Currency.
    /// </summary>
    [DisplayName("Value Currency")]
    [IsoXmlTag("ValCcy")]
    public ActiveOrHistoricCurrencyCode? ValueCurrency { get; init; }
}
