// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Clearing data at batch level. Allows clearing in different currencies.
/// </summary>
[IsoId("_MCJ34FA6EeedyPuM0kK2EQ")]
[DisplayName("Clearing Batch Data")]
public record ClearingBatchData1
{
    /// <summary>
    /// Type of clearing method used.
    /// </summary>
    [IsoId("_aETkAFA6EeedyPuM0kK2EQ")]
    [DisplayName("Clearing Method")]
    [IsoXmlTag("ClrMtd")]
    public required ClearingMethod2Code ClearingMethod { get; init; }

    /// <summary>
    /// Other type of clearing method.
    /// </summary>
    [IsoId("_6cTJkFA7EeedyPuM0kK2EQ")]
    [DisplayName("Other Clearing Method")]
    [IsoXmlTag("OthrClrMtd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherClearingMethod { get; init; }

    /// <summary>
    /// Level of priority of clearing.
    /// </summary>
    [IsoId("__8ATgFA7EeedyPuM0kK2EQ")]
    [DisplayName("Clearing Priority")]
    [IsoXmlTag("ClrPrty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingPriority { get; init; }

    /// <summary>
    /// Date of clearing.
    /// </summary>
    [IsoId("_Fof8QFA8EeedyPuM0kK2EQ")]
    [DisplayName("Clearing Date")]
    [IsoXmlTag("ClrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ClearingDate { get; init; }

    /// <summary>
    /// Clearing totals of the batch file.
    /// </summary>
    [IsoId("_KmAioFA9EeedyPuM0kK2EQ")]
    [DisplayName("Clearing Totals")]
    [IsoXmlTag("ClrTtls")]
    public ClearingTotals1? ClearingTotals { get; init; }

    /// <summary>
    /// Interchange fee.
    /// </summary>
    [IsoId("_S7N6EFA9EeedyPuM0kK2EQ")]
    [DisplayName("Interchange Fee")]
    [IsoXmlTag("IntrchngFee")]
    public Amount14? InterchangeFee { get; init; }

    /// <summary>
    /// Fee of the agent.
    /// </summary>
    [IsoId("_XEn_cFA9EeedyPuM0kK2EQ")]
    [DisplayName("Agent Fee")]
    [IsoXmlTag("AgtFee")]
    public Amount14? AgentFee { get; init; }
}
