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
/// Specifies the type, date and version of the agreement.
/// </summary>
[IsoId("_bedvoJUTEea7vKctaoIyEQ")]
[DisplayName("Agreement Conditions")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AgreementConditions1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AgreementConditions1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AgreementConditions1( System.String reqAgreementCode )
    {
        AgreementCode = reqAgreementCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of agreement.
    /// </summary>
    [IsoId("_LS4cYJUUEea7vKctaoIyEQ")]
    [DisplayName("Agreement Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgrmtCd")]
    #endif
    [IsoXmlTag("AgrmtCd")]
    [IsoSimpleType(IsoSimpleType.Max6AlphaText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax6AlphaText AgreementCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AgreementCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AgreementCode { get; init; } 
    #else
    public System.String AgreementCode { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date of the agreement.
    /// </summary>
    [IsoId("_6QcZoJUUEea7vKctaoIyEQ")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? Date { get; init; } 
    #else
    public System.DateOnly? Date { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the version of the agreement.
    /// </summary>
    [IsoId("_-vvPcJUUEea7vKctaoIyEQ")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Exact4NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact4NumericText? Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Version { get; init; } 
    #else
    public System.String? Version { get; set; } 
    #endif
    
    
    #nullable disable
    
}
