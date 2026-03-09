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
/// Detailed information on rejections for derivatives submitted to trade repositories and failed to pass validations.
/// </summary>
[IsoId("_MwencVfdEeqZr5K1Woax-g")]
[DisplayName("Rejection Statistics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RejectionStatistics3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RejectionStatistics3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RejectionStatistics3( System.UInt64 reqTotalNumberOfTechnicalRejections,DerivativesStatistics3 reqDerivativesStatistics )
    {
        TotalNumberOfTechnicalRejections = reqTotalNumberOfTechnicalRejections;
        DerivativesStatistics = reqDerivativesStatistics;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total number of derivatives submitted by the report submitting entity for the reporting counterparty which failed to pass technical schema validations.
    /// </summary>
    [IsoId("_NHlf4VfdEeqZr5K1Woax-g")]
    [DisplayName("Total Number Of Technical Rejections")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfTechRjctns")]
    #endif
    [IsoXmlTag("TtlNbOfTechRjctns")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax20PositiveNumber TotalNumberOfTechnicalRejections { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 TotalNumberOfTechnicalRejections { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 TotalNumberOfTechnicalRejections { get; init; } 
    #else
    public System.UInt64 TotalNumberOfTechnicalRejections { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information on rejections for derivatives submitted to trade repositories and failed to pass data validations.
    /// </summary>
    [IsoId("_NHlf41fdEeqZr5K1Woax-g")]
    [DisplayName("Derivatives Statistics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DerivsSttstcs")]
    #endif
    [IsoXmlTag("DerivsSttstcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DerivativesStatistics3 DerivativesStatistics { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DerivativesStatistics3 DerivativesStatistics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DerivativesStatistics3 DerivativesStatistics { get; init; } 
    #else
    public DerivativesStatistics3 DerivativesStatistics { get; set; } 
    #endif
    
    
    #nullable disable
    
}
