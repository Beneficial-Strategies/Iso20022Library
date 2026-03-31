// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the clearing of the contract.
/// </summary>
[IsoId("_BIv4sexYEemioJdkOVFBdw")]
[DisplayName("Trade Clearing")]
public record TradeClearing5
{
    /// <summary>
    /// Indicates, whether the reported contract belongs to a class of OTC derivatives that has been declared subject to the clearing obligation and both counterparties to the contract are subject to the clearing obligation, as of the time of execution of the contract.
    /// </summary>
    [IsoId("_BT5_0exYEemioJdkOVFBdw")]
    [DisplayName("Clearing Obligation")]
    [IsoXmlTag("ClrOblgtn")]
    public ClearingObligationType1Code? ClearingObligation { get; init; }

    /// <summary>
    /// Indicator of whether the transaction has been cleared, or is intended to be cleared, by a central counterparty.
    /// </summary>
    [IsoId("_BT5_0-xYEemioJdkOVFBdw")]
    [DisplayName("Clearing Status")]
    [IsoXmlTag("ClrSts")]
    public Cleared12Choice_? ClearingStatus { get; init; }

    /// <summary>
    /// Indicates whether the contract was entered into as an intragroup transaction.
    /// Usage: When absent, default value is false.
    /// </summary>
    [IsoId("_BT5_1exYEemioJdkOVFBdw")]
    [DisplayName("Intra Group")]
    [IsoXmlTag("IntraGrp")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? IntraGroup { get; init; }
}
