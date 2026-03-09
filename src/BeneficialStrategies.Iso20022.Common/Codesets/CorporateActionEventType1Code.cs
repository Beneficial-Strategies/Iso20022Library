// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of corporate action event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bEb709p-Ed-ak6NoX_4Aeg_-1007587502")]
[Description(@"Specifies the type of corporate action event.")]
[DerivedFrom(typeof(CorporateActionEventTypeCode))]
public enum CorporateActionEventType1Code
{
    /// <summary>
    /// Event is a dividend payment type where cash dividend is rolled over into additional shares in the issuing company.
    /// Encoded/decoded by serializers as &quot;DRIP&quot;.
    /// </summary>
    [EnumMember(Value = "DRIP")]
    [IsoId("_bEb71Np-Ed-ak6NoX_4Aeg_-949359166")]
    [Description(@"Event is a dividend payment type where cash dividend is rolled over into additional shares in the issuing company.")]
    DividendReinvestment = CorporateActionEventTypeCode.DividendReinvestment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event is the distribution of profits resulting from the sale of securities. Shareholders of mutual funds, unit trusts, or Sicavs are recipients of capital gains distributions and are often reinvested in additional shares of the fund.
    /// Encoded/decoded by serializers as &quot;CAPG&quot;.
    /// </summary>
    [EnumMember(Value = "CAPG")]
    [IsoId("_bEb71dp-Ed-ak6NoX_4Aeg_220697386")]
    [Description(@"Event is the distribution of profits resulting from the sale of securities. Shareholders of mutual funds, unit trusts, or Sicavs are recipients of capital gains distributions and are often reinvested in additional shares of the fund.")]
    CapitalGainsDistribution = CorporateActionEventTypeCode.CapitalGainsDistribution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event is a distribution of cash to shareholders, in proportion to their equity holding. Ordinary dividends are recurring and regular. The shareholder must take cash and is not offered a choice in the form of distribution.
    /// Encoded/decoded by serializers as &quot;DVCA&quot;.
    /// </summary>
    [EnumMember(Value = "DVCA")]
    [IsoId("_bEb71tp-Ed-ak6NoX_4Aeg_-949358829")]
    [Description(@"Event is a distribution of cash to shareholders, in proportion to their equity holding. Ordinary dividends are recurring and regular. The shareholder must take cash and is not offered a choice in the form of distribution.")]
    CashDividend = CorporateActionEventTypeCode.CashDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event is a distribution of a dividend to shareholders with the choice of payment method. The shareholder must choose the form of payment - stock, cash, or both.
    /// Encoded/decoded by serializers as &quot;DVOP&quot;.
    /// </summary>
    [EnumMember(Value = "DVOP")]
    [IsoId("_bEb719p-Ed-ak6NoX_4Aeg_-948438720")]
    [Description(@"Event is a distribution of a dividend to shareholders with the choice of payment method. The shareholder must choose the form of payment - stock, cash, or both.")]
    DividendOption = CorporateActionEventTypeCode.DividendOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event is a dividend paid to shareholders in the form of shares of stock in the issuing company or in another company. The shareholder must take stock and is not offered a choice in the form of distribution.
    /// Encoded/decoded by serializers as &quot;DVSE&quot;.
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("_bEb72Np-Ed-ak6NoX_4Aeg_-948438590")]
    [Description(@"Event is a dividend paid to shareholders in the form of shares of stock in the issuing company or in another company. The shareholder must take stock and is not offered a choice in the form of distribution.")]
    StockDividend = CorporateActionEventTypeCode.StockDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event is a liquidating dividend or liquidation that consists of a distribution of cash, assets, or both. Debt may be paid in order of priority based on preferred claims to assets specified by the security. The security holder may be able to choose the form of liquidation distribution.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_bEb72dp-Ed-ak6NoX_4Aeg_-948438253")]
    [Description(@"Event is a liquidating dividend or liquidation that consists of a distribution of cash, assets, or both. Debt may be paid in order of priority based on preferred claims to assets specified by the security. The security holder may be able to choose the form of liquidation distribution.")]
    Liquidation = CorporateActionEventTypeCode.Liquidation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event is a mandatory or voluntary exchange of outstanding securities as the result of two or more companies combining assets. Cash payments may accompany share exchange.
    /// Encoded/decoded by serializers as &quot;MRGR&quot;.
    /// </summary>
    [EnumMember(Value = "MRGR")]
    [IsoId("_bEls0Np-Ed-ak6NoX_4Aeg_-948437849")]
    [Description(@"Event is a mandatory or voluntary exchange of outstanding securities as the result of two or more companies combining assets. Cash payments may accompany share exchange.")]
    Merger = CorporateActionEventTypeCode.Merger, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event is a name change. The issuing company changes its name. The event shows the change from old name to new name and may involve surrendering physical shares with the old name to the registrar.
    /// Encoded/decoded by serializers as &quot;NAME&quot;.
    /// </summary>
    [EnumMember(Value = "NAME")]
    [IsoId("_bEls0dp-Ed-ak6NoX_4Aeg_-948437712")]
    [Description(@"Event is a name change. The issuing company changes its name. The event shows the change from old name to new name and may involve surrendering physical shares with the old name to the registrar.")]
    NameChange = CorporateActionEventTypeCode.NameChange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event is a demerger or distribution or an unbundling. It is a distribution of subsidiary stock to the shareholders of the parent company without a surrender of shares. A spin-off represents a form of divestiture resulting in an independent company. Normally this is without cost to the parent issue shareholder.
    /// Encoded/decoded by serializers as &quot;SOFF&quot;.
    /// </summary>
    [EnumMember(Value = "SOFF")]
    [IsoId("_bEls0tp-Ed-ak6NoX_4Aeg_-948437557")]
    [Description(@"Event is a demerger or distribution or an unbundling. It is a distribution of subsidiary stock to the shareholders of the parent company without a surrender of shares. A spin-off represents a form of divestiture resulting in an independent company. Normally this is without cost to the parent issue shareholder.")]
    SpinOff = CorporateActionEventTypeCode.SpinOff, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event is a change in nominal value, a subdivision. It is an increase in a corporation&apos;s number of outstanding shares of stock without any change in the shareholder&apos;s equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly.
    /// Encoded/decoded by serializers as &quot;SPLF&quot;.
    /// </summary>
    [EnumMember(Value = "SPLF")]
    [IsoId("_bEls09p-Ed-ak6NoX_4Aeg_252095194")]
    [Description(@"Event is a change in nominal value, a subdivision. It is an increase in a corporation's number of outstanding shares of stock without any change in the shareholder's equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly.")]
    StockSplit = CorporateActionEventTypeCode.StockSplit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event is a change in nominal value, a consolidation. It is a decrease in number of outstanding shares of stock without any change in the shareholder&apos;s equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly.
    /// Encoded/decoded by serializers as &quot;SPLR&quot;.
    /// </summary>
    [EnumMember(Value = "SPLR")]
    [IsoId("_bEls1Np-Ed-ak6NoX_4Aeg_252095349")]
    [Description(@"Event is a change in nominal value, a consolidation. It is a decrease in number of outstanding shares of stock without any change in the shareholder's equity or the aggregate market value at the time of the split. Stock price and nominal value are reduced accordingly.")]
    ReverseStockSplit = CorporateActionEventTypeCode.ReverseStockSplit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event is an acquisition or take-over or offre publique de retrait (FR) or purchase offer or buy-back. It is an offer made to shareholders requesting them to sell (tender) their shares for a specified price usually at a premium over prevailing market price. Generally, the objective of a tender offer is to take control of the target company.
    /// Encoded/decoded by serializers as &quot;TEND&quot;.
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("_bEls1dp-Ed-ak6NoX_4Aeg_-948437202")]
    [Description(@"Event is an acquisition or take-over or offre publique de retrait (FR) or purchase offer or buy-back. It is an offer made to shareholders requesting them to sell (tender) their shares for a specified price usually at a premium over prevailing market price. Generally, the objective of a tender offer is to take control of the target company.")]
    Tender = CorporateActionEventTypeCode.Tender, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event is a bonus issue or scrip issue or capitalisation issue. Security holders are awarded additional assets free of payment from the issuer in proportion to their holding. A bonus issue is typically represented by shares, rights or warrants. Nominal value doesn&apos;t change. Holder may be offered choice of form.
    /// Encoded/decoded by serializers as &quot;BONU&quot;.
    /// </summary>
    [EnumMember(Value = "BONU")]
    [IsoId("_bEls1tp-Ed-ak6NoX_4Aeg_-969437653")]
    [Description(@"Event is a bonus issue or scrip issue or capitalisation issue. Security holders are awarded additional assets free of payment from the issuer in proportion to their holding. A bonus issue is typically represented by shares, rights or warrants. Nominal value doesn't change. Holder may be offered choice of form.")]
    BonusIssue = CorporateActionEventTypeCode.BonusIssue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event is the distribution of rights to shareholders, in proportion to their equity holding.
    /// Encoded/decoded by serializers as &quot;RHDI&quot;.
    /// </summary>
    [EnumMember(Value = "RHDI")]
    [IsoId("_bEls19p-Ed-ak6NoX_4Aeg_-969437285")]
    [Description(@"Event is the distribution of rights to shareholders, in proportion to their equity holding.")]
    RightsDistribution = CorporateActionEventTypeCode.RightsDistribution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event is a call or exercise on nil-paid securities or rights resulting from a rights distribution (RHDI). This is to be used for the second event in those cases where the rights issue is dealt with in two events, the first event being the rights distribution (RHDI).
    /// Encoded/decoded by serializers as &quot;EXRI&quot;.
    /// </summary>
    [EnumMember(Value = "EXRI")]
    [IsoId("_bEls2Np-Ed-ak6NoX_4Aeg_-969437268")]
    [Description(@"Event is a call or exercise on nil-paid securities or rights resulting from a rights distribution (RHDI). This is to be used for the second event in those cases where the rights issue is dealt with in two events, the first event being the rights distribution (RHDI).")]
    CallOnRights = CorporateActionEventTypeCode.CallOnRights, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event is a generic change. For example, a change in the terms of an issue, a change in the identification of a security, change of a board lot, a change from global to definitive.
    /// Encoded/decoded by serializers as &quot;CHAN&quot;.
    /// </summary>
    [EnumMember(Value = "CHAN")]
    [IsoId("_bEls2dp-Ed-ak6NoX_4Aeg_-969437190")]
    [Description(@"Event is a generic change. For example, a change in the terms of an issue, a change in the identification of a security, change of a board lot, a change from global to definitive.")]
    Change = CorporateActionEventTypeCode.Change, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event by which the unit (currency and/or nominal) of a financial instrument is restated, eg, the debt in a national currency is restated in euro.
    /// Encoded/decoded by serializers as &quot;REDO&quot;.
    /// </summary>
    [EnumMember(Value = "REDO")]
    [IsoId("_bEu2wNp-Ed-ak6NoX_4Aeg_-969437165")]
    [Description(@"Event by which the unit (currency and/or nominal) of a financial instrument is restated, eg, the debt in a national currency is restated in euro.")]
    Redenomination = CorporateActionEventTypeCode.Redenomination, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event is an option for the shareholders to exchange their securities for other securities and/or cash. Exchange options are mentioned in the terms and conditions of a security and are valid during the whole lifetime of a security.
    /// Encoded/decoded by serializers as &quot;EXOP&quot;.
    /// </summary>
    [EnumMember(Value = "EXOP")]
    [IsoId("_bEu2wdp-Ed-ak6NoX_4Aeg_-969437130")]
    [Description(@"Event is an option for the shareholders to exchange their securities for other securities and/or cash. Exchange options are mentioned in the terms and conditions of a security and are valid during the whole lifetime of a security.")]
    ExchangeOption = CorporateActionEventTypeCode.ExchangeOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event is an exchange offer or capital reorganisation.|It is an offer to shareholders to exchange their holdings for other securities and/or cash. Exchange offers are usually voluntary involving the exchange of outstanding security for a different security or securities and/or cash.
    /// Encoded/decoded by serializers as &quot;EXOF&quot;.
    /// </summary>
    [EnumMember(Value = "EXOF")]
    [IsoId("_bEu2wtp-Ed-ak6NoX_4Aeg_-969437095")]
    [Description(@"Event is an exchange offer or capital reorganisation.|It is an offer to shareholders to exchange their holdings for other securities and/or cash. Exchange offers are usually voluntary involving the exchange of outstanding security for a different security or securities and/or cash.")]
    ExchangeOffer = CorporateActionEventTypeCode.ExchangeOffer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event is a reduction of the share capital and face value of a single share. The number of the circulating shares remains unchanged. It may include a capital pay-out to shareholder.
    /// Encoded/decoded by serializers as &quot;DECR&quot;.
    /// </summary>
    [EnumMember(Value = "DECR")]
    [IsoId("_bEu2w9p-Ed-ak6NoX_4Aeg_-969437053")]
    [Description(@"Event is a reduction of the share capital and face value of a single share. The number of the circulating shares remains unchanged. It may include a capital pay-out to shareholder.")]
    DecreaseInValue = CorporateActionEventTypeCode.DecreaseInValue, // same ordinal as derivation source for type conversions
    
}
