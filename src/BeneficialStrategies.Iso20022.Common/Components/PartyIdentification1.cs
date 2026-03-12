// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity involved in an activity.
/// </summary>
[IsoId("_PbFTE9p-Ed-ak6NoX_4Aeg_-883407308")]
[DisplayName("Party Identification")]
public partial record PartyIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_PbFTFNp-Ed-ak6NoX_4Aeg_-569408152")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; } 
    
    /// <summary>
    /// Postal address of a party.
    /// </summary>
    [IsoId("_PbFTFdp-Ed-ak6NoX_4Aeg_-805213936")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress1? PostalAddress { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification of a party.
    /// </summary>
    [IsoId("_PbFTFtp-Ed-ak6NoX_4Aeg_58319748")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public Party1Choice_? Identification { get; init; } 
    
    
    #nullable disable
    
}
