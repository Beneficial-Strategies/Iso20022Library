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
[IsoId("_uQtNwQ4EEeKN_Y-2Awiamw")]
[DisplayName("Request Details")]
public record RequestDetails11
{
    /// <summary>
    /// References of the transaction for which the securities settlement condition modification is requested.
    /// </summary>
    [IsoId("_unNCQQ4EEeKN_Y-2Awiamw")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References9 Reference { get; init; }

    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    [IsoId("_unNCSw4EEeKN_Y-2Awiamw")]
    [DisplayName("Automatic Borrowing")]
    [IsoXmlTag("AutomtcBrrwg")]
    public AutomaticBorrowing2Choice_? AutomaticBorrowing { get; init; }

    /// <summary>
    /// Specifies whether the instruction due to expire is confirmed for settlement.
    /// </summary>
    [IsoId("_unNCVQ4EEeKN_Y-2Awiamw")]
    [DisplayName("Retain Indicator")]
    [IsoXmlTag("RtnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RetainIndicator { get; init; }

    /// <summary>
    /// Specifies the type of linkage requested.
    /// </summary>
    [IsoId("_unNCXw4EEeKN_Y-2Awiamw")]
    [DisplayName("Linkage")]
    [IsoXmlTag("Lkg")]
    public LinkageType1Choice_? Linkage { get; init; }

    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_unNCaQ4EEeKN_Y-2Awiamw")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric1Choice_? Priority { get; init; }

    /// <summary>
    /// Specifies another type of processing change request.
    /// </summary>
    [IsoId("_unNCcw4EEeKN_Y-2Awiamw")]
    [DisplayName("Other Processing")]
    [IsoXmlTag("OthrPrcg")]
    public ValueList<GenericIdentification20> OtherProcessing { get; init; } = [];

    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("_unNCfQ4EEeKN_Y-2Awiamw")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_unNChw4EEeKN_Y-2Awiamw")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS1Choice_? SecuritiesRTGS { get; init; }

    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    [IsoId("_unNCkQ4EEeKN_Y-2Awiamw")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    public HoldIndicator4? HoldIndicator { get; init; }

    /// <summary>
    /// Specifies the matching processing change requested.
    /// </summary>
    [IsoId("_unNCmw4EEeKN_Y-2Awiamw")]
    [DisplayName("Matching Denial")]
    [IsoXmlTag("MtchgDnl")]
    public MatchingDenied1Choice_? MatchingDenial { get; init; }

    /// <summary>
    /// Specifies that the transaction is requested to be unilaterally split.
    /// </summary>
    [IsoId("_unNCpQ4EEeKN_Y-2Awiamw")]
    [DisplayName("Unilateral Split")]
    [IsoXmlTag("UnltrlSplt")]
    public UnilateralSplit1Choice_? UnilateralSplit { get; init; }

    /// <summary>
    /// Information regarding the linkage requested.
    /// </summary>
    [IsoId("_unNCrw4EEeKN_Y-2Awiamw")]
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public ValueList<Linkages27> Linkages { get; init; } = [];
}
