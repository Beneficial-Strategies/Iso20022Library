// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDocument12"/>
[IsoId("_Q1Ld4XR1EeiH1ZOt2UD8vQ")]
[DisplayName("Document")]
public partial record Document12
{
    /// <inheritdoc cref="IDocument12.Type"/>
    [IsoId("_Q_AvUXR1EeiH1ZOt2UD8vQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required DocumentType1Choice_ Type { get; init; }

    /// <inheritdoc cref="IDocument12.Identification"/>
    [IsoId("_Q_AvU3R1EeiH1ZOt2UD8vQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <inheritdoc cref="IDocument12.IssueDate"/>
    [IsoId("_3iRlYXiJEeidzqjNEfehPg")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    public required DateAndDateTime2Choice_ IssueDate { get; init; }

    /// <inheritdoc cref="IDocument12.Name"/>
    [IsoId("_E_8EYniKEeidzqjNEfehPg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; }

    /// <inheritdoc cref="IDocument12.LanguageCode"/>
    [IsoId("_E_8EY3iKEeidzqjNEfehPg")]
    [DisplayName("Language Code")]
    [IsoXmlTag("LangCd")]
    public LanguageCode? LanguageCode { get; init; }

    /// <inheritdoc cref="IDocument12.Format"/>
    [IsoId("_Q_AvVXR1EeiH1ZOt2UD8vQ")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public required DocumentFormat1Choice_ Format { get; init; }

    /// <inheritdoc cref="IDocument12.FileName"/>
    [IsoId("_ZEDS8XiKEeidzqjNEfehPg")]
    [DisplayName("File Name")]
    [IsoXmlTag("FileNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? FileName { get; init; }

    /// <inheritdoc cref="IDocument12.DigitalSignature"/>
    [IsoId("_Q_AvWXR1EeiH1ZOt2UD8vQ")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature3? DigitalSignature { get; init; }

    /// <inheritdoc cref="IDocument12.Enclosure"/>
    [IsoId("_Q_AvV3R1EeiH1ZOt2UD8vQ")]
    [DisplayName("Enclosure")]
    [IsoXmlTag("Nclsr")]
    [IsoSimpleType(IsoSimpleType.Max10MbBinary)]
    public required IsoMax10MbBinary Enclosure { get; init; }
}
