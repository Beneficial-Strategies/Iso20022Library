// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditorReferenceInformation3"/>
[IsoId("_7u-CcTEsEe6GxLzpkVnWYg")]
[Description(@"Reference information provided by the creditor to allow the identification of the underlying documents.")]
[DisplayName("Creditor Reference Information3")]
public partial record CreditorReferenceInformation3
{
    /// <inheritdoc cref="ICreditorReferenceInformation3.Reference"/>
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public IsoMax35Text? Reference { get; init; }

    /// <inheritdoc cref="ICreditorReferenceInformation3.Type"/>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CreditorReferenceType3? Type { get; init; }
}
