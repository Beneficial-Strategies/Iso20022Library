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
/// Provides for regional taxes on the service.
/// </summary>
[IsoId("_6RcRdZqlEeGSON8vddiWzQ_-658807987")]
[DisplayName("Billing Services Tax")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BillingServicesTax3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BillingServicesTax3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BillingServicesTax3( System.String reqNumber,System.UInt64 reqRate,AmountAndDirection34 reqTotalTaxAmount )
    {
        Number = reqNumber;
        Rate = reqRate;
        TotalTaxAmount = reqTotalTaxAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification number of the specific region tax used to calculate the tax.
    /// </summary>
    [IsoId("_6RcRdpqlEeGSON8vddiWzQ_-1655880340")]
    [DisplayName("Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nb")]
    #endif
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Number { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Number { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Number { get; init; } 
    #else
    public System.String Number { get; set; } 
    #endif
    
    /// <summary>
    /// Name used to describe the tax (such as the national value added tax).
    /// </summary>
    [IsoId("_6RcRd5qlEeGSON8vddiWzQ_1528175537")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max40Text)]
    [StringLength(maximumLength: 40 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax40Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    [IsoId("_6RcReJqlEeGSON8vddiWzQ_-352130103")]
    [DisplayName("Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rate")]
    #endif
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoDecimalNumber Rate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Rate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Rate { get; init; } 
    #else
    public System.UInt64 Rate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the tax obligation for taxable services within a tax region for a specific tax identifier (such as national value added tax equals 34,00), and expressed in the tax region’s host currency.
    /// </summary>
    [IsoId("_6RmCcJqlEeGSON8vddiWzQ_2143637300")]
    [DisplayName("Total Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlTaxAmt")]
    #endif
    [IsoXmlTag("TtlTaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection34 TotalTaxAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection34 TotalTaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34 TotalTaxAmount { get; init; } 
    #else
    public AmountAndDirection34 TotalTaxAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
