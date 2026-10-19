// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tax41.
/// </summary>
[IsoId("_ATvMQXNTEe6Y1uOeeiF_Eg")]
[DisplayName("Tax41")]
public partial record Tax41
{
    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required AddendumTaxType3Code Type { get; init; }

    /// <summary>
    /// Other Type.
    /// </summary>
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    public Max35Text? OtherType { get; init; }

    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public Max35Text? Description { get; init; }

    /// <summary>
    /// Exemption.
    /// </summary>
    [DisplayName("Exemption")]
    [IsoXmlTag("Xmptn")]
    public TrueFalseIndicator? Exemption { get; init; }

    /// <summary>
    /// Exempt Reason.
    /// </summary>
    [DisplayName("Exempt Reason")]
    [IsoXmlTag("XmptRsn")]
    public Max35Text? ExemptReason { get; init; }

    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Rate.
    /// </summary>
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public PercentageRate? Rate { get; init; }

    /// <summary>
    /// Included In Total.
    /// </summary>
    [DisplayName("Included In Total")]
    [IsoXmlTag("InclInTtl")]
    public TrueFalseIndicator? IncludedInTotal { get; init; }

    /// <summary>
    /// Credit Debit.
    /// </summary>
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }
}
