// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Certificate and contract reference of a transaction.
/// </summary>
[IsoId("__CcGsbMlEeueudaIbClZbQ")]
[DisplayName("Transaction Certificate Contract")]
public record TransactionCertificateContract2
{
    /// <summary>
    /// Reference of the contract provided as through the date and identification of the contract or through the registered contract identification.
    /// </summary>
    [IsoId("__Da-I7MlEeueudaIbClZbQ")]
    [DisplayName("Contract Reference")]
    [IsoXmlTag("CtrctRef")]
    public ContractRegistrationReference2Choice_? ContractReference { get; init; }

    /// <summary>
    /// Provides the amount of the transaction in the currency of the registered contract.
    /// </summary>
    [IsoId("__Da-JbMlEeueudaIbClZbQ")]
    [DisplayName("Transaction Amount In Contract Currency")]
    [IsoXmlTag("TxAmtInCtrctCcy")]
    public ActiveCurrencyAndAmount? TransactionAmountInContractCurrency { get; init; }

    /// <summary>
    /// Expected shipment date as per registered contract.
    /// </summary>
    [IsoId("__Da-J7MlEeueudaIbClZbQ")]
    [DisplayName("Expected Shipment Date")]
    [IsoXmlTag("XpctdShipmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpectedShipmentDate { get; init; }

    /// <summary>
    /// Expected advance payment (or prepayment) return date in case counterparty will not deliver the goods/services.
    /// </summary>
    [IsoId("__Da-KbMlEeueudaIbClZbQ")]
    [DisplayName("Expected Advance Payment Return Date")]
    [IsoXmlTag("XpctdAdvncPmtRtrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpectedAdvancePaymentReturnDate { get; init; }

    /// <summary>
    /// Further details on the transaction certificate contract.
    /// </summary>
    [IsoId("__Da-K7MlEeueudaIbClZbQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? AdditionalInformation { get; init; }
}
