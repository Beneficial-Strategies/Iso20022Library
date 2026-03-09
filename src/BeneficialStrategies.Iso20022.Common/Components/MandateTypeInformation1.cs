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
/// Set of elements used to further detail the information related to the type of payment.
/// </summary>
[IsoId("_TFxcONp-Ed-ak6NoX_4Aeg_1015976937")]
[DisplayName("Mandate Type Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MandateTypeInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Agreement under which or rules under which the mandate resides.
    /// </summary>
    [IsoId("_TF7NINp-Ed-ak6NoX_4Aeg_1015977061")]
    [DisplayName("Service Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcLvl")]
    #endif
    [IsoXmlTag("SvcLvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ServiceLevel8Choice_? ServiceLevel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ServiceLevel8Choice_? ServiceLevel { get; init; } 
    #else
    public ServiceLevel8Choice_? ServiceLevel { get; set; } 
    #endif
    
    /// <summary>
    /// User community specific instrument.|Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level.
    /// </summary>
    [IsoId("_TF7NIdp-Ed-ak6NoX_4Aeg_405655354")]
    [DisplayName("Local Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclInstrm")]
    #endif
    [IsoXmlTag("LclInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LocalInstrument2Choice_? LocalInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LocalInstrument2Choice_? LocalInstrument { get; init; } 
    #else
    public LocalInstrument2Choice_? LocalInstrument { get; set; } 
    #endif
    
    
    #nullable disable
    
}
