// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference to the collateral management transaction (exposure) or the contract identification of  the sender (collateral taker) or the receiver (triparty agent)
/// </summary>
[IsoId("_dOIDYPkCEeicy5Zn42b9bg")]
[DisplayName("Reference")]
public record Reference21
{
    /// <summary>
    /// Unique reference identifying the collateral management transaction (exposure) from the collateral taker&apos;s or the collateral giver point of view.
    /// </summary>
    [IsoId("_Z6qcoPkEEeicy5Zn42b9bg")]
    [DisplayName("Sender Collateral Transaction Identification")]
    [IsoXmlTag("SndrCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SenderCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Unique reference identifying the collateral management transaction (exposure)  from the triparty agent&apos;s point of view.
    /// </summary>
    [IsoId("_o8Z9gPkEEeicy5Zn42b9bg")]
    [DisplayName("Receiver Collateral Transaction Identification")]
    [IsoXmlTag("RcvrCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReceiverCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Unique reference identifying the collateral management contract from the collateral taker&apos;s or the collateral giver&apos;s point of view.
    /// </summary>
    [IsoId("_eQJZsPkFEeicy5Zn42b9bg")]
    [DisplayName("Sender Collateral Contract Identification")]
    [IsoXmlTag("SndrCollCtrctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SenderCollateralContractIdentification { get; init; }

    /// <summary>
    /// Unique reference identifying the collateral management contract from the triparty agent&apos;s point of view.
    /// </summary>
    [IsoId("_ihJU0PkFEeicy5Zn42b9bg")]
    [DisplayName("Receiver Collateral Contract Identification")]
    [IsoXmlTag("RcvrCollCtrctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReceiverCollateralContractIdentification { get; init; }

    /// <summary>
    /// Unique identification (UTI) agreed upon by the two trade counterparties to identify the transaction/exposure or the contract.
    /// </summary>
    [IsoId("_NZbooPogEeiAfJEqh4xF_Q")]
    [DisplayName("Common Transaction Identification")]
    [IsoXmlTag("CmonTxId")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public IsoMax52Text? CommonTransactionIdentification { get; init; }
}
