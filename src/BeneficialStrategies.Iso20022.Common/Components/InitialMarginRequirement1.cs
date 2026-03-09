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
/// Liability and assets that arise for a clearing member with respect to a central counterparty.
/// </summary>
[IsoId("_BTNckKpwEeamNLogr5TkIQ")]
[DisplayName("Initial Margin Requirement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InitialMarginRequirement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InitialMarginRequirement1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InitialMarginRequirement1( ActiveCurrencyAndAmount reqCredit )
    {
        Credit = reqCredit;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Liability a clearing member has to a central counterparty with respect to potential future exposures.
    /// </summary>
    [IsoId("_iLGYQKpzEeamNLogr5TkIQ")]
    [DisplayName("Initial Margin Exposure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlMrgnXpsr")]
    #endif
    [IsoXmlTag("InitlMrgnXpsr")]
    public ValueList<InitialMarginExposure1> InitialMarginExposure { get; init; } = new ValueList<InitialMarginExposure1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _iLGYQKpzEeamNLogr5TkIQ
    
    /// <summary>
    /// Total value of any credits offsetable against initial margin requirements at the end of day. For example, net liquidating value of option positions, contingent variation margin, delivery credits.
    /// </summary>
    [IsoId("_rCMxQKpyEeamNLogr5TkIQ")]
    [DisplayName("Credit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdt")]
    #endif
    [IsoXmlTag("Cdt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount Credit { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount Credit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount Credit { get; init; } 
    #else
    public ActiveCurrencyAndAmount Credit { get; set; } 
    #endif
    
    
    #nullable disable
    
}
