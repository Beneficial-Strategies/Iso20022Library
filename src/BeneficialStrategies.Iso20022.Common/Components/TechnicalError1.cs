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
/// Specifies information concerning the technical error that prevented delivery of the referenced messaging by the payment gateway application.
/// </summary>
[IsoId("_-CoNsw23EeWH49U6bkyMaA")]
[DisplayName("Technical Error")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TechnicalError1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TechnicalError1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TechnicalError1( ErrorSeverity1Code reqSeverity,TechnicalError1Choice_ reqErrorCode )
    {
        Severity = reqSeverity;
        ErrorCode = reqErrorCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the severity of the related error.
    /// </summary>
    [IsoId("_DP8UMg3FEeWH49U6bkyMaA")]
    [DisplayName("Severity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="svrty")]
    #endif
    [IsoXmlTag("svrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ErrorSeverity1Code Severity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ErrorSeverity1Code Severity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ErrorSeverity1Code Severity { get; init; } 
    #else
    public ErrorSeverity1Code Severity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the error code.
    /// </summary>
    [IsoId("_qpz94A3CEeWH49U6bkyMaA")]
    [DisplayName("Error Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ErrCd")]
    #endif
    [IsoXmlTag("ErrCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TechnicalError1Choice_ ErrorCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TechnicalError1Choice_ ErrorCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TechnicalError1Choice_ ErrorCode { get; init; } 
    #else
    public TechnicalError1Choice_ ErrorCode { get; set; } 
    #endif
    
    /// <summary>
    /// Specification of the error, in free format.
    /// </summary>
    [IsoId("_-CoNtA23EeWH49U6bkyMaA")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    public SimpleValueList<System.String> Description { get; init; } = new SimpleValueList<System.String>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _-CoNtA23EeWH49U6bkyMaA
    
    
    #nullable disable
    
}
