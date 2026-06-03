// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Represents a party to be identified as eligible for the instructing party.
/// </summary>
[IsoId("_wlhJsWc-EemvNLufWGIVOQ")]
[DisplayName("Eligible Counterpart3")]
public record EligibleCounterpart3
{
    /// <summary>
    /// Unique business identifier code used to identify the party providing the eligible counterpart information.
    /// </summary>
    [IsoId("_wwg4wWc-EemvNLufWGIVOQ")]
    [DisplayName("Issuer Identification")]
    [IsoXmlTag("IssrId")]
    public required SystemPartyIdentification2Choice_ IssuerIdentification { get; init; }

    /// <summary>
    /// Unique business identifier code used to identify the central securities depository to be defined as eligible.
    /// </summary>
    [IsoId("_wwg4w2c-EemvNLufWGIVOQ")]
    [DisplayName("Eligible Counterpart Identification")]
    [IsoXmlTag("ElgblCntrptId")]
    public required SystemPartyIdentification2Choice_ EligibleCounterpartIdentification { get; init; }

    /// <summary>
    /// Date from when the eligible counterpart is valid.
    /// </summary>
    [IsoId("_wwg4xWc-EemvNLufWGIVOQ")]
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    public required IsoISODate ValidFrom { get; init; }

    /// <summary>
    /// Date until when the eligible counterpart is valid.
    /// </summary>
    [IsoId("_wwg4x2c-EemvNLufWGIVOQ")]
    [DisplayName("Valid To")]
    [IsoXmlTag("VldTo")]
    public IsoISODate? ValidTo { get; init; }

    /// <summary>
    /// Defines the type of eligibility.
    /// </summary>
    [IsoId("_wwg4yWc-EemvNLufWGIVOQ")]
    [DisplayName("Eligibility Type")]
    [IsoXmlTag("ElgbltyTp")]
    public required EligibilityType1Code EligibilityType { get; init; }

    /// <summary>
    /// Unique identification of the eligible counterpart party.
    /// </summary>
    [IsoId("_wwg4y2c-EemvNLufWGIVOQ")]
    [DisplayName("Eligibility Identification")]
    [IsoXmlTag("ElgbltyId")]
    public required EligibilityIdentification3Choice_ EligibilityIdentification { get; init; }
}
