// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the collateral that will be substituted.
/// </summary>
[IsoId("_0UbmsmA3EeSMf75YyPqG7w")]
[DisplayName("Collateral Substitution")]
public record CollateralSubstitution2
{
    /// <summary>
    /// Indicates whether the collateral substitution request is new or updated.
    /// </summary>
    [IsoId("_0zFRk2A3EeSMf75YyPqG7w")]
    [DisplayName("Collateral Substitution Sequence")]
    [IsoXmlTag("CollSbstitnSeq")]
    public required CollateralSubstitutionSequence1Code CollateralSubstitutionSequence { get; init; }

    /// <summary>
    /// Cash value of the requested collateral substitution transfer in the base currency.
    /// </summary>
    [IsoId("_0zFRlWA3EeSMf75YyPqG7w")]
    [DisplayName("Substitution Requirement")]
    [IsoXmlTag("SbstitnRqrmnt")]
    public required ActiveCurrencyAndAmount SubstitutionRequirement { get; init; }

    /// <summary>
    /// Specifies if the collateral that is substituted was posted against the variation margin or the independent amount.
    /// </summary>
    [IsoId("_0zFRl2A3EeSMf75YyPqG7w")]
    [DisplayName("Collateral Substitution Type")]
    [IsoXmlTag("CollSbstitnTp")]
    public required CollateralSubstitutionType1Code CollateralSubstitutionType { get; init; }

    /// <summary>
    /// Identifies the standard settlement instructions.
    /// </summary>
    [IsoId("_0zFRmWA3EeSMf75YyPqG7w")]
    [DisplayName("Standard Settlement Instructions")]
    [IsoXmlTag("StdSttlmInstrs")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? StandardSettlementInstructions { get; init; }

    /// <summary>
    /// Collateral type is securities.
    /// </summary>
    [IsoId("_0zFRn2A3EeSMf75YyPqG7w")]
    [DisplayName("Securities Collateral")]
    [IsoXmlTag("SctiesColl")]
    public SecuritiesCollateral4? SecuritiesCollateral { get; init; }

    /// <summary>
    /// Collateral type is cash.
    /// </summary>
    [IsoId("_0zFRnWA3EeSMf75YyPqG7w")]
    [DisplayName("Cash Collateral")]
    [IsoXmlTag("CshColl")]
    public CashCollateral5? CashCollateral { get; init; }

    /// <summary>
    /// Collateral type is other than securities or cash for example letter of credit.
    /// </summary>
    [IsoId("_0zFRm2A3EeSMf75YyPqG7w")]
    [DisplayName("Other Collateral")]
    [IsoXmlTag("OthrColl")]
    public OtherCollateral4? OtherCollateral { get; init; }

    /// <summary>
    /// Provides details on the identification of previously sent and/or received message(s), in case of updated substitution request.
    /// </summary>
    [IsoId("_0zFRoWA3EeSMf75YyPqG7w")]
    [DisplayName("Linked References")]
    [IsoXmlTag("LkdRefs")]
    public Reference17? LinkedReferences { get; init; }
}
