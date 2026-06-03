// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a redemption leg of a switch order.
/// </summary>
[IsoId("f3cc386a-dadf-4691-afd6-1c60f6402f94")]
[DisplayName("Switch Redemption Leg Execution5")]
public record SwitchRedemptionLegExecution5
{
    [IsoId("f3cc386a-lgid-0001-0001-1c60f6402f94")]
    [DisplayName("Leg Identification")]
    [IsoXmlTag("LegId")]
    public IsoMax35Text? LegIdentification { get; init; }

    [IsoId("f3cc386a-lgex-0001-0002-1c60f6402f94")]
    [DisplayName("Leg Execution Identification")]
    [IsoXmlTag("LegExctnId")]
    public IsoMax35Text? LegExecutionIdentification { get; init; }

    [IsoId("f3cc386a-fiin-0001-0003-1c60f6402f94")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument107 FinancialInstrumentDetails { get; init; }

    [IsoId("f3cc386a-unit-0001-0004-1c60f6402f94")]
    [DisplayName("Units")]
    [IsoXmlTag("Unts")]
    public required Unit1Choice_ Units { get; init; }

    [IsoId("f3cc386a-hldr-0001-0005-1c60f6402f94")]
    [DisplayName("Holdings Redemption Rate")]
    [IsoXmlTag("HldgsRedRate")]
    public IsoPercentageRate? HoldingsRedemptionRate { get; init; }

    [IsoId("f3cc386a-neta-0001-0006-1c60f6402f94")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; }

    [IsoId("f3cc386a-grsa-0001-0007-1c60f6402f94")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveCurrencyAndAmount? GrossAmount { get; init; }

    [IsoId("f3cc386a-invs-0001-0008-1c60f6402f94")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount81? InvestmentAccountDetails { get; init; }

    [IsoId("f3cc386a-trad-0001-0009-1c60f6402f94")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTime2Choice_ TradeDateTime { get; init; }

    [IsoId("f3cc386a-prcd-0001-0010-1c60f6402f94")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public required UnitPrice22 PriceDetails { get; init; }

    [IsoId("f3cc386a-infp-0001-0011-1c60f6402f94")]
    [DisplayName("Informative Price Details")]
    [IsoXmlTag("InftvPricDtls")]
    public ValueList<UnitPrice22> InformativePriceDetails { get; init; } = [];

    [IsoId("f3cc386a-cumd-0001-0012-1c60f6402f94")]
    [DisplayName("Cum Dividend Indicator")]
    [IsoXmlTag("CumDvddInd")]
    public required IsoYesNoIndicator CumDividendIndicator { get; init; }

    [IsoId("f3cc386a-intp-0001-0013-1c60f6402f94")]
    [DisplayName("Interim Profit Amount")]
    [IsoXmlTag("IntrmPrftAmt")]
    public ProfitAndLoss2Choice_? InterimProfitAmount { get; init; }

    [IsoId("f3cc386a-incp-0001-0014-1c60f6402f94")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    [IsoId("f3cc386a-grp1-0001-0015-1c60f6402f94")]
    [DisplayName("Group1 Or2 Units")]
    [IsoXmlTag("Grp1Or2Unts")]
    public UKTaxGroupUnit1Code? Group1Or2Units { get; init; }

    [IsoId("f3cc386a-rqsc-0001-0016-1c60f6402f94")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; }

    [IsoId("f3cc386a-rqnc-0001-0017-1c60f6402f94")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    [IsoId("f3cc386a-txov-0001-0018-1c60f6402f94")]
    [DisplayName("Transaction Overhead")]
    [IsoXmlTag("TxOvrhd")]
    public TotalFeesAndTaxes44? TransactionOverhead { get; init; }

    [IsoId("f3cc386a-intx-0001-0019-1c60f6402f94")]
    [DisplayName("Informative Tax Details")]
    [IsoXmlTag("InftvTaxDtls")]
    public InformativeTax2? InformativeTaxDetails { get; init; }

    [IsoId("f3cc386a-stcd-0001-0020-1c60f6402f94")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters22? SettlementAndCustodyDetails { get; init; }

    [IsoId("f3cc386a-phyd-0001-0021-1c60f6402f94")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    [IsoId("f3cc386a-phdd-0001-0022-1c60f6402f94")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; }

    [IsoId("f3cc386a-dgts-0001-0023-1c60f6402f94")]
    [DisplayName("Digital Asset Settlement")]
    [IsoXmlTag("DgtlAsstSttlm")]
    public DigitalPaymentSettlement3? DigitalAssetSettlement { get; init; }

    [IsoId("f3cc386a-nsts-0001-0024-1c60f6402f94")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    [IsoId("f3cc386a-eqls-0001-0025-1c60f6402f94")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation1? Equalisation { get; init; }

    [IsoId("f3cc386a-gthb-0001-0026-1c60f6402f94")]
    [DisplayName("Gating Or Hold Back Details")]
    [IsoXmlTag("GtgOrHldBckDtls")]
    public HoldBackInformation5? GatingOrHoldBackDetails { get; init; }
}
