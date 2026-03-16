// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice of format for the classification.
/// </summary>
[IsoId("_58Yc4eLVEeWFtOV72FbX9w")]
[DisplayName("Classification Type")]
public record ClassificationType2
{
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_6LaXYeLVEeWFtOV72FbX9w")]
    [DisplayName("Classification Financial Instrument")]
    [IsoXmlTag("ClssfctnFinInstrm")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    public IsoCFIOct2015Identifier? ClassificationFinancialInstrument { get; init; }

    /// <summary>
    /// Name of the identification scheme, in a coded form as published in an external list.
    /// </summary>
    [IsoId("_6LaXY-LVEeWFtOV72FbX9w")]
    [DisplayName("Financial Instrument Product Type Code")]
    [IsoXmlTag("FinInstrmPdctTpCd")]
    public ExternalFinancialInstrumentProductType1Code? FinancialInstrumentProductTypeCode { get; init; }

    /// <summary>
    /// Proprietary classification of financial instrument.
    /// </summary>
    [IsoId("_6LaXZeLVEeWFtOV72FbX9w")]
    [DisplayName("Alternate Classification")]
    [IsoXmlTag("AltrnClssfctn")]
    public GenericIdentification36? AlternateClassification { get; init; }
}
