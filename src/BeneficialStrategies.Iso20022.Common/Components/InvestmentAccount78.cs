// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investment Account78.
/// </summary>
[IsoId("_4u7MMRwMEe6O0NdiBuX__w")]
[DisplayName("Investment Account78")]
public record InvestmentAccount78
{
    /// <summary>
    /// Account Designation.
    /// </summary>
    [DisplayName("Account Designation")]
    [IsoXmlTag("AcctDsgnt")]
    public IsoMax35Text? AccountDesignation { get; init; }

    /// <summary>
    /// Account Identification.
    /// </summary>
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required IsoMax35Text AccountIdentification { get; init; }

    /// <summary>
    /// Account Name.
    /// </summary>
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    public IsoMax35Text? AccountName { get; init; }

    /// <summary>
    /// Account Servicer.
    /// </summary>
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification139? AccountServicer { get; init; }

    /// <summary>
    /// Order Originator Eligibility.
    /// </summary>
    [DisplayName("Order Originator Eligibility")]
    [IsoXmlTag("OrdrOrgtrElgblty")]
    public OrderOriginatorEligibility1Code? OrderOriginatorEligibility { get; init; }

    /// <summary>
    /// Owner Identification.
    /// </summary>
    [DisplayName("Owner Identification")]
    [IsoXmlTag("OwnrId")]
    public ValueList<PartyIdentification139> OwnerIdentification { get; init; } = [];

    /// <summary>
    /// Sub Account Details.
    /// </summary>
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccount6? SubAccountDetails { get; init; }
}
