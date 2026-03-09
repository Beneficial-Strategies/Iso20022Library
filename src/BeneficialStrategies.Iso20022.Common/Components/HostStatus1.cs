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
/// State of a Host.
/// </summary>
[IsoId("_N2O4cN6MEeiwsev40qZGEQ")]
[DisplayName("Host Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record HostStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a HostStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public HostStatus1( System.String reqAcquirerIdentification )
    {
        AcquirerIdentification = reqAcquirerIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the Acquirer.
    /// </summary>
    [IsoId("_Teh9sN6MEeiwsev40qZGEQ")]
    [DisplayName("Acquirer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrrId")]
    #endif
    [IsoXmlTag("AcqrrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text AcquirerIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AcquirerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AcquirerIdentification { get; init; } 
    #else
    public System.String AcquirerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicate if a Host is reachable.
    /// </summary>
    [IsoId("_WWtEsN6MEeiwsev40qZGEQ")]
    [DisplayName("Reachable")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rchbl")]
    #endif
    [IsoXmlTag("Rchbl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? Reachable { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Reachable { get; init; } 
    #else
    public System.String? Reachable { get; set; } 
    #endif
    
    
    #nullable disable
    
}
