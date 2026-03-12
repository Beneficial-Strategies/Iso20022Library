// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services to investors relating to financial products.
/// </summary>
[IsoId("_U_XbBdp-Ed-ak6NoX_4Aeg_-129041693")]
[DisplayName("Intermediary")]
public partial record Intermediary4
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    [IsoId("_U_XbBtp-Ed-ak6NoX_4Aeg_-129041435")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification2Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_U_XbB9p-Ed-ak6NoX_4Aeg_-129041402")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account2? Account { get; init; } 
    
    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    [IsoId("_U_XbCNp-Ed-ak6NoX_4Aeg_-129041385")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Role { get; init; } 
    
    
    #nullable disable
    
}
