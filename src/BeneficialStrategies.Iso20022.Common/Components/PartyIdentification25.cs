// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a person, or a non-financial institution.
/// </summary>
[IsoId("_Pb059Np-Ed-ak6NoX_4Aeg_-72138267")]
[DisplayName("Party Identification")]
public partial record PartyIdentification25
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_Pb059dp-Ed-ak6NoX_4Aeg_-72138265")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text Name { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a party using a proprietary identification scheme.
    /// </summary>
    [IsoId("_Pb059tp-Ed-ak6NoX_4Aeg_-72138205")]
    [DisplayName("Proprietary Identification")]
    [IsoXmlTag("PrtryId")]
    public GenericIdentification4? ProprietaryIdentification { get; init; } 
    
    /// <summary>
    /// Identification of a non-financial institution.
    /// </summary>
    [IsoId("_Pb0599p-Ed-ak6NoX_4Aeg_-1406582918")]
    [DisplayName("BEI")]
    [IsoXmlTag("BEI")]
    [IsoSimpleType(IsoSimpleType.BEIIdentifier)]
    public IsoBEIIdentifier? BEI { get; init; } 
    
    
    #nullable disable
    
}
