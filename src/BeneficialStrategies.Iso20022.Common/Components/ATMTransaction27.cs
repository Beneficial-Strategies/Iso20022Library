// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction for which the exception is sent.
/// </summary>
[IsoId("_KIj5ca5FEeWCgYcWSNgX5g")]
[DisplayName("ATM Transaction")]
public record ATMTransaction27
{
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_KTvOs65FEeWCgYcWSNgX5g")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public TransactionIdentifier1? TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the reconciliation period.
    /// </summary>
    [IsoId("_KTvOta5FEeWCgYcWSNgX5g")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Exception occurring outside the service.
    /// </summary>
    [IsoId("_fA9EoK5FEeWCgYcWSNgX5g")]
    [DisplayName("Exception")]
    [IsoXmlTag("Xcptn")]
    public SimpleValueList<FailureReason8Code> Exception { get; init; } = [];

    // ID for the above is _fA9EoK5FEeWCgYcWSNgX5g

    /// <summary>
    /// Explanation of the exception.
    /// </summary>
    [IsoId("_57VncK5FEeWCgYcWSNgX5g")]
    [DisplayName("Exception Detail")]
    [IsoXmlTag("XcptnDtl")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? ExceptionDetail { get; init; }

    /// <summary>
    /// Balance of the captured card or epurse if available.
    /// </summary>
    [IsoId("_CX6yMK5GEeWCgYcWSNgX5g")]
    [DisplayName("Electronic Purse Balance")]
    [IsoXmlTag("ElctrncPrsBal")]
    public CurrencyAndAmount? ElectronicPurseBalance { get; init; }
}
