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
/// Information about hold back.
/// </summary>
[IsoId("_SdsIetp-Ed-ak6NoX_4Aeg_1440751245")]
[DisplayName("Hold Back Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record HoldBackInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Value of the redemption amount subject to hold back.
    /// </summary>
    [IsoId("_SdsIe9p-Ed-ak6NoX_4Aeg_1820317430")]
    [DisplayName("Hold Back Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldBckAmt")]
    #endif
    [IsoXmlTag("HldBckAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? HoldBackAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? HoldBackAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? HoldBackAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the hold back amount is to be released.
    /// </summary>
    [IsoId("_SdsIfNp-Ed-ak6NoX_4Aeg_-2030432920")]
    [DisplayName("Hold Back Release Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldBckRlsDt")]
    #endif
    [IsoXmlTag("HldBckRlsDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? HoldBackReleaseDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? HoldBackReleaseDate { get; init; } 
    #else
    public System.DateOnly? HoldBackReleaseDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
