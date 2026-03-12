// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Organised structure that is set up for a particular purpose, eg, a business, government body, department, charity, or financial institution.
/// </summary>
[IsoId("_QN5QEtp-Ed-ak6NoX_4Aeg_-1748201737")]
[DisplayName("Intermediary")]
public partial record Intermediary1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution, eg, Dun &amp; Bradstreet Identification.
    /// </summary>
    [IsoId("_QN5QE9p-Ed-ak6NoX_4Aeg_-1748201735")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification1Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_QN5QFNp-Ed-ak6NoX_4Aeg_-1748201734")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account1? Account { get; init; } 
    
    /// <summary>
    /// Set of functions performed by an intermediary in a given situation.
    /// </summary>
    [IsoId("_QN5QFdp-Ed-ak6NoX_4Aeg_-1748201733")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Role { get; init; } 
    
    
    #nullable disable
    
}
