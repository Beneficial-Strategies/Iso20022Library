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
/// Asset class specific details of a derivative.
/// </summary>
[IsoId("_Hx9E0cnYEeWpf-ImB_F2gQ")]
[DisplayName("Asset Class Attributes")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AssetClassAttributes1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AssetClassAttributes1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AssetClassAttributes1( DerivativeInterest2 reqInterest,DerivativeForeignExchange2 reqForeignExchange )
    {
        Interest = reqInterest;
        ForeignExchange = reqForeignExchange;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Asset class is a non-financial instrument of type interest rate.
    /// </summary>
    [IsoId("_IO1OE8nYEeWpf-ImB_F2gQ")]
    [DisplayName("Interest")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Intrst")]
    #endif
    [IsoXmlTag("Intrst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DerivativeInterest2 Interest { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DerivativeInterest2 Interest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DerivativeInterest2 Interest { get; init; } 
    #else
    public DerivativeInterest2 Interest { get; set; } 
    #endif
    
    /// <summary>
    /// Asset class is a non-financial instrument of type foreign exchange.
    /// </summary>
    [IsoId("_IO1OFcnYEeWpf-ImB_F2gQ")]
    [DisplayName("Foreign Exchange")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FX")]
    #endif
    [IsoXmlTag("FX")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DerivativeForeignExchange2 ForeignExchange { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DerivativeForeignExchange2 ForeignExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DerivativeForeignExchange2 ForeignExchange { get; init; } 
    #else
    public DerivativeForeignExchange2 ForeignExchange { get; set; } 
    #endif
    
    
    #nullable disable
    
}
