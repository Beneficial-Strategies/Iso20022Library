// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Deal amount details.
/// </summary>
[IsoId("_k9T14RIlEeyLzJfz3xPQNA")]
[DisplayName("Collateral Amount")]
public record CollateralAmount14
{
    /// <summary>
    /// Amount of the principal.
    /// </summary>
    [IsoId("_lUQWQRIlEeyLzJfz3xPQNA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public AmountAndDirection49? Transaction { get; init; }

    /// <summary>
    /// Amount of principal plus interests at termination.
    /// </summary>
    [IsoId("_lUQWQxIlEeyLzJfz3xPQNA")]
    [DisplayName("Termination")]
    [IsoXmlTag("Termntn")]
    public AmountAndDirection49? Termination { get; init; }

    /// <summary>
    /// Specifies the accrued interest on the value of the principal trade, in the currency of the principal trade.
    /// </summary>
    [IsoId("_lUQWRRIlEeyLzJfz3xPQNA")]
    [DisplayName("Accrued")]
    [IsoXmlTag("Acrd")]
    public AmountAndDirection49? Accrued { get; init; }

    /// <summary>
    /// Value of collateral offered or sought.
    /// </summary>
    [IsoId("_lUQWRxIlEeyLzJfz3xPQNA")]
    [DisplayName("Value Sought")]
    [IsoXmlTag("ValSght")]
    public AmountAndDirection49? ValueSought { get; init; }

    /// <summary>
    /// Transaction amount effectively processed by the TPA taking into account the matching tolerance threshold.
    /// </summary>
    [IsoId("_lUQWSRIlEeyLzJfz3xPQNA")]
    [DisplayName("Undisputed Transaction")]
    [IsoXmlTag("UdsptdTx")]
    public AmountAndDirection49? UndisputedTransaction { get; init; }
}
