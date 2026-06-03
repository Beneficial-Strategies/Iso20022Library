// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tax applicable to a transaction.
/// </summary>
[IsoId("_s2I_cVXZEfC0lMwgjvMClw")]
[DisplayName("Tax44")]
public record Tax44
{
    [IsoId("_s2I_cVXZEfC0lMwgjvMClw-typ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required AddendumTaxType4Code Type { get; init; }

    [IsoId("_s2I_cVXZEfC0lMwgjvMClw-dsc")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax35Text? Description { get; init; }

    [IsoId("_s2I_cVXZEfC0lMwgjvMClw-exmp")]
    [DisplayName("Exemption")]
    [IsoXmlTag("Xmptn")]
    public IsoTrueFalseIndicator? Exemption { get; init; }

    [IsoId("_s2I_cVXZEfC0lMwgjvMClw-exrs")]
    [DisplayName("Exempt Reason")]
    [IsoXmlTag("XmptRsn")]
    public IsoMax35Text? ExemptReason { get; init; }

    [IsoId("_s2I_cVXZEfC0lMwgjvMClw-amt")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    [IsoId("_s2I_cVXZEfC0lMwgjvMClw-rate")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public IsoPercentageRate? Rate { get; init; }

    [IsoId("_s2I_cVXZEfC0lMwgjvMClw-intt")]
    [DisplayName("Included In Total")]
    [IsoXmlTag("InclInTtl")]
    public IsoTrueFalseIndicator? IncludedInTotal { get; init; }

    [IsoId("_s2I_cVXZEfC0lMwgjvMClw-crdb")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }
}
