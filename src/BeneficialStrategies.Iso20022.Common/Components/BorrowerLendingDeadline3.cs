// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Stock lending deadline assigned to a borrower of the stock.
/// </summary>
[IsoId("_ePYU17QXEeeKRKrD60ELBQ")]
[DisplayName("Borrower Lending Deadline")]
public record BorrowerLendingDeadline3
{
    /// <summary>
    /// Date/time set as the deadline to respond, with instructions, to an outstanding event for which the underlying security is out on loan.
    /// </summary>
    [IsoId("_eeQeEbQXEeeKRKrD60ELBQ")]
    [DisplayName("Stock Lending Deadline")]
    [IsoXmlTag("StockLndgDdln")]
    public required DateFormat43Choice_ StockLendingDeadline { get; init; }

    /// <summary>
    /// Party who has borrowed stocks on loan.
    /// </summary>
    [IsoId("_eeQeE7QXEeeKRKrD60ELBQ")]
    [DisplayName("Borrower")]
    [IsoXmlTag("Brrwr")]
    public required PartyIdentification92Choice_ Borrower { get; init; }
}
