// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies possible agreement clauses related to invoice financing.
/// </summary>
[IsoId("_RX8oZdp-Ed-ak6NoX_4Aeg_1393986563")]
[DisplayName("Agreement Clauses")]
public partial record AgreementClauses1
{
    #nullable enable
    
    /// <summary>
    /// Description of agreement clauses, given in a textual form.
    /// </summary>
    [IsoId("_RX8oZtp-Ed-ak6NoX_4Aeg_1897307883")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? Description { get; init; } 
    
    /// <summary>
    /// External reference to the document, containing agreement clauses, where it is stored.
    /// </summary>
    [IsoId("_RX8oZ9p-Ed-ak6NoX_4Aeg_-35889760")]
    [DisplayName("Document URL")]
    [IsoXmlTag("DocURL")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? DocumentURL { get; init; } 
    
    
    #nullable disable
    
}
