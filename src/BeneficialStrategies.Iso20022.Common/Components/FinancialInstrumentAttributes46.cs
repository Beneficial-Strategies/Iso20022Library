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
[IsoId("_DeW-8WSDEeKFfdK0gKYFLQ")]
[DisplayName("Financial Instrument Attributes")]
public record FinancialInstrumentAttributes46
{
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_D3_m-WSDEeKFfdK0gKYFLQ")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification14 SecurityIdentification { get; init; }

    /// <summary>
    /// Quantity of entitled intermediate securities based on the balance of underlying securities.
    /// </summary>
    [IsoId("_D3_nA2SDEeKFfdK0gKYFLQ")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? Quantity { get; init; }

    /// <summary>
    /// Specifies whether terms of the event allow resale of the rights.
    /// </summary>
    [IsoId("_D3_nDWSDEeKFfdK0gKYFLQ")]
    [DisplayName("Renounceable Entitlement Status Type")]
    [IsoXmlTag("RnncblEntitlmntStsTp")]
    public RenounceableEntitlementStatusTypeFormat1Choice_? RenounceableEntitlementStatusType { get; init; }

    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_D3_nF2SDEeKFfdK0gKYFLQ")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType15Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Quantity of intermediate securities awarded for a given quantity of underlying security.
    /// </summary>
    [IsoId("_D3_nIWSDEeKFfdK0gKYFLQ")]
    [DisplayName("Intermediate Securities To Underlying Ratio")]
    [IsoXmlTag("IntrmdtSctiesToUndrlygRatio")]
    public QuantityToQuantityRatio1? IntermediateSecuritiesToUnderlyingRatio { get; init; }

    /// <summary>
    /// Last reported/known price of a financial instrument in a market.
    /// </summary>
    [IsoId("_D3_nK2SDEeKFfdK0gKYFLQ")]
    [DisplayName("Market Price")]
    [IsoXmlTag("MktPric")]
    public AmountPrice2? MarketPrice { get; init; }

    /// <summary>
    /// Date on which an order expires or at which a privilege or offer terminates.
    /// </summary>
    [IsoId("_D3_nNWSDEeKFfdK0gKYFLQ")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public required DateFormat16Choice_ ExpiryDate { get; init; }

    /// <summary>
    /// Date of the posting (credit or debit) to the account.
    /// </summary>
    [IsoId("_D3_nP2SDEeKFfdK0gKYFLQ")]
    [DisplayName("Posting Date")]
    [IsoXmlTag("PstngDt")]
    public required DateFormat16Choice_ PostingDate { get; init; }

    /// <summary>
    /// Period during which intermediate or outturn securities are tradable in a secondary market.
    /// </summary>
    [IsoId("_D3_nSWSDEeKFfdK0gKYFLQ")]
    [DisplayName("Trading Period")]
    [IsoXmlTag("TradgPrd")]
    public Period4? TradingPeriod { get; init; }

    /// <summary>
    /// Balance of uninstructed position.
    /// </summary>
    [IsoId("_D3_nU2SDEeKFfdK0gKYFLQ")]
    [DisplayName("Uninstructed Balance")]
    [IsoXmlTag("UinstdBal")]
    public BalanceFormat1Choice_? UninstructedBalance { get; init; }

    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_D3_nXWSDEeKFfdK0gKYFLQ")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public BalanceFormat1Choice_? InstructedBalance { get; init; }
}
