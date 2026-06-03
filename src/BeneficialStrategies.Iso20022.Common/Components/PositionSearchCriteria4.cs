// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the securities account position query criteria.
/// </summary>
[IsoId("_EpRYIQweEfG65oVFfOF9vw")]
[DisplayName("Position Search Criteria4")]
public record PositionSearchCriteria4
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_Esj8sQweEfG65oVFfOF9vw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification136? AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner.
    /// </summary>
    [IsoId("_Esj8swweEfG65oVFfOF9vw")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification136? AccountServicer { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_Esj8tQweEfG65oVFfOF9vw")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount2Choice_? SafekeepingAccount { get; init; }

    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-à-vis the issuer.
    /// </summary>
    [IsoId("_Esj8twweEfG65oVFfOF9vw")]
    [DisplayName("Financial Instrument")]
    [IsoXmlTag("FinInstrm")]
    public SecurityIdentification19? FinancialInstrument { get; init; }

    /// <summary>
    /// Country where the security is issued.
    /// </summary>
    [IsoId("_Esj8uQweEfG65oVFfOF9vw")]
    [DisplayName("Country Of Issue")]
    [IsoXmlTag("CtryOfIsse")]
    public CountryCode? CountryOfIssue { get; init; }

    /// <summary>
    /// Defines specific restriction characteristics for a securities position.
    /// </summary>
    [IsoId("_Esj8uwweEfG65oVFfOF9vw")]
    [DisplayName("Sub Balance Type")]
    [IsoXmlTag("SubBalTp")]
    public SecuritiesBalanceType7Choice_? SubBalanceType { get; init; }

    /// <summary>
    /// Option to provide output zero position in the results.
    /// </summary>
    [IsoId("_Esj8vQweEfG65oVFfOF9vw")]
    [DisplayName("Return Zero Position")]
    [IsoXmlTag("RtrZeroPos")]
    public required IsoTrueFalseIndicator ReturnZeroPosition { get; init; }

    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_Esj8vwweEfG65oVFfOF9vw")]
    [DisplayName("Other Business Parties")]
    [IsoXmlTag("OthrBizPties")]
    public OtherParties46? OtherBusinessParties { get; init; }
}
