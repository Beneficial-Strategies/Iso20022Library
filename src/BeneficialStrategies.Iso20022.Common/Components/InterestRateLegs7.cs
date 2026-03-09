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
/// Details related to interest rate attributes.
/// </summary>
[IsoId("_GOMJAQ1IEeqV4s5SpzR1dQ")]
[DisplayName("Interest Rate Legs")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InterestRateLegs7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Details concerning the rate in the first leg of an interest rate contract.
    /// </summary>
    [IsoId("_GO8-AQ1IEeqV4s5SpzR1dQ")]
    [DisplayName("First Leg")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstLeg")]
    #endif
    [IsoXmlTag("FrstLeg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRate21Choice_? FirstLeg { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRate21Choice_? FirstLeg { get; init; } 
    #else
    public InterestRate21Choice_? FirstLeg { get; set; } 
    #endif
    
    /// <summary>
    /// Details concerning the rate in the second leg of an interest rate contract.
    /// </summary>
    [IsoId("_GO8-Aw1IEeqV4s5SpzR1dQ")]
    [DisplayName("Second Leg")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndLeg")]
    #endif
    [IsoXmlTag("ScndLeg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRate21Choice_? SecondLeg { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRate21Choice_? SecondLeg { get; init; } 
    #else
    public InterestRate21Choice_? SecondLeg { get; set; } 
    #endif
    
    
    #nullable disable
    
}
