// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides document line information.
/// </summary>
[IsoId("_Cy5dt6JpEeKmspP9k_hIRQ")]
[DisplayName("Document Line Information")]
public partial record DocumentLineInformation1
{
    #nullable enable
    
    /// <summary>
    /// Provides identification of the document line.
    /// </summary>
    [IsoId("_ULe6IKJpEeKmspP9k_hIRQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public ValueList<DocumentLineIdentification1> Identification { get; init; } = new ValueList<DocumentLineIdentification1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _ULe6IKJpEeKmspP9k_hIRQ
    
    /// <summary>
    /// Description associated with the document line.
    /// </summary>
    [IsoId("_huX3YKJpEeKmspP9k_hIRQ")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    public IsoMax2048Text? Description { get; init; } 
    
    /// <summary>
    /// Provides details on the amounts of the document line.
    /// </summary>
    [IsoId("_oMvB8KJpEeKmspP9k_hIRQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public RemittanceAmount3? Amount { get; init; } 
    
    
    #nullable disable
    
}
