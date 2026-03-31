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
[IsoId("_CDRukUo6EeSXmLDTLfhEww")]
[DisplayName("Tax")]
public record Tax25
{
    /// <summary>
    /// Type of tax.
    /// </summary>
    [IsoId("_CdK1Q0o6EeSXmLDTLfhEww")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TaxType1Choice_ Type { get; init; }

    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_CdK1RUo6EeSXmLDTLfhEww")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Basis used to determine the capital gain or loss, for example, the purchase price.
    /// </summary>
    [IsoId("_CdK1R0o6EeSXmLDTLfhEww")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public TaxBasis1Choice_? Basis { get; init; }

    /// <summary>
    /// Party that receives the tax. The recipient of, and the party entitled to, the tax may be two different parties.
    /// </summary>
    [IsoId("_CdK1SUo6EeSXmLDTLfhEww")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification2Choice_? RecipientIdentification { get; init; }

    /// <summary>
    /// Indicates whether a tax exemption applies.
    /// </summary>
    [IsoId("_CdK1S0o6EeSXmLDTLfhEww")]
    [DisplayName("Exemption Indicator")]
    [IsoXmlTag("XmptnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExemptionIndicator { get; init; }

    /// <summary>
    /// Reason for a tax exemption.
    /// </summary>
    [IsoId("_CdK1TUo6EeSXmLDTLfhEww")]
    [DisplayName("Exemption Reason")]
    [IsoXmlTag("XmptnRsn")]
    public ExemptionReason1Choice_? ExemptionReason { get; init; }

    /// <summary>
    /// Information used to calculate the tax.
    /// </summary>
    [IsoId("_CdK1T0o6EeSXmLDTLfhEww")]
    [DisplayName("Tax Calculation Details")]
    [IsoXmlTag("TaxClctnDtls")]
    public TaxCalculationInformation8? TaxCalculationDetails { get; init; }
}
