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
/// Information for the presentation of documents.
/// </summary>
[IsoId("_97bkJnltEeG7BsjMvd1mEw_1224258578")]
[DisplayName("Presentation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Presentation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Party, other than beneficiary, forwarding the documents.
    /// </summary>
    [IsoId("_97kuEHltEeG7BsjMvd1mEw_2057434773")]
    [DisplayName("Presenter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Presntr")]
    #endif
    [IsoXmlTag("Presntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? Presenter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? Presenter { get; init; } 
    #else
    public PartyIdentification43? Presenter { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the beneficiary presented the demand.
    /// </summary>
    [IsoId("_97kuEXltEeG7BsjMvd1mEw_-177176006")]
    [DisplayName("Beneficiary Presentation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfcryPresntnDt")]
    #endif
    [IsoXmlTag("BnfcryPresntnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? BeneficiaryPresentationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? BeneficiaryPresentationDate { get; init; } 
    #else
    public System.DateOnly? BeneficiaryPresentationDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
