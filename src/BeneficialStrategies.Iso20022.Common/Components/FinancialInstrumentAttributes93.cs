// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Description of the financial instrument.
/// </summary>
[IsoId("_kkuQnbQYEeeKRKrD60ELBQ")]
[DisplayName("Financial Instrument Attributes")]
public record FinancialInstrumentAttributes93
{
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_kzcpE7QYEeeKRKrD60ELBQ")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification19 SecurityIdentification { get; init; }

    /// <summary>
    /// Quantity of entitled intermediate securities based on the balance of underlying securities.
    /// </summary>
    [IsoId("_kzcpG7QYEeeKRKrD60ELBQ")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? Quantity { get; init; }

    /// <summary>
    /// Specifies whether terms of the event allow resale of the rights.
    /// </summary>
    [IsoId("_kzcpI7QYEeeKRKrD60ELBQ")]
    [DisplayName("Renounceable Entitlement Status Type")]
    [IsoXmlTag("RnncblEntitlmntStsTp")]
    public RenounceableEntitlementStatusTypeFormat3Choice_? RenounceableEntitlementStatusType { get; init; }

    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_kzcpK7QYEeeKRKrD60ELBQ")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType25Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Quantity of intermediate securities awarded for a given quantity of underlying security.
    /// </summary>
    [IsoId("_kzcpM7QYEeeKRKrD60ELBQ")]
    [DisplayName("Intermediate Securities To Underlying Ratio")]
    [IsoXmlTag("IntrmdtSctiesToUndrlygRatio")]
    public QuantityToQuantityRatio1? IntermediateSecuritiesToUnderlyingRatio { get; init; }

    /// <summary>
    /// Last reported/known price of a financial instrument in a market.
    /// </summary>
    [IsoId("_kzcpO7QYEeeKRKrD60ELBQ")]
    [DisplayName("Market Price")]
    [IsoXmlTag("MktPric")]
    public AmountPrice2? MarketPrice { get; init; }

    /// <summary>
    /// Date on which an order expires or at which a privilege or offer terminates.
    /// </summary>
    [IsoId("_kzcpQ7QYEeeKRKrD60ELBQ")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public required DateFormat30Choice_ ExpiryDate { get; init; }

    /// <summary>
    /// Date of the posting (credit or debit) to the account.
    /// </summary>
    [IsoId("_kzcpS7QYEeeKRKrD60ELBQ")]
    [DisplayName("Posting Date")]
    [IsoXmlTag("PstngDt")]
    public required DateFormat30Choice_ PostingDate { get; init; }

    /// <summary>
    /// Period during which intermediate or outturn securities are tradable in a secondary market.
    /// </summary>
    [IsoId("_kzcpU7QYEeeKRKrD60ELBQ")]
    [DisplayName("Trading Period")]
    [IsoXmlTag("TradgPrd")]
    public Period11? TradingPeriod { get; init; }

    /// <summary>
    /// Balance of uninstructed position.
    /// </summary>
    [IsoId("_kzcpW7QYEeeKRKrD60ELBQ")]
    [DisplayName("Uninstructed Balance")]
    [IsoXmlTag("UinstdBal")]
    public BalanceFormat5Choice_? UninstructedBalance { get; init; }

    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_kzcpY7QYEeeKRKrD60ELBQ")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public BalanceFormat5Choice_? InstructedBalance { get; init; }
}
