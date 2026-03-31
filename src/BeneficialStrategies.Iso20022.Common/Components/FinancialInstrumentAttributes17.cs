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
[IsoId("_0Zq7QeEMEd-qUMZtd_eZuQ")]
[DisplayName("Financial Instrument Attributes")]
public record FinancialInstrumentAttributes17
{
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_0Z0FMeEMEd-qUMZtd_eZuQ")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification14 SecurityIdentification { get; init; }

    /// <summary>
    /// Quantity of entitled intermediate securities based on the balance of underlying securities.
    /// </summary>
    [IsoId("_0Z0FM-EMEd-qUMZtd_eZuQ")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? Quantity { get; init; }

    /// <summary>
    /// Specifies whether terms of the event allow resale of the rights.
    /// </summary>
    [IsoId("_0Z0FNeEMEd-qUMZtd_eZuQ")]
    [DisplayName("Renounceable Entitlement Status Type")]
    [IsoXmlTag("RnncblEntitlmntStsTp")]
    public RenounceableEntitlementStatusTypeFormat1Choice_? RenounceableEntitlementStatusType { get; init; }

    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_0Z0FN-EMEd-qUMZtd_eZuQ")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType9Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Quantity of intermediate securities awarded for a given quantity of underlying security.
    /// </summary>
    [IsoId("_0Z0FOeEMEd-qUMZtd_eZuQ")]
    [DisplayName("Intermediate Securities To Underlying Ratio")]
    [IsoXmlTag("IntrmdtSctiesToUndrlygRatio")]
    public QuantityToQuantityRatio1? IntermediateSecuritiesToUnderlyingRatio { get; init; }

    /// <summary>
    /// Last reported/known price of a financial instrument in a market.
    /// </summary>
    [IsoId("_0Z0FO-EMEd-qUMZtd_eZuQ")]
    [DisplayName("Market Price")]
    [IsoXmlTag("MktPric")]
    public AmountPrice2? MarketPrice { get; init; }

    /// <summary>
    /// Date on which an order expires or at which a privilege or offer terminates.
    /// </summary>
    [IsoId("_0Z0FPeEMEd-qUMZtd_eZuQ")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public required DateFormat16Choice_ ExpiryDate { get; init; }

    /// <summary>
    /// Date of the posting (credit or debit) to the account.
    /// </summary>
    [IsoId("_0Z0FP-EMEd-qUMZtd_eZuQ")]
    [DisplayName("Posting Date")]
    [IsoXmlTag("PstngDt")]
    public required DateFormat16Choice_ PostingDate { get; init; }

    /// <summary>
    /// Period during which intermediate or outturn securities are tradable in a secondary market.
    /// </summary>
    [IsoId("_0Z0FQeEMEd-qUMZtd_eZuQ")]
    [DisplayName("Trading Period")]
    [IsoXmlTag("TradgPrd")]
    public Period4? TradingPeriod { get; init; }

    /// <summary>
    /// Balance of uninstructed position.
    /// </summary>
    [IsoId("_0Z0FQ-EMEd-qUMZtd_eZuQ")]
    [DisplayName("Uninstructed Balance")]
    [IsoXmlTag("UinstdBal")]
    public BalanceFormat1Choice_? UninstructedBalance { get; init; }

    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_0Z0FReEMEd-qUMZtd_eZuQ")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public BalanceFormat1Choice_? InstructedBalance { get; init; }
}
