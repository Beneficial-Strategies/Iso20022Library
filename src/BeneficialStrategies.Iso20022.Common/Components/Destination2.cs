// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the details of the destination. 
/// </summary>
[IsoId("_REQg1fQbEeihCvvpsmGI2w")]
[DisplayName("Destination")]
public partial record Destination2
{
    #nullable enable
    
    /// <summary>
    /// Name and location of the destination.
    /// </summary>
    [IsoId("_REQg2fQbEeihCvvpsmGI2w")]
    [DisplayName("Name And Location")]
    [IsoXmlTag("NmAndLctn")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99 ,MinimumLength = 1)]
    public IsoMax99Text? NameAndLocation { get; init; } 
    
    /// <summary>
    /// Specific address of the destination.
    /// </summary>
    [IsoId("_REQg1_QbEeihCvvpsmGI2w")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address1? Address { get; init; } 
    
    
    #nullable disable
    
}
