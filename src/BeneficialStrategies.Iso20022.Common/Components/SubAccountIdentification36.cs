// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a securities entry is made.
/// </summary>
[IsoId("_2-lV4Qf9EeSaceXTzyiZRg")]
[DisplayName("Sub Account Identification")]
public record SubAccountIdentification36
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_3ZqIVQf9EeSaceXTzyiZRg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentificationFormatChoice_ Identification { get; init; }

    /// <summary>
    /// Indicates whether there is activity reported in the statement.
    /// </summary>
    [IsoId("_3ZqIVwf9EeSaceXTzyiZRg")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Creation/cancellation of investment units on the books of the fund or its designated agent, as a result of executing an investment fund order.
    /// </summary>
    [IsoId("_3ZqIWQf9EeSaceXTzyiZRg")]
    [DisplayName("Transaction On Sub Account")]
    [IsoXmlTag("TxOnSubAcct")]
    public ValueList<InvestmentFundTransactionsByFund3> TransactionOnSubAccount { get; init; } = [];
}
