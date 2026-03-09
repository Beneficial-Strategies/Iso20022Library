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
/// Species the tax applicable for this settlement.
/// </summary>
[IsoId("_S0j3LAEcEeCQm6a_G2yO_w_811596505")]
[DisplayName("Settlement Tax")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementTax1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_S0j3LQEcEeCQm6a_G2yO_w_-664594537")]
    [DisplayName("Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TpCd")]
    #endif
    [IsoXmlTag("TpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxTypeFormat1Choice_? TypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxTypeFormat1Choice_? TypeCode { get; init; } 
    #else
    public TaxTypeFormat1Choice_? TypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// Monetary value resulting from the calculation of this tax, levy or duty.
    /// </summary>
    [IsoId("_S0j3LgEcEeCQm6a_G2yO_w_588725222")]
    [DisplayName("Calculated Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClctdAmt")]
    #endif
    [IsoXmlTag("ClctdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? CalculatedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? CalculatedAmount { get; init; } 
    #else
    public CurrencyAndAmount? CalculatedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Monetary value used as the basis on which this tax, levy or duty is calculated.
    /// </summary>
    [IsoId("_S0j3LwEcEeCQm6a_G2yO_w_-780660433")]
    [DisplayName("Basis Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BsisAmt")]
    #endif
    [IsoXmlTag("BsisAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? BasisAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? BasisAmount { get; init; } 
    #else
    public CurrencyAndAmount? BasisAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the tax point when this tax, levy or duty becomes applicable.
    /// </summary>
    [IsoId("_S0j3MAEcEeCQm6a_G2yO_w_-805508608")]
    [DisplayName("Tax Point Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxPtDt")]
    #endif
    [IsoXmlTag("TaxPtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TaxPointDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TaxPointDate { get; init; } 
    #else
    public System.DateOnly? TaxPointDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
