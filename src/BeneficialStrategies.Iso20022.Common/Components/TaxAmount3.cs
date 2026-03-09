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
/// Set of elements used to provide information on the tax amount(s) of tax record.
/// </summary>
[IsoId("_n-65U94lEeqt1ZcLzWyWFw")]
[DisplayName("Tax Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxAmount3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    [IsoId("_oAWcod4lEeqt1ZcLzWyWFw")]
    [DisplayName("Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rate")]
    #endif
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? Rate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Rate { get; init; } 
    #else
    public System.Decimal? Rate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money on which the tax is based.
    /// </summary>
    [IsoId("_oAWco94lEeqt1ZcLzWyWFw")]
    [DisplayName("Taxable Base Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxblBaseAmt")]
    #endif
    [IsoXmlTag("TaxblBaseAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TaxableBaseAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TaxableBaseAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TaxableBaseAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount that is the result of the calculation of the tax for the record.
    /// </summary>
    [IsoId("_oAWcpd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmt")]
    #endif
    [IsoXmlTag("TtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide details on the tax period and amount.
    /// </summary>
    [IsoId("_oAWcp94lEeqt1ZcLzWyWFw")]
    [DisplayName("Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dtls")]
    #endif
    [IsoXmlTag("Dtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxRecordDetails3? Details { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxRecordDetails3? Details { get; init; } 
    #else
    public TaxRecordDetails3? Details { get; set; } 
    #endif
    
    
    #nullable disable
    
}
