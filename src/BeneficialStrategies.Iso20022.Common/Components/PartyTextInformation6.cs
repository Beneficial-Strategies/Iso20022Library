// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
/// </summary>
[IsoId("_0GUwgQVLEeq4ZaI1b_-GPA")]
[DisplayName("Party Text Information")]
public partial record PartyTextInformation6
{
    #nullable enable
    
    /// <summary>
    /// Provides declaration details narrative relative to the party.
    /// </summary>
    [IsoId("_0aj7IwVLEeq4ZaI1b_-GPA")]
    [DisplayName("Declaration Details")]
    [IsoXmlTag("DclrtnDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? DeclarationDetails { get; init; } 
    
    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_0aj7JQVLEeq4ZaI1b_-GPA")]
    [DisplayName("Party Contact Details")]
    [IsoXmlTag("PtyCtctDtls")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? PartyContactDetails { get; init; } 
    
    /// <summary>
    /// Provides information required for the registration.
    /// </summary>
    [IsoId("_0aj7JwVLEeq4ZaI1b_-GPA")]
    [DisplayName("Registration Details")]
    [IsoXmlTag("RegnDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? RegistrationDetails { get; init; } 
    
    /// <summary>
    /// Address of the nominee company that holds the assets at the transfer agent or International Central Securities Depository or Central Securities Depository on behalf of the party.
    /// </summary>
    [IsoId("_N37GUAVMEeq4ZaI1b_-GPA")]
    [DisplayName("Registration Address")]
    [IsoXmlTag("RegnAdr")]
    public PostalAddress1? RegistrationAddress { get; init; } 
    
    
    #nullable disable
    
}
