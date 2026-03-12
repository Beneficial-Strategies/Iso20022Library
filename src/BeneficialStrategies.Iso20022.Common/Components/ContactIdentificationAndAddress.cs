// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
/// </summary>
[IsoId("_QBrZANp-Ed-ak6NoX_4Aeg_-1266481859")]
[DisplayName("Contact Identification And Address")]
public partial record ContactIdentificationAndAddress
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_QBrZAdp-Ed-ak6NoX_4Aeg_-1266481858")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; } 
    
    /// <summary>
    /// Role of the party in the activity.
    /// </summary>
    [IsoId("_QBrZAtp-Ed-ak6NoX_4Aeg_-1266481857")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public required PaymentRole1Code Role { get; init; } 
    
    /// <summary>
    /// Number, or virtual address, used for communication.
    /// </summary>
    [IsoId("_QBrZA9p-Ed-ak6NoX_4Aeg_286978258")]
    [DisplayName("Communication Address")]
    [IsoXmlTag("ComAdr")]
    public required CommunicationAddressDetails CommunicationAddress { get; init; } 
    
    
    #nullable disable
    
}
