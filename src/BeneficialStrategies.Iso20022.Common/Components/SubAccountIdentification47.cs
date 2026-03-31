// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides all sub-account details.
/// </summary>
[IsoId("_8bqnzZNLEeWGlc8L7oPDIg")]
[DisplayName("Sub Account Identification")]
public record SubAccountIdentification47
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_8bqnz5NLEeWGlc8L7oPDIg")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification109? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_8bqn05NLEeWGlc8L7oPDIg")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount34 SafekeepingAccount { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_8bqn15NLEeWGlc8L7oPDIg")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Reporting per financial instrument.
    /// </summary>
    [IsoId("_8bqn25NLEeWGlc8L7oPDIg")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public ValueList<FinancialInstrumentDetails23> FinancialInstrumentDetails { get; init; } = [];
}
