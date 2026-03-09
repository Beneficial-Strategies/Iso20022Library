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
/// Total amount of charges.
/// </summary>
[IsoId("_RttdDNp-Ed-ak6NoX_4Aeg_-26727186")]
[DisplayName("Total Charges")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TotalCharges3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Total value of the charges for a specific order.
    /// </summary>
    [IsoId("_RttdDdp-Ed-ak6NoX_4Aeg_-26725711")]
    [DisplayName("Total Amount Of Charges")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmtOfChrgs")]
    #endif
    [IsoXmlTag("TtlAmtOfChrgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? TotalAmountOfCharges { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? TotalAmountOfCharges { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? TotalAmountOfCharges { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to a specific charge.
    /// </summary>
    [IsoId("_RttdDtp-Ed-ak6NoX_4Aeg_-26724668")]
    [DisplayName("Charge Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgDtls")]
    #endif
    [IsoXmlTag("ChrgDtls")]
    public ValueList<Charge18> ChargeDetails { get; init; } = new ValueList<Charge18>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _RttdDtp-Ed-ak6NoX_4Aeg_-26724668
    
    
    #nullable disable
    
}
