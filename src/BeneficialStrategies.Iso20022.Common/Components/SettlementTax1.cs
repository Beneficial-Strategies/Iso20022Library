// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Species the tax applicable for this settlement.
/// </summary>
[IsoId("_S0j3LAEcEeCQm6a_G2yO_w_811596505")]
[DisplayName("Settlement Tax")]
public record SettlementTax1
{
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_S0j3LQEcEeCQm6a_G2yO_w_-664594537")]
    [DisplayName("Type Code")]
    [IsoXmlTag("TpCd")]
    public TaxTypeFormat1Choice_? TypeCode { get; init; }

    /// <summary>
    /// Monetary value resulting from the calculation of this tax, levy or duty.
    /// </summary>
    [IsoId("_S0j3LgEcEeCQm6a_G2yO_w_588725222")]
    [DisplayName("Calculated Amount")]
    [IsoXmlTag("ClctdAmt")]
    public CurrencyAndAmount? CalculatedAmount { get; init; }

    /// <summary>
    /// Monetary value used as the basis on which this tax, levy or duty is calculated.
    /// </summary>
    [IsoId("_S0j3LwEcEeCQm6a_G2yO_w_-780660433")]
    [DisplayName("Basis Amount")]
    [IsoXmlTag("BsisAmt")]
    public CurrencyAndAmount? BasisAmount { get; init; }

    /// <summary>
    /// Date of the tax point when this tax, levy or duty becomes applicable.
    /// </summary>
    [IsoId("_S0j3MAEcEeCQm6a_G2yO_w_-805508608")]
    [DisplayName("Tax Point Date")]
    [IsoXmlTag("TaxPtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TaxPointDate { get; init; }
}
