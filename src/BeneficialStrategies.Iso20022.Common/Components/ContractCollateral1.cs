// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further details on the contract collateral.
/// </summary>
[IsoId("_5ysDEdOOEeSQ_-lmj1tzfw")]
[DisplayName("Contract Collateral")]
public record ContractCollateral1
{
    /// <summary>
    /// Total amount of the collateral as defined in the contract.
    /// </summary>
    [IsoId("_-YNcsNOOEeSQ_-lmj1tzfw")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required ActiveCurrencyAndAmount TotalAmount { get; init; }

    /// <summary>
    /// Detailed description of the collateral.
    /// </summary>
    [IsoId("_FP2C4NOPEeSQ_-lmj1tzfw")]
    [DisplayName("Collateral Description")]
    [IsoXmlTag("CollDesc")]
    public CashCollateral5? CollateralDescription { get; init; }

    /// <summary>
    /// Further information on the contract collateral.
    /// </summary>
    [IsoId("_f4fVctOPEeSQ_-lmj1tzfw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? AdditionalInformation { get; init; }
}
