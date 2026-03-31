// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sub-account reporting.
/// </summary>
[IsoId("_IjR3cSW8EeOslcz0TJwprQ")]
[DisplayName("Sub Account Identification")]
public record SubAccountIdentification34
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_I7h_YyW8EeOslcz0TJwprQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification36Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_I7h_ayW8EeOslcz0TJwprQ")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount14 SafekeepingAccount { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_I7h_cyW8EeOslcz0TJwprQ")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Reporting per financial instrument.
    /// </summary>
    [IsoId("_I7h_eyW8EeOslcz0TJwprQ")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public ValueList<FinancialInstrumentDetails17> FinancialInstrumentDetails { get; init; } = [];
}
