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
[IsoId("_DrjvOc3yEee5nJBZsW8MFQ")]
[DisplayName("Financial Instrument Attributes")]
public record FinancialInstrumentAttributes94
{
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_DrjvPc3yEee5nJBZsW8MFQ")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification20 SecurityIdentification { get; init; }

    /// <summary>
    /// Quantity of entitled intermediate securities based on the balance of underlying securities.
    /// </summary>
    [IsoId("_DrjvRc3yEee5nJBZsW8MFQ")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINDecimalNumber)]
    public IsoRestrictedFINDecimalNumber? Quantity { get; init; }

    /// <summary>
    /// Specifies whether terms of the event allow resale of the rights.
    /// </summary>
    [IsoId("_DrjvTc3yEee5nJBZsW8MFQ")]
    [DisplayName("Renounceable Entitlement Status Type")]
    [IsoXmlTag("RnncblEntitlmntStsTp")]
    public RenounceableEntitlementStatusTypeFormat4Choice_? RenounceableEntitlementStatusType { get; init; }

    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_DrjvVc3yEee5nJBZsW8MFQ")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType32Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Quantity of intermediate securities awarded for a given quantity of underlying security.
    /// </summary>
    [IsoId("_DrjvXc3yEee5nJBZsW8MFQ")]
    [DisplayName("Intermediate Securities To Underlying Ratio")]
    [IsoXmlTag("IntrmdtSctiesToUndrlygRatio")]
    public QuantityToQuantityRatio2? IntermediateSecuritiesToUnderlyingRatio { get; init; }

    /// <summary>
    /// Last reported/known price of a financial instrument in a market.
    /// </summary>
    [IsoId("_DrjvZc3yEee5nJBZsW8MFQ")]
    [DisplayName("Market Price")]
    [IsoXmlTag("MktPric")]
    public AmountPrice4? MarketPrice { get; init; }

    /// <summary>
    /// Date on which an order expires or at which a privilege or offer terminates.
    /// </summary>
    [IsoId("_Drjvbc3yEee5nJBZsW8MFQ")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public required DateFormat41Choice_ ExpiryDate { get; init; }

    /// <summary>
    /// Date of the posting (credit or debit) to the account.
    /// </summary>
    [IsoId("_Drjvdc3yEee5nJBZsW8MFQ")]
    [DisplayName("Posting Date")]
    [IsoXmlTag("PstngDt")]
    public required DateFormat41Choice_ PostingDate { get; init; }

    /// <summary>
    /// Period during which intermediate or outturn securities are tradable in a secondary market.
    /// </summary>
    [IsoId("_Drjvfc3yEee5nJBZsW8MFQ")]
    [DisplayName("Trading Period")]
    [IsoXmlTag("TradgPrd")]
    public Period11? TradingPeriod { get; init; }

    /// <summary>
    /// Balance of uninstructed position.
    /// </summary>
    [IsoId("_Drjvhc3yEee5nJBZsW8MFQ")]
    [DisplayName("Uninstructed Balance")]
    [IsoXmlTag("UinstdBal")]
    public BalanceFormat7Choice_? UninstructedBalance { get; init; }

    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_Drjvjc3yEee5nJBZsW8MFQ")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public BalanceFormat7Choice_? InstructedBalance { get; init; }
}
