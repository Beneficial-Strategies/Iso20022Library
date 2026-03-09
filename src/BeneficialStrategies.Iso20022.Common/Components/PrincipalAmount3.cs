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
/// Indication of the cash values to be settled as of the start and maturity date of the transaction.
/// </summary>
[IsoId("_-cnGsa5MEeuo-IflVgGqiA")]
[DisplayName("Principal Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PrincipalAmount3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Cash value to be settled as of the start date of the transaction.
    /// </summary>
    [IsoId("_-r0AUa5MEeuo-IflVgGqiA")]
    [DisplayName("Value Date Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDtAmt")]
    #endif
    [IsoXmlTag("ValDtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? ValueDateAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? ValueDateAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? ValueDateAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Cash value to be settled as of the maturity date of the transaction.
    /// </summary>
    [IsoId("_-r0AU65MEeuo-IflVgGqiA")]
    [DisplayName("Maturity Date Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDtAmt")]
    #endif
    [IsoXmlTag("MtrtyDtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? MaturityDateAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? MaturityDateAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? MaturityDateAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
