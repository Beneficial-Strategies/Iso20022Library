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
/// Specifies the date from which the financial instrument identification is valid.
/// </summary>
[IsoId("_hW9wVGliEeGaMcKyqKNRfQ_288608342")]
[DisplayName("Financial Instrument Identification Validity")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentIdentificationValidity1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Way(s) of identifying the security.
    /// </summary>
    [IsoId("_hW9wVWliEeGaMcKyqKNRfQ_1938517514")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification14? FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the date from which the instrument code is valid. This date can be before the actual issue date of an instrument for &apos;when-issued&apos; securities, but may not be a date in the future for a new security.
    /// </summary>
    [IsoId("_hW9wVmliEeGaMcKyqKNRfQ_-12545399")]
    [DisplayName("ISIN Valid From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ISINVldFr")]
    #endif
    [IsoXmlTag("ISINVldFr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ISINValidFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ISINValidFrom { get; init; } 
    #else
    public System.DateOnly? ISINValidFrom { get; set; } 
    #endif
    
    
    #nullable disable
    
}
