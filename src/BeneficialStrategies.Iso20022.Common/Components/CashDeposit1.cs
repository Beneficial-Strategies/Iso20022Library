// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Deposit of an amount of money defined in cash notes and/or coins.
/// </summary>
[IsoId("_t0kyllkyEeGeoaLUQk__nA_-1150554853")]
[DisplayName("Cash Deposit")]
public partial record CashDeposit1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the note or coin denomination, including the currency, such as a 50 euro note.
    /// </summary>
    [IsoId("_t0ujkFkyEeGeoaLUQk__nA_1181780870")]
    [DisplayName("Note Denomination")]
    [IsoXmlTag("NoteDnmtn")]
    public required ActiveCurrencyAndAmount NoteDenomination { get; init; } 
    
    /// <summary>
    /// Specifies the number of notes of the same denomination in the deposit.
    /// </summary>
    [IsoId("_t0ujkVkyEeGeoaLUQk__nA_-1821036106")]
    [DisplayName("Number Of Notes")]
    [IsoXmlTag("NbOfNotes")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfNotes { get; init; } 
    
    /// <summary>
    /// Specifies the total amount of money in the cash deposit, that is the note denomination times the number of notes.
    /// </summary>
    [IsoId("_t0ujklkyEeGeoaLUQk__nA_-754114545")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    
    #nullable disable
    
}
