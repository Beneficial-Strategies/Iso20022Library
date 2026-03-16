// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party Identification289.
/// </summary>
[IsoId("_s13qUEmmEe-NocYul3BKXQ")]
[DisplayName("Party Identification289")]
public partial record PartyIdentification289
{
    #nullable enable

    /// <summary>
    /// Contact Person.
    /// </summary>
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public ContactIdentification1? ContactPerson { get; init; } 

    /// <summary>
    /// Contact Person Address.
    /// </summary>
    [DisplayName("Contact Person Address")]
    [IsoXmlTag("CtctPrsnAdr")]
    public PostalAddress1? ContactPersonAddress { get; init; } 

    /// <summary>
    /// Party Identification.
    /// </summary>
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification129Choice_ PartyIdentification { get; init; } 

    
    #nullable disable
    
}
