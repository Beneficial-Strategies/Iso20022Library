// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides general interest information that applies to the account at a particular moment in time.
/// </summary>
[IsoId("_SRxMUNp-Ed-ak6NoX_4Aeg_-808808918")]
[DisplayName("Account Interest")]
public record AccountInterest1
{
    /// <summary>
    /// Specifies the type of interest.
    /// </summary>
    [IsoId("_SRxMUdp-Ed-ak6NoX_4Aeg_-701014230")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public InterestType1Choice_? Type { get; init; }

    /// <summary>
    /// Set of elements qualifying the interest rate.
    /// </summary>
    [IsoId("_SRxMUtp-Ed-ak6NoX_4Aeg_124611606")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public Rate1? Rate { get; init; }

    /// <summary>
    /// Range of time between a start date and an end date for the calculation of the interest.
    /// </summary>
    [IsoId("_SRxMU9p-Ed-ak6NoX_4Aeg_408390950")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriodDetails? FromToDate { get; init; }

    /// <summary>
    /// Underlying reason for the interest, eg, yearly credit interest on a savings account.
    /// </summary>
    [IsoId("_SRxMVNp-Ed-ak6NoX_4Aeg_-447711170")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Reason { get; init; }
}
