// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Collection of data for that is exchanged between two or more parties in written, printed or electronic form.
/// </summary>
[IsoId("_1EABwcNREeWGDrnsYu2p6g")]
[DisplayName("Invoice Header")]
public record InvoiceHeader2
{
    /// <summary>
    /// Unique identification of this invoice document.
    /// </summary>
    [IsoId("_1QzHocNREeWGDrnsYu2p6g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Specifies the type of the document, for example commercial invoice.
    /// </summary>
    [IsoId("_1QzHo8NREeWGDrnsYu2p6g")]
    [DisplayName("Type Code")]
    [IsoXmlTag("TpCd")]
    public required ExternalDocumentType1Code TypeCode { get; init; }

    /// <summary>
    /// Name of invoice document or transaction, for example, tax invoice.
    /// </summary>
    [IsoId("_1QzHpcNREeWGDrnsYu2p6g")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public SimpleValueList<IsoMax35Text> Name { get; init; } = [];

    /// <summary>
    /// Issue date of the document.
    /// </summary>
    [IsoId("_1QzHp8NREeWGDrnsYu2p6g")]
    [DisplayName("Issue Date Time")]
    [IsoXmlTag("IsseDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime IssueDateTime { get; init; }

    /// <summary>
    /// Party that issued this invoice document.
    /// </summary>
    [IsoId("_1QzHqcNREeWGDrnsYu2p6g")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public TradeParty3? Issuer { get; init; }

    /// <summary>
    /// Unique identifier for a language used in this invoice document.
    /// </summary>
    [IsoId("_1QzHq8NREeWGDrnsYu2p6g")]
    [DisplayName("Language Code")]
    [IsoXmlTag("LangCd")]
    public LanguageCode? LanguageCode { get; init; }

    /// <summary>
    /// Indicator that the document is a copy of the|original document.
    /// </summary>
    [IsoId("_1QzHrcNREeWGDrnsYu2p6g")]
    [DisplayName("Copy Indicator")]
    [IsoXmlTag("CpyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CopyIndicator { get; init; }

    /// <summary>
    /// Specifies the function of the document.
    /// </summary>
    [IsoId("_1QzHr8NREeWGDrnsYu2p6g")]
    [DisplayName("Document Purpose")]
    [IsoXmlTag("DocPurp")]
    public ExternalDocumentPurpose1Code? DocumentPurpose { get; init; }

    /// <summary>
    /// Note included in this invoice document.
    /// </summary>
    [IsoId("_1QzHscNREeWGDrnsYu2p6g")]
    [DisplayName("Included Note")]
    [IsoXmlTag("InclNote")]
    public ValueList<AdditionalInformation6> IncludedNote { get; init; } = [];
}
