// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of search criteria for querying securities account reference data.
/// </summary>
[IsoId("_U5MuUTp1Eemk2e6qGBk8IQ")]
[DisplayName("Securities Account Search Criteria")]
public record SecuritiesAccountSearchCriteria2
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_VDocsTp1Eemk2e6qGBk8IQ")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Party that services the account.
    /// </summary>
    [IsoId("_VDocszp1Eemk2e6qGBk8IQ")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification136? AccountServicer { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_VDoctTp1Eemk2e6qGBk8IQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public SystemPartyIdentification8? AccountOwner { get; init; }

    /// <summary>
    /// Specifies the type of the party for which securities account data have been queried.
    /// </summary>
    [IsoId("_VDoctzp1Eemk2e6qGBk8IQ")]
    [DisplayName("Party Type")]
    [IsoXmlTag("PtyTp")]
    public SystemPartyType1Choice_? PartyType { get; init; }

    /// <summary>
    /// Legal opening date for the securities account.
    /// </summary>
    [IsoId("_VDocuTp1Eemk2e6qGBk8IQ")]
    [DisplayName("Opening Date")]
    [IsoXmlTag("OpngDt")]
    public DatePeriodSearch1Choice_? OpeningDate { get; init; }

    /// <summary>
    /// Legal closing date for the securities account.
    /// </summary>
    [IsoId("_VDocuzp1Eemk2e6qGBk8IQ")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    public DatePeriodSearch1Choice_? ClosingDate { get; init; }

    /// <summary>
    /// Specifies the type of securities account.
    /// </summary>
    [IsoId("_VDocvTp1Eemk2e6qGBk8IQ")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public SystemSecuritiesAccountType1Choice_? AccountType { get; init; }

    /// <summary>
    /// Specifies information to identify securities accounts where allocation instructions are posted.
    /// </summary>
    [IsoId("_VDocvzp1Eemk2e6qGBk8IQ")]
    [DisplayName("End Investor Flag")]
    [IsoXmlTag("EndInvstrFlg")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public IsoExact4AlphaNumericText? EndInvestorFlag { get; init; }

    /// <summary>
    /// Defines how the price is applied to the securities account.
    /// </summary>
    [IsoId("_VDocwTp1Eemk2e6qGBk8IQ")]
    [DisplayName("Pricing Scheme")]
    [IsoXmlTag("PricgSchme")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public IsoExact4AlphaNumericText? PricingScheme { get; init; }
}
