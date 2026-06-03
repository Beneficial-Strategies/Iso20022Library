// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies further details on the penalty.
/// </summary>
[IsoId("_xUaQ56gzEfCXwLUUylXgrQ")]
[DisplayName("Penalty Record4")]
public record PenaltyRecord4
{
    /// <summary>
    /// Identification as assigned to the penalty by the market infrastructure.
    /// </summary>
    [IsoId("_xXR-sagzEfCXwLUUylXgrQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PenaltyIdentification1 Identification { get; init; }

    /// <summary>
    /// Type of the penalty.
    /// </summary>
    [IsoId("_xXR-s6gzEfCXwLUUylXgrQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required PenaltyType1Code Type { get; init; }

    /// <summary>
    /// Party can no longer meet its financial obligations.
    /// </summary>
    [IsoId("_xXR-tagzEfCXwLUUylXgrQ")]
    [DisplayName("Insolvency")]
    [IsoXmlTag("Inslvncy")]
    public IsoYesNoIndicator? Insolvency { get; init; }

    /// <summary>
    /// Status of a penalty.
    /// </summary>
    [IsoId("_xXR-t6gzEfCXwLUUylXgrQ")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public PenaltyStatus2? Status { get; init; }

    /// <summary>
    /// Amount computed for this penalty.
    /// </summary>
    [IsoId("_xXR-uagzEfCXwLUUylXgrQ")]
    [DisplayName("Computed Amount")]
    [IsoXmlTag("CmptdAmt")]
    public required AmountAndDirection5 ComputedAmount { get; init; }

    /// <summary>
    /// Provides the calculation rule used to compute the penalty.
    /// </summary>
    [IsoId("_xXR-u6gzEfCXwLUUylXgrQ")]
    [DisplayName("Calculation Method")]
    [IsoXmlTag("ClctnMtd")]
    public PenaltyCalculationMethod1Code? CalculationMethod { get; init; }

    /// <summary>
    /// Number of business days from/to the intended settlement date.
    /// </summary>
    [IsoId("_xXR-vagzEfCXwLUUylXgrQ")]
    [DisplayName("Number Of Days")]
    [IsoXmlTag("NbOfDays")]
    public IsoNumber? NumberOfDays { get; init; }

    /// <summary>
    /// Further details for the calculation of the penalty.
    /// </summary>
    [IsoId("_xXR-v6gzEfCXwLUUylXgrQ")]
    [DisplayName("Calculation Data")]
    [IsoXmlTag("ClctnData")]
    public ValueList<PenaltyCalculationRecord1> CalculationData { get; init; } = [];

    /// <summary>
    /// Transaction for which the penalties apply.
    /// </summary>
    [IsoId("_xXR-wagzEfCXwLUUylXgrQ")]
    [DisplayName("Related Transaction")]
    [IsoXmlTag("RltdTx")]
    public PenaltyTransaction3? RelatedTransaction { get; init; }
}
