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
/// Contains fee collection reference details.
/// </summary>
[IsoId("_0yDt0SxMEeyg-aG5nXcnfg")]
[DisplayName("Fee Collection Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FeeCollectionReference1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the entity assigning the fee collection reference.
    /// </summary>
    [IsoId("_04oP4SxMEeyg-aG5nXcnfg")]
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
    [IsoId("_04o28SxMEeyg-aG5nXcnfg")]
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
    /// Identification of the fee collection.
    /// </summary>
    [IsoId("_04o28yxMEeyg-aG5nXcnfg")]
    [DisplayName("Fee Collection Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FeeColltnId")]
    #endif
    [IsoXmlTag("FeeColltnId")]
    public ValueList<FeeCollectionIdentification1> FeeCollectionIdentification { get; init; } = new ValueList<FeeCollectionIdentification1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _04o28yxMEeyg-aG5nXcnfg
    
    
    #nullable disable
    
}
