// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action dates.
/// </summary>
[IsoId("_MlVlDUEEEeWVgfuHGaKtRQ")]
[DisplayName("Corporate Action Date")]
public record CorporateActionDate49
{
    /// <summary>
    /// Date/time at which positions are struck at the end of the day to note which parties will receive the relevant amount of entitlement, due to be distributed on payment date.
    /// </summary>
    [IsoId("_MxiN80EEEeWVgfuHGaKtRQ")]
    [DisplayName("Record Date")]
    [IsoXmlTag("RcrdDt")]
    public DateFormat31Choice_? RecordDate { get; init; }

    /// <summary>
    /// Date/time as from which trading (including exchange and OTC trading) occurs on the underlying security without the benefit.
    /// </summary>
    [IsoId("_MxiN-0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Ex Dividend Date")]
    [IsoXmlTag("ExDvddDt")]
    public DateFormat31Choice_? ExDividendDate { get; init; }
}
