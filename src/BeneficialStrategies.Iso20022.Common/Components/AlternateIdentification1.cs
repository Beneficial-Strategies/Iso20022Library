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
/// Alternate identification of a security.
/// </summary>
[IsoId("_TBTL0tp-Ed-ak6NoX_4Aeg_1536045465")]
[DisplayName("Alternate Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AlternateIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AlternateIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AlternateIdentification1( System.String reqIdentification,IdentificationSource1Choice_ reqIdentificationSource )
    {
        Identification = reqIdentification;
        IdentificationSource = reqIdentificationSource;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a security.
    /// </summary>
    [IsoId("_TBTL09p-Ed-ak6NoX_4Aeg_2021814610")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Source of the security identification.
    /// </summary>
    [IsoId("_TBTL1Np-Ed-ak6NoX_4Aeg_-1724730736")]
    [DisplayName("Identification Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IdSrc")]
    #endif
    [IsoXmlTag("IdSrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IdentificationSource1Choice_ IdentificationSource { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IdentificationSource1Choice_ IdentificationSource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IdentificationSource1Choice_ IdentificationSource { get; init; } 
    #else
    public IdentificationSource1Choice_ IdentificationSource { get; set; } 
    #endif
    
    
    #nullable disable
    
}
