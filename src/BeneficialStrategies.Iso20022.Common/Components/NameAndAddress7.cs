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
/// Name and address of an institution.
/// </summary>
[IsoId("_PZleQdp-Ed-ak6NoX_4Aeg_1385273164")]
[DisplayName("Name And Address")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NameAndAddress7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NameAndAddress7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NameAndAddress7( System.String reqName,PostalAddress1 reqPostalAddress )
    {
        Name = reqName;
        PostalAddress = reqPostalAddress;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_PZleQtp-Ed-ak6NoX_4Aeg_1385273243")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax70Text Name { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Name { get; init; } 
    #else
    public System.String Name { get; set; } 
    #endif
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_PZleQ9p-Ed-ak6NoX_4Aeg_1385275042")]
    [DisplayName("Postal Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstlAdr")]
    #endif
    [IsoXmlTag("PstlAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PostalAddress1 PostalAddress { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PostalAddress1 PostalAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress1 PostalAddress { get; init; } 
    #else
    public PostalAddress1 PostalAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
