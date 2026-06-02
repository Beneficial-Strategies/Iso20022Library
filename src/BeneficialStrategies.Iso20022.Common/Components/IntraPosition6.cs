// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the intra-position movement.
/// </summary>
[IsoId("_TgKYgWp9EemmaZLSPtWX5A")]
[DisplayName("Intra Position6")]
public record IntraPosition6
{
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_TryZsWp9EemmaZLSPtWX5A")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_TryZuWp9EemmaZLSPtWX5A")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public required FinancialInstrumentQuantity1Choice SettlementQuantity { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be moved.
    /// </summary>
    [IsoId("_TryZu2p9EemmaZLSPtWX5A")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required DateAndDateTime2Choice SettlementDate { get; init; }

    /// <summary>
    /// Balance from which the securities are moving.
    /// </summary>
    [IsoId("_TryZw2p9EemmaZLSPtWX5A")]
    [DisplayName("Balance From")]
    [IsoXmlTag("BalFr")]
    public SecuritiesSubBalanceTypeAndQuantityBreakdown3? BalanceFrom { get; init; }

    /// <summary>
    /// Balance to which the securities are moving.
    /// </summary>
    [IsoId("_TryZy2p9EemmaZLSPtWX5A")]
    [DisplayName("Balance To")]
    [IsoXmlTag("BalTo")]
    public SecuritiesSubBalanceTypeAndQuantityBreakdown3? BalanceTo { get; init; }

    /// <summary>
    /// Number identifying a lot constituting the sub-balance.
    /// </summary>
    [IsoId("_TryZ02p9EemmaZLSPtWX5A")]
    [DisplayName("Securities Sub Balance Identification")]
    [IsoXmlTag("SctiesSubBalId")]
    public GenericIdentification37? SecuritiesSubBalanceIdentification { get; init; }

    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_TryZ1Wp9EemmaZLSPtWX5A")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric4Choice? Priority { get; init; }
}
