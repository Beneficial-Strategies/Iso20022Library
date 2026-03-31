// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Message Status Response Data9.
/// </summary>
[IsoId("_DcwT4aEYEe-MRKYsaX6JDg")]
[DisplayName("Message Status Response Data9")]
public record MessageStatusResponseData9
{
    /// <summary>
    /// Exchange Identification.
    /// </summary>
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    public required IsoMax35Text ExchangeIdentification { get; init; }

    /// <summary>
    /// Initiating Party.
    /// </summary>
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required GenericIdentification177 InitiatingParty { get; init; }

    /// <summary>
    /// Repeated Card Acquisition Response.
    /// </summary>
    [DisplayName("Repeated Card Acquisition Response")]
    [IsoXmlTag("RpeatdCardAcqstnRspn")]
    public CardAcquisitionResponse3? RepeatedCardAcquisitionResponse { get; init; }

    /// <summary>
    /// Repeated Loyalty Response.
    /// </summary>
    [DisplayName("Repeated Loyalty Response")]
    [IsoXmlTag("RpeatdLltyRspn")]
    public LoyaltyResponse3? RepeatedLoyaltyResponse { get; init; }

    /// <summary>
    /// Repeated Payment Response.
    /// </summary>
    [DisplayName("Repeated Payment Response")]
    [IsoXmlTag("RpeatdPmtRspn")]
    public PaymentResponse7? RepeatedPaymentResponse { get; init; }

    /// <summary>
    /// Repeated Reversal Response.
    /// </summary>
    [DisplayName("Repeated Reversal Response")]
    [IsoXmlTag("RpeatdRvslRspn")]
    public ReversalResponse9? RepeatedReversalResponse { get; init; }

    /// <summary>
    /// Repeated Send Application Protocol Data Unit Card Reader Response.
    /// </summary>
    [DisplayName("Repeated Send Application Protocol Data Unit Card Reader Response")]
    [IsoXmlTag("RpeatdSndApplPrtcolDataUnitCardRdrRspn")]
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1? RepeatedSendApplicationProtocolDataUnitCardReaderResponse { get; init; }

    /// <summary>
    /// Repeated Stored Value Response.
    /// </summary>
    [DisplayName("Repeated Stored Value Response")]
    [IsoXmlTag("RpeatdStordValRspn")]
    public StoredValueResponse8? RepeatedStoredValueResponse { get; init; }

    /// <summary>
    /// Transaction Response.
    /// </summary>
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType11 TransactionResponse { get; init; }
}
