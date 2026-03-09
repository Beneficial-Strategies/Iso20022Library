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
/// Reference of an order, order cancellation and master reference.
/// </summary>
[IsoId("_TSlwKNp-Ed-ak6NoX_4Aeg_-337332402")]
[DisplayName("Investment Fund Order")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentFundOrder1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_TSu6ENp-Ed-ak6NoX_4Aeg_-2008589874")]
    [DisplayName("Master Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrRef")]
    #endif
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MasterReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MasterReference { get; init; } 
    #else
    public System.String? MasterReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of an order and order cancellation.
    /// </summary>
    [IsoId("_TSu6Edp-Ed-ak6NoX_4Aeg_1448063042")]
    [DisplayName("Order References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrRefs")]
    #endif
    [IsoXmlTag("OrdrRefs")]
    public ValueList<InvestmentFundOrder5> OrderReferences { get; init; } = new ValueList<InvestmentFundOrder5>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _TSu6Edp-Ed-ak6NoX_4Aeg_1448063042
    
    
    #nullable disable
    
}
