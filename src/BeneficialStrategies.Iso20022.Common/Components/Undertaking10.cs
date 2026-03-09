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
/// Details related to the undertaking.
/// </summary>
[IsoId("_VAaxMH7pEeGudZE4UaJCHQ")]
[DisplayName("Undertaking")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Undertaking10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Details related to the requested new amount for the counter-undertaking.
    /// </summary>
    [IsoId("_YWoEwH75EeGvEbxvurqpIg")]
    [DisplayName("New Undertaking Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewUdrtkgAmt")]
    #endif
    [IsoXmlTag("NewUdrtkgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UndertakingAmount2? NewUndertakingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingAmount2? NewUndertakingAmount { get; init; } 
    #else
    public UndertakingAmount2? NewUndertakingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the requested new expiry terms for the counter-undertaking.
    /// </summary>
    [IsoId("_vndG8H75EeGvEbxvurqpIg")]
    [DisplayName("New Expiry Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewXpryDtls")]
    #endif
    [IsoXmlTag("NewXpryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExpiryDetails1? NewExpiryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExpiryDetails1? NewExpiryDetails { get; init; } 
    #else
    public ExpiryDetails1? NewExpiryDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
