// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding account balance. Contains transaction details of the stock loans, repurchase agreements (REPOs) and undelivered trades (FAILs).
/// </summary>
[IsoId("_got8Ab-zEeeb2ZBoAlSG1Q")]
[DisplayName("Account Balance SD")]
public record AccountBalanceSD13
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_g35Acb-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Position held in a security as of the day prior to publication date. This position is subject to a redemption lottery call when this is the first lottery. This balance will not be adjusted for the supplemental or concurrent lotteries and will remain constant to report the original position.
    /// </summary>
    [IsoId("_g35Ac7-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Original Balance")]
    [IsoXmlTag("OrgnlBal")]
    public SignedQuantityFormat9? OriginalBalance { get; init; }

    /// <summary>
    /// Portion of the original balance position held in DTC general free account as of day prior to publication date. Position held in this account is subject to redemption lottery call.
    /// </summary>
    [IsoId("_g35Adb-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Unpledged Balance")]
    [IsoXmlTag("UpldgdBal")]
    public SignedQuantityFormat9? UnpledgedBalance { get; init; }

    /// <summary>
    /// Portion of the original balance position held in DTC segregated account as of day prior to publication date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    [IsoId("_g35Ad7-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Investment Unpledged Balance")]
    [IsoXmlTag("InvstmtUpldgdBal")]
    public SignedQuantityFormat9? InvestmentUnpledgedBalance { get; init; }

    /// <summary>
    /// Portion of the original balance position held in DTC investment account as of day prior to publication date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    [IsoId("_g35Aeb-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Investment Pledged Balance")]
    [IsoXmlTag("InvstmtPldgdBal")]
    public SignedQuantityFormat9? InvestmentPledgedBalance { get; init; }

    /// <summary>
    /// Balance that has been accepted by the issuer / agent for payment.
    /// </summary>
    [IsoId("_g35Ae7-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Accepted Balance")]
    [IsoXmlTag("AccptdBal")]
    public SignedQuantityFormat9? AcceptedBalance { get; init; }

    /// <summary>
    /// Balance that has not been accepted by issuer / agent for payment.
    /// </summary>
    [IsoId("_g35Afb-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Unaccepted Balance")]
    [IsoXmlTag("UaccptdBal")]
    public SignedQuantityFormat9? UnacceptedBalance { get; init; }

    /// <summary>
    /// For rights subscription events, total number of oversubscribed units applicable to the payment or the subscription charge.
    /// </summary>
    [IsoId("_g35Af7-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Oversubscription Balance")]
    [IsoXmlTag("OvrsbcptBal")]
    public SignedQuantityFormat9? OversubscriptionBalance { get; init; }
}
