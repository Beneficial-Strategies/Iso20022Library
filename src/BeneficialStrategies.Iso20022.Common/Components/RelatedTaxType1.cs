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
/// Specifies the type of related tax.
/// </summary>
[IsoId("_UPYvktp-Ed-ak6NoX_4Aeg_1950331335")]
[DisplayName("Related Tax Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RelatedTaxType1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RelatedTaxType1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RelatedTaxType1( TaxType3FormatChoice_ reqTaxType,ActiveCurrencyAndAmount reqAmount )
    {
        TaxType = reqTaxType;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of tax.
    /// </summary>
    [IsoId("_UPYvk9p-Ed-ak6NoX_4Aeg_1967880045")]
    [DisplayName("Tax Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxTp")]
    #endif
    [IsoXmlTag("TaxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TaxType3FormatChoice_ TaxType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TaxType3FormatChoice_ TaxType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxType3FormatChoice_ TaxType { get; init; } 
    #else
    public TaxType3FormatChoice_ TaxType { get; set; } 
    #endif
    
    /// <summary>
    /// The value of the related tax expressed as an amount.
    /// </summary>
    [IsoId("_UPYvlNp-Ed-ak6NoX_4Aeg_1981731905")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount Amount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
