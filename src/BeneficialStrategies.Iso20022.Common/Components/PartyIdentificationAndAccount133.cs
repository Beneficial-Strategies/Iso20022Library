// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account details.
/// </summary>
[IsoId("_5nBWHZNLEeWGlc8L7oPDIg")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount133
{
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_5nBWH5NLEeWGlc8L7oPDIg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification104Choice_ Identification { get; init; }

    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    [IsoId("_5nBWJ5NLEeWGlc8L7oPDIg")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_5nBWKZNLEeWGlc8L7oPDIg")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification9? AlternateIdentification { get; init; }

    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_5nBWMZNLEeWGlc8L7oPDIg")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification6Choice_? CashAccount { get; init; }

    /// <summary>
    /// Account to be used for charges/fees if different from the account for payment.
    /// </summary>
    [IsoId("_5nBWOZNLEeWGlc8L7oPDIg")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccountIdentification6Choice_? ChargesAccount { get; init; }

    /// <summary>
    /// Account to be used for commission if different from the account for payment.
    /// </summary>
    [IsoId("_5nBWQZNLEeWGlc8L7oPDIg")]
    [DisplayName("Commission Account")]
    [IsoXmlTag("ComssnAcct")]
    public CashAccountIdentification6Choice_? CommissionAccount { get; init; }

    /// <summary>
    /// Account to be used for taxes if different from the account for payment.
    /// </summary>
    [IsoId("_5nBWSZNLEeWGlc8L7oPDIg")]
    [DisplayName("Tax Account")]
    [IsoXmlTag("TaxAcct")]
    public CashAccountIdentification6Choice_? TaxAccount { get; init; }

    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    [IsoId("_5nBWUZNLEeWGlc8L7oPDIg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation4? AdditionalInformation { get; init; }
}
