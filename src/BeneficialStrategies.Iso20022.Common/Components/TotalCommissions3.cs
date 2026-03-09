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
/// Total amount of commissions related to a specific order.
/// </summary>
[IsoId("_RrxjX9p-Ed-ak6NoX_4Aeg_-940532207")]
[DisplayName("Total Commissions")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TotalCommissions3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Total value of the commissions for a specific order.
    /// </summary>
    [IsoId("_Rr6tQNp-Ed-ak6NoX_4Aeg_-940531964")]
    [DisplayName("Total Amount Of Commissions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmtOfComssns")]
    #endif
    [IsoXmlTag("TtlAmtOfComssns")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? TotalAmountOfCommissions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? TotalAmountOfCommissions { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? TotalAmountOfCommissions { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to a specific commission.
    /// </summary>
    [IsoId("_Rr6tQdp-Ed-ak6NoX_4Aeg_-940531912")]
    [DisplayName("Commission Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComssnDtls")]
    #endif
    [IsoXmlTag("ComssnDtls")]
    public ValueList<Commission10> CommissionDetails { get; init; } = new ValueList<Commission10>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Rr6tQdp-Ed-ak6NoX_4Aeg_-940531912
    
    
    #nullable disable
    
}
