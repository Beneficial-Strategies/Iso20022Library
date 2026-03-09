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
/// Identification of a financial instrument.
/// </summary>
[IsoId("_lFfFsXwgEeuQY_68iqAoCQ")]
[DisplayName("Conversion")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Conversion2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Conversion2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Conversion2( FinancialInstrumentIdentification1 reqSourceSecurity )
    {
        SourceSecurity = reqSourceSecurity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the source security.
    /// </summary>
    [IsoId("_lcDyoXwgEeuQY_68iqAoCQ")]
    [DisplayName("Source Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrcScty")]
    #endif
    [IsoXmlTag("SrcScty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentIdentification1 SourceSecurity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentIdentification1 SourceSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentIdentification1 SourceSecurity { get; init; } 
    #else
    public FinancialInstrumentIdentification1 SourceSecurity { get; set; } 
    #endif
    
    /// <summary>
    /// Number of units of the source security.
    /// </summary>
    [IsoId("_EeuSEXwkEeuQY_68iqAoCQ")]
    [DisplayName("Total Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlUnitsNb")]
    #endif
    [IsoXmlTag("TtlUnitsNb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? TotalUnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TotalUnitsNumber { get; init; } 
    #else
    public System.UInt64? TotalUnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of units of the source security.
    /// </summary>
    [IsoId("__g-GAXwgEeuQY_68iqAoCQ")]
    [DisplayName("Units Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitsDtls")]
    #endif
    [IsoXmlTag("UnitsDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Unit13? UnitsDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Unit13? UnitsDetails { get; init; } 
    #else
    public Unit13? UnitsDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the conversion.
    /// </summary>
    [IsoId("_lcDyo3wgEeuQY_68iqAoCQ")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
