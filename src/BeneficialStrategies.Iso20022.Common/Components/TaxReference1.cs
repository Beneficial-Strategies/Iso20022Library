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
/// Pension scheme tax reference.
/// </summary>
[IsoId("_jUsPcE4QEeiQHa-q1Uephw")]
[DisplayName("Tax Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxReference1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TaxReference1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TaxReference1( System.String reqReference )
    {
        Reference = reqReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of tax reference.
    /// </summary>
    [IsoId("_x0JioE4QEeiQHa-q1Uephw")]
    [DisplayName("Tax Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxTp")]
    #endif
    [IsoXmlTag("TaxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxReferenceType1Choice_? TaxType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxReferenceType1Choice_? TaxType { get; init; } 
    #else
    public TaxReferenceType1Choice_? TaxType { get; set; } 
    #endif
    
    /// <summary>
    /// Tax reference.
    /// </summary>
    [IsoId("_1V_RsE4QEeiQHa-q1Uephw")]
    [DisplayName("Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ref")]
    #endif
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Reference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Reference { get; init; } 
    #else
    public System.String Reference { get; set; } 
    #endif
    
    /// <summary>
    /// Type of reference holder. For example, the transferee&apos;s tax reference. The transferee may also be known as the acquiring party.
    /// </summary>
    [IsoId("_refLoE4REeiQHa-q1Uephw")]
    [DisplayName("Holder Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldrTp")]
    #endif
    [IsoXmlTag("HldrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxReferenceParty1Choice_? HolderType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxReferenceParty1Choice_? HolderType { get; init; } 
    #else
    public TaxReferenceParty1Choice_? HolderType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
