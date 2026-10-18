// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDocumentLineInformation1"/>
[IsoId("_Cy5dt6JpEeKmspP9k_hIRQ")]
[DisplayName("Document Line Information")]
public partial record DocumentLineInformation1
{
    /// <inheritdoc cref="IDocumentLineInformation1.Identification"/>
    [IsoId("_ULe6IKJpEeKmspP9k_hIRQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public ValueList<DocumentLineIdentification1> Identification { get; init; } = [];

    // ID for the above is _ULe6IKJpEeKmspP9k_hIRQ

    /// <inheritdoc cref="IDocumentLineInformation1.Description"/>
    [IsoId("_huX3YKJpEeKmspP9k_hIRQ")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048, MinimumLength = 1)]
    public IsoMax2048Text? Description { get; init; }

    /// <inheritdoc cref="IDocumentLineInformation1.Amount"/>
    [IsoId("_oMvB8KJpEeKmspP9k_hIRQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public RemittanceAmount3? Amount { get; init; }
}
