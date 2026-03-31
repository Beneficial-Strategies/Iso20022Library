// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Deposit limits for the account.
/// </summary>
[IsoId("_VLidYYq7EeSHjtO_wHA7PQ")]
[DisplayName("ATM Transaction Amounts")]
public record ATMTransactionAmounts5
{
    /// <summary>
    /// True if limits may be displayed on the ATM to the customer.
    /// </summary>
    [IsoId("_VYWxYYq7EeSHjtO_wHA7PQ")]
    [DisplayName("Display Flag")]
    [IsoXmlTag("DispFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DisplayFlag { get; init; }

    /// <summary>
    /// Maximum amount allowed for deposit on the account.
    /// </summary>
    [IsoId("_VYWxY4q7EeSHjtO_wHA7PQ")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ImpliedCurrencyAndAmount? MaximumAmount { get; init; }
}
