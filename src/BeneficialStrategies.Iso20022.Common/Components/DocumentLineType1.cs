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
/// Specifies the type of the document line identification.
/// </summary>
[IsoId("_cX4kMablEeKvUvwX_r3tzA")]
[DisplayName("Document Line Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DocumentLineType1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DocumentLineType1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DocumentLineType1( DocumentLineType1Choice_ reqCodeOrProprietary )
    {
        CodeOrProprietary = reqCodeOrProprietary;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the type details of the referred document line identification.
    /// </summary>
    [IsoId("_ciKhlablEeKvUvwX_r3tzA")]
    [DisplayName("Code Or Proprietary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdOrPrtry")]
    #endif
    [IsoXmlTag("CdOrPrtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentLineType1Choice_ CodeOrProprietary { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentLineType1Choice_ CodeOrProprietary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentLineType1Choice_ CodeOrProprietary { get; init; } 
    #else
    public DocumentLineType1Choice_ CodeOrProprietary { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the issuer of the reference document line identificationtype.
    /// </summary>
    [IsoId("_ciKhmablEeKvUvwX_r3tzA")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Issuer { get; init; } 
    #else
    public System.String? Issuer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
