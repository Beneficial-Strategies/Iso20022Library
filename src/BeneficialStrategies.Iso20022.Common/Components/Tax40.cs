// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tax40.
/// </summary>
[IsoId("_17LSPRwMEe6O0NdiBuX__w")]
[DisplayName("Tax40")]
public record Tax40
{
    /// <summary>
    /// Country.
    /// </summary>
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }

    /// <summary>
    /// Exemption Indicator.
    /// </summary>
    [DisplayName("Exemption Indicator")]
    [IsoXmlTag("XmptnInd")]
    public required IsoYesNoIndicator ExemptionIndicator { get; init; }

    /// <summary>
    /// Exemption Reason.
    /// </summary>
    [DisplayName("Exemption Reason")]
    [IsoXmlTag("XmptnRsn")]
    public ExemptionReason1Choice_? ExemptionReason { get; init; }

    /// <summary>
    /// Informative Amount.
    /// </summary>
    [DisplayName("Informative Amount")]
    [IsoXmlTag("InftvAmt")]
    public ActiveCurrencyAndAmount? InformativeAmount { get; init; }

    /// <summary>
    /// Informative Rate.
    /// </summary>
    [DisplayName("Informative Rate")]
    [IsoXmlTag("InftvRate")]
    public IsoPercentageRate? InformativeRate { get; init; }

    /// <summary>
    /// Recipient Identification.
    /// </summary>
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification139? RecipientIdentification { get; init; }

    /// <summary>
    /// Tax Calculation Details.
    /// </summary>
    [DisplayName("Tax Calculation Details")]
    [IsoXmlTag("TaxClctnDtls")]
    public TaxCalculationInformation10? TaxCalculationDetails { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TaxType3Choice_ Type { get; init; }
}
