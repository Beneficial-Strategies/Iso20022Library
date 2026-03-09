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
/// Current totals of the ATM.
/// </summary>
[IsoId("_XPWq4IqdEeS4a4abTJTSSw")]
[DisplayName("ATM Totals")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMTotals1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of media inside the cassette.
    /// </summary>
    [IsoId("_H7ZjMIqeEeS4a4abTJTSSw")]
    [DisplayName("Media Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MdiaTp")]
    #endif
    [IsoXmlTag("MdiaTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMMediaType1Code? MediaType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMMediaType1Code? MediaType { get; init; } 
    #else
    public ATMMediaType1Code? MediaType { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the totals.
    /// </summary>
    [IsoId("_QIrGoIqeEeS4a4abTJTSSw")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Total balance of the ATM including reject cassette, but excluding the retract cassette.
    /// </summary>
    [IsoId("_iyycYIqeEeS4a4abTJTSSw")]
    [DisplayName("ATM Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMBal")]
    #endif
    [IsoXmlTag("ATMBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? ATMBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? ATMBalance { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? ATMBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Available amount for dispense in the ATM.
    /// </summary>
    [IsoId("_pmgL4IqeEeS4a4abTJTSSw")]
    [DisplayName("ATM Current")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMCur")]
    #endif
    [IsoXmlTag("ATMCur")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? ATMCurrent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? ATMCurrent { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? ATMCurrent { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of units for non-valued media, including reject cassette.
    /// </summary>
    [IsoId("_uaqecIqeEeS4a4abTJTSSw")]
    [DisplayName("ATM Balance Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMBalNb")]
    #endif
    [IsoXmlTag("ATMBalNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? ATMBalanceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ATMBalanceNumber { get; init; } 
    #else
    public System.UInt64? ATMBalanceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of units for non-valued media, excluding reject cassette.
    /// </summary>
    [IsoId("_yIVqEIqeEeS4a4abTJTSSw")]
    [DisplayName("ATM Current Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMCurNb")]
    #endif
    [IsoXmlTag("ATMCurNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? ATMCurrentNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ATMCurrentNumber { get; init; } 
    #else
    public System.UInt64? ATMCurrentNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
