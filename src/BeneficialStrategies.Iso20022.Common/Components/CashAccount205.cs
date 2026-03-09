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
/// Account to or from which a cash entry is made.
/// </summary>
[IsoId("_ol7pkdASEeuSBa1PsnseFg")]
[DisplayName("Cash Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashAccount205
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency of the settlement.
    /// </summary>
    [IsoId("_o68QQ9ASEeuSBa1PsnseFg")]
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
    /// Cash account for settlement.
    /// </summary>
    [IsoId("_o68QRdASEeuSBa1PsnseFg")]
    [DisplayName("Primary Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmryAcct")]
    #endif
    [IsoXmlTag("PmryAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount206? PrimaryAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount206? PrimaryAccount { get; init; } 
    #else
    public CashAccount206? PrimaryAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-division of a master or omnibus cash account.
    /// </summary>
    [IsoId("_o68QR9ASEeuSBa1PsnseFg")]
    [DisplayName("Secondary Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndryAcct")]
    #endif
    [IsoXmlTag("ScndryAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount206? SecondaryAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount206? SecondaryAccount { get; init; } 
    #else
    public CashAccount206? SecondaryAccount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
