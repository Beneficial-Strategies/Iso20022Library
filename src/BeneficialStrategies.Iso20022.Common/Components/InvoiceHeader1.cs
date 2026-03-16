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
[IsoId("_SuAjMAEcEeCQm6a_G2yO_w_-887541899")]
[DisplayName("Invoice Header")]
public record InvoiceHeader1
{
    /// <summary>
    /// Unique identification of this invoice document.
    /// </summary>
    [IsoId("_SuAjMQEcEeCQm6a_G2yO_w_1153581036")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Specifies the type of the document, for example commercial invoice.
    /// </summary>
    [IsoId("_SuAjMgEcEeCQm6a_G2yO_w_270347749")]
    [DisplayName("Type Code")]
    [IsoXmlTag("TpCd")]
    public required ExternalDocumentType1Code TypeCode { get; init; }

    /// <summary>
    /// Name of invoice document or transaction, for example, tax invoice.
    /// </summary>
    [IsoId("_SuAjMwEcEeCQm6a_G2yO_w_1331699708")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public SimpleValueList<IsoMax35Text> Name { get; init; } = [];

    /// <summary>
    /// Issue date of the document.
    /// </summary>
    [IsoId("_SuAjNAEcEeCQm6a_G2yO_w_334627355")]
    [DisplayName("Issue Date Time")]
    [IsoXmlTag("IsseDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime IssueDateTime { get; init; }

    /// <summary>
    /// Party that issued this invoice document.
    /// </summary>
    [IsoId("_SuAjNQEcEeCQm6a_G2yO_w_-1479749531")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public TradeParty1? Issuer { get; init; }

    /// <summary>
    /// Unique identifier for a language used in this invoice document.
    /// </summary>
    [IsoId("_SuAjNgEcEeCQm6a_G2yO_w_156508683")]
    [DisplayName("Language Code")]
    [IsoXmlTag("LangCd")]
    public LanguageCode? LanguageCode { get; init; }

    /// <summary>
    /// Indicator that the document is a copy of the|original document.
    /// </summary>
    [IsoId("_SuAjNwEcEeCQm6a_G2yO_w_448466421")]
    [DisplayName("Copy Indicator")]
    [IsoXmlTag("CpyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CopyIndicator { get; init; }

    /// <summary>
    /// Specifies the function of the document.
    /// </summary>
    [IsoId("_SuAjOAEcEeCQm6a_G2yO_w_1273017488")]
    [DisplayName("Document Purpose")]
    [IsoXmlTag("DocPurp")]
    public ExternalDocumentPurpose1Code? DocumentPurpose { get; init; }

    /// <summary>
    /// Note included in this invoice document.
    /// </summary>
    [IsoId("_SuAjOQEcEeCQm6a_G2yO_w_-726724604")]
    [DisplayName("Included Note")]
    [IsoXmlTag("InclNote")]
    public ValueList<AdditionalInformation6> IncludedNote { get; init; } = [];
}
