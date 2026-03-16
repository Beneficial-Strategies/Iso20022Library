// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Request Details32.
/// </summary>
[IsoId("_ItbUYYYeEe-Pv9KR9bv9IA")]
[DisplayName("Request Details32")]
public record RequestDetails32
{
    /// <summary>
    /// Automatic Borrowing.
    /// </summary>
    [DisplayName("Automatic Borrowing")]
    [IsoXmlTag("AutomtcBrrwg")]
    public AutomaticBorrowing7Choice_? AutomaticBorrowing { get; init; }

    /// <summary>
    /// Hold Indicator.
    /// </summary>
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    public HoldIndicator6? HoldIndicator { get; init; }

    /// <summary>
    /// Linkage.
    /// </summary>
    [DisplayName("Linkage")]
    [IsoXmlTag("Lkg")]
    public LinkageType3Choice_? Linkage { get; init; }

    /// <summary>
    /// Linkages.
    /// </summary>
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public ValueList<Linkages74> Linkages { get; init; } = [];

    /// <summary>
    /// Matching Denial.
    /// </summary>
    [DisplayName("Matching Denial")]
    [IsoXmlTag("MtchgDnl")]
    public MatchingDenied3Choice_? MatchingDenial { get; init; }

    /// <summary>
    /// Other Processing.
    /// </summary>
    [DisplayName("Other Processing")]
    [IsoXmlTag("OthrPrcg")]
    public ValueList<GenericIdentification30> OtherProcessing { get; init; } = [];

    /// <summary>
    /// Partial Settlement Indicator.
    /// </summary>
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; }

    /// <summary>
    /// Priority.
    /// </summary>
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric4Choice_? Priority { get; init; }

    /// <summary>
    /// Reference.
    /// </summary>
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References30 Reference { get; init; }

    /// <summary>
    /// Restriction Reference.
    /// </summary>
    [DisplayName("Restriction Reference")]
    [IsoXmlTag("RstrctnRef")]
    public ValueList<RestrictionIdentification1> RestrictionReference { get; init; } = [];

    /// <summary>
    /// Retain Indicator.
    /// </summary>
    [DisplayName("Retain Indicator")]
    [IsoXmlTag("RtnInd")]
    public IsoYesNoIndicator? RetainIndicator { get; init; }

    /// <summary>
    /// Securities RTGS.
    /// </summary>
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS4Choice_? SecuritiesRTGS { get; init; }

    /// <summary>
    /// Unilateral Split.
    /// </summary>
    [DisplayName("Unilateral Split")]
    [IsoXmlTag("UnltrlSplt")]
    public UnilateralSplit3Choice_? UnilateralSplit { get; init; }
}
