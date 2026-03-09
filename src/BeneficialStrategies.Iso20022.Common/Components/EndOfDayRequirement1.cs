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
/// Obligations of a clearing member with respect to a central counterparty that are calculated based on end of day positions.
/// </summary>
[IsoId("__p1KALC8EeaSl6vJk5Bd8w")]
[DisplayName("End Of Day Requirement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EndOfDayRequirement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the initial margin requirement for position.
    /// </summary>
    [IsoId("_TC3bQLC9EeaSl6vJk5Bd8w")]
    [DisplayName("Initial Margin Requirement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlMrgnRqrmnt")]
    #endif
    [IsoXmlTag("InitlMrgnRqrmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? InitialMarginRequirement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? InitialMarginRequirement { get; init; } 
    #else
    public ActiveCurrencyAndAmount? InitialMarginRequirement { get; set; } 
    #endif
    
    /// <summary>
    /// Daily change in mark-to-market for the associated position. Indicates whether variation margin paid to clearing members (true) or received from clearing members (false).
    /// </summary>
    [IsoId("_VNaAMLC9EeaSl6vJk5Bd8w")]
    [DisplayName("Variation Margin Requirement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgnRqrmnt")]
    #endif
    [IsoXmlTag("VartnMrgnRqrmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection102? VariationMarginRequirement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102? VariationMarginRequirement { get; init; } 
    #else
    public AmountAndDirection102? VariationMarginRequirement { get; set; } 
    #endif
    
    
    #nullable disable
    
}
