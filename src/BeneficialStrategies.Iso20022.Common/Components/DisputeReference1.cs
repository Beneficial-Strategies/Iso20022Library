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
/// Contains dispute reference details.
/// </summary>
[IsoId("_sXZCwOCmEee9RadpHmUgYw")]
[DisplayName("Dispute Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DisputeReference1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the entity assigning the dispute reference.
    /// </summary>
    [IsoId("_8BhZUOCmEee9RadpHmUgYw")]
    [DisplayName("Assigner Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssgnrNtty")]
    #endif
    [IsoXmlTag("AssgnrNtty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyType32Code? AssignerEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyType32Code? AssignerEntity { get; init; } 
    #else
    public PartyType32Code? AssignerEntity { get; set; } 
    #endif
    
    /// <summary>
    /// Other assigner entity.
    /// </summary>
    [IsoId("_krXOYOCqEee9RadpHmUgYw")]
    [DisplayName("Other Assigner Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrAssgnrNtty")]
    #endif
    [IsoXmlTag("OthrAssgnrNtty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherAssignerEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherAssignerEntity { get; init; } 
    #else
    public System.String? OtherAssignerEntity { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the dispute.
    /// </summary>
    [IsoId("_NvLt4OCnEee9RadpHmUgYw")]
    [DisplayName("Dispute Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DsptId")]
    #endif
    [IsoXmlTag("DsptId")]
    public ValueList<DisputeIdentification1> DisputeIdentification { get; init; } = new ValueList<DisputeIdentification1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _NvLt4OCnEee9RadpHmUgYw
    
    
    #nullable disable
    
}
