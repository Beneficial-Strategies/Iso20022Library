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
/// Specifies an entity involved in a trade activity.
/// </summary>
[IsoId("_4NfCAdOdEeS75MhTUaTyUQ")]
[DisplayName("Trade Party")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeParty2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeParty2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeParty2( PartyIdentification77 reqPartyIdentification )
    {
        PartyIdentification = reqPartyIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_4Xc2UdOdEeS75MhTUaTyUQ")]
    [DisplayName("Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyId")]
    #endif
    [IsoXmlTag("PtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification77 PartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification77 PartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification77 PartyIdentification { get; init; } 
    #else
    public PartyIdentification77 PartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Legally constituted organization specified for this trade party.
    /// </summary>
    [IsoId("_4Xc2U9OdEeS75MhTUaTyUQ")]
    [DisplayName("Legal Organisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglOrg")]
    #endif
    [IsoXmlTag("LglOrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LegalOrganisation2? LegalOrganisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LegalOrganisation2? LegalOrganisation { get; init; } 
    #else
    public LegalOrganisation2? LegalOrganisation { get; set; } 
    #endif
    
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_4Xc2VdOdEeS75MhTUaTyUQ")]
    [DisplayName("Tax Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxPty")]
    #endif
    [IsoXmlTag("TaxPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxParty3? TaxParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxParty3? TaxParty { get; init; } 
    #else
    public TaxParty3? TaxParty { get; set; } 
    #endif
    
    
    #nullable disable
    
}
