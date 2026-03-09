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
/// A proprietary or domestic identification scheme that uniquely identifies a financial instrument.
/// </summary>
[IsoId("_SlI0Stp-Ed-ak6NoX_4Aeg_-1692049135")]
[DisplayName("Alternate Financial Instrument Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AlternateFinancialInstrumentIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AlternateFinancialInstrumentIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AlternateFinancialInstrumentIdentification1( string reqDomesticIdentificationSource,System.String reqProprietaryIdentificationSource,System.String reqIdentification )
    {
        DomesticIdentificationSource = reqDomesticIdentificationSource;
        ProprietaryIdentificationSource = reqProprietaryIdentificationSource;
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Country of the proprietary identification scheme.
    /// </summary>
    [IsoId("_SlI0S9p-Ed-ak6NoX_4Aeg_-1692049133")]
    [DisplayName("Domestic Identification Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmstIdSrc")]
    #endif
    [IsoXmlTag("DmstIdSrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode DomesticIdentificationSource { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string DomesticIdentificationSource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string DomesticIdentificationSource { get; init; } 
    #else
    public string DomesticIdentificationSource { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that issues the proprietary identification.
    /// </summary>
    [IsoId("_SlSlQNp-Ed-ak6NoX_4Aeg_273812165")]
    [DisplayName("Proprietary Identification Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtryIdSrc")]
    #endif
    [IsoXmlTag("PrtryIdSrc")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax16Text ProprietaryIdentificationSource { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ProprietaryIdentificationSource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ProprietaryIdentificationSource { get; init; } 
    #else
    public System.String ProprietaryIdentificationSource { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of a security.
    /// </summary>
    [IsoId("_SlSlQdp-Ed-ak6NoX_4Aeg_-1692049134")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
