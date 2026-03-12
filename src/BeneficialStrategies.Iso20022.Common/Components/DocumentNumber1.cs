// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a document.
/// </summary>
[IsoId("_Tg5R5dp-Ed-ak6NoX_4Aeg_-1445653769")]
[DisplayName("Document Number")]
public partial record DocumentNumber1
{
    #nullable enable
    
    /// <summary>
    /// Number used to identify a message or document.
    /// </summary>
    [IsoId("_Tg5R5tp-Ed-ak6NoX_4Aeg_160411897")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    public required DocumentNumber1Choice_ Number { get; init; } 
    
    
    #nullable disable
    
}
