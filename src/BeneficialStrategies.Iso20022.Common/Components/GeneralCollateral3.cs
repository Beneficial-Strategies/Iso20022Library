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
/// Repurchase agreement where the agreement allows for the sale and repurchase of any of a selection of assets from a pool of eligible assets.
/// </summary>
[IsoId("_M0GsEeoaEeadseq5W5YLvQ")]
[DisplayName("General Collateral")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GeneralCollateral3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// ISINs of allocated securities of general collateral where known.
    /// </summary>
    [IsoId("_plT7AfnbEeaHA8tUPpXMKA")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument59? FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument59? FinancialInstrumentIdentification { get; init; } 
    #else
    public FinancialInstrument59? FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// List of eligible securities to be allocated where known.
    /// </summary>
    [IsoId("_M-XbUeoaEeadseq5W5YLvQ")]
    [DisplayName("Eligible Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElgblFinInstrmId")]
    #endif
    [IsoXmlTag("ElgblFinInstrmId")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISINOct2015Identifier? EligibleFinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EligibleFinancialInstrumentIdentification { get; init; } 
    #else
    public System.String? EligibleFinancialInstrumentIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
