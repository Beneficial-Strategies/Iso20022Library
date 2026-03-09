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
/// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
/// </summary>
[IsoId("_puMT0dLFEeiN28wlpBQScw")]
[DisplayName("Safe Keeping Place")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SafeKeepingPlace3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    [IsoId("_qVK0Q9LFEeiN28wlpBQScw")]
    [DisplayName("Safekeeping Place Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlcFrmt")]
    #endif
    [IsoXmlTag("SfkpgPlcFrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafekeepingPlaceFormat29Choice_? SafekeepingPlaceFormat { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlaceFormat29Choice_? SafekeepingPlaceFormat { get; init; } 
    #else
    public SafekeepingPlaceFormat29Choice_? SafekeepingPlaceFormat { get; set; } 
    #endif
    
    /// <summary>
    /// Legal entity identification as an alternate identification for a place of safekeeping.
    /// </summary>
    [IsoId("_qVK0RdLFEeiN28wlpBQScw")]
    [DisplayName("LEI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LEI")]
    #endif
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLEIIdentifier? LEI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LEI { get; init; } 
    #else
    public System.String? LEI { get; set; } 
    #endif
    
    
    #nullable disable
    
}
