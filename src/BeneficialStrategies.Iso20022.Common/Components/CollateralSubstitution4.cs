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
[IsoId("_tOZoYYFvEeWtPe6Crjmeug")]
[DisplayName("Collateral Substitution")]
public record CollateralSubstitution4
{
    /// <summary>
    /// Indicates whether the collateral substitution request is new or updated.
    /// </summary>
    [IsoId("_tpLf44FvEeWtPe6Crjmeug")]
    [DisplayName("Collateral Substitution Sequence")]
    [IsoXmlTag("CollSbstitnSeq")]
    public required CollateralSubstitutionSequence1Code CollateralSubstitutionSequence { get; init; }

    /// <summary>
    /// Cash value of the requested collateral substitution transfer in the base currency.
    /// </summary>
    [IsoId("_tpLf5YFvEeWtPe6Crjmeug")]
    [DisplayName("Substitution Requirement")]
    [IsoXmlTag("SbstitnRqrmnt")]
    public required ActiveCurrencyAndAmount SubstitutionRequirement { get; init; }

    /// <summary>
    /// Specifies if the collateral that is substituted was posted against the variation margin or the independent amount.
    /// </summary>
    [IsoId("_tpLf54FvEeWtPe6Crjmeug")]
    [DisplayName("Collateral Substitution Type")]
    [IsoXmlTag("CollSbstitnTp")]
    public required CollateralSubstitutionType1Code CollateralSubstitutionType { get; init; }

    /// <summary>
    /// Identifies the standard settlement instructions.
    /// </summary>
    [IsoId("_tpLf6YFvEeWtPe6Crjmeug")]
    [DisplayName("Standard Settlement Instructions")]
    [IsoXmlTag("StdSttlmInstrs")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? StandardSettlementInstructions { get; init; }

    /// <summary>
    /// Collateral type is securities.
    /// </summary>
    [IsoId("_tpLf64FvEeWtPe6Crjmeug")]
    [DisplayName("Securities Collateral")]
    [IsoXmlTag("SctiesColl")]
    public ValueList<SecuritiesCollateral5> SecuritiesCollateral { get; init; } = [];

    /// <summary>
    /// Collateral type is cash.
    /// </summary>
    [IsoId("_tpLf7YFvEeWtPe6Crjmeug")]
    [DisplayName("Cash Collateral")]
    [IsoXmlTag("CshColl")]
    public ValueList<CashCollateral3> CashCollateral { get; init; } = [];

    /// <summary>
    /// Collateral type is other than securities or cash for example letter of credit.
    /// </summary>
    [IsoId("_tpLf74FvEeWtPe6Crjmeug")]
    [DisplayName("Other Collateral")]
    [IsoXmlTag("OthrColl")]
    public ValueList<OtherCollateral5> OtherCollateral { get; init; } = [];

    /// <summary>
    /// Provides details on the identification of previously sent and/or received message(s), in case of updated substitution request.
    /// </summary>
    [IsoId("_tpLf8YFvEeWtPe6Crjmeug")]
    [DisplayName("Linked References")]
    [IsoXmlTag("LkdRefs")]
    public Reference17? LinkedReferences { get; init; }
}
