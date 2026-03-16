// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction.
/// </summary>
[IsoId("_BYxPIXDgEe2MCaKO5AtGsA")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment79
{
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_BfzrQXDgEe2MCaKO5AtGsA")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer10? Acquirer { get; init; }

    /// <summary>
    /// Third party agent which provides services.
    /// </summary>
    [IsoId("_pp-CEHDgEe2MCaKO5AtGsA")]
    [DisplayName("Service Provider")]
    [IsoXmlTag("SvcPrvdr")]
    public Acquirer10? ServiceProvider { get; init; }

    /// <summary>
    /// Merchant performing the card payment transaction.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_BfzrQ3DgEe2MCaKO5AtGsA")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation41? Merchant { get; init; }

    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_BfzrRXDgEe2MCaKO5AtGsA")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public PointOfInteraction13? POI { get; init; }

    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_BfzrR3DgEe2MCaKO5AtGsA")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard33? Card { get; init; }

    /// <summary>
    /// Check Payment instrument.
    /// </summary>
    [IsoId("_BfzrSXDgEe2MCaKO5AtGsA")]
    [DisplayName("Check")]
    [IsoXmlTag("Chck")]
    public Check1? Check { get; init; }

    /// <summary>
    /// Store value account payment instrument.
    /// </summary>
    [IsoId("_BfzrS3DgEe2MCaKO5AtGsA")]
    [DisplayName("Stored Value Account")]
    [IsoXmlTag("StordValAcct")]
    public StoredValueAccount2? StoredValueAccount { get; init; }

    /// <summary>
    /// Store value account associated to the payment.
    /// </summary>
    [IsoId("_BfzrTXDgEe2MCaKO5AtGsA")]
    [DisplayName("Loyalty Account")]
    [IsoXmlTag("LltyAcct")]
    public LoyaltyAccount3? LoyaltyAccount { get; init; }

    /// <summary>
    /// Device used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_BfzrT3DgEe2MCaKO5AtGsA")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice3? CustomerDevice { get; init; }

    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_BfzrUXDgEe2MCaKO5AtGsA")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public CustomerDevice3? Wallet { get; init; }

    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_BfzrU3DgEe2MCaKO5AtGsA")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public Token1? PaymentToken { get; init; }

    /// <summary>
    /// Merchant token information.
    /// </summary>
    [IsoId("_BfzrVXDgEe2MCaKO5AtGsA")]
    [DisplayName("Merchant Token")]
    [IsoXmlTag("MrchntTkn")]
    public MerchantToken2? MerchantToken { get; init; }

    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_BfzrV3DgEe2MCaKO5AtGsA")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder20? Cardholder { get; init; }

    /// <summary>
    /// Replacement of the message element Cardholder by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_BfzrWXDgEe2MCaKO5AtGsA")]
    [DisplayName("Protected Cardholder Data")]
    [IsoXmlTag("PrtctdCrdhldrData")]
    public ContentInformationType35? ProtectedCardholderData { get; init; }

    /// <summary>
    /// Sale Retailer Environment for this message.
    /// </summary>
    [IsoId("_BfzrW3DgEe2MCaKO5AtGsA")]
    [DisplayName("Sale Environment")]
    [IsoXmlTag("SaleEnvt")]
    public RetailerSaleEnvironment2? SaleEnvironment { get; init; }
}
