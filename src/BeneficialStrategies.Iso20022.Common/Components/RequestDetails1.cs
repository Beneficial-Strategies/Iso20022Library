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
[IsoId("_UhHYzNp-Ed-ak6NoX_4Aeg_-52038934")]
[DisplayName("Request Details")]
public record RequestDetails1
{
    /// <summary>
    /// References of the transaction for which the securities settlement condition modification is requested.
    /// </summary>
    [IsoId("_UhHYzdp-Ed-ak6NoX_4Aeg_1451100052")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References1 Reference { get; init; }

    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    [IsoId("_UhHYztp-Ed-ak6NoX_4Aeg_-187586029")]
    [DisplayName("Automatic Borrowing")]
    [IsoXmlTag("AutomtcBrrwg")]
    public AutomaticBorrowing2Choice_? AutomaticBorrowing { get; init; }

    /// <summary>
    /// Specifies whether the instruction due to expire is confirmed for settlement.
    /// </summary>
    [IsoId("_UhRJwNp-Ed-ak6NoX_4Aeg_198445615")]
    [DisplayName("Retain Indicator")]
    [IsoXmlTag("RtnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RetainIndicator { get; init; }

    /// <summary>
    /// Specifies the type of linkage requested.
    /// </summary>
    [IsoId("_UhRJwdp-Ed-ak6NoX_4Aeg_545688622")]
    [DisplayName("Linkage")]
    [IsoXmlTag("Lkg")]
    public LinkageType1Choice_? Linkage { get; init; }

    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_UhRJwtp-Ed-ak6NoX_4Aeg_97783160")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric1Choice_? Priority { get; init; }

    /// <summary>
    /// Specifies another type of processing change request.
    /// </summary>
    [IsoId("_UhRJw9p-Ed-ak6NoX_4Aeg_688837633")]
    [DisplayName("Other Processing")]
    [IsoXmlTag("OthrPrcg")]
    public ValueList<GenericIdentification20> OtherProcessing { get; init; } = [];

    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("_UhRJxNp-Ed-ak6NoX_4Aeg_-187586028")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PartialSettlementIndicator { get; init; }

    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_UhRJxdp-Ed-ak6NoX_4Aeg_-187586089")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS1Choice_? SecuritiesRTGS { get; init; }

    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    [IsoId("_UhRJxtp-Ed-ak6NoX_4Aeg_-2070646385")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? HoldIndicator { get; init; }

    /// <summary>
    /// Specifies the matching processing change requested.
    /// </summary>
    [IsoId("_UhRJx9p-Ed-ak6NoX_4Aeg_2041059877")]
    [DisplayName("Matching Denial")]
    [IsoXmlTag("MtchgDnl")]
    public MatchingDenied1Choice_? MatchingDenial { get; init; }

    /// <summary>
    /// Specifies that the transaction is requested to be unilaterally split.
    /// </summary>
    [IsoId("_UhRJyNp-Ed-ak6NoX_4Aeg_-1042550853")]
    [DisplayName("Unilateral Split")]
    [IsoXmlTag("UnltrlSplt")]
    public UnilateralSplit1Choice_? UnilateralSplit { get; init; }

    /// <summary>
    /// Information regarding the linkage requested.
    /// </summary>
    [IsoId("_UhRJydp-Ed-ak6NoX_4Aeg_661474902")]
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public ValueList<Linkages3> Linkages { get; init; } = [];
}
