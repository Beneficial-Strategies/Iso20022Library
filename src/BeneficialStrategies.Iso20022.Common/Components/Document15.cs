// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDocument15"/>
[IsoId("_wy9ZETEyEe6g-ffJsqGiSA")]
[Description(@"Information about a document.")]
[DisplayName("Document15")]
public partial record Document15
{
    /// <inheritdoc cref="IDocument15.DigitalSignature"/>
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature4? DigitalSignature { get; init; }

    /// <inheritdoc cref="IDocument15.Enclosure"/>
    [DisplayName("Enclosure")]
    [IsoXmlTag("Nclsr")]
    public required IsoMax10MbBinary Enclosure { get; init; }

    /// <inheritdoc cref="IDocument15.FileName"/>
    [DisplayName("File Name")]
    [IsoXmlTag("FileNm")]
    public IsoMax140Text? FileName { get; init; }

    /// <inheritdoc cref="IDocument15.Format"/>
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public required DocumentFormat1Choice_ Format { get; init; }

    /// <inheritdoc cref="IDocument15.Identification"/>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <inheritdoc cref="IDocument15.IssueDate"/>
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    public required DateAndDateTime2Choice_ IssueDate { get; init; }

    /// <inheritdoc cref="IDocument15.LanguageCode"/>
    [DisplayName("Language Code")]
    [IsoXmlTag("LangCd")]
    public LanguageCode? LanguageCode { get; init; }

    /// <inheritdoc cref="IDocument15.Name"/>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax140Text? Name { get; init; }

    /// <inheritdoc cref="IDocument15.Type"/>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required DocumentType1Choice_ Type { get; init; }
}
