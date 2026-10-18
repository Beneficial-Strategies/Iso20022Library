// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDocumentLineInformation2"/>
[IsoId("_eZxMgTE4Ee62xuUQ2zyZww")]
[Description(@"Provides document line information.")]
[DisplayName("Document Line Information2")]
public partial record DocumentLineInformation2
{
    /// <inheritdoc cref="IDocumentLineInformation2.Amount"/>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public RemittanceAmount4? Amount { get; init; }

    /// <inheritdoc cref="IDocumentLineInformation2.Description"/>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax2048Text? Description { get; init; }

    /// <inheritdoc cref="IDocumentLineInformation2.Identification"/>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public ValueList<DocumentLineIdentification1> Identification { get; init; } = [];
}
