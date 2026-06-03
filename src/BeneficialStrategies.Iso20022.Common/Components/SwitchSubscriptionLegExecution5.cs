// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a subscription leg of a switch order.
/// </summary>
[IsoId("ec413d6f-6bc2-4f14-a0da-b9bb7bb30358")]
[DisplayName("Switch Subscription Leg Execution5")]
public record SwitchSubscriptionLegExecution5
{
    [IsoId("ec413d6f-lgid-0001-0001-b9bb7bb30358")]
    [DisplayName("Leg Identification")]
    [IsoXmlTag("LegId")]
    public IsoMax35Text? LegIdentification { get; init; }

    [IsoId("ec413d6f-lgex-0001-0002-b9bb7bb30358")]
    [DisplayName("Leg Execution Identification")]
    [IsoXmlTag("LegExctnId")]
    public IsoMax35Text? LegExecutionIdentification { get; init; }

    [IsoId("ec413d6f-fiin-0001-0003-b9bb7bb30358")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument107 FinancialInstrumentDetails { get; init; }

    [IsoId("ec413d6f-unit-0001-0004-b9bb7bb30358")]
    [DisplayName("Units")]
    [IsoXmlTag("Unts")]
    public required Unit1Choice Units { get; init; }

    [IsoId("ec413d6f-neta-0001-0005-b9bb7bb30358")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; }

    [IsoId("ec413d6f-grsa-0001-0006-b9bb7bb30358")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveCurrencyAndAmount? GrossAmount { get; init; }

    [IsoId("ec413d6f-invs-0001-0007-b9bb7bb30358")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount81? InvestmentAccountDetails { get; init; }

    [IsoId("ec413d6f-trad-0001-0008-b9bb7bb30358")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTime2Choice TradeDateTime { get; init; }

    [IsoId("ec413d6f-prcd-0001-0009-b9bb7bb30358")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public required UnitPrice22 PriceDetails { get; init; }

    [IsoId("ec413d6f-infp-0001-0010-b9bb7bb30358")]
    [DisplayName("Informative Price Details")]
    [IsoXmlTag("InftvPricDtls")]
    public ValueList<UnitPrice22> InformativePriceDetails { get; init; } = [];

    [IsoId("ec413d6f-cumd-0001-0011-b9bb7bb30358")]
    [DisplayName("Cum Dividend Indicator")]
    [IsoXmlTag("CumDvddInd")]
    public required IsoYesNoIndicator CumDividendIndicator { get; init; }

    [IsoId("ec413d6f-intp-0001-0012-b9bb7bb30358")]
    [DisplayName("Interim Profit Amount")]
    [IsoXmlTag("IntrmPrftAmt")]
    public ProfitAndLoss2Choice? InterimProfitAmount { get; init; }

    [IsoId("ec413d6f-incp-0001-0013-b9bb7bb30358")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    [IsoId("ec413d6f-rqsc-0001-0014-b9bb7bb30358")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; }

    [IsoId("ec413d6f-rqnc-0001-0015-b9bb7bb30358")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    [IsoId("ec413d6f-txov-0001-0016-b9bb7bb30358")]
    [DisplayName("Transaction Overhead")]
    [IsoXmlTag("TxOvrhd")]
    public TotalFeesAndTaxes44? TransactionOverhead { get; init; }

    [IsoId("ec413d6f-intx-0001-0017-b9bb7bb30358")]
    [DisplayName("Informative Tax Details")]
    [IsoXmlTag("InftvTaxDtls")]
    public InformativeTax2? InformativeTaxDetails { get; init; }

    [IsoId("ec413d6f-stcd-0001-0018-b9bb7bb30358")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters28? SettlementAndCustodyDetails { get; init; }

    [IsoId("ec413d6f-phyd-0001-0019-b9bb7bb30358")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    [IsoId("ec413d6f-phdd-0001-0020-b9bb7bb30358")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; }

    [IsoId("ec413d6f-dgts-0001-0021-b9bb7bb30358")]
    [DisplayName("Digital Asset Settlement")]
    [IsoXmlTag("DgtlAsstSttlm")]
    public DigitalPaymentSettlement3? DigitalAssetSettlement { get; init; }

    [IsoId("ec413d6f-nsts-0001-0022-b9bb7bb30358")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    [IsoId("ec413d6f-eqls-0001-0023-b9bb7bb30358")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation1? Equalisation { get; init; }
}
