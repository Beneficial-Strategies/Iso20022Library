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
/// Acquirer involved in the card payment.
/// </summary>
[IsoId("_Fgq1ARzyEeK5OKMB21JFBg")]
[DisplayName("Acquirer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Acquirer3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Acquirer3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Acquirer3( GenericIdentification32 reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the acquirer (for example the bank identification number BIN).
    /// </summary>
    [IsoId("_Fs3d9RzyEeK5OKMB21JFBg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification32 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification32 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification32 Identification { get; init; } 
    #else
    public GenericIdentification32 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Version of the payment acquirer parameters of the POI.
    /// </summary>
    [IsoId("_Fs3d_BzyEeK5OKMB21JFBg")]
    [DisplayName("Parameters Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ParamsVrsn")]
    #endif
    [IsoXmlTag("ParamsVrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ParametersVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ParametersVersion { get; init; } 
    #else
    public System.String? ParametersVersion { get; set; } 
    #endif
    
    
    #nullable disable
    
}
