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
/// Transparency calculation specific details on a bond derivative.
/// </summary>
[IsoId("_s736gWlJEeaLAKoEUNsD9g")]
[DisplayName("Bond Derivative")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BondDerivative2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BondDerivative2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BondDerivative2( System.String reqIssuer )
    {
        Issuer = reqIssuer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Legal Entity Identifier (LEI) code of the issuer of the direct or ultimate underlying bond.
    /// </summary>
    [IsoId("_tFkCAWlJEeaLAKoEUNsD9g")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoLEIIdentifier Issuer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Issuer { get; init; } 
    #else
    public System.String Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Date of maturity of the underlying bond. This field applies to debt instruments with defined maturity.
    /// </summary>
    [IsoId("_tFkCA2lJEeaLAKoEUNsD9g")]
    [DisplayName("Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDt")]
    #endif
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? MaturityDate { get; init; } 
    #else
    public System.DateOnly? MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Populated with the issuance date of the underlying bond.
    /// </summary>
    [IsoId("_zoY10GlJEeaLAKoEUNsD9g")]
    [DisplayName("Issuance Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssncDt")]
    #endif
    [IsoXmlTag("IssncDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? IssuanceDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? IssuanceDate { get; init; } 
    #else
    public System.DateOnly? IssuanceDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
