// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tax related to an investment fund order.
/// </summary>
[IsoId("_yAxHwTklEeapUO0vUIo9Xw")]
[DisplayName("Tax")]
public record Tax30
{
    /// <summary>
    /// Type of tax.
    /// </summary>
    [IsoId("_yZwPgzklEeapUO0vUIo9Xw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TaxType3Choice_ Type { get; init; }

    /// <summary>
    /// Tax to be applied.
    /// </summary>
    [IsoId("_hPc3kEUWEea21qTBwbMSEA")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxAmountOrRate4Choice_? Tax { get; init; }

    /// <summary>
    /// Country where the tax is due.
    /// </summary>
    [IsoId("_yZwPiTklEeapUO0vUIo9Xw")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }

    /// <summary>
    /// Indicates whether a tax exemption applies.
    /// </summary>
    [IsoId("_RYyrckUXEea21qTBwbMSEA")]
    [DisplayName("Exemption Indicator")]
    [IsoXmlTag("XmptnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExemptionIndicator { get; init; }

    /// <summary>
    /// Reason for the tax exemption.
    /// </summary>
    [IsoId("_RYyrc0UXEea21qTBwbMSEA")]
    [DisplayName("Exemption Reason")]
    [IsoXmlTag("XmptnRsn")]
    public ExemptionReason1Choice_? ExemptionReason { get; init; }

    /// <summary>
    /// Party that receives the tax. The recipient of, and the party entitled to, the tax may be two different parties.
    /// </summary>
    [IsoId("_yZwPizklEeapUO0vUIo9Xw")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification113? RecipientIdentification { get; init; }

    /// <summary>
    /// Information used to calculate the tax.
    /// </summary>
    [IsoId("_yZwPjTklEeapUO0vUIo9Xw")]
    [DisplayName("Tax Calculation Details")]
    [IsoXmlTag("TaxClctnDtls")]
    public TaxCalculationInformation9? TaxCalculationDetails { get; init; }
}
