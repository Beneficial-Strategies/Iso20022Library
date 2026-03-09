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
/// Information related specifically to credit derivatives attributes.
/// </summary>
[IsoId("_pAsKEZjeEeqkLZLH6DK3UQ")]
[DisplayName("Credit Derivative")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CreditDerivative4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Classification of seniority in case of contract on index or on a single name entity.
    /// </summary>
    [IsoId("_pBSnAZjeEeqkLZLH6DK3UQ")]
    [DisplayName("Seniority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Snrty")]
    #endif
    [IsoXmlTag("Snrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DebtInstrumentSeniorityType2Code? Seniority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DebtInstrumentSeniorityType2Code? Seniority { get; init; } 
    #else
    public DebtInstrumentSeniorityType2Code? Seniority { get; set; } 
    #endif
    
    /// <summary>
    /// Designation of the underlying reference obligation.
    /// </summary>
    [IsoId("_pBSnA5jeEeqkLZLH6DK3UQ")]
    [DisplayName("Reference Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefPty")]
    #endif
    [IsoXmlTag("RefPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DerivativePartyIdentification1Choice_? ReferenceParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DerivativePartyIdentification1Choice_? ReferenceParty { get; init; } 
    #else
    public DerivativePartyIdentification1Choice_? ReferenceParty { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the time unit associated with the frequency of payments.
    /// </summary>
    [IsoId("_pBSnBZjeEeqkLZLH6DK3UQ")]
    [DisplayName("Payment Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtFrqcy")]
    #endif
    [IsoXmlTag("PmtFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency13Code? PaymentFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency13Code? PaymentFrequency { get; init; } 
    #else
    public Frequency13Code? PaymentFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Calculation basis of the interest rate, such as Act/360.
    /// </summary>
    [IsoId("_pBSnB5jeEeqkLZLH6DK3UQ")]
    [DisplayName("Calculation Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClctnBsis")]
    #endif
    [IsoXmlTag("ClctnBsis")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CalculationBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CalculationBasis { get; init; } 
    #else
    public System.String? CalculationBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the series number of the composition of the index if applicable.
    /// </summary>
    [IsoId("_pBSnCZjeEeqkLZLH6DK3UQ")]
    [DisplayName("Series")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Srs")]
    #endif
    [IsoXmlTag("Srs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? Series { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Series { get; init; } 
    #else
    public System.UInt64? Series { get; set; } 
    #endif
    
    /// <summary>
    /// New version of a series is issued if one of the constituents defaults and the index has to be re-weighted to account for the new number of total constituents within the index.
    /// </summary>
    [IsoId("_pBSnC5jeEeqkLZLH6DK3UQ")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Version { get; init; } 
    #else
    public System.UInt64? Version { get; set; } 
    #endif
    
    /// <summary>
    /// Factor to apply to the actual notional to adjust it to all the previous credit events in the index series. 
    /// Usage: The figure varies between 0 and 100.
    /// </summary>
    [IsoId("_pBSnDZjeEeqkLZLH6DK3UQ")]
    [DisplayName("Index Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndxFctr")]
    #endif
    [IsoXmlTag("IndxFctr")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? IndexFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? IndexFactor { get; init; } 
    #else
    public System.Decimal? IndexFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the derivative contract is tranched or not.
    /// </summary>
    [IsoId("_pBSnD5jeEeqkLZLH6DK3UQ")]
    [DisplayName("Tranche")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trch")]
    #endif
    [IsoXmlTag("Trch")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TrancheIndicator3Choice_? Tranche { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrancheIndicator3Choice_? Tranche { get; init; } 
    #else
    public TrancheIndicator3Choice_? Tranche { get; set; } 
    #endif
    
    
    #nullable disable
    
}
