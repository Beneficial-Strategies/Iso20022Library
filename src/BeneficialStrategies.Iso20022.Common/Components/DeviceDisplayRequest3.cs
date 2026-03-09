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
/// Content of the Display Request message.
/// </summary>
[IsoId("_1jAyIS8_Eeu125Ip9zFcsQ")]
[DisplayName("Device Display Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceDisplayRequest3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Message to be displayed.
    /// </summary>
    [IsoId("_1vV98S8_Eeu125Ip9zFcsQ")]
    [DisplayName("Display Output")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DispOutpt")]
    #endif
    [IsoXmlTag("DispOutpt")]
    public ValueList<ActionMessage8> DisplayOutput { get; init; } = new ValueList<ActionMessage8>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _1vV98S8_Eeu125Ip9zFcsQ
    
    
    #nullable disable
    
}
