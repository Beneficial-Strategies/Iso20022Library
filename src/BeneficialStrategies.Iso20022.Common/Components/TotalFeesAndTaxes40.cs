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
/// Amount of money associated with a service.
/// </summary>
[IsoId("_VJEXMDh2EeamLZQeccJa7w")]
[DisplayName("Total Fees And Taxes")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TotalFeesAndTaxes40
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Total amount of overhead applied to the transaction that impacts the settlement amount.
    /// </summary>
    [IsoId("_k2yNQTh2EeamLZQeccJa7w")]
    [DisplayName("Total Overhead Applied")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlOvrhdApld")]
    #endif
    [IsoXmlTag("TtlOvrhdApld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalOverheadApplied { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalOverheadApplied { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalOverheadApplied { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of fees (charge/commissions) applied to the transaction that impacts the settlement amount.
    /// </summary>
    [IsoId("_5R60sTh2EeamLZQeccJa7w")]
    [DisplayName("Total Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlFees")]
    #endif
    [IsoXmlTag("TtlFees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalFees { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalFees { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of taxes applied to the transaction that impacts the settlement amount.
    /// </summary>
    [IsoId("_-H0zsTh2EeamLZQeccJa7w")]
    [DisplayName("Total Taxes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlTaxs")]
    #endif
    [IsoXmlTag("TtlTaxs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalTaxes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalTaxes { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalTaxes { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the agreement established between the fund and another party. This element, amongst others, defines the conditions of the commissions.
    /// </summary>
    [IsoId("_Bufe0XTEEea79aegl3yVYg")]
    [DisplayName("Commercial Agreement Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComrclAgrmtRef")]
    #endif
    [IsoXmlTag("ComrclAgrmtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CommercialAgreementReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CommercialAgreementReference { get; init; } 
    #else
    public System.String? CommercialAgreementReference { get; set; } 
    #endif
    
    /// <summary>
    /// Individual fee (charge/commission).
    /// </summary>
    [IsoId("_uoKLQDh3EeamLZQeccJa7w")]
    [DisplayName("Individual Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndvFee")]
    #endif
    [IsoXmlTag("IndvFee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Fee2? IndividualFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Fee2? IndividualFee { get; init; } 
    #else
    public Fee2? IndividualFee { get; set; } 
    #endif
    
    /// <summary>
    /// Individual tax.
    /// </summary>
    [IsoId("_0eXCQDh6EeaH-93K5JKmzw")]
    [DisplayName("Individual Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndvTax")]
    #endif
    [IsoXmlTag("IndvTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax31? IndividualTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax31? IndividualTax { get; init; } 
    #else
    public Tax31? IndividualTax { get; set; } 
    #endif
    
    
    #nullable disable
    
}
