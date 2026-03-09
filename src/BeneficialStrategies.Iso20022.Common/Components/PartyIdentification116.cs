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
/// Unique identification, as assigned by an organisation, to unambiguously identify a party.
/// </summary>
[IsoId("_ynQ8AEkIEeaOe8w0NJ11wQ")]
[DisplayName("Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentification116
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentification116 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentification116( OrganisationIdentification28 reqPartyIdentification )
    {
        PartyIdentification = reqPartyIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_HxZ-gEkJEeaOe8w0NJ11wQ")]
    [DisplayName("Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyId")]
    #endif
    [IsoXmlTag("PtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrganisationIdentification28 PartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrganisationIdentification28 PartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification28 PartyIdentification { get; init; } 
    #else
    public OrganisationIdentification28 PartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier and name of an organisation that is allocated by an institution.
    /// </summary>
    [IsoId("_5D82IEkJEeaOe8w0NJ11wQ")]
    [DisplayName("Legal Organisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglOrg")]
    #endif
    [IsoXmlTag("LglOrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LegalOrganisation1? LegalOrganisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LegalOrganisation1? LegalOrganisation { get; init; } 
    #else
    public LegalOrganisation1? LegalOrganisation { get; set; } 
    #endif
    
    /// <summary>
    /// TaxParty.
    /// </summary>
    [IsoId("_-F1boEkJEeaOe8w0NJ11wQ")]
    [DisplayName("Tax Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxPty")]
    #endif
    [IsoXmlTag("TaxPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxParty1? TaxParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxParty1? TaxParty { get; init; } 
    #else
    public TaxParty1? TaxParty { get; set; } 
    #endif
    
    
    #nullable disable
    
}
