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
/// Information about a blocked holding.
/// </summary>
[IsoId("_H0B8ESGdEeWKAaDJcYGKLw")]
[DisplayName("Blocked Holding Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BlockedHoldingDetails2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BlockedHoldingDetails2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BlockedHoldingDetails2( Holding1Code reqBlockedHolding )
    {
        BlockedHolding = reqBlockedHolding;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies how the blocked account holding is defined.
    /// </summary>
    [IsoId("_IQ5eSSGdEeWKAaDJcYGKLw")]
    [DisplayName("Blocked Holding")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckdHldg")]
    #endif
    [IsoXmlTag("BlckdHldg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Holding1Code BlockedHolding { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Holding1Code BlockedHolding { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Holding1Code BlockedHolding { get; init; } 
    #else
    public Holding1Code BlockedHolding { get; set; } 
    #endif
    
    /// <summary>
    /// When an account is blocked at the level of fund or security, partially, this is the number of units blocked.
    /// </summary>
    [IsoId("_IQ5eSyGdEeWKAaDJcYGKLw")]
    [DisplayName("Partial Holding Units")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlHldgUnits")]
    #endif
    [IsoXmlTag("PrtlHldgUnits")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? PartialHoldingUnits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PartialHoldingUnits { get; init; } 
    #else
    public System.UInt64? PartialHoldingUnits { get; set; } 
    #endif
    
    /// <summary>
    /// When an account is blocked at the level of fund or security, this specifies the certificate number of the blocked units.
    /// </summary>
    [IsoId("_IQ5eTSGdEeWKAaDJcYGKLw")]
    [DisplayName("Holding Certificate Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldgCertNb")]
    #endif
    [IsoXmlTag("HldgCertNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? HoldingCertificateNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? HoldingCertificateNumber { get; init; } 
    #else
    public System.String? HoldingCertificateNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
