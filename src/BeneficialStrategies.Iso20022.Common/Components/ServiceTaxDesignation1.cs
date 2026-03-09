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
/// Designates the tax calculation to be applied on a service.
/// </summary>
[IsoId("_6RJWjpqlEeGSON8vddiWzQ_-263337197")]
[DisplayName("Service Tax Designation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ServiceTaxDesignation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ServiceTaxDesignation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ServiceTaxDesignation1( ServiceTaxDesignation1Code reqCode )
    {
        Code = reqCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the taxable status of the service.
    /// </summary>
    [IsoId("_6RJWj5qlEeGSON8vddiWzQ_1442912136")]
    [DisplayName("Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cd")]
    #endif
    [IsoXmlTag("Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ServiceTaxDesignation1Code Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ServiceTaxDesignation1Code Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ServiceTaxDesignation1Code Code { get; init; } 
    #else
    public ServiceTaxDesignation1Code Code { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the tax region associated with the service. This element must be present if taxes are involved with any portion of the statement.
    /// </summary>
    [IsoId("_6RJWkJqlEeGSON8vddiWzQ_115283382")]
    [DisplayName("Region")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rgn")]
    #endif
    [IsoXmlTag("Rgn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Region { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Region { get; init; } 
    #else
    public System.String? Region { get; set; } 
    #endif
    
    /// <summary>
    /// Provides free form explanations of the various tax codes used within the statement.
    /// </summary>
    [IsoId("_6RSgcJqlEeGSON8vddiWzQ_1740386990")]
    [DisplayName("Tax Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRsn")]
    #endif
    [IsoXmlTag("TaxRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxReason1? TaxReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxReason1? TaxReason { get; init; } 
    #else
    public TaxReason1? TaxReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
