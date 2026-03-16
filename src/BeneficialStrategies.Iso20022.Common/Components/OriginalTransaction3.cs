// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Original Transaction3.
/// </summary>
[IsoId("_kQt7IXpdEe6YlIMyoxWMJA")]
[DisplayName("Original Transaction3")]
public record OriginalTransaction3
{
    /// <summary>
    /// Acceptor.
    /// </summary>
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public PartyIdentification284? Acceptor { get; init; }

    /// <summary>
    /// Account From.
    /// </summary>
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public AccountDetails4? AccountFrom { get; init; }

    /// <summary>
    /// Account To.
    /// </summary>
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public AccountDetails4? AccountTo { get; init; }

    /// <summary>
    /// Acquirer.
    /// </summary>
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public PartyIdentification286? Acquirer { get; init; }

    /// <summary>
    /// Additional Amount.
    /// </summary>
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public ValueList<AdditionalAmounts4> AdditionalAmount { get; init; } = [];

    /// <summary>
    /// Additional Fee.
    /// </summary>
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public ValueList<AdditionalFee3> AdditionalFee { get; init; } = [];

    /// <summary>
    /// Additional Service.
    /// </summary>
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public ValueList<AdditionalService2> AdditionalService { get; init; } = [];

    /// <summary>
    /// Card.
    /// </summary>
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required CardData13 Card { get; init; }

    /// <summary>
    /// Cardholder.
    /// </summary>
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder22? Cardholder { get; init; }

    /// <summary>
    /// Context.
    /// </summary>
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context19? Context { get; init; }

    /// <summary>
    /// Conversion Date Time.
    /// </summary>
    [DisplayName("Conversion Date Time")]
    [IsoXmlTag("ConvsDtTm")]
    public DateTime2? ConversionDateTime { get; init; }

    /// <summary>
    /// Customer Device.
    /// </summary>
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice5? CustomerDevice { get; init; }

    /// <summary>
    /// Deposit Details.
    /// </summary>
    [DisplayName("Deposit Details")]
    [IsoXmlTag("DpstDtls")]
    public ValueList<DepositDetails3> DepositDetails { get; init; } = [];

    /// <summary>
    /// Destination.
    /// </summary>
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyIdentification286? Destination { get; init; }

    /// <summary>
    /// Dispute Data.
    /// </summary>
    [DisplayName("Dispute Data")]
    [IsoXmlTag("DsptData")]
    public ValueList<DisputeData4> DisputeData { get; init; } = [];

    /// <summary>
    /// Documentation.
    /// </summary>
    [DisplayName("Documentation")]
    [IsoXmlTag("Dcmnttn")]
    public ValueList<DisputeDocumentation1> Documentation { get; init; } = [];

    /// <summary>
    /// Exchange Rate.
    /// </summary>
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    public ValueList<ExchangeRateInformation5> ExchangeRate { get; init; } = [];

    /// <summary>
    /// Funds Services.
    /// </summary>
    [DisplayName("Funds Services")]
    [IsoXmlTag("FndsSvcs")]
    public FundingService3? FundsServices { get; init; }

    /// <summary>
    /// Issuer.
    /// </summary>
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification286? Issuer { get; init; }

    /// <summary>
    /// Jurisdiction.
    /// </summary>
    [DisplayName("Jurisdiction")]
    [IsoXmlTag("Jursdctn")]
    public Jurisdiction2? Jurisdiction { get; init; }

    /// <summary>
    /// Originator.
    /// </summary>
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification286? Originator { get; init; }

    /// <summary>
    /// Payee.
    /// </summary>
    [DisplayName("Payee")]
    [IsoXmlTag("Pyee")]
    public PartyIdentification287? Payee { get; init; }

    /// <summary>
    /// Payer.
    /// </summary>
    [DisplayName("Payer")]
    [IsoXmlTag("Pyer")]
    public PartyIdentification287? Payer { get; init; }

    /// <summary>
    /// POI Component.
    /// </summary>
    [DisplayName("POI Component")]
    [IsoXmlTag("POICmpnt")]
    public ValueList<PointOfInteractionComponent16> POIComponent { get; init; } = [];

    /// <summary>
    /// Processing Result.
    /// </summary>
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult22? ProcessingResult { get; init; }

    /// <summary>
    /// Programme.
    /// </summary>
    [DisplayName("Programme")]
    [IsoXmlTag("Prgrmm")]
    public ProgrammeMode4? Programme { get; init; }

    /// <summary>
    /// Receiver.
    /// </summary>
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification286? Receiver { get; init; }

    /// <summary>
    /// Reconciliation.
    /// </summary>
    [DisplayName("Reconciliation")]
    [IsoXmlTag("Rcncltn")]
    public Reconciliation4? Reconciliation { get; init; }

    /// <summary>
    /// Risk.
    /// </summary>
    [DisplayName("Risk")]
    [IsoXmlTag("Rsk")]
    public ValueList<RiskContext3> Risk { get; init; } = [];

    /// <summary>
    /// Sender.
    /// </summary>
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification286? Sender { get; init; }

    /// <summary>
    /// Settlement Service.
    /// </summary>
    [DisplayName("Settlement Service")]
    [IsoXmlTag("SttlmSvc")]
    public SettlementService6? SettlementService { get; init; }

    /// <summary>
    /// Special Programme Qualification.
    /// </summary>
    [DisplayName("Special Programme Qualification")]
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    public ValueList<SpecialProgrammeQualification2> SpecialProgrammeQualification { get; init; } =
        [];

    /// <summary>
    /// Terminal.
    /// </summary>
    [DisplayName("Terminal")]
    [IsoXmlTag("Termnl")]
    public Terminal9? Terminal { get; init; }

    /// <summary>
    /// Token.
    /// </summary>
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token2? Token { get; init; }

    /// <summary>
    /// Transaction Amounts.
    /// </summary>
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public TransactionAmounts3? TransactionAmounts { get; init; }

    /// <summary>
    /// Transaction Characteristics.
    /// </summary>
    [DisplayName("Transaction Characteristics")]
    [IsoXmlTag("TxChrtcs")]
    public OriginalTransactionCharacteristics1? TransactionCharacteristics { get; init; }

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public TransactionIdentification54? TransactionIdentification { get; init; }

    /// <summary>
    /// Verification.
    /// </summary>
    [DisplayName("Verification")]
    [IsoXmlTag("Vrfctn")]
    public ValueList<Verification7> Verification { get; init; } = [];

    /// <summary>
    /// Wallet.
    /// </summary>
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public Wallet3? Wallet { get; init; }
}
