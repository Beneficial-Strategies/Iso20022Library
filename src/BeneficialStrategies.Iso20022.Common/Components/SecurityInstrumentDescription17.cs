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
/// Identifies the security instrument by its name and typical characteristics.
/// </summary>
[IsoId("_EO4_QUmXEeqmSrLQiFB8FA")]
[DisplayName("Security Instrument Description")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityInstrumentDescription17
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecurityInstrumentDescription17 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecurityInstrumentDescription17( System.String reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Code used to identify the financial instrument.
    /// </summary>
    [IsoId("_EPy-N0mXEeqmSrLQiFB8FA")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISINOct2015Identifier Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Full name of the financial instrument.
    /// </summary>
    [IsoId("_EPy-OUmXEeqmSrLQiFB8FA")]
    [DisplayName("Full Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FullNm")]
    #endif
    [IsoXmlTag("FullNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? FullName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FullName { get; init; } 
    #else
    public System.String? FullName { get; set; } 
    #endif
    
    /// <summary>
    /// Short name of financial instrument in accordance with ISO 18774.
    /// </summary>
    [IsoId("_EPy-O0mXEeqmSrLQiFB8FA")]
    [DisplayName("Short Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtNm")]
    #endif
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ShortName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ShortName { get; init; } 
    #else
    public System.String? ShortName { get; set; } 
    #endif
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification.
    /// </summary>
    [IsoId("_EPy-PUmXEeqmSrLQiFB8FA")]
    [DisplayName("Classification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssfctnTp")]
    #endif
    [IsoXmlTag("ClssfctnTp")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoCFIOct2015Identifier? ClassificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClassificationType { get; init; } 
    #else
    public System.String? ClassificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which the notional is denominated.
    /// </summary>
    [IsoId("_EPy-QUmXEeqmSrLQiFB8FA")]
    [DisplayName("Notional Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlCcy")]
    #endif
    [IsoXmlTag("NtnlCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? NotionalCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? NotionalCurrency { get; init; } 
    #else
    public string? NotionalCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the financial instrument falls within the definition of commodities derivative under the local regulation.
    /// Usage: when not present, the indicator in not applicable.
    /// </summary>
    [IsoId("_EPy-Q0mXEeqmSrLQiFB8FA")]
    [DisplayName("Commodity Derivative Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmmdtyDerivInd")]
    #endif
    [IsoXmlTag("CmmdtyDerivInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CommodityDerivativeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CommodityDerivativeIndicator { get; init; } 
    #else
    public System.String? CommodityDerivativeIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
