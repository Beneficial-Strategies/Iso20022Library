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
/// Choice between a standard code or proprietary code to specify the type of interest computation method.
/// </summary>
[IsoId("_YO9D8XitEeqKjIYaFgh_2g")]
[DisplayName("Interest Computation Method Format")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InterestComputationMethodFormat7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InterestComputationMethodFormat7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InterestComputationMethodFormat7( InterestComputationMethod4Code reqCode )
    {
        Code = reqCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Standard code to specify the method used to compute accruing interest of a financial instrument.
    /// </summary>
    [IsoId("_YPsq0XitEeqKjIYaFgh_2g")]
    [DisplayName("Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cd")]
    #endif
    [IsoXmlTag("Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InterestComputationMethod4Code Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InterestComputationMethod4Code Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestComputationMethod4Code Code { get; init; } 
    #else
    public InterestComputationMethod4Code Code { get; set; } 
    #endif
    
    /// <summary>
    /// The computation method can not be represented in the predefined fields.
    /// </summary>
    [IsoId("_2h3KIH_yEeqdQubSe21TTw")]
    [DisplayName("Narrative")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nrrtv")]
    #endif
    [IsoXmlTag("Nrrtv")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1000Text? Narrative { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Narrative { get; init; } 
    #else
    public System.String? Narrative { get; set; } 
    #endif
    
    
    #nullable disable
    
}
