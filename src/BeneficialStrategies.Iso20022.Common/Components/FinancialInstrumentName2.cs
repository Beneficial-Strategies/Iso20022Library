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
/// Name of the security.
/// </summary>
[IsoId("_Olzf4WqUEemHy6n1hjosWw")]
[DisplayName("Financial Instrument Name")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentName2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Short name of the security expressed as ISO 18773/18774.
    /// </summary>
    [IsoId("_OzhLwWqUEemHy6n1hjosWw")]
    [DisplayName("ISO Short Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ISOShrtNm")]
    #endif
    [IsoXmlTag("ISOShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ISOShortName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ISOShortName { get; init; } 
    #else
    public System.String? ISOShortName { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the security.
    /// </summary>
    [IsoId("_OzhLw2qUEemHy6n1hjosWw")]
    [DisplayName("ISO Long Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ISOLngNm")]
    #endif
    [IsoXmlTag("ISOLngNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? ISOLongName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ISOLongName { get; init; } 
    #else
    public System.String? ISOLongName { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the date since when the name of the security is valid.
    /// </summary>
    [IsoId("_OzhLxWqUEemHy6n1hjosWw")]
    [DisplayName("Valid From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldFr")]
    #endif
    [IsoXmlTag("VldFr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? ValidFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? ValidFrom { get; init; } 
    #else
    public DateAndDateTime2Choice_? ValidFrom { get; set; } 
    #endif
    
    
    #nullable disable
    
}
