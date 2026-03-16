// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fees not included in the transaction.
/// </summary>
[IsoId("_xv70MYdGEeuBS50MFjViNw")]
[DisplayName("Additional Fee")]
public record AdditionalFee2
{
    /// <summary>
    /// Type or class of fee.
    /// </summary>
    [IsoId("_x1HPIYdGEeuBS50MFjViNw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfAmount21Code Type { get; init; }

    /// <summary>
    /// Additional information to specify the type of amount of fee.
    /// </summary>
    [IsoId("_x1HPI4dGEeuBS50MFjViNw")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Identification of fee program.
    /// </summary>
    [IsoId("_x1HPJYdGEeuBS50MFjViNw")]
    [DisplayName("Fee Program")]
    [IsoXmlTag("FeePrgm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FeeProgram { get; init; }

    /// <summary>
    /// Identification of specific fee.
    /// </summary>
    [IsoId("_x1HPJ4dGEeuBS50MFjViNw")]
    [DisplayName("Fee Descriptor")]
    [IsoXmlTag("FeeDscrptr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FeeDescriptor { get; init; }

    /// <summary>
    /// Amount of one occurrence of the fee amount.
    /// </summary>
    [IsoId("_x1HPKYdGEeuBS50MFjViNw")]
    [DisplayName("Fee Amount")]
    [IsoXmlTag("FeeAmt")]
    public required FeeAmount3 FeeAmount { get; init; }

    /// <summary>
    /// Contains the fee amount in reconciliation currency.
    /// </summary>
    [IsoId("_CHQygIdIEeuBS50MFjViNw")]
    [DisplayName("Fee Reconciliation Amount")]
    [IsoXmlTag("FeeRcncltnAmt")]
    public FeeAmount3? FeeReconciliationAmount { get; init; }

    /// <summary>
    /// Short description of the fee amount.
    /// </summary>
    [IsoId("_x1HPK4dGEeuBS50MFjViNw")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Description { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_nKZbYTNJEeylu6lH-gut-A")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}
