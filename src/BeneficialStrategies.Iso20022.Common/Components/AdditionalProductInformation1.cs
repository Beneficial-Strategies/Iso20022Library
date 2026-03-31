// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information required for distribution in the German market.
/// </summary>
[IsoId("_Z1vAIM2rEeuAE-cYsQdwHQ")]
[DisplayName("Additional Product Information")]
public record AdditionalProductInformation1
{
    /// <summary>
    /// Category of fund product.  When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT V3.1) reference 09000.
    /// </summary>
    [IsoId("_1fDskM2rEeuAE-cYsQdwHQ")]
    [DisplayName("ESG Category German Fund Market")]
    [IsoXmlTag("ESGCtgyGrmnFndMkt")]
    public ESGCategoryGermanFundMarket1Code? ESGCategoryGermanFundMarket { get; init; }

    /// <summary>
    /// Category of structured securities product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT V3.1) reference 09000.
    /// </summary>
    [IsoId("_5mXgMM2rEeuAE-cYsQdwHQ")]
    [DisplayName("ESG Category German Structured Securities Market")]
    [IsoXmlTag("ESGCtgyGrmnStrdSctiesMkt")]
    public ESGCategoryGermanStructuredSecuritiesMarket1Code? ESGCategoryGermanStructuredSecuritiesMarket { get; init; }

    /// <summary>
    /// Specifies if the focus will be Environmental, Social or Governance.  When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT V3.1) reference 09010.
    /// </summary>
    [IsoId("_8e2wQM2rEeuAE-cYsQdwHQ")]
    [DisplayName("ESG Focus")]
    [IsoXmlTag("ESGFcs")]
    public ESGFocus1Code? ESGFocus { get; init; }

    /// <summary>
    /// ESG label or standard of a product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT V3.1) reference 09020.
    /// </summary>
    [IsoId("_D4f3UM2sEeuAE-cYsQdwHQ")]
    [DisplayName("ESG Label Or Standard")]
    [IsoXmlTag("ESGLablOrStd")]
    public SimpleValueList<ESGLabelOrStandard1Code> ESGLabelOrStandard { get; init; } = [];
}
