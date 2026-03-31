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
[IsoId("_K3YysSgaEey2k_sfZmJz4g")]
[DisplayName("Request Details")]
public record RequestDetails27
{
    /// <summary>
    /// References of the transaction for which the securities settlement condition modification is requested.
    /// </summary>
    [IsoId("_LQIC1ygaEey2k_sfZmJz4g")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References27 Reference { get; init; }

    /// <summary>
    /// Restriction references applied on the transaction for which the securities settlement condition modification is requested.
    /// </summary>
    [IsoId("_LQIC2ygaEey2k_sfZmJz4g")]
    [DisplayName("Restriction Reference")]
    [IsoXmlTag("RstrctnRef")]
    public ValueList<RestrictionIdentification1> RestrictionReference { get; init; } = [];

    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    [IsoId("_LQIC3SgaEey2k_sfZmJz4g")]
    [DisplayName("Automatic Borrowing")]
    [IsoXmlTag("AutomtcBrrwg")]
    public AutomaticBorrowing7Choice_? AutomaticBorrowing { get; init; }

    /// <summary>
    /// Indicates whether the instruction due to expire is confirmed for settlement.
    /// </summary>
    [IsoId("_LQIC4SgaEey2k_sfZmJz4g")]
    [DisplayName("Retain Indicator")]
    [IsoXmlTag("RtnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RetainIndicator { get; init; }

    /// <summary>
    /// Specifies the type of linkage requested.
    /// </summary>
    [IsoId("_LQIC5SgaEey2k_sfZmJz4g")]
    [DisplayName("Linkage")]
    [IsoXmlTag("Lkg")]
    public LinkageType3Choice_? Linkage { get; init; }

    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_LQIC6SgaEey2k_sfZmJz4g")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric4Choice_? Priority { get; init; }

    /// <summary>
    /// Specifies another type of processing change request.
    /// </summary>
    [IsoId("_LQIC7SgaEey2k_sfZmJz4g")]
    [DisplayName("Other Processing")]
    [IsoXmlTag("OthrPrcg")]
    public ValueList<GenericIdentification30> OtherProcessing { get; init; } = [];

    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("_LQIC8SgaEey2k_sfZmJz4g")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_LQIC9SgaEey2k_sfZmJz4g")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS4Choice_? SecuritiesRTGS { get; init; }

    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    [IsoId("_LQIC-SgaEey2k_sfZmJz4g")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    public HoldIndicator6? HoldIndicator { get; init; }

    /// <summary>
    /// Specifies the matching processing change requested.
    /// </summary>
    [IsoId("_LQIC_SgaEey2k_sfZmJz4g")]
    [DisplayName("Matching Denial")]
    [IsoXmlTag("MtchgDnl")]
    public MatchingDenied3Choice_? MatchingDenial { get; init; }

    /// <summary>
    /// Specifies that the transaction is requested to be unilaterally split.
    /// </summary>
    [IsoId("_LQIDASgaEey2k_sfZmJz4g")]
    [DisplayName("Unilateral Split")]
    [IsoXmlTag("UnltrlSplt")]
    public UnilateralSplit3Choice_? UnilateralSplit { get; init; }

    /// <summary>
    /// Information regarding the linkage requested.
    /// </summary>
    [IsoId("_LQIDBSgaEey2k_sfZmJz4g")]
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public ValueList<Linkages62> Linkages { get; init; } = [];
}
