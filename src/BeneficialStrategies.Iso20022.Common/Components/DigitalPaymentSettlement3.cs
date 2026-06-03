// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the information related to the digital payment settlement.
/// </summary>
[IsoId("4ac01ad2-2079-4ed3-ad62-4e288f83f9ca")]
[DisplayName("Digital Payment Settlement3")]
public record DigitalPaymentSettlement3
{
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("3945e85b-05a1-4886-a3df-2a5821062a37")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification50 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Choice between different quantities related to the payment in digital asset.
    /// </summary>
    [IsoId("1914951e-2848-4767-a200-fc133e7c48fd")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required Quantity48Choice_ Quantity { get; init; }

    /// <summary>
    /// Place of settlement expressed with a Digital Ledger Identifier.
    /// </summary>
    [IsoId("54fcb8ad-eba4-4c72-ba57-5169403c6b53")]
    [DisplayName("Digital Ledger Identification")]
    [IsoXmlTag("DgtlLdgrId")]
    public required IsoDTI2024Identifier DigitalLedgerIdentification { get; init; }
}
