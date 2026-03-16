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
[IsoId("_-zrY2zqEEeWVrPy0StzzSg")]
[DisplayName("Request Details")]
public record RequestDetails15
{
    /// <summary>
    /// References of the transaction for which the securities settlement condition modification is requested.
    /// </summary>
    [IsoId("__S65ZzqEEeWVrPy0StzzSg")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References18 Reference { get; init; }

    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    [IsoId("__S65azqEEeWVrPy0StzzSg")]
    [DisplayName("Automatic Borrowing")]
    [IsoXmlTag("AutomtcBrrwg")]
    public AutomaticBorrowing7Choice_? AutomaticBorrowing { get; init; }

    /// <summary>
    /// Specifies whether the instruction due to expire is confirmed for settlement.
    /// </summary>
    [IsoId("__S65bzqEEeWVrPy0StzzSg")]
    [DisplayName("Retain Indicator")]
    [IsoXmlTag("RtnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RetainIndicator { get; init; }

    /// <summary>
    /// Specifies the type of linkage requested.
    /// </summary>
    [IsoId("__S65czqEEeWVrPy0StzzSg")]
    [DisplayName("Linkage")]
    [IsoXmlTag("Lkg")]
    public LinkageType3Choice_? Linkage { get; init; }

    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("__S65dzqEEeWVrPy0StzzSg")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric4Choice_? Priority { get; init; }

    /// <summary>
    /// Specifies another type of processing change request.
    /// </summary>
    [IsoId("__S65ezqEEeWVrPy0StzzSg")]
    [DisplayName("Other Processing")]
    [IsoXmlTag("OthrPrcg")]
    public ValueList<GenericIdentification30> OtherProcessing { get; init; } = [];

    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("__S65fzqEEeWVrPy0StzzSg")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("__S65gzqEEeWVrPy0StzzSg")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS4Choice_? SecuritiesRTGS { get; init; }

    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    [IsoId("__S65hzqEEeWVrPy0StzzSg")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    public HoldIndicator6? HoldIndicator { get; init; }

    /// <summary>
    /// Specifies the matching processing change requested.
    /// </summary>
    [IsoId("__S65izqEEeWVrPy0StzzSg")]
    [DisplayName("Matching Denial")]
    [IsoXmlTag("MtchgDnl")]
    public MatchingDenied3Choice_? MatchingDenial { get; init; }

    /// <summary>
    /// Specifies that the transaction is requested to be unilaterally split.
    /// </summary>
    [IsoId("__S65jzqEEeWVrPy0StzzSg")]
    [DisplayName("Unilateral Split")]
    [IsoXmlTag("UnltrlSplt")]
    public UnilateralSplit3Choice_? UnilateralSplit { get; init; }

    /// <summary>
    /// Information regarding the linkage requested.
    /// </summary>
    [IsoId("__S65kzqEEeWVrPy0StzzSg")]
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public ValueList<Linkages39> Linkages { get; init; } = [];
}
