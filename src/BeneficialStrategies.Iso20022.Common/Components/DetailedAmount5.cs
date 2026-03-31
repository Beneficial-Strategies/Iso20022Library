// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed amounts associated with the total amount of transaction.
/// </summary>
[IsoId("_QaMvIDAqEeOqioR9srQH1g")]
[DisplayName("Detailed Amount")]
public record DetailedAmount5
{
    /// <summary>
    /// Cash-back amount.
    /// </summary>
    [IsoId("_R55K0DArEeOqioR9srQH1g")]
    [DisplayName("Cash Back")]
    [IsoXmlTag("CshBck")]
    public ImpliedCurrencyAndAmount? CashBack { get; init; }

    /// <summary>
    /// Gratuity amount.
    /// </summary>
    [IsoId("_H5yF4DAtEeOqioR9srQH1g")]
    [DisplayName("Gratuity")]
    [IsoXmlTag("Grtty")]
    public ImpliedCurrencyAndAmount? Gratuity { get; init; }

    /// <summary>
    /// Fees amount.
    /// </summary>
    [IsoId("_x29u8DAsEeOqioR9srQH1g")]
    [DisplayName("Fees")]
    [IsoXmlTag("Fees")]
    public ValueList<DetailedAmount4> Fees { get; init; } = [];

    /// <summary>
    /// Global rebate of the transaction. This amount is counted as a negative amount.
    /// </summary>
    [IsoId("_6tylsDAsEeOqioR9srQH1g")]
    [DisplayName("Rebate")]
    [IsoXmlTag("Rbt")]
    public ValueList<DetailedAmount4> Rebate { get; init; } = [];

    /// <summary>
    /// Value added tax amount.
    /// </summary>
    [IsoId("_A-JJcDAtEeOqioR9srQH1g")]
    [DisplayName("Value Added Tax")]
    [IsoXmlTag("ValAddedTax")]
    public ValueList<DetailedAmount4> ValueAddedTax { get; init; } = [];
}
