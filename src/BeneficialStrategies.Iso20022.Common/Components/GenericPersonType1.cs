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
/// Specifies a generic type of identification requested for a person.
/// </summary>
[IsoId("_lvDzgnFwEemaN4ndAVY1ZQ")]
[DisplayName("Generic Person Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GenericPersonType1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GenericPersonType1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GenericPersonType1( System.String reqRequested,PersonIdentificationSchemeName1Choice_ reqSchemeName )
    {
        Requested = reqRequested;
        SchemeName = reqSchemeName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the private type for the customer identification is requested or not.
    /// </summary>
    [IsoId("_lvDzhHFwEemaN4ndAVY1ZQ")]
    [DisplayName("Requested")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Reqd")]
    #endif
    [IsoXmlTag("Reqd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator Requested { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Requested { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Requested { get; init; } 
    #else
    public System.String Requested { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    [IsoId("_lvDzhnFwEemaN4ndAVY1ZQ")]
    [DisplayName("Scheme Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SchmeNm")]
    #endif
    [IsoXmlTag("SchmeNm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PersonIdentificationSchemeName1Choice_ SchemeName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PersonIdentificationSchemeName1Choice_ SchemeName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PersonIdentificationSchemeName1Choice_ SchemeName { get; init; } 
    #else
    public PersonIdentificationSchemeName1Choice_ SchemeName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
