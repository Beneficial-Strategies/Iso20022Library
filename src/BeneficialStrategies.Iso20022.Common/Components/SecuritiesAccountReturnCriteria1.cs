// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Return criteria for information to be returned in the report deriving from a query about securities account reference data.
/// </summary>
[IsoId("_X5rHEeX3EeWawO9uAAThyQ")]
[DisplayName("Securities Account Return Criteria")]
public record SecuritiesAccountReturnCriteria1
{
    /// <summary>
    /// Indicates whether the identification of the account is requested.
    /// </summary>
    [IsoId("_YDWAceX3EeWawO9uAAThyQ")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? AccountIdentification { get; init; }

    /// <summary>
    /// Indicates whether the identification of the party owning the account is requested.
    /// </summary>
    [IsoId("_YDWAc-X3EeWawO9uAAThyQ")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PartyIdentification { get; init; }

    /// <summary>
    /// Indicates whether the type of the party owning the account is requested.
    /// </summary>
    [IsoId("_YDWAdeX3EeWawO9uAAThyQ")]
    [DisplayName("Party Type")]
    [IsoXmlTag("PtyTp")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PartyType { get; init; }

    /// <summary>
    /// Indicates whether the account servicer is requested.
    /// </summary>
    [IsoId("_YDWAd-X3EeWawO9uAAThyQ")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? AccountServicer { get; init; }

    /// <summary>
    /// Indicates whether the account type is requested.
    /// </summary>
    [IsoId("_YDWAeeX3EeWawO9uAAThyQ")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? AccountType { get; init; }

    /// <summary>
    /// Indicates whether the opening date for the account is requested.
    /// </summary>
    [IsoId("_YDWAe-X3EeWawO9uAAThyQ")]
    [DisplayName("Opening Date")]
    [IsoXmlTag("OpngDt")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? OpeningDate { get; init; }

    /// <summary>
    /// Indicates whether the closing date for the account is requested.
    /// </summary>
    [IsoId("_YDWAfeX3EeWawO9uAAThyQ")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? ClosingDate { get; init; }

    /// <summary>
    /// Specifies information to identify securities accounts where allocation instructions are posted.
    /// </summary>
    [IsoId("_YDWAf-X3EeWawO9uAAThyQ")]
    [DisplayName("End Investor Flag")]
    [IsoXmlTag("EndInvstrFlg")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? EndInvestorFlag { get; init; }

    /// <summary>
    /// Defines how the price is applied to the securities account.
    /// </summary>
    [IsoId("_YDWAgeX3EeWawO9uAAThyQ")]
    [DisplayName("Pricing Scheme")]
    [IsoXmlTag("PricgSchme")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PricingScheme { get; init; }
}
