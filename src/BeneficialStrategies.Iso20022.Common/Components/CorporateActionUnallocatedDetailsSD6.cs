// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding the corporate action event.
/// </summary>
[IsoId("_QeZTYb-8Eeeb2ZBoAlSG1Q")]
[DisplayName("Corporate Action Unallocated Details SD")]
public record CorporateActionUnallocatedDetailsSD6
{
    /// <summary>
    /// Type of Participants positions distribution balance concerned in unallocated payment.
    /// </summary>
    [IsoId("_QvgRgb-8Eeeb2ZBoAlSG1Q")]
    [DisplayName("Unallocated Distribution Balance")]
    [IsoXmlTag("UallctdDstrbtnBal")]
    public CorporateActionUnallocatedBalanceSD3Choice_? UnallocatedDistributionBalance { get; init; }

    /// <summary>
    /// Type of Participants positions redemption balance concerned in unallocated payment.
    /// </summary>
    [IsoId("_QvgRib-8Eeeb2ZBoAlSG1Q")]
    [DisplayName("Unallocated Redemption Balance")]
    [IsoXmlTag("UallctdRedBal")]
    public CorporateActionUnallocatedBalanceSD3? UnallocatedRedemptionBalance { get; init; }

    /// <summary>
    /// Type of participants positions reorganisation balance concerned in unallocated payment.
    /// </summary>
    [IsoId("_QvgRi7-8Eeeb2ZBoAlSG1Q")]
    [DisplayName("Unallocated Reorganisation Balance")]
    [IsoXmlTag("UallctdReorgBal")]
    public CorporateActionUnallocatedBalanceSD4? UnallocatedReorganisationBalance { get; init; }

    /// <summary>
    /// Details of the securities transactions concerned in unallocated payment.
    /// </summary>
    [IsoId("_QvgRjb-8Eeeb2ZBoAlSG1Q")]
    [DisplayName("Unallocated Securities Transaction Details")]
    [IsoXmlTag("UallctdSctiesTxDtls")]
    public CorporateActionUnallocatedSecuritiesTransactionDetailsSD7? UnallocatedSecuritiesTransactionDetails { get; init; }

    /// <summary>
    /// Details of the cash transactions concerned in unallocated payment.
    /// </summary>
    [IsoId("_QvgRlb-8Eeeb2ZBoAlSG1Q")]
    [DisplayName("Unallocated Cash Transaction Details")]
    [IsoXmlTag("UallctdCshTxDtls")]
    public CorporateActionUnallocatedCashTransactionDetailsSD6? UnallocatedCashTransactionDetails { get; init; }
}
