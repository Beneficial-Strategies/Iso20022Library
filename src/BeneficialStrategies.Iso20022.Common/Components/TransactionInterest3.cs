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
/// Provide further details on transaction specific interest information that applies to the underlying transaction.
/// </summary>
[IsoId("_txJrIFkyEeGeoaLUQk__nA_-921369458")]
[DisplayName("Transaction Interest")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionInterest3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Total amount of interests and taxes included in the entry amount.
    /// </summary>
    [IsoId("_txJrIVkyEeGeoaLUQk__nA_-504205189")]
    [DisplayName("Total Interest And Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlIntrstAndTaxAmt")]
    #endif
    [IsoXmlTag("TtlIntrstAndTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalInterestAndTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalInterestAndTaxAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalInterestAndTaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Individual interest record.
    /// </summary>
    [IsoId("_txS1EFkyEeGeoaLUQk__nA_45439285")]
    [DisplayName("Record")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcrd")]
    #endif
    [IsoXmlTag("Rcrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRecord1? Record { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRecord1? Record { get; init; } 
    #else
    public InterestRecord1? Record { get; set; } 
    #endif
    
    
    #nullable disable
    
}
