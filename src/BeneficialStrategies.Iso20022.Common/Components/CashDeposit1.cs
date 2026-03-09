// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Deposit of an amount of money defined in cash notes and/or coins.
/// </summary>
[IsoId("_t0kyllkyEeGeoaLUQk__nA_-1150554853")]
[DisplayName("Cash Deposit")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashDeposit1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashDeposit1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashDeposit1( ActiveCurrencyAndAmount reqNoteDenomination,System.String reqNumberOfNotes,ActiveCurrencyAndAmount reqAmount )
    {
        NoteDenomination = reqNoteDenomination;
        NumberOfNotes = reqNumberOfNotes;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the note or coin denomination, including the currency, such as a 50 euro note.
    /// </summary>
    [IsoId("_t0ujkFkyEeGeoaLUQk__nA_1181780870")]
    [DisplayName("Note Denomination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NoteDnmtn")]
    #endif
    [IsoXmlTag("NoteDnmtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount NoteDenomination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount NoteDenomination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount NoteDenomination { get; init; } 
    #else
    public ActiveCurrencyAndAmount NoteDenomination { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the number of notes of the same denomination in the deposit.
    /// </summary>
    [IsoId("_t0ujkVkyEeGeoaLUQk__nA_-1821036106")]
    [DisplayName("Number Of Notes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfNotes")]
    #endif
    [IsoXmlTag("NbOfNotes")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText NumberOfNotes { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String NumberOfNotes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String NumberOfNotes { get; init; } 
    #else
    public System.String NumberOfNotes { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the total amount of money in the cash deposit, that is the note denomination times the number of notes.
    /// </summary>
    [IsoId("_t0ujklkyEeGeoaLUQk__nA_-754114545")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount Amount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
