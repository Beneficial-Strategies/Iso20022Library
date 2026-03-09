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
/// Unique and unambiguous way to identify a person.
/// </summary>
[IsoId("_QENImdp-Ed-ak6NoX_4Aeg_1939129475")]
[DisplayName("Person Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PersonIdentification6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PersonIdentification6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PersonIdentification6( PersonIdentificationType1Choice_ reqPersonIdentificationType )
    {
        PersonIdentificationType = reqPersonIdentificationType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Entity that assigns the identifier.
    /// </summary>
    [IsoId("_QENImtp-Ed-ak6NoX_4Aeg_1939130030")]
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
    
    /// <summary>
    /// Personal identification type.
    /// </summary>
    [IsoId("_QEW5kNp-Ed-ak6NoX_4Aeg_2117937583")]
    [DisplayName("Person Identification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrsnIdTp")]
    #endif
    [IsoXmlTag("PrsnIdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PersonIdentificationType1Choice_ PersonIdentificationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PersonIdentificationType1Choice_ PersonIdentificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PersonIdentificationType1Choice_ PersonIdentificationType { get; init; } 
    #else
    public PersonIdentificationType1Choice_ PersonIdentificationType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
