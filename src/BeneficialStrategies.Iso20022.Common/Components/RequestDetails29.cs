// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the settlement condition modification request.
/// </summary>
[IsoId("_diWrmTi8Eeydid5dcNPKvg")]
[DisplayName("Request Details")]
public record RequestDetails29
{
    /// <summary>
    /// References of the transaction for which the securities settlement condition modification is requested.
    /// </summary>
    [IsoId("_diWroTi8Eeydid5dcNPKvg")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References28 Reference { get; init; }

    /// <summary>
    /// Restriction references applied on the transaction for which the securities settlement condition modification is requested.
    /// </summary>
    [IsoId("_diWrpTi8Eeydid5dcNPKvg")]
    [DisplayName("Restriction Reference")]
    [IsoXmlTag("RstrctnRef")]
    public ValueList<RestrictionIdentification2> RestrictionReference { get; init; } = [];

    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    [IsoId("_diWrpzi8Eeydid5dcNPKvg")]
    [DisplayName("Automatic Borrowing")]
    [IsoXmlTag("AutomtcBrrwg")]
    public AutomaticBorrowing11Choice_? AutomaticBorrowing { get; init; }

    /// <summary>
    /// Indicates whether the instruction due to expire is confirmed for settlement.
    /// </summary>
    [IsoId("_diWrqzi8Eeydid5dcNPKvg")]
    [DisplayName("Retain Indicator")]
    [IsoXmlTag("RtnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RetainIndicator { get; init; }

    /// <summary>
    /// Specifies the type of linkage requested.
    /// </summary>
    [IsoId("_diWrrzi8Eeydid5dcNPKvg")]
    [DisplayName("Linkage")]
    [IsoXmlTag("Lkg")]
    public LinkageType4Choice_? Linkage { get; init; }

    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_diWrszi8Eeydid5dcNPKvg")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric5Choice_? Priority { get; init; }

    /// <summary>
    /// Specifies another type of processing change request.
    /// </summary>
    [IsoId("_diWrtzi8Eeydid5dcNPKvg")]
    [DisplayName("Other Processing")]
    [IsoXmlTag("OthrPrcg")]
    public ValueList<GenericIdentification47> OtherProcessing { get; init; } = [];

    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("_diWruzi8Eeydid5dcNPKvg")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_diWrvzi8Eeydid5dcNPKvg")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS5Choice_? SecuritiesRTGS { get; init; }

    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    [IsoId("_diWrwzi8Eeydid5dcNPKvg")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    public HoldIndicator7? HoldIndicator { get; init; }

    /// <summary>
    /// Specifies the matching processing change requested.
    /// </summary>
    [IsoId("_diWrxzi8Eeydid5dcNPKvg")]
    [DisplayName("Matching Denial")]
    [IsoXmlTag("MtchgDnl")]
    public MatchingDenied4Choice_? MatchingDenial { get; init; }

    /// <summary>
    /// Specifies that the transaction is requested to be unilaterally split.
    /// </summary>
    [IsoId("_diWryzi8Eeydid5dcNPKvg")]
    [DisplayName("Unilateral Split")]
    [IsoXmlTag("UnltrlSplt")]
    public UnilateralSplit4Choice_? UnilateralSplit { get; init; }

    /// <summary>
    /// Information regarding the linkage requested.
    /// </summary>
    [IsoId("_diWrzzi8Eeydid5dcNPKvg")]
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public ValueList<Linkages66> Linkages { get; init; } = [];
}
