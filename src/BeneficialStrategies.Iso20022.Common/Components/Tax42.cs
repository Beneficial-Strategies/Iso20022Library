// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tax applicable to the investment fund order.
/// </summary>
[IsoId("c1c36ba1-72f2-4518-9304-b6e05bdf3942")]
[DisplayName("Tax42")]
public record Tax42
{
    /// <summary>
    /// Type of tax.
    /// </summary>
    [IsoId("c1c36ba1-type-0001-0001-b6e05bdf3942")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TaxType3Choice_ Type { get; init; }

    /// <summary>
    /// Tax to be applied.
    /// </summary>
    [IsoId("c1c36ba1-tax0-0001-0002-b6e05bdf3942")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxAmountOrRate4Choice_? Tax { get; init; }

    /// <summary>
    /// Country where the tax is due.
    /// </summary>
    [IsoId("c1c36ba1-ctry-0001-0003-b6e05bdf3942")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }

    /// <summary>
    /// Indicates whether a tax exemption applies.
    /// </summary>
    [IsoId("c1c36ba1-exmp-0001-0004-b6e05bdf3942")]
    [DisplayName("Exemption Indicator")]
    [IsoXmlTag("XmptnInd")]
    public required IsoYesNoIndicator ExemptionIndicator { get; init; }

    /// <summary>
    /// Reason for the tax exemption.
    /// </summary>
    [IsoId("c1c36ba1-exrs-0001-0005-b6e05bdf3942")]
    [DisplayName("Exemption Reason")]
    [IsoXmlTag("XmptnRsn")]
    public ExemptionReason1Choice_? ExemptionReason { get; init; }

    /// <summary>
    /// Party that receives the tax. The recipient of, and the party entitled to, the tax may be two different parties.
    /// </summary>
    [IsoId("c1c36ba1-rcid-0001-0006-b6e05bdf3942")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification139? RecipientIdentification { get; init; }

    /// <summary>
    /// Information used to calculate the tax.
    /// </summary>
    [IsoId("c1c36ba1-txcd-0001-0007-b6e05bdf3942")]
    [DisplayName("Tax Calculation Details")]
    [IsoXmlTag("TaxClctnDtls")]
    public TaxCalculationInformation9? TaxCalculationDetails { get; init; }
}
