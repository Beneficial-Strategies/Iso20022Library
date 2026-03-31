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
[IsoId("_UGnzYQ3sEeKIIIcS0K4sAQ")]
[DisplayName("Sub Account Identification")]
public record SubAccountIdentification30
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_Uc921Q3sEeKIIIcS0K4sAQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification36Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_Uc923w3sEeKIIIcS0K4sAQ")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount14 SafekeepingAccount { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_Uc926Q3sEeKIIIcS0K4sAQ")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Reporting per financial instrument.
    /// </summary>
    [IsoId("_Uc928w3sEeKIIIcS0K4sAQ")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public ValueList<FinancialInstrumentDetails13> FinancialInstrumentDetails { get; init; } = [];
}
