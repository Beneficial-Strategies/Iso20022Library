// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the time-out consequences.
/// </summary>
[IsoId("_RbFb8tp-Ed-ak6NoX_4Aeg_-1237479550")]
[DisplayName("Time Out Result")]
public record TimeOutResult2
{
    /// <summary>
    /// Specifies the status of the transaction if no action is taken by the user.
    /// </summary>
    [IsoId("_RbFb89p-Ed-ak6NoX_4Aeg_-324119576")]
    [DisplayName("Transaction Future Status")]
    [IsoXmlTag("TxFutrSts")]
    public required TransactionStatus5 TransactionFutureStatus { get; init; }
}
