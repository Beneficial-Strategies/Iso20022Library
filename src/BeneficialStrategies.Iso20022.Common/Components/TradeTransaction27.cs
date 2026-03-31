// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of the trade transaction.
/// </summary>
[IsoId("_yTcm8Q1JEeqV4s5SpzR1dQ")]
[DisplayName("Trade Transaction")]
public record TradeTransaction27
{
    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the counterparty.
    /// </summary>
    [IsoId("_yUUJoQ1JEeqV4s5SpzR1dQ")]
    [DisplayName("Unique Trade Identifier")]
    [IsoXmlTag("UnqTradIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public IsoMax52Text? UniqueTradeIdentifier { get; init; }

    /// <summary>
    /// Unique number to indicate a group of reports which relate to the same execution.
    /// </summary>
    [IsoId("_yUUJow1JEeqV4s5SpzR1dQ")]
    [DisplayName("Report Tracking Number")]
    [IsoXmlTag("RptTrckgNb")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public IsoMax52Text? ReportTrackingNumber { get; init; }

    /// <summary>
    /// Identification, internal to the reporting firm to identify all the reports related to the same execution of a combination of financial instruments. The code must be unique for the firm for the group of reports for the execution.
    /// Usage: Field only applies when the instrument is complex.
    /// </summary>
    [IsoId("_yUUJpQ1JEeqV4s5SpzR1dQ")]
    [DisplayName("Complex Trade Identification")]
    [IsoXmlTag("CmplxTradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ComplexTradeIdentification { get; init; }

    /// <summary>
    /// Venue of execution identified by a unique code for this venue.
    /// In case of a contract concluded OTC, it has to be identified using specific MIC codes designating OTC transactions.
    /// </summary>
    [IsoId("_yUUJpw1JEeqV4s5SpzR1dQ")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? TradingVenue { get; init; }

    /// <summary>
    /// Identifies whether the contract results from a compression operation or not.
    /// </summary>
    [IsoId("_yUUJqQ1JEeqV4s5SpzR1dQ")]
    [DisplayName("Compression")]
    [IsoXmlTag("Cmprssn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? Compression { get; init; }

    /// <summary>
    /// Indicates the price per derivative excluding, where applicable, commission and accrued interest.
    /// </summary>
    [IsoId("_yUUJqw1JEeqV4s5SpzR1dQ")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public SecuritiesTransactionPrice10Choice_? Price { get; init; }

    /// <summary>
    /// Reference amount from which contractual payments are determined.
    /// Usage: In case of partial terminations, and amortisations and in case of contracts where the notional, due to the characteristics of the contract, varies over time, it shall reflect the remaining notional after the change took place.
    /// </summary>
    [IsoId("_yUUJrQ1JEeqV4s5SpzR1dQ")]
    [DisplayName("Notional Amount")]
    [IsoXmlTag("NtnlAmt")]
    public AmountAndDirection56? NotionalAmount { get; init; }

    /// <summary>
    /// Number of units of the underlying instrument represented by a single derivative contract.
    /// </summary>
    [IsoId("_yUUJrw1JEeqV4s5SpzR1dQ")]
    [DisplayName("Price Multiplier")]
    [IsoXmlTag("PricMltplr")]
    [IsoSimpleType(IsoSimpleType.LongFraction21DecimalNumber)]
    public IsoLongFraction21DecimalNumber? PriceMultiplier { get; init; }

    /// <summary>
    /// Number of units of the financial instrument, that is, the nominal value.
    /// </summary>
    [IsoId("_yUUJsQ1JEeqV4s5SpzR1dQ")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public FinancialInstrumentQuantity30Choice_? Quantity { get; init; }

    /// <summary>
    /// Amount of money of any up-front payment the reporting counterparty made or received.
    /// Usage: The negative symbol to be used to indicate that the payment was made, not received.
    /// </summary>
    [IsoId("_yUUJsw1JEeqV4s5SpzR1dQ")]
    [DisplayName("Up Front Payment")]
    [IsoXmlTag("UpFrntPmt")]
    public AmountAndDirection56? UpFrontPayment { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is settled physically or in cash or decided at expiration time by counterparty.
    /// </summary>
    [IsoId("_yUUJtQ1JEeqV4s5SpzR1dQ")]
    [DisplayName("Delivery Type")]
    [IsoXmlTag("DlvryTp")]
    public PhysicalTransferType4Code? DeliveryType { get; init; }

    /// <summary>
    /// Indicates the date and time when the contract was executed.
    /// </summary>
    [IsoId("_yUUJtw1JEeqV4s5SpzR1dQ")]
    [DisplayName("Execution Date Time")]
    [IsoXmlTag("ExctnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ExecutionDateTime { get; init; }

    /// <summary>
    /// Indicates the date when obligations under the contract come into effect.
    /// </summary>
    [IsoId("_yUUJuQ1JEeqV4s5SpzR1dQ")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EffectiveDate { get; init; }

    /// <summary>
    /// Indicates the original date of expiry of the reported contract.
    /// Usage:
    /// An early termination shall not be reported in this field.
    /// </summary>
    [IsoId("_yUUJuw1JEeqV4s5SpzR1dQ")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; }

    /// <summary>
    /// Indicates the date in the case of an early termination of the reported contract.
    /// </summary>
    [IsoId("_yUUJvQ1JEeqV4s5SpzR1dQ")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TerminationDate { get; init; }

    /// <summary>
    /// Indicates the date of settlement of the underlying.
    /// </summary>
    [IsoId("_yUUJvw1JEeqV4s5SpzR1dQ")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public SimpleValueList<IsoISODate> SettlementDate { get; init; } = [];

    /// <summary>
    /// Details related to the Master agreement.
    /// </summary>
    [IsoId("_yUUJww1JEeqV4s5SpzR1dQ")]
    [DisplayName("Master Agreement")]
    [IsoXmlTag("MstrAgrmt")]
    public MasterAgreement5? MasterAgreement { get; init; }

    /// <summary>
    /// Provides information on whether the contract was electronically confirmed, non-electronically confirmed or remains unconfirmed.
    /// </summary>
    [IsoId("_yUUJxQ1JEeqV4s5SpzR1dQ")]
    [DisplayName("Trade Confirmation")]
    [IsoXmlTag("TradConf")]
    public TradeConfirmation2Choice_? TradeConfirmation { get; init; }

    /// <summary>
    /// Information related to clearing of the reported contract.
    /// </summary>
    [IsoId("_yUUJxw1JEeqV4s5SpzR1dQ")]
    [DisplayName("Trade Clearing")]
    [IsoXmlTag("TradClr")]
    public TradeClearing3? TradeClearing { get; init; }

    /// <summary>
    /// Information related to interest rate asset class type.
    /// </summary>
    [IsoId("_yUUJyQ1JEeqV4s5SpzR1dQ")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public InterestRateLegs7? InterestRate { get; init; }

    /// <summary>
    /// Information related to currency asset class type.
    /// </summary>
    [IsoId("_yUUJyw1JEeqV4s5SpzR1dQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public CurrencyExchange10? Currency { get; init; }

    /// <summary>
    /// Information related to commodity asset class type.
    /// </summary>
    [IsoId("_yUUJzQ1JEeqV4s5SpzR1dQ")]
    [DisplayName("Commodity")]
    [IsoXmlTag("Cmmdty")]
    public AssetClassCommodity2Choice_? Commodity { get; init; }

    /// <summary>
    /// Attributes specific for derivative contracts related to natural gas and electricity delivered in the European Union.
    /// </summary>
    [IsoId("_yUUJzw1JEeqV4s5SpzR1dQ")]
    [DisplayName("Energy Specific Attributes")]
    [IsoXmlTag("NrgySpcfcAttrbts")]
    public EnergySpecificAttribute5? EnergySpecificAttributes { get; init; }

    /// <summary>
    /// Information related to credit derivative asset class type.
    /// </summary>
    [IsoId("_yUUJ0Q1JEeqV4s5SpzR1dQ")]
    [DisplayName("Option")]
    [IsoXmlTag("Optn")]
    public OptionOrSwaption4? Option { get; init; }

    /// <summary>
    /// Information related to credit derivative asset class type.
    /// </summary>
    [IsoId("_yUUJ0w1JEeqV4s5SpzR1dQ")]
    [DisplayName("Credit")]
    [IsoXmlTag("Cdt")]
    public CreditDerivative2? Credit { get; init; }
}
