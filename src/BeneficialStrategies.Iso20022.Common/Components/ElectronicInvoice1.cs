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
/// Specifies details of the electronic invoice.
/// </summary>
[IsoId("_7qk3ikWdEempSe_3C1a9EQ")]
[DisplayName("Electronic Invoice")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ElectronicInvoice1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ElectronicInvoice1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ElectronicInvoice1( PresentmentType1Code reqPresentmentType )
    {
        PresentmentType = reqPresentmentType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of elements to be presented in the electronic invoice (e-invoice).
    /// </summary>
    [IsoId("_4OShYUWeEempSe_3C1a9EQ")]
    [DisplayName("Presentment Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PresntmntTp")]
    #endif
    [IsoXmlTag("PresntmntTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PresentmentType1Code PresentmentType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PresentmentType1Code PresentmentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PresentmentType1Code PresentmentType { get; init; } 
    #else
    public PresentmentType1Code PresentmentType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
