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
/// Contact person at the party organising the meeting, at the issuer or at an intermediary.
/// </summary>
[IsoId("_OEm_MVthEeSwKe7KuKvXhg")]
[DisplayName("Meeting Contact Person")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingContactPerson2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the contact person by its name, given name and address.
    /// </summary>
    [IsoId("_OiEXQ1thEeSwKe7KuKvXhg")]
    [DisplayName("Contact Person")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctPrsn")]
    #endif
    [IsoXmlTag("CtctPrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactIdentification1? ContactPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactIdentification1? ContactPerson { get; init; } 
    #else
    public ContactIdentification1? ContactPerson { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the organisation which is represented by the person or for which the person works.
    /// </summary>
    [IsoId("_OiEXRVthEeSwKe7KuKvXhg")]
    [DisplayName("Employing Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EmplngPty")]
    #endif
    [IsoXmlTag("EmplngPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification40Choice_? EmployingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification40Choice_? EmployingParty { get; init; } 
    #else
    public PartyIdentification40Choice_? EmployingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the financial market, as stipulated in the norm ISO 10383 &apos;Codes for exchanges and market identifications&apos;.
    /// </summary>
    [IsoId("_OiEXR1thEeSwKe7KuKvXhg")]
    [DisplayName("Place Of Listing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfListg")]
    #endif
    [IsoXmlTag("PlcOfListg")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMICIdentifier? PlaceOfListing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceOfListing { get; init; } 
    #else
    public System.String? PlaceOfListing { get; set; } 
    #endif
    
    
    #nullable disable
    
}
