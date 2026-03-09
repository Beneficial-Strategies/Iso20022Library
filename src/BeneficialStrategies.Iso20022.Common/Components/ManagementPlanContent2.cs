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
/// Content of the management plan.
/// </summary>
[IsoId("_xXJXkR3ZEeKKrOIoqWglDw")]
[DisplayName("Management Plan Content")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ManagementPlanContent2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Terminal management action to be performed by the point of interaction (POI).
    /// </summary>
    [IsoId("_xjWnkR3ZEeKKrOIoqWglDw")]
    [DisplayName("Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Actn")]
    #endif
    [IsoXmlTag("Actn")]
    public ValueList<TMSAction2> Action { get; init; } = new ValueList<TMSAction2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _xjWnkR3ZEeKKrOIoqWglDw
    
    
    #nullable disable
    
}
