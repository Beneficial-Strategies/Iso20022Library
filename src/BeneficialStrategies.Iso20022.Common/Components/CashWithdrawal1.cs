// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Withdrawal of an amount of money defined in cash notes and or cash coins.
/// </summary>
[IsoId("_yg8nEbDnEfCbk9-eHc2eXw")]
[DisplayName("Cash Withdrawal1")]
public record CashWithdrawal1
{
    /// <summary>
    /// Indicates whether the denominations in the original cash withdrawal request have been amended.
    /// Usage: where this element is not used the denominations match the original cash withdrawal request or no denominations were included in the original cash withdrawal request.
    /// </summary>
    [IsoId("_vxTJ8bDnEfCbk9-eHc2eXw")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    public IsoYesNoIndicator? AmendmentIndicator { get; init; }

    /// <summary>
    /// Specifies the details of the requested withdrawal in notes.
    /// </summary>
    [IsoId("_ynAy0bDnEfCbk9-eHc2eXw")]
    [DisplayName("Note Details")]
    [IsoXmlTag("NoteDtls")]
    public ValueList<CashNote1> NoteDetails { get; init; } = [];

    /// <summary>
    /// Specifies the details of the requested withdrawal in coins.
    /// </summary>
    [IsoId("_ynAy07DnEfCbk9-eHc2eXw")]
    [DisplayName("Coin Details")]
    [IsoXmlTag("CoinDtls")]
    public ValueList<CashCoin1> CoinDetails { get; init; } = [];

    /// <summary>
    /// Total amount of all notes and coins being withdrawn.
    /// </summary>
    [IsoId("_ynAy1bDnEfCbk9-eHc2eXw")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required ActiveCurrencyAndAmount TotalAmount { get; init; }

    /// <summary>
    /// Unique identification for any discrepancy.
    /// </summary>
    [IsoId("_na2s4dEnEfCHIpLhE5dmGg")]
    [DisplayName("Discrepancy Identification")]
    [IsoXmlTag("DscrpncyId")]
    public IsoMax35Text? DiscrepancyIdentification { get; init; }
}
