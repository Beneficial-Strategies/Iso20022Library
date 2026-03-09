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
/// Guarantee funds details.
/// </summary>
[IsoId("_IhrDAB92EeapDZRA0Hb6ow")]
[DisplayName("Guarantee Funds")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GuaranteeFunds1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GuaranteeFunds1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GuaranteeFunds1( System.String reqGuaranteeFundsUsageType )
    {
        GuaranteeFundsUsageType = reqGuaranteeFundsUsageType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type for the guarantee funds used.
    /// </summary>
    [IsoId("_V6KHEB92EeapDZRA0Hb6ow")]
    [DisplayName("Guarantee Funds Usage Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrntFndsUsgTp")]
    #endif
    [IsoXmlTag("GrntFndsUsgTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text GuaranteeFundsUsageType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String GuaranteeFundsUsageType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String GuaranteeFundsUsageType { get; init; } 
    #else
    public System.String GuaranteeFundsUsageType { get; set; } 
    #endif
    
    /// <summary>
    /// Owner and account number of the guarantee fund.
    /// </summary>
    [IsoId("_VZlMICciEeaBPexHR4QTEw")]
    [DisplayName("Guarantee Fund Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrntFndInf")]
    #endif
    [IsoXmlTag("GrntFndInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GuaranteeFundInformation1? GuaranteeFundInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GuaranteeFundInformation1? GuaranteeFundInformation { get; init; } 
    #else
    public GuaranteeFundInformation1? GuaranteeFundInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
